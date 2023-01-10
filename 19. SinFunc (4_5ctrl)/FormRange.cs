using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _19.SinFunc__4_5ctrl_
{
    public partial class FormRange : Form
    {
        public FormRange()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + " " + textBox2.Text;
            string l = "Левая граница: " +textBox1.Text + " правая граница " + textBox2.Text;
            Form1 frm1 = this.Owner as Form1;
            if (frm1 != null)
            {
                frm1.S_Data = s;
                frm1.L_Data = l;
            }
            this.Close();
        }
    }
    
}