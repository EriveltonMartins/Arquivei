using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Login_Arquivei
{
    [Binding]
    public class LoginSteps
    {
        private static IWebDriver driver;

        [Given(@"que o Usuário esteja na pagina de login do Arquivei")]
        public void DadoQueOUsuarioEstejaNaPaginaDeLoginDoArquivei()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://psel-app.arquivei.com.br");   
        }
        
        [When(@"digitar o usuário ""(.*)"" e senha ""(.*)""")]
        public void QuandoDigitarOUsuarioESenha(string p0, string p1)
        {
            driver.FindElement(By.Id("login-email")).Clear();
            driver.FindElement(By.Id("login-email")).SendKeys("erivelton_martins@hotmail.com");

            driver.FindElement(By.Id("login-password")).Clear();
            driver.FindElement(By.Id("login-password")).SendKeys("mudar123");
        }
        
        [When(@"tenha clicado no botão Entrar")]
        public void QuandoTenhaClicadoNoBotaoEntrar()
        {
            driver.FindElement(By.Id("login-submit")).Click();            
        }
        
        [Then(@"o Usuário estiver na home")]
        public void EntaoOUsuarioEstiverNaHome()
        {
            Assert.AreEqual("Painel Principal", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Mostrar/ocultar navegação'])[3]/following::h1[1]")).Text);

            driver.Close();
            driver.Dispose();
        }
        
        [Then(@"é exibida uma mensagem de erro, informando que suas credenciais estão inválidas")]
        public void EntaoEExibidaUmaMensagemDeErroInformandoQueSuasCredenciaisEstaoInvalidas()
        {
            Assert.AreNotEqual("Painel Principal", driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='Mostrar/ocultar navegação'])[3]/following::h1[1]")).Text);

            driver.Close();
            driver.Dispose();
        }
    }
}
