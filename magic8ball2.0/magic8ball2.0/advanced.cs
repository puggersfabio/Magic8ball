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
    public partial class advanced : Form
    {
        public advanced()
        {
            InitializeComponent();
        }
        public enum Errorenum
        {
            Info,
            Warning,
            Error
        }
        private void button1_Click(object sender, EventArgs e)
        {
           // Form1 c = new Form1();
          //  c.Show();
            advanced f = new advanced();
            f.Close();
        }
        private void button2_Click(object sender, EventArgs e)
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
                    string c = label2.Text;
                    label2.Text = c;

                    string d = textBox1.Text;
                    label1.Text = d;

            /* maakt een logboek aan/zet in het logboek, wat er werd getypt in string a en b */
            System.IO.File.AppendAllText("antwoord.text", DateTime.Now + " " + "advanced" + " " + c + " " + d);

            /* deze functie stuurt het naar de windows logboek */
            EventLog eventLog = new EventLog();
            eventLog.Source = "Application";
            eventLog.WriteEntry("advanced" + c + " " + d, EventLogEntryType.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }        
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
    }
