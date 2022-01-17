﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasta_PisirmeUyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value % 20 == 0)
                label2.BackColor = Color.Aquamarine;
            else
                label2.BackColor = Color.LightGreen;

            if(progressBar1.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar2.Value += 20;
            if (progressBar2.Value % 40 == 0)
                label3.BackColor = Color.Aquamarine;
            else
                label3.BackColor = Color.LightGreen;
            if(progressBar2.Value == 100)
            {
                timer2.Stop();
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            progressBar3.Value += 20;
            if (progressBar3.Value % 40 == 0)
                label4.BackColor = Color.Aquamarine;
            else
                label4.BackColor = Color.LightGreen;

            if(progressBar3.Value == 100)
            {
                timer3.Stop();
                timer4.Start();
            }
            
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            progressBar4.Value += 5;
            if (progressBar4.Value % 10 == 0)
                label5.BackColor = Color.Aquamarine;
            else
                label5.BackColor = Color.LightGreen;

            if(progressBar4.Value == 100)
            {
                timer4.Stop();
                MessageBox.Show("Pişirme İşlemi Tamamlandı!..");
            }
        }
    }
}
