namespace hotel
{
    partial class login
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
            txt_name = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txt_pass = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.FromArgb(31, 33, 37);
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.ForeColor = Color.White;
            txt_name.Location = new Point(38, 326);
            txt_name.Margin = new Padding(3, 2, 3, 2);
            txt_name.Name = "txt_name";
            txt_name.PlaceholderText = "Username";
            txt_name.Size = new Size(379, 29);
            txt_name.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(35, 358);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 3);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(32, 428);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(382, 3);
            panel2.TabIndex = 3;
            // 
            // txt_pass
            // 
            txt_pass.BackColor = Color.FromArgb(31, 33, 37);
            txt_pass.BorderStyle = BorderStyle.None;
            txt_pass.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.ForeColor = Color.White;
            txt_pass.Location = new Point(35, 394);
            txt_pass.Margin = new Padding(3, 2, 3, 2);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.PlaceholderText = "Password";
            txt_pass.Size = new Size(379, 29);
            txt_pass.TabIndex = 2;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Black;
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.ImageAlign = ContentAlignment.MiddleLeft;
            btn_login.Location = new Point(129, 484);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(164, 52);
            btn_login.TabIndex = 4;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            BackgroundImage = Properties.Resources.Midnight_Inn;
            ClientSize = new Size(1435, 688);
            Controls.Add(btn_login);
            Controls.Add(panel2);
            Controls.Add(txt_pass);
            Controls.Add(panel1);
            Controls.Add(txt_name);
            Margin = new Padding(3, 2, 3, 2);
            Name = "login";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_name;
        private Panel panel1;
        private Panel panel2;
        private TextBox txt_pass;
        private Button btn_login;
    }
}