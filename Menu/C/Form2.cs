﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var k = Convert.ToDouble(textBox1.Text);
            var j = Convert.ToDouble(textBox2.Text);
            result.Text =Convert.ToString(Class1.addition (k , j));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var k = Convert.ToDouble(textBox1.Text);
            var j = Convert.ToDouble(textBox2.Text);
            result.Text = Convert.ToString(Class1.subtraction(k, j));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var k = Convert.ToDouble(textBox1.Text);
            var j = Convert.ToDouble(textBox2.Text);
            result.Text = Convert.ToString(Class1.multiplication(k, j));

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var k = Convert.ToDouble(textBox1.Text);
            var j = Convert.ToDouble(textBox2.Text);
                
            if (b != 0) { result.Text = Convert.ToString(Class1.division(k, j)); }
            else MessageBox.Show("SECOND NUMBER MUST BE DIFFERENT FROM ZERO");


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
    

