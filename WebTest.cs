using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace bgpicker2
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
            //Setup Chrome Options
            ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--headless");
            //Setup web driver
            ChromeDriver driver = new ChromeDriver(options);
            #endregion
            //Navigate to Games page to access Mechanics and types
            #region Navigation
            //goes to website
            driver.Navigate().GoToUrl("Https://www.boardgamegeek.com");
            //find the search bar and searches for game
            driver.FindElement(By.Id("1")).SendKeys(GameName + OpenQA.Selenium.Keys.Enter);
            //driver.FindElement(By.CssSelector("#results_objectname1 > a")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("results_objectname1")).Click();
            
            //Click on the See Full Credits link to access all mechanics and types
            driver.FindElement(By.LinkText("See Full Credits")).Click();
            //  string gameName = webDriver.FindElement(By.XPath("/html/body/div[2]/main/div[2]/div/div[1]/div[2]/ng-include/div/div/ui-view/ui-view/div/div/div[2]/credits-module/ul/li[1]/div[2]/div/div/div")).Text;
            //get game's primary name

            string gameName = driver.FindElement(By.CssSelector("#mainbody > div.global-body-content-container.container-fluid > div > div.content.ng-isolate-scope > div:nth-child(2) > ng-include > div > div > ui-view > ui-view > div > div > div.panel-body > credits-module > ul > li:nth-child(1) > div.outline-item-description > div > div > div > span > span.ng-binding.ng-scope")).Text;
            #endregion
            _bg.SetName(gameName);
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

        public static List<BoardGame> ImportCollection(string collectionLink)
        {
            #region Setup
            List<BoardGame> colBg = new List<BoardGame>();
            //Setup Chrome Options
            
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            //Setup web driver
            ChromeDriver driver = new ChromeDriver(options);
            #endregion
            #region Navigation
            driver.Navigate().GoToUrl(collectionLink);
            #endregion
            #region Loop through collection
            int gamesLeft = 0;


            //get the amount of games displayed on page (gameCountCurr) and also amount of games in collection (gameCountTotal)
            //for example "1 to 105 of 149"
            string gameCountText = driver.FindElement(By.XPath("/html/body/div[2]/main/div/div/div[1]/div/div/div[1]/div[4]/div[3]/span")).Text;
            string[] split = gameCountText.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            

            int gameCountTotal = int.Parse(split[4]);
            int gameCountCurr = int.Parse(split[2]);
            List<string> gameLinks = new List<string>();
            for (int row = 2; row < gameCountCurr; row++)
            {
               //grab all of the links from the collection
               gameLinks.Add(driver.FindElement(By.XPath("/html/body/div[2]/main/div/div/div[1]/div/div/div[1]/div[4]/div[4]/table/tbody/tr[" + row + "]/td[1]/div[2]/a")).GetAttribute("href"));
            }
            driver.Quit();
            #endregion
            foreach(string link in gameLinks)
            {
                BoardGame bg = GetBgInfo(link);
                colBg.Add(bg);
            }
            return colBg;
        }

        public static BoardGame GetBgInfo(string gameLink)
        {
            BoardGame bg = new BoardGame();
            int min = 0;
            int max;
            //Setup Chrome Options
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--headless");
            //Setup web driver
            ChromeDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(gameLink+"/credits");
            //Click on the See Full Credits link to access all mechanics and types
            //driver.FindElement(By.LinkText("See Full Credits")).Click();
            //get game's primary name
            string gameName = driver.FindElement(By.XPath("/html/head/meta[7]")).GetAttribute("content");
            bg.SetName(gameName);
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

            bg.SetPlayerSize(new Vector2(min, max));
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
            bg.SetPlayTime(new Vector2(min, max));
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
            bg.SetTypes(typeList);
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
            driver.Quit();
            //Set temp Board game object's mechanics list
            bg.SetMechanics(mechanicsList);
            #endregion
            return bg;
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
