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
            var InfoPesquisaPO = new InformacoesPesquisaPO(driver);

            InfoPesquisaPO.NavegarParaUrl();
            InfoPesquisaPO.PreecherInformacoesPesquisaEuro();

            if (double.TryParse(InfoPesquisaPO.ValorEuroTexto, out double ValorEuro2))
            {
                double ValorReferencia = 5.0;

                if (ValorEuro2 > ValorReferencia)
                {
                    Console.WriteLine("O Euro est� alto. Seu valor �: " + InfoPesquisaPO.ValorEuroTexto);
                }

                else
                {
                    Console.WriteLine("O Euro est� acess�vel. Seu valor �: " + InfoPesquisaPO.ValorEuroTexto);
                }
            }

            Dispose();
        }

    }
}