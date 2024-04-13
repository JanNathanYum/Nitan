using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingWord
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static ArrayList WordList = new ArrayList();
        static StringBuilder S1 = new StringBuilder();
        static StringBuilder S2 = new StringBuilder();
        private void Form1_Load(object sender, EventArgs e)
        {
            Return();
        }
        private void Return()
        {
            WordList.Add("N*a*t*h*a*n");
            WordList.Add("F*l*o*w*e*r");
            WordList.Add("A*n*g*e*l");
            WordList.Add("C*r*u*s*h");
            WordList.Add("W*a*t*e*r*m*e*l*o*n");

            Random rand = new Random();
            int randomNum = rand.Next(1, 5);

            string[] word = WordList[randomNum].ToString().Split('*');

            for (int i = 0; i < word.Length; i++)
            {
                S1.Append(word[i]);
            }
            S2.Append(word[0]);
            for (int i = 1; i < word.Length - 1; i++)
            {
                word[i] = "?";
                S2.Append(word[i]);
            }
            S2.Append(word[word.Length - 1]);
            label1.Text = S2.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {

            string answer = textBox1.Text.ToString();
            if (answer.Equals(S1.ToString()))
            {
                label1.Text = answer;
                MessageBox.Show("Correct!!");

                listBox1.Items.Clear();
                S1.Clear();
                S2.Clear();
                Return();

            }
            else if (answer == "")
            {
                MessageBox.Show("No Input");
            }
            else if (!answer.Equals(S1.ToString()))
            {
                MessageBox.Show("Incorrect Answer " +
                    "\nTry Again");
                listBox1.Items.Add(answer);

            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Return();
        }
    }
}