using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace magic8ball2._0
{
    public partial class easy : Form
    {

        public easy()
        {
            InitializeComponent();
        }
        public enum Errorenum
        {
            Info,
            Warning,
            Error
        }
        private void Button2_Click(object sender, EventArgs e)
        {

            /* pakt een getal voor de switch */
            Random rnd = new Random();
            int num = rnd.Next(1, 14);
            
            /* pakt het nummer dat gegenereerd is en neem 1 van de 14 */
            switch (num)
            {
                case 1:
                    {
                        pictureBox1.Image = Properties.Resources._1;
                        label2.Text = "Absolutely!";
                        break;
                    }
                case 2:
                    {
                        pictureBox1.Image = Properties.Resources._2;
                        label2.Text = "Ask again!";
                        break;
                    }
                case 3:
                    {
                        pictureBox1.Image = Properties.Resources._3;
                        label2.Text = "Cannot tell now!";
                        break;
                    }
                case 4:
                    {
                        pictureBox1.Image = Properties.Resources._4;
                        label2.Text = "Count on it!";
                        break;
                    }
                case 5:
                    {
                        pictureBox1.Image = Properties.Resources._5;
                        label2.Text = "Go for it!";
                        break;
                    }
                case 6:
                    {
                        pictureBox1.Image = Properties.Resources._6;
                        label2.Text = "It is ok!";
                        break;
                    }
                case 7:
                    {
                        pictureBox1.Image = Properties.Resources._7;
                        label2.Text = "It will pass!";
                        break;
                    }
                case 8:
                    {
                        pictureBox1.Image = Properties.Resources._8;
                        label2.Text = "Maybe!";
                        break;
                    }
                case 9:
                    {
                        pictureBox1.Image = Properties.Resources._9;
                        label2.Text = "No!";
                        break;
                    }
                case 10:
                    {
                        pictureBox1.Image = Properties.Resources._10;
                        label2.Text = "No doubt!";
                        break;
                    }
                case 11:
                    {
                        pictureBox1.Image = Properties.Resources._11;
                        label2.Text = "Very likely!";
                        break;
                    }
                case 12:
                    {
                        pictureBox1.Image = Properties.Resources._12;
                        label2.Text = "Wait for it!";
                        break;
                    }
                case 13:
                    {
                        pictureBox1.Image = Properties.Resources._13;
                        label2.Text = "Yes!";
                        break;
                    }
                case 14:
                    {
                        pictureBox1.Image = Properties.Resources._14;
                        label2.Text = "You're hot!"; 
                        break;
                    }
            }
            /* maakt de teksten naar een string */
            string b = label2.Text;
            label2.Text = b;
            string a = textBox1.Text;
            label1.Text = a;

            /* maakt een logboek aan/zet in het logboek, wat er werd getypt in string a en b */
            System.IO.File.AppendAllText("antwoord.text", DateTime.Now + " " + "simpel" + " " + a + " " + b + "\n");

            /* deze functie stuurt het naar de windows logboek */
           EventLog eventLog = new EventLog();
           eventLog.Source = "Application";
           eventLog.WriteEntry("simpel" + a + " " + b, EventLogEntryType.Information);
           
        }

    /*   private void Logboek()
        {
            string b = label2.Text;
            label2.Text = b;
            string a = textBox1.Text;
            label1.Text = a;


            switch (error)
            {
                case Errorenum.Info:
                    
                    break;

                case Errorenum.Error:
                    eventLog.WriteEntry(a + b, EventLogEntryType.Error);
                    break;

                case Errorenum.Warning:
                    eventLog.WriteEntry(a + b, EventLogEntryType.Warning);
                    break;
            }
        } */
 
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 d = new Form1();
            d.Show();
            easy f = new easy();
            f.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void easy_Load(object sender, EventArgs e)
        {

        }
    }
}
