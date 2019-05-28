using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormValidation
{
    public partial class FormValidation : Form
    {

        List<string> names = new List<string>();
        List<string> users = new List<string>();
        List<int> ages = new List<int>();
        

        public FormValidation()
        {
            InitializeComponent();
        }

        

        private void SaveButton_Click(object sender, EventArgs e)
        {

            
            try
            {
                string user;
                string name = nameTextBox.Text;
                int age;

                userLabel.Text = "";
                if (!String.IsNullOrEmpty(userTextBox.Text))
                {
                    user = user = userTextBox.Text; 
                   
                }
                else
                {
                    userLabel.Text = "Field Must Not be Empty";
                    return;
                }

                ageLabel.Text = "";
                    if (!String.IsNullOrEmpty(ageTextBox.Text))
                {
                    age = Convert.ToInt32(ageTextBox.Text);
                    
                }
                else
                {
                    ageLabel.Text = "Field Must Not be Empty";
                    return;
                }

                
                users.Add(user);
                names.Add(name);
                ages.Add(age);


                showRichTextBox.Text = display();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            


        }

        private string display()
        {
            string message = "";
            message = "SL\tUser\tName\tAge\n";

            int index = 0;

            foreach (string user in users)
                message = message + (index+1) + "\t" + user + "\t" + names[index] + "\t" + ages[index] + "\n";

            return message;

               }
    }
}
