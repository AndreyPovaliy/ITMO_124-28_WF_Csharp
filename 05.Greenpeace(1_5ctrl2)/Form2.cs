﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05.Greenpeace_1_5ctrl2_
{
    public partial class Form2 : Form
    {
        Form1 myF2;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 myF2 = new Form1();
            myF2.StartPosition = FormStartPosition.Manual; 
            myF2.Location = new Point(this.Location.X + this.Width, this.Location.Y); 
            myF2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
