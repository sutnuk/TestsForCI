using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestsForCI
{
    class Program
    {
        static void Main(string[] args)
        {
                        
        }
    }

    [TestFixture]
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void PreConditions()
        {
            driver = new ChromeDriver("C:\\Driver");
            driver.Url = "https://ua.sinoptik.ua/";
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test()
        {
            IWebElement element = driver.FindElement(By.XPath("//input[@id='search_city']"));
            Assert.True(element.GetAttribute("placeholder").Equals("Назва населеного пункту, країни або регіону"));
        }

        [TearDown]
        public void PostConditions()
        {
            driver.Quit();
        }

    }
}
