namespace WinForms_Password_Gen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            passwordGenButton = new Button();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // passwordGenButton
            // 
            passwordGenButton.BackColor = SystemColors.ControlDarkDark;
            passwordGenButton.Location = new Point(277, 175);
            passwordGenButton.Name = "passwordGenButton";
            passwordGenButton.Size = new Size(154, 42);
            passwordGenButton.TabIndex = 0;
            passwordGenButton.Text = "Click me :)";
            passwordGenButton.UseVisualStyleBackColor = false;
            passwordGenButton.Click += passwordGenButton_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(299, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Location = new Point(277, 128);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 3;
            label1.Text = "Enter Number Of Characters";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 157);
            label2.Name = "label2";
            label2.Size = new Size(246, 60);
            label2.TabIndex = 4;
            label2.Text = "Welcome to my random password generator.\r\nplease enter number of chars to the right \r\nand click the \"click me\" button\r\nplease note do not go over 60 chars.";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Window;
            textBoxResult.Location = new Point(98, 54);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(442, 44);
            textBoxResult.TabIndex = 5;
            textBoxResult.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(552, 258);
            Controls.Add(textBoxResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(passwordGenButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Password Generator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button passwordGenButton;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBoxResult;
    }
}