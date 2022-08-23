using System.Diagnostics;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Linq;
using System.Linq;
using System.Linq;
using System.Linq;

namespace NewCalculator
{
    public partial class one_button : Form
    {
        private int sayi1;
        public int sayi2;
        public int sonuc;
        public char islem;
        public bool screenclear;
        public void zeroCheck()
        {
            if (screen.Text == "0") screen.Text = "";
        }
        public one_button()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (screenclear) screen.Text = ""; screenclear =false; 
            zeroCheck();
            screen.Text += "1";
        }

        private void two_button_Click(object sender, EventArgs e)
        {
            if (screenclear) screen.Text = ""; screenclear = false;
            zeroCheck();
            screen.Text += "2";
        }

        private void tree_button_Click(object sender, EventArgs e)
        {
            if (screenclear) screen.Text = ""; screenclear = false;
            zeroCheck();
            screen.Text += "3";
        }

        private void four_button_Click(object sender, EventArgs e)
        {
            if (screenclear) screen.Text = ""; screenclear = false;
            zeroCheck();
            screen.Text += "4";
        }

        private void five_button_Click(object sender, EventArgs e)
        {
            if (screenclear) screen.Text = ""; screenclear = false;
            zeroCheck();
            screen.Text += "5";
        }

        private void six_button_Click(object sender, EventArgs e)
        {
            if (screenclear) screen.Text = ""; screenclear = false;
            zeroCheck();
            screen.Text += "6";
        }

        private void seven_button_Click(object sender, EventArgs e)
        {
            if (screenclear) screen.Text = ""; screenclear = false;
            zeroCheck();
            screen.Text += "7";
        }

        private void eight_button_Click(object sender, EventArgs e)
        {
            if (screenclear) screen.Text = ""; screenclear = false;
            zeroCheck();
            screen.Text += "8";
        }

        private void nine_button_Click(object sender, EventArgs e)
        {
            if (screenclear) screen.Text = ""; screenclear = false;
            zeroCheck();
            screen.Text += "9";
        }



        private void zero_button_Click(object sender, EventArgs e)
        {
            if (screenclear) screen.Text = ""; screenclear = false;
            zeroCheck();
            screen.Text += "0";
        }

        private void multiplication_button_Click(object sender, EventArgs e)
        {
            screenclear = true;
            islem = 'x';
            zeroCheck();
            sayi1 = Convert.ToInt32(screen.Text);
            screen.Text += "x";
        }

        private void slash_button_Click(object sender, EventArgs e)
        {
            screenclear = true;
            islem = '/';
            zeroCheck();
            sayi1 = Convert.ToInt32(screen.Text);
            screen.Text += "/";
        }



        private void addition_button_Click(object sender, EventArgs e)
        {
            screenclear = true;
            islem = '+';
            zeroCheck();
            sayi1 = Convert.ToInt32(screen.Text);
            screen.Text += "+";
        }



        private void minus_button_Click_1(object sender, EventArgs e)
        {
            screenclear = true;
            islem = '-';
            zeroCheck();
            sayi1 = Convert.ToInt32(screen.Text);
            screen.Text += "-";
        }

        private void c_button_Click_1(object sender, EventArgs e)
        {
            screen.Text = "0";
        }

        private void equal_button_Click(object sender, EventArgs e)
        {
            zeroCheck();
            sayi2 = Convert.ToInt32(screen.Text);
            switch (islem)
            {
                case '+':
                    sonuc = sayi1 + sayi2;
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    break;
                case '/':
                    sonuc = sayi1 / sayi2;
                    break;
                case 'x':
                    sonuc = sayi1 * sayi2;
                    break;
            }
            screen.Text = Convert.ToString(sonuc);
        }


    }
}