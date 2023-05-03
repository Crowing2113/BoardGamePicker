using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace BoardGamePicker
{
    internal class WebTest
    {
        public static BoardGame FindGame(string GameName)
        {
            //Initialize Variables
            #region Setup
            //Setup variables
            int min = 1;
            int max;
            BoardGame _bg = new BoardGame();
            _bg.SetName(GameName);
            //Setup Chrome Options
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            //Setup web driver
            ChromeDriver driver = new ChromeDriver(options);
            #endregion
            //Navigate to Games page to access Mechanics and types
            #region Navigation
            //goes to website
            driver.Navigate().GoToUrl("Https://www.boardgamegeek.com");
            //find the search bar and searches for game
            driver.FindElement(By.Id("1")).SendKeys(GameName + OpenQA.Selenium.Keys.Enter);
            driver.FindElement(By.LinkText(GameName)).Click();
            //Click on the See Full Credits link to access all mechanics and types
            driver.FindElement(By.LinkText("See Full Credits")).Click();
            #endregion
            //Grab Player range and set games player range
            #region Players
            //find the "min" number of players           
            var elements = driver.FindElements(By.CssSelector(".gameplay-item-primary > .ng-scope > .ng-binding:nth-child(1)"));
            if (elements.Count > 0)
                min = GetNum(elements.First().Text);
            //find the "max" number of players
            elements = driver.FindElements(By.CssSelector(".gameplay-item-primary > .ng-scope > .ng-binding:nth-child(2)"));

            if (elements.Count > 0)
                max = GetNum(elements.First().Text);
            else
                max = min;

            _bg.SetPlayerSize(new Vector2(min, max));
            #endregion
            //Grab the Playtime range and set the games playtime
            #region Play time
            //get time
            //check for min playtime element
            elements = driver.FindElements(By.CssSelector(".ng-scope > .ng-isolate-scope > .ng-binding:nth-child(1)"));
            if (elements.Count > 0)
                min = GetNum(elements.First().Text);
            else
                min = 0;
            //check for max playtime element
            elements = driver.FindElements(By.CssSelector(".ng-scope > .ng-isolate-scope > .ng-binding:nth-child(2)"));
            if (elements.Count > 0)
                max = GetNum(elements.First().Text);
            else
                max = min;
            //set the board game's play time
            _bg.SetPlayTime(new Vector2(min, max));
            #endregion
            //Get the list of Types and set the games types
            #region Types
            //XPath for types list
            string xPath = ".//credits-module/ul/li[14]/div[2]/div";
            //wait for the page to properly load before looking for element (throws 'no element found' exception without this)
            Thread.Sleep(1000);
            //find the typesElement list and get the child count
            var typesElementList = driver.FindElements(By.XPath(xPath));
            int childCount = int.Parse(typesElementList.First().GetDomProperty("childElementCount"));
            //temp typesList used to store the types
            List<string> typeList = new List<string>();
            //loop through the typesELement child nodes and grab the info
            for (int i = 1; i <= childCount; i++)
            {
                //Find the child element
                IWebElement el = driver.FindElement(By.XPath(".//credits-module/ul/li[14]/div[2]/div/div[" + i + "]"));

                //add the text to the temp type list
                typeList.Add(el.Text);
                //MessageBox.Show("typeList[" + (i - 1) + "] = " + typeList[i - 1], "Added " + el.Text + " to array at location " + (i - 1), MessageBoxButtons.OK);
            }
            //Set temp Board game object's type list
            _bg.SetTypes(typeList);
            #endregion
            //Get the list of Mechanics and set the games Mechanic
            #region Mechanics
            //XPath for mechanics list
            xPath = ".//credits-module/ul/li[15]/div[2]/div";
            //wait for the page to properly load before looking for element (throws 'no element found' exception without this)
            Thread.Sleep(1000);
            //find the mechanicssElement list and get the child count
            var mechanicsElementList = driver.FindElements(By.XPath(xPath));
            childCount = int.Parse(mechanicsElementList.First().GetDomProperty("childElementCount"));
            //temp typesList used to store the types
            List<string> mechanicsList = new List<string>();
            //loop through the mechanicsElement child nodes and grab the info
            for (int i = 1; i <= childCount; i++)
            {
                //Find the child element
                IWebElement el = driver.FindElement(By.XPath(".//credits-module/ul/li[15]/div[2]/div/div[" + i + "]"));
                
                //add the text to the temp mechanic list
                mechanicsList.Add(el.Text);
                //MessageBox.Show("mechanicsList[" + (i - 1) + "] = " + mechanicsList[i - 1], "Added " + el.Text + " to mechanics List at location " + (i - 1), MessageBoxButtons.OK);
            }
            //Set temp Board game object's mechanics list
            _bg.SetMechanics(mechanicsList);
            #endregion
            driver.Quit();
            return _bg;
        }



        //gets only numbers from input.
        //used for dumb stuff like getting -4 in return from player size and play time
        private static int GetNum(string s)
        {
            int n = 0;
            string str = new string(s.Where(c => char.IsDigit(c)).ToArray());
            n = int.Parse(str);
            return n;
        }
    }
}
