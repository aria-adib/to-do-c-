using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODO_LIST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string Task = textBox1.Text.ToString();
            string todayTask = textBox2.Text.ToString();
            string Reminder = textBox3.Text.ToString();


            if (checkBox1.Checked)
            {
                      listBox1.Items.Add(Task);
                      listBox1.Items.Add(todayTask);


            } else
               
                  {
                   listBox2.Items.Add(Reminder);

                }

            
            

            textBox1.Clear();
            textBox1.Focus();

            textBox2.Clear();
            textBox2.Focus();


            textBox3.Clear();
            textBox3.Focus();



        }
    }

      
    }
