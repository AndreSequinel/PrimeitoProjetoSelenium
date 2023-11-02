using System;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using ProjetoRepositorio.Fixture;
using ProjetoRepositorio.PageObjects;

namespace ProjetoRepositorio
{
    public class BuscandoInforma��es : TestFixture
    {  

        public void Setup(TestFixture fixture)
        {
            driver = fixture.driver;                  
        }

        [Test]
        public void ProcurarValorDolar()
        {
            var InfoPesquisaPo = new InformacoesPesquisaPO(driver);

            InfoPesquisaPo.NavegarParaUrl();
            InfoPesquisaPo.PreecherInformacoesPesquisaDolar();
            

            if (double.TryParse(InfoPesquisaPo.ValorDolarTexto, out double ValorDolar2))
            {
                double ValorReferencia = 5.0;

                if (ValorDolar2 > ValorReferencia)
                {
                    Console.WriteLine("O Dolar est� alto. Seu valor �: " + InfoPesquisaPo.ValorDolarTexto);
                }

                else
                {
                    Console.WriteLine("O dolar est� acess�vel. Seu valor �: " + InfoPesquisaPo.ValorDolarTexto);

                }
            }

            Dispose();
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

            Dispose();
        }

    }
}