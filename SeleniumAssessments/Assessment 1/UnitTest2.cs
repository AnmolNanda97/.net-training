using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace Assessment_1
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod2()
        {
            IWebDriver driver;
           
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:\Selenium Jar", "geckodriver.exe");
            service.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            driver = new FirefoxDriver(service);

            string firstLink = "Calculators & Resources";
            string secondLink = "Calculators";
            string thirdLink = "Budget Calculator";
           
            //driver = new ChromeDriver("C:\\Selenium Jar");
            driver.Url = "http://www.youcandealwithit.com/";
            IWebElement vCert = driver.FindElement(By.XPath("/html/body/div[1]/ul[2]/li[1]/a"));
            Actions act = new Actions(driver);
            act.MoveToElement(vCert).Build().Perform();
            driver.FindElement(By.LinkText(firstLink)).Click();
            string firstTitle = driver.Title.ToString();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText(secondLink)).Click();
            string secondTitle = driver.Title.ToString();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText(thirdLink)).Click();
            string thirdTitle = driver.Title.ToString();
            string food = "3000";
            string clothing = "2000";
            string shelter = "5000";
            string monthlyPay = "12000";
            string monthlyOther = "2000";

            driver.FindElement(By.Id("food")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("food")).SendKeys(food);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("clothing")).SendKeys(clothing);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("shelter")).SendKeys(shelter);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("monthlyPay")).SendKeys(monthlyPay);
            Thread.Sleep(1000);
            driver.FindElement(By.Id("monthlyOther")).SendKeys(monthlyOther);
            Thread.Sleep(2000);

            double monthlyExpense = Convert.ToDouble(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[5]/div[2]/input")).GetAttribute("value"));
            double monthlyPay1 = Convert.ToDouble(driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div/div[4]/div[1]/input")).GetAttribute("value"));







            if ((firstTitle.Contains(firstLink)))
            {
                Console.WriteLine(firstLink +" - PASS");
            }
            else
            {
                Console.WriteLine(firstLink + " - FAIL");
            }

            if ((secondTitle.Contains(secondLink)))
            {
                Console.WriteLine(secondLink+" - PASS");
            }
            else
            {
                Console.WriteLine(secondLink + " - FAIL");
            }

            if ((thirdTitle.Contains(thirdLink)))
            {
                Console.WriteLine(thirdLink +" - PASS");
            }
            else
            {
                Console.WriteLine(thirdLink + " - FAIL");
            }

            Console.WriteLine("Monthly Expense = "+ monthlyExpense);

            if ((monthlyExpense)>=(monthlyPay1))
            {
                Console.WriteLine("You are an Warren Buffet");
            }
            else
            {
                Console.WriteLine("You are VM");
            }









        }
    }
}
