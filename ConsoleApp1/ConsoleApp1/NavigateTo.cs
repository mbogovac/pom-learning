
using ConsoleApp1.UIElements;
using System.Threading;

namespace ConsoleApp1
{
    public static class NavigateTo
    {
        public static void LoginFormThroughMenu()
        {
            Menu menu = new Menu();
            TestScenarioPage tsPage = new TestScenarioPage();

            menu.TestScenariosBtn.Click();
            Thread.Sleep(1000);
            tsPage.LoginForm.Click();
            Thread.Sleep(1000);
        }
        public static void LoginFormThroughPost()
        {
            Menu menu = new Menu();
            TestCasesPage tcPage = new TestCasesPage();
            UsernameFieldPost ufPost = new UsernameFieldPost();

            menu.TestCasesBtn.Click();
            Thread.Sleep(1000);
            tcPage.UsernamePostLink.Click();
            Thread.Sleep(1000);
            ufPost.LoginFormLink.Click();
            Thread.Sleep(1000);

        }
    }
}
