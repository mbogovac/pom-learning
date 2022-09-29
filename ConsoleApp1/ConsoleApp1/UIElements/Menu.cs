using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace ConsoleApp1.UIElements
{
    public class Menu
    {
        public Menu()
        {
            PageFactory.InitElements(Driver.driver,this);
        }

        [FindsBy(How = How.Id, Using = "menu-item-25")]
        public IWebElement IntroductionBtn { get; set; }


        [FindsBy(How = How.Id, Using = "menu-item-106")]
        public IWebElement SelectorsBtn { get; set; }


        [FindsBy(How = How.Id, Using = "menu-item-35")]
        public IWebElement SpecialElemetsBtn { get; set; }


        [FindsBy(How = How.Id, Using = "menu-item-57")]
        public IWebElement TestCasesBtn { get; set; }


        [FindsBy(How = How.Id, Using = "menu-item-58")]
        public IWebElement TestScenariosBtn { get; set; }


        [FindsBy(How = How.Id, Using = "menu-item-26")]
        public IWebElement AboutBtn { get; set; }
    }
}
