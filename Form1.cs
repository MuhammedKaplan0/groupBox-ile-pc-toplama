using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KonteynerKontrolleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tabanFiyat = 500;
            int cpuFiyat = 0;
            if (radioButton1.Checked)
                cpuFiyat = 8150;
            else if (radioButton2.Checked)
                cpuFiyat = 5475;
            else if (radioButton3.Checked)
                cpuFiyat = 1950;
            else if (radioButton4.Checked)
                cpuFiyat = 4600;
            else if (radioButton5.Checked)
                cpuFiyat = 1425;
            tabanFiyat += cpuFiyat;

            int ramFiyat = 0;
            if (radioButton6.Checked)
                ramFiyat = 1000;
            else if (radioButton7.Checked)
                ramFiyat = 550;
            else if (radioButton8.Checked)
                ramFiyat = 170;
            tabanFiyat += ramFiyat;

            int diskfiyat = 0;
            if (radioButton9.Checked)
                diskfiyat = 120;
            else if (radioButton10.Checked)
                diskfiyat = 290;
            else if (radioButton11.Checked)
                diskfiyat = 488;
            tabanFiyat += diskfiyat;
            
            int ekdonanim = 0;
            if (checkBox1.Checked)
            {
                tabanFiyat+= 255;
            }
            if (checkBox2.Checked)
            {
                tabanFiyat += 360;
            }
            if (checkBox3.Checked)
            {
                tabanFiyat += 100;
            }
            tabanFiyat += ekdonanim;
            MessageBox.Show(string.Format("toplam fiyat ={0:C}", tabanFiyat));







        }

      
    }
}
