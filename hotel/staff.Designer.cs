namespace hotel
{
    partial class staff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgv_emp = new DataGridView();
            textBox2 = new TextBox();
            panel1 = new Panel();
            txt_id = new TextBox();
            textBox3 = new TextBox();
            panel2 = new Panel();
            txt_name = new TextBox();
            textBox5 = new TextBox();
            panel3 = new Panel();
            textBox7 = new TextBox();
            textBox9 = new TextBox();
            panel5 = new Panel();
            txt_idCard = new TextBox();
            textBox11 = new TextBox();
            panel6 = new Panel();
            txt_phone = new TextBox();
            date_dob = new DateTimePicker();
            ck_male = new CheckBox();
            ck_female = new CheckBox();
            btn_delete = new Button();
            btn_add = new Button();
            txt_search = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_emp).BeginInit();
            SuspendLayout();
            // 
            // dgv_emp
            // 
            dgv_emp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_emp.BackgroundColor = Color.FromArgb(25, 25, 25);
            dgv_emp.BorderStyle = BorderStyle.Fixed3D;
            dgv_emp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_emp.GridColor = Color.White;
            dgv_emp.Location = new Point(27, 450);
            dgv_emp.Name = "dgv_emp";
            dgv_emp.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(25, 25, 25);
            dataGridViewCellStyle1.Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dgv_emp.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_emp.RowTemplate.Height = 29;
            dgv_emp.Size = new Size(1097, 296);
            dgv_emp.TabIndex = 0;
            dgv_emp.CellClick += dgv_emp_CellClick;
            dgv_emp.CellEndEdit += dgv_emp_CellEndEdit;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(25, 25, 25);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(26, 163);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 10;
            textBox2.Text = "ID ";
            // 
            // panel1
            // 
            panel1.Location = new Point(28, 218);
            panel1.Name = "panel1";
            panel1.Size = new Size(249, 3);
            panel1.TabIndex = 9;
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.FromArgb(25, 25, 25);
            txt_id.BorderStyle = BorderStyle.None;
            txt_id.Cursor = Cursors.IBeam;
            txt_id.Enabled = false;
            txt_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.ForeColor = Color.White;
            txt_id.Location = new Point(26, 191);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(249, 27);
            txt_id.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(25, 25, 25);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(28, 262);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 13;
            textBox3.Text = "Name";
            // 
            // panel2
            // 
            panel2.Location = new Point(30, 317);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 3);
            panel2.TabIndex = 12;
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.FromArgb(25, 25, 25);
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Cursor = Cursors.IBeam;
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.ForeColor = Color.White;
            txt_name.Location = new Point(28, 290);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(249, 27);
            txt_name.TabIndex = 11;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(25, 25, 25);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(30, 358);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 16;
            textBox5.Text = "Date of birth";
            // 
            // panel3
            // 
            panel3.Location = new Point(30, 413);
            panel3.Name = "panel3";
            panel3.Size = new Size(249, 3);
            panel3.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(25, 25, 25);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.ForeColor = Color.White;
            textBox7.Location = new Point(448, 163);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 19;
            textBox7.Text = "Gender";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(25, 25, 25);
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.ForeColor = Color.White;
            textBox9.Location = new Point(448, 262);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(189, 27);
            textBox9.TabIndex = 22;
            textBox9.Text = "Citizen Identification";
            // 
            // panel5
            // 
            panel5.Location = new Point(450, 317);
            panel5.Name = "panel5";
            panel5.Size = new Size(249, 3);
            panel5.TabIndex = 21;
            // 
            // txt_idCard
            // 
            txt_idCard.BackColor = Color.FromArgb(25, 25, 25);
            txt_idCard.BorderStyle = BorderStyle.None;
            txt_idCard.Cursor = Cursors.IBeam;
            txt_idCard.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_idCard.ForeColor = Color.White;
            txt_idCard.Location = new Point(448, 290);
            txt_idCard.Name = "txt_idCard";
            txt_idCard.Size = new Size(249, 27);
            txt_idCard.TabIndex = 20;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(25, 25, 25);
            textBox11.BorderStyle = BorderStyle.None;
            textBox11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox11.ForeColor = Color.White;
            textBox11.Location = new Point(448, 358);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(135, 27);
            textBox11.TabIndex = 25;
            textBox11.Text = "Phone number";
            // 
            // panel6
            // 
            panel6.Location = new Point(450, 413);
            panel6.Name = "panel6";
            panel6.Size = new Size(249, 3);
            panel6.TabIndex = 24;
            // 
            // txt_phone
            // 
            txt_phone.BackColor = Color.FromArgb(25, 25, 25);
            txt_phone.BorderStyle = BorderStyle.None;
            txt_phone.Cursor = Cursors.IBeam;
            txt_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phone.ForeColor = Color.White;
            txt_phone.Location = new Point(448, 386);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(249, 27);
            txt_phone.TabIndex = 23;
            txt_phone.KeyPress += textBox12_KeyPress;
            // 
            // date_dob
            // 
            date_dob.Cursor = Cursors.Hand;
            date_dob.Location = new Point(30, 385);
            date_dob.Name = "date_dob";
            date_dob.Size = new Size(251, 25);
            date_dob.TabIndex = 26;
            // 
            // ck_male
            // 
            ck_male.AutoSize = true;
            ck_male.BackColor = Color.Transparent;
            ck_male.Cursor = Cursors.Hand;
            ck_male.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ck_male.ForeColor = Color.White;
            ck_male.Location = new Point(450, 201);
            ck_male.Name = "ck_male";
            ck_male.Size = new Size(77, 32);
            ck_male.TabIndex = 27;
            ck_male.Text = "Male";
            ck_male.UseVisualStyleBackColor = false;
            ck_male.CheckedChanged += ck_male_CheckedChanged;
            // 
            // ck_female
            // 
            ck_female.AutoSize = true;
            ck_female.BackColor = Color.Transparent;
            ck_female.Cursor = Cursors.Hand;
            ck_female.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ck_female.ForeColor = Color.White;
            ck_female.Location = new Point(604, 201);
            ck_female.Name = "ck_female";
            ck_female.Size = new Size(96, 32);
            ck_female.TabIndex = 28;
            ck_female.Text = "Female";
            ck_female.UseVisualStyleBackColor = false;
            ck_female.CheckedChanged += ck_female_CheckedChanged;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Black;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.Image = Properties.Resources.x_5;
            btn_delete.ImageAlign = ContentAlignment.MiddleRight;
            btn_delete.Location = new Point(814, 342);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(117, 47);
            btn_delete.TabIndex = 31;
            btn_delete.Text = "Delete";
            btn_delete.TextAlign = ContentAlignment.MiddleLeft;
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.Black;
            btn_add.Cursor = Cursors.Hand;
            btn_add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_add.ForeColor = Color.White;
            btn_add.Image = Properties.Resources.plus_1_1_5;
            btn_add.ImageAlign = ContentAlignment.MiddleRight;
            btn_add.Location = new Point(814, 265);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(117, 48);
            btn_add.TabIndex = 29;
            btn_add.Text = "Add";
            btn_add.TextAlign = ContentAlignment.MiddleLeft;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.Black;
            txt_search.Cursor = Cursors.IBeam;
            txt_search.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.ForeColor = Color.White;
            txt_search.Location = new Point(967, 163);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search";
            txt_search.Size = new Size(313, 38);
            txt_search.TabIndex = 32;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = Properties.Resources.search_1_5;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1249, 170);
            button1.Name = "button1";
            button1.Size = new Size(28, 27);
            button1.TabIndex = 90;
            button1.UseVisualStyleBackColor = false;
            // 
            // staff
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackgroundImage = Properties.Resources.Midnight_Inn__2_;
            Controls.Add(button1);
            Controls.Add(txt_search);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(ck_female);
            Controls.Add(ck_male);
            Controls.Add(date_dob);
            Controls.Add(textBox11);
            Controls.Add(panel6);
            Controls.Add(txt_phone);
            Controls.Add(textBox9);
            Controls.Add(panel5);
            Controls.Add(txt_idCard);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(panel3);
            Controls.Add(textBox3);
            Controls.Add(panel2);
            Controls.Add(txt_name);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(txt_id);
            Controls.Add(dgv_emp);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "staff";
            Size = new Size(1504, 803);
            Load += staff_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_emp).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_emp;
        private TextBox textBox2;
        private Panel panel1;
        private TextBox txt_id;
        private TextBox textBox3;
        private Panel panel2;
        private TextBox txt_name;
        private TextBox textBox5;
        private Panel panel3;
        private TextBox textBox7;
        private TextBox textBox9;
        private Panel panel5;
        private TextBox txt_idCard;
        private TextBox textBox11;
        private Panel panel6;
        private TextBox txt_phone;
        private DateTimePicker date_dob;
        private CheckBox ck_male;
        private CheckBox ck_female;
        private Button btn_delete;
        private Button btn_add;
        private TextBox txt_search;
        private Button button1;
    }
}
