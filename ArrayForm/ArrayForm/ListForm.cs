﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayForm
{
    public partial class ListForm : Form
    {
        public ListForm()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            List<int> numbers = new List<int>();

            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);
            numbers.Add(7);

            List<string> names = new List<string>();

            names.Add("kawsar");
            names.Add("tamim");

            names.Add("babul");

            names.Add("Mijan");
            names.Add("Shimul");
            names.Add("Shamim");
            names.Add("Kalam");







            string message = "";

                message = message + "ForEach" + "\n";
            int index = 0;

            foreach (int number in numbers)
            {
                message = message + number + names[index] + "\n";

                index ++;
            }

            message = message + "ForLoop" + "\n";

            for(int i =0; i<numbers.Count; i++)
            {
                message = message + numbers[i].ToString( ) + names[i] + "\n";
            }

            richTextBox.Text = message;
        }

        
    }
}
