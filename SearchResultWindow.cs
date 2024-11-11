using OpenQA.Selenium.DevTools.V123.Overlay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
struct SearchResultObject
{
    public string title;
    public int id;

    public SearchResultObject(int id, string name)
    {
        this.id = id;
        this.title = name;
    }
}
namespace bgpicker2
{
    public partial class SearchResultWindow : Form
    {
        List<SearchResultObject> searchResults = new List<SearchResultObject>();
        private int selectedGameId = 0;
        public SearchResultWindow()
        {
            InitializeComponent();
        }

        public void Show(string[] data)
        {
            foreach (string item in data)
            {
                gamesResultList.Items.Add(item);
            }
        }

        internal int SelectedGame()
        {
            return selectedGameId;
        }
        //clicking search
        private async void SearchBtnClick(object sender, EventArgs e)
        {
            string t = searchTextBox.Text;
            searchResults.Clear();
            gamesResultList.Items.Clear();
            string response = await Task.Run(() => BggAPITest.SearchTest(t));
            if (response == "Error")
                return;

            //different try of xml
            XDocument doc = XDocument.Parse(response);
            var n = doc.Elements();

            //handle xml data
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(response);
            XmlNodeList nodes = xmlDoc.SelectNodes("/items");
            //XmlNodeList nodes = xmlDoc.SelectNodes("/items/");
            foreach (XmlElement c in nodes)
            {
                if (c.FirstChild != null)
                {
                    //XmlNode node = c.GetElementById("//item");
                    string name = "";
                    string id = "";
                    if (c.FirstChild.InnerText != null)
                        name = c.FirstChild.FirstChild.Attributes[1].Value;
                    SearchResultObject sro = new SearchResultObject(int.Parse(id), name);
                    searchResults.Add(sro);
                }
            }
            foreach (SearchResultObject item in searchResults)
            {
                gamesResultList.Items.Add(item.title);
            }
        }

        //sometimes calls an error when selecting an objecti n the list
        private async void gamesResultList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selGameInfo.Text = "";
            int idx = gamesResultList.SelectedIndex;
            int gameId = searchResults[idx].id;
            string resp = await Task.Run(() => BggAPITest.LookupGame(gameId));
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(resp);
            selGameInfo.Text += "Name: " + xmlDoc.SelectSingleNode("//name[@primary='true']").InnerText + "\n";
            selGameInfo.Text += "Year: " + xmlDoc.SelectSingleNode("//yearpublished").InnerText + "\n";
            selGameInfo.Text += "Players: " + xmlDoc.SelectSingleNode("//minplayers").InnerText + " - " + xmlDoc.SelectSingleNode("//maxplayers").InnerText + "\n";
            selGameInfo.Text += "Description: " + xmlDoc.SelectSingleNode("//description").InnerText + "\n";

            selectedGameId = gameId;
        }
    }
}
