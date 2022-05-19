using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestsForCI
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests tests = new Tests();
            tests.PreConditions();
            tests.Test();
            tests.PostConditions();
        }
    }

    [TestFixture]
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void PreConditions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("headless");
            driver = new ChromeDriver("C:\\ChromeDriver", options);                     
        }

        [Test]
        public void Test()        
        {
            driver.Url = "https://www.google.com/";
            IWebElement element = driver.FindElement(By.XPath("//input[@class='gLFyf gsfi']"));
            Assert.True(element.GetAttribute("title").Equals("Пошук"));
        }

        [TearDown]
        public void PostConditions()
        {
            driver.Quit();
        }

    }
}
