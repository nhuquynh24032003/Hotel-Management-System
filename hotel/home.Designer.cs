namespace hotel
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            staff1 = new staff();
            label3 = new Label();
            room1 = new room();
            label4 = new Label();
            service1 = new service();
            label5 = new Label();
            checkin1 = new checkin();
            label6 = new Label();
            mana_customer1 = new mana_customer();
            label7 = new Label();
            booked1 = new booked();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(31, 33, 37);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.logout_1_1_10;
            button1.Location = new Point(1549, 0);
            button1.Name = "button1";
            button1.Size = new Size(77, 78);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(31, 33, 37);
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(602, 23);
            label1.Name = "label1";
            label1.Size = new Size(75, 31);
            label1.TabIndex = 2;
            label1.Text = "Home";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(31, 33, 37);
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(715, 23);
            label2.Name = "label2";
            label2.Size = new Size(59, 31);
            label2.TabIndex = 3;
            label2.Text = "Staff";
            label2.Click += label2_Click;
            // 
            // staff1
            // 
            staff1.AutoSize = true;
            staff1.BackgroundImage = (Image)resources.GetObject("staff1.BackgroundImage");
            staff1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            staff1.ForeColor = SystemColors.ButtonHighlight;
            staff1.Location = new Point(-1, 83);
            staff1.Name = "staff1";
            staff1.Size = new Size(1640, 1080);
            staff1.TabIndex = 4;
            staff1.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(31, 33, 37);
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(938, 23);
            label3.Name = "label3";
            label3.Size = new Size(73, 31);
            label3.TabIndex = 5;
            label3.Text = "Room";
            label3.Click += label3_Click;
            // 
            // room1
            // 
            room1.BackColor = Color.Black;
            room1.BackgroundImage = (Image)resources.GetObject("room1.BackgroundImage");
            room1.Location = new Point(-1, 84);
            room1.Name = "room1";
            room1.Size = new Size(1647, 1131);
            room1.TabIndex = 6;
            room1.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(31, 33, 37);
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(1155, 23);
            label4.Name = "label4";
            label4.Size = new Size(86, 31);
            label4.TabIndex = 7;
            label4.Text = "Service";
            label4.Click += label4_Click;
            // 
            // service1
            // 
            service1.BackgroundImage = (Image)resources.GetObject("service1.BackgroundImage");
            service1.Location = new Point(-1, 85);
            service1.Name = "service1";
            service1.Size = new Size(2052, 1041);
            service1.TabIndex = 8;
            service1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(31, 33, 37);
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(1273, 23);
            label5.Name = "label5";
            label5.Size = new Size(100, 31);
            label5.TabIndex = 9;
            label5.Text = "Check In";
            label5.Click += label5_Click;
            // 
            // checkin1
            // 
            checkin1.BackgroundImage = (Image)resources.GetObject("checkin1.BackgroundImage");
            checkin1.Location = new Point(-3, 86);
            checkin1.Name = "checkin1";
            checkin1.Size = new Size(2054, 1082);
            checkin1.TabIndex = 10;
            checkin1.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.FromArgb(31, 33, 37);
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(804, 23);
            label6.Name = "label6";
            label6.Size = new Size(112, 31);
            label6.TabIndex = 11;
            label6.Text = "Customer";
            label6.Click += label6_Click;
            // 
            // mana_customer1
            // 
            mana_customer1.BackgroundImage = (Image)resources.GetObject("mana_customer1.BackgroundImage");
            mana_customer1.BorderStyle = BorderStyle.Fixed3D;
            mana_customer1.ForeColor = SystemColors.ButtonHighlight;
            mana_customer1.Location = new Point(-5, 83);
            mana_customer1.Name = "mana_customer1";
            mana_customer1.Size = new Size(1649, 1037);
            mana_customer1.TabIndex = 12;
            mana_customer1.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(31, 33, 37);
            label7.Cursor = Cursors.Hand;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(1045, 23);
            label7.Name = "label7";
            label7.Size = new Size(90, 31);
            label7.TabIndex = 13;
            label7.Text = "Booked";
            label7.Click += label7_Click;
            // 
            // booked1
            // 
            booked1.BackgroundImage = (Image)resources.GetObject("booked1.BackgroundImage");
            booked1.Location = new Point(-3, 86);
            booked1.Name = "booked1";
            booked1.Size = new Size(2049, 1052);
            booked1.TabIndex = 14;
            booked1.Visible = false;
            // 
            // home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Midnight_Inn__1_;
            ClientSize = new Size(1638, 897);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(checkin1);
            Controls.Add(room1);
            Controls.Add(staff1);
            Controls.Add(service1);
            Controls.Add(booked1);
            Controls.Add(mana_customer1);
            Name = "home";
            Text = "Home";
            Load += home_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private staff staff1;
        private Label label3;
        private room room1;
        private Label label4;
        private service service1;
        private Label label5;
        private checkin checkin1;
        private Label label6;
        private mana_customer mana_customer1;
        private Label label7;
        private booked booked1;
    }
}