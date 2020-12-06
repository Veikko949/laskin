using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin
{

    public partial class Form1 : Form
    {
        Double summa = 0;
        String lasku = "";
        bool lasku_Painettu = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Numerot_TextChanged(object sender, EventArgs e)
        {

        }

        //Katsoo mitä numero tai pistetä painetaan ja laitaa sen texst boxsiin 
        private void button_Click(object sender, EventArgs e)
        {
            if ((VastausTxBox.Text == "")||(lasku_Painettu))
            {
                VastausTxBox.Clear();
            }

            lasku_Painettu = false;
            Button n = (Button)sender;
            VastausTxBox.Text = VastausTxBox.Text + n.Text;
        }

        //CE nappi poistaa kaiken vsataus text boxsista
        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            VastausTxBox.Text = "";
        }

        //Katsoo mitä laskutapaa painetiin
        private void buttonLasku_Click(object sender, EventArgs e)
        {
            string tulos;
            {
                Button n = (Button)sender;
                lasku = n.Text;
                summa = Double.Parse(VastausTxBox.Text);
                lasku_Painettu = true;
                MitaTeit.Text = summa + " " + lasku;
            }
        }

        //Katsoo mitä laksutapaa painetiin jha laskee  sen sillä tavalla
        private void buttonTulos_Click(object sender, EventArgs e)
        {
            MitaTeit.Text = "";

            switch (lasku)
            {
                case "+":
                    {
                        VastausTxBox.Text = (summa + Double.Parse(VastausTxBox.Text)).ToString();
                    }
                    break;
                case "-":
                    {
                        VastausTxBox.Text = (summa + Double.Parse(VastausTxBox.Text)).ToString();
                    }
                    break;
                case "*":
                    {
                        VastausTxBox.Text = (summa + Double.Parse(VastausTxBox.Text)).ToString();
                    }
                    break;
                case "/":
                    {
                        VastausTxBox.Text = (summa + Double.Parse(VastausTxBox.Text)).ToString();
                    }
                    break;
                default:
                  break;
            }
            lasku = VastausTxBox.Text;   
        }

        //C nappi poistaa kirjoitetut tiedot
        private void buttonClear_Click(object sender, EventArgs e)
        {
            VastausTxBox.Clear();
            summa = 0;
        }
    }
}
