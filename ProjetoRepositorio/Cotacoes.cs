using System;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace ProjetoRepositorio
{
    public class BuscandoInforma��es
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void ProcurarValorDolar()
        {
            driver.Url = "https://www.google.com.br/?hl=pt-BR";
            driver.FindElement(By.Id("APjFqb")).SendKeys("Cota��o dolar");
            driver.FindElement(By.Id("APjFqb")).SendKeys(Keys.Enter);
            IWebElement ValorDolar = driver.FindElement(By.CssSelector(".SwHCTb"));

            string ValorDolarText = ValorDolar.Text;

            if (double.TryParse(ValorDolarText, out double ValorDolar2))
            {
                double ValorReferencia = 5.0;

                if (ValorDolar2 > ValorReferencia)
                {
                    Console.WriteLine("O Dolar est� alto. Seu valor �: " + ValorDolarText);
                }

                else
                {
                    Console.WriteLine("O dolar est� acess�vel. Seu valor �: " + ValorDolarText);

                }
            }
        }

        [Test]
        public void ProcurarValorEuro()
        {
            driver.Url = "https://www.google.com.br/?hl=pt-BR";
            driver.FindElement(By.Id("APjFqb")).SendKeys("Cota��o Euro");
            driver.FindElement(By.Id("APjFqb")).SendKeys(Keys.Enter);
            IWebElement ValorEuro = driver.FindElement(By.CssSelector(".SwHCTb"));

            string ValorEuroText = ValorEuro.Text;

            if (double.TryParse(ValorEuroText, out double ValorEuro2))
            {
                double ValorReferencia = 5.0;

                if (ValorEuro2 > ValorReferencia)
                {
                    Console.WriteLine("O Euro est� alto. Seu valor �: " + ValorEuroText);
                }

                else
                {
                    Console.WriteLine("O Euro est� acess�vel. Seu valor �: " + ValorEuroText);
                }
            }                            
        }

        [TearDown]
        public void FecharNavegador()
        {
            driver.Close();
        }



     }
}