using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using TechTalk.SpecFlow;

namespace Projeto.AutomationPractice.Util
{
  
    [Binding]
    public sealed class TestRunSingleBrowserHooks
    {
        private static IWebDriver _navegador;

        private TestRunSingleBrowserHooks()
        {

        }
        [BeforeFeature]
        public static void RegistrarPaginas()
        {

            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");

            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }

            if (!FeatureContext.Current.FeatureInfo.Tags.Contains("ignore"))
            {


                //var _opcoesChrome = new ChromeOptions();
                //_opcoesChrome.AddArguments(new List<string>() {
                //"--silent-launch",
                //"--no-startup-window",
                //"no-sandbox",});

                //_navegador = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), _opcoesChrome);
                _navegador = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
                _navegador.Manage().Window.Maximize();
            }
        }

        public static IWebDriver RetornarDriver(string url)
        {
            _navegador.Navigate().GoToUrl(url);
            return _navegador;
        }

        // Reuse browser for the whole run.
        [AfterTestRun]
        public static void AfterTestRun()
        {
            //_navegador.Quit();

            //Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            //foreach (var chromeDriverProcess in chromeDriverProcesses)
            //{
            //    chromeDriverProcess.Kill();
            //}

        }
    }
}