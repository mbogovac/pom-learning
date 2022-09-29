using ConsoleApp1.UIElements;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp1
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
        }

        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginForm loginForm = new LoginForm();

            loginForm.UsernameField.Clear();
            loginForm.UsernameField.SendKeys(username);
            loginForm.PasswordField.Clear();
            loginForm.PasswordField.SendKeys(password);
            loginForm.RepeatPassField.Clear();
            loginForm.RepeatPassField.SendKeys(repeatPassword);
            loginForm.LoginButton.Click();
        }
    }
}
