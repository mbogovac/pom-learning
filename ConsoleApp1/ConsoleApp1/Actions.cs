
using ConsoleApp1.UIElements;

namespace ConsoleApp1
{
    public static class Actions
    {
        public static void InitializeDriver()
        {
            Driver.driver.Navigate().GoToUrl(Config.BaseUrl);
        }

        public static void FillLoginForm(string username, string password, string repeatPassword)
        {
            LoginForm loginForm = new LoginForm();

            loginForm.UsernameField.SendKeys(username);
            loginForm.PasswordField.SendKeys(password);
            loginForm.RepeatPassField.SendKeys(repeatPassword);
            loginForm.LoginButton.Click();
        }
    }
}
