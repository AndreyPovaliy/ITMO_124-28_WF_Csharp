﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17.EditPerson__4_23_
{
    

    public partial class Form1 : Form
    {
        List<Person> pers = new List<Person>();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() != DialogResult.OK)
                return;
            pers.Add(p);
            personsListView.VirtualListSize = pers.Count;
            personsListView.Invalidate();


        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            if(personsListView.SelectedIndices.Count == 0) 
                return;
            Person p = pers[personsListView.SelectedIndices[0]];
            EditPersonForm editForm = new EditPersonForm(p);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                personsListView.Invalidate();
            }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Person item in pers)
            {
                sb.Append("Сотрудник: \n" + item.ToString());
            }
            richTextBox1.Text = sb.ToString();
        }

        private void personsListView_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (e.ItemIndex >= 0 && e.ItemIndex < pers.Count)
            {
                e.Item = new ListViewItem(pers[e.ItemIndex].FirstName);
                e.Item.SubItems.Add(pers[e.ItemIndex].LastName);
                e.Item.SubItems.Add(pers[e.ItemIndex].Age.ToString());
            }
        }
    }
}
