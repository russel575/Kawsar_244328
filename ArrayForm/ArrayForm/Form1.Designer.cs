namespace ArrayForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.reveresButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(155, 75);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(350, 151);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(430, 30);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show Array";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(315, 30);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // addTextBox
            // 
            this.addTextBox.Location = new System.Drawing.Point(172, 32);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(100, 20);
            this.addTextBox.TabIndex = 3;
            // 
            // reveresButton
            // 
            this.reveresButton.Location = new System.Drawing.Point(540, 106);
            this.reveresButton.Name = "reveresButton";
            this.reveresButton.Size = new System.Drawing.Size(75, 23);
            this.reveresButton.TabIndex = 4;
            this.reveresButton.Text = "Reveres";
            this.reveresButton.UseVisualStyleBackColor = true;
            this.reveresButton.Click += new System.EventHandler(this.reveresButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reveresButton);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Array Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button reveresButton;
    }
}

