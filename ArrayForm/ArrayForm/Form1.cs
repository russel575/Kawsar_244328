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
        public Form1()
        {
            InitializeComponent();
            const int size = 10;
            int[] number = new int[size];

            number[0] = 10;
            number[2] = 20;

            String message = "" ;

            for(int k = 0; k < 9; k++)
            {
                if(number[k] != 0)
                message = message + "value of index " + k + " is " + number[k].ToString() +"\n";
            }

            richTextBox1.Text =message;
            //richTextBox1.Text = number[2].ToString();
        }

       

        
        
        //for( int index = 0; Binder >9; index ++){
                
        //    }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
