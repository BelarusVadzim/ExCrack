using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ExCrack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Timer T = new Timer();
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            T.Interval = 10;
            T.Tick += new EventHandler(T_Tick);
            T.Start();
        }
            

        void T_Tick(object sender, EventArgs e)
        {
            this.Opacity = Opacity + 0.05;
            if (this.Opacity > 99)
                T.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Crack C = new Crack();
            try
            {
                textBox2.Text = C.Transform(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
