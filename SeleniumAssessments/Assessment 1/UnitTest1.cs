using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Assessment_1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver;
            string search = "DXC Technologies";
            driver = new ChromeDriver("C:\\Selenium Jar");
            driver.Url = "https://www.google.com/";
            driver.FindElement(By.Name("q")).SendKeys(search);
            Thread.Sleep(2000);
            driver.FindElement(By.Name("btnK")).Click();
            string title = driver.Title.ToString();
            Console.WriteLine(title);
            string stats = driver.FindElement(By.XPath("/html/body/div[7]/div[3]/div[7]/div[1]/div/div/div/div")).Text;
            Console.WriteLine(stats);

            if ((title.Contains(search)))
            {
                Console.WriteLine("PASS");
            }
            else
            {
                Console.WriteLine("FAIL");
            }
            driver.Close();
           
        }
    }
}
