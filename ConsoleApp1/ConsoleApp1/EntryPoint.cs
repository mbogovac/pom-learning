
using ConsoleApp1;
using ConsoleApp1.UIElements;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

public class EntryPoint
{
    IAlert alert;

  static void Main()
  {
  }

    [SetUp]
    public void Initialize()
    {
        Actions.InitializeDriver();
    }

    [Test]
    public void ValidLogin()
    {
        NavigateTo.LoginFormThroughMenu();
        Thread.Sleep(1000);

        Actions.FillLoginForm(Config.Credentials.Valid.Username, Config.Credentials.Valid.Password, Config.Credentials.Valid.RepeatPassword);

        alert = Driver.driver.SwitchTo().Alert();
        Assert.AreEqual(Config.AlertMessages.SuccessfulLogin, alert.Text);
        alert.Accept();
    }

    [TearDown]
    public void CleanUp()
    {
        Driver.driver.Quit();
    }
}
