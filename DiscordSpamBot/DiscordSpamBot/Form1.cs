//Created by Tyler-N-Solutions
//A Bot that can spam your friends in discord!
//Disclaimer: if you chose to use this, I take responsibility of repercussions that occur to you.using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace DiscordSpamBot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, EventArgs e)
        {
            string discord = channel.Text;
            IWebDriver driver;
            driver = new ChromeDriver();
            driver.Url = discord;

            IWebElement fieldEmail = driver.FindElement(By.Name("email"));
            fieldEmail.SendKeys(email.Text);

            IWebElement fieldPassword = driver.FindElement(By.Name("password"));
            fieldPassword.SendKeys(password.Text);

            fieldPassword.SendKeys(OpenQA.Selenium.Keys.Enter);

            System.Threading.Thread.Sleep(7000);

            IWebElement input = driver.FindElement(By.ClassName("slateTextArea-1Mkdgw"));

            int sleepTime = Int32.Parse(time.Text) * 1000;
            int iter = 0;

            if (Int32.Parse(iteration.Text) == 0)
            {
                while (true)
                {
                    input.SendKeys(message.Text);
                    input.SendKeys(OpenQA.Selenium.Keys.Enter);

                    System.Threading.Thread.Sleep(sleepTime);
                }
            }
            else
            {
                while(iter < Int32.Parse(iteration.Text))
                {
                    input.SendKeys(message.Text);
                    input.SendKeys(OpenQA.Selenium.Keys.Enter);

                    System.Threading.Thread.Sleep(sleepTime);
                    iter++;
                }
            }
        }
    }
}
