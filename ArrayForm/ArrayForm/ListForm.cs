using System;
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

            string message = "";

                message = message + "ForEach" + "\n";

            foreach (int number in numbers)
            {
                message = message + number + "\n";
            }

            message = message + "ForLoop" + "\n";

            for(int i =0; i<numbers.Count; i++)
            {
                message = message + numbers[i].ToString() + "\n";
            }

            richTextBox.Text = message;
        }
    }
}
