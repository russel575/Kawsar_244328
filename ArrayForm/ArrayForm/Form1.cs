using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayForm
{
    public partial class Form1 : Form

      {
        int index = 0;
        const int size = 10;
        int[] number = new int[size];

        public Form1()
        {
            InitializeComponent();

           
                
        }

       

        
        
        //for( int index = 0; Binder >9; index ++){
                
        //    }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            const int size = 10;
            int[] number = new int[size];

            number[0] = 10;
            //[2] = 20;

            String message = "";

            for (int i = 0; i < 10; i++)
            {
                if (number[i] != 0)
                    message = message + "value of index " + i + " is " + number[i].ToString() + "\n";
            }

            richTextBox1.Text = message;
            //richTextBox1.Text = number[2].ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            

             number[index] = Convert.ToInt32(addTextBox.Text);

             index++;
            

            //String message = "";

            //for (int index = 0; index < 10; index++)
            //{
            //    if (number[index] != 0)
            //        message = message + "value of index " + index + " is " + number[index].ToString() + "\n";
            //}

            richTextBox1.Text = Sh("add");
            //richTextBox1.Text = number[2].ToString();
        }

        private void reveresButton_Click(object sender, EventArgs e)
        {





            String message = "";

            //for (int index = 0; index < 10; index++)
            //{
            //    if (number[index] != 0)
            //        message = message + "value of index " + index + " is " + number[index].ToString() + "\n";
            //}

            for (int index = 9; index >= 0; index--)
            {
                if (number[index] != 0)
                    message = message + "value of index " + index + " is " + number[index].ToString() + "\n";
            }

            richTextBox1.Text = message;
            //richTextBox1.Text = number[2].ToString();
        }

        private string Sh(string name)
        {
            string message = "";

            for (int index = 0; index < 10; index++)
            {
                if (number[index] != 0)
                    message = message + "value of index " + index + " is " + number[index].ToString() + "\n";
            }
            return name + ":" +message;
           
        }
    }
}
