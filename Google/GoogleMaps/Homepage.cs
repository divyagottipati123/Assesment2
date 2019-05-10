using Google.ComponentHelper;
using Google.Configuration;
using Google.DataDriven;
using Google.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google.GoogleMaps
{
   public class Homepage
    {
        AppConfigReader acr = new AppConfigReader();
        public void IamatGoogleMapsHomePage()
        {
            NavigationHelper.NavigateToUrl(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 0, 1).ToString());
            ObjectRepository.Driver.Manage().Window.Maximize();
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        public void SearchBanglore()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 1, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 4, 1).ToString());
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 2, 1).ToString())).Click();

        }
        public void ClickDirections()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 3, 1).ToString())).Click();

        }
        public void GetDirections()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 5, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 6, 1).ToString());
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 7, 1).ToString())).Click();

        }
        public void CheckZoomlevels()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 8, 1).ToString())).Click();
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 9, 1).ToString())).Click();

        }
        public void CheckRoutesForPublicTransportAndWalk()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 11, 1).ToString())).Click();
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 12, 1).ToString())).Click();

        }
        public void CheckContextMenu()
        {
           // WebDriverWait wait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromSeconds(10));
            //IWebElement element = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 13, 1).ToString())));
            ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 13, 1).ToString())).Click();
        }
        public void ClickMenu()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 33, 1).ToString())).Click();
        }
        public void ClickSaveAndShare()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 14, 1).ToString())).Click();
        }
        public void checkResult()
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 15, 1).ToString())));
            //var currentHandle = ObjectRepository.Driver.CurrentWindowHandle;
            //PopupWindowFinder finder = new PopupWindowFinder(ObjectRepository.Driver);
            //WebDriverWait customWait = new WebDriverWait(ObjectRepository.Driver, TimeSpan.FromMinutes(2));
            //customWait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 16, 1).ToString())));
            //string popupWindowHandle = finder.Click(ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 16, 1).ToString())));
            //ObjectRepository.Driver.SwitchTo().Window(popupWindowHandle);
            //ObjectRepository.Driver.SwitchTo().Window(currentHandle);
            // ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 16, 1).ToString())).Click();
        }
        public void Clickyourplaces()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 17, 1).ToString())).Click();
        }
        public void EnterUserNameandPassword()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 18, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 19, 1).ToString());
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 20, 1).ToString())).Click();
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 21, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 22, 1).ToString());
            IWebElement element =ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 23, 1).ToString()));
            Actions actions = new Actions(ObjectRepository.Driver);
            actions.MoveToElement(element).Click().Perform();
            //ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 23, 1).ToString())).Click();
        }
        public void ClickSaved()
        {
            //ObjectRepository.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //IWebElement element = ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 24, 1).ToString()));
            //Actions actions = new Actions(ObjectRepository.Driver);
            //actions.MoveToElement(element).Click().Perform();
           ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 24, 1).ToString())).Click();
        }
        public void ClickFavorites()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 25, 1).ToString())).Click();
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 26, 1).ToString())).Click();
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 27, 1).ToString())).Click();
        }
        public void ClickAddPlace()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 28, 1).ToString())).Click();
        }
        public void EnterPlaceName()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 29, 1).ToString())).SendKeys(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 30, 1).ToString());

        }
        public void SelectFromDropDown()
        {
            ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 31, 1).ToString())).Click();
        }
        public void CheckifPlaceisAddedorNot()
        {
            Assert.IsNotNull(ObjectRepository.Driver.FindElement(By.XPath(ExcelHelper.GetCellData(acr.GetXlpath(), "Data", 32, 1).ToString())));
        }
    }
}
