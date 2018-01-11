using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace ToolsQA
{
    class NUnitTest
    {
        IWebDriver driver;
        
        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://qa.suturehealth.com/Account/Login.aspx";
        }

        [TearDown]
        public void EndTest()
        {
            driver.Close();
        }
    }
}