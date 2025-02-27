namespace hotel
{
    partial class service
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel4 = new Panel();
            txt_price = new TextBox();
            txt_name = new TextBox();
            btn_search = new Button();
            txt_search = new TextBox();
            btn_delete = new Button();
            btn_add = new Button();
            textBox7 = new TextBox();
            textBox5 = new TextBox();
            panel3 = new Panel();
            textBox2 = new TextBox();
            panel1 = new Panel();
            txt_id = new TextBox();
            dgv_service = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_service).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Location = new Point(24, 424);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 3);
            panel4.TabIndex = 82;
            panel4.Paint += panel4_Paint;
            // 
            // txt_price
            // 
            txt_price.BackColor = Color.FromArgb(0, 1, 0);
            txt_price.BorderStyle = BorderStyle.None;
            txt_price.Cursor = Cursors.IBeam;
            txt_price.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_price.ForeColor = Color.White;
            txt_price.Location = new Point(23, 392);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(250, 27);
            txt_price.TabIndex = 81;
            txt_price.TextChanged += textBox8_TextChanged;
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.FromArgb(0, 1, 0);
            txt_name.BorderStyle = BorderStyle.None;
            txt_name.Cursor = Cursors.IBeam;
            txt_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.ForeColor = Color.White;
            txt_name.Location = new Point(23, 301);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(250, 27);
            txt_name.TabIndex = 80;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Black;
            btn_search.BackgroundImage = Properties.Resources.search_1_5;
            btn_search.Cursor = Cursors.Hand;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Location = new Point(1057, 205);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(27, 27);
            btn_search.TabIndex = 78;
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.Black;
            txt_search.Cursor = Cursors.IBeam;
            txt_search.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.ForeColor = Color.White;
            txt_search.Location = new Point(778, 197);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search";
            txt_search.Size = new Size(313, 38);
            txt_search.TabIndex = 77;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.Black;
            btn_delete.Cursor = Cursors.Hand;
            btn_delete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.Image = Properties.Resources.x_5;
            btn_delete.ImageAlign = ContentAlignment.MiddleRight;
            btn_delete.Location = new Point(486, 379);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(117, 55);
            btn_delete.TabIndex = 76;
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
            btn_add.Location = new Point(486, 287);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(117, 57);
            btn_add.TabIndex = 74;
            btn_add.Text = "Add";
            btn_add.TextAlign = ContentAlignment.MiddleLeft;
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(0, 1, 0);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.ForeColor = Color.White;
            textBox7.Location = new Point(23, 359);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(125, 27);
            textBox7.TabIndex = 72;
            textBox7.Text = "Price";
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(0, 1, 0);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.ForeColor = Color.White;
            textBox5.Location = new Point(22, 269);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 71;
            textBox5.Text = "Name";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(23, 333);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 3);
            panel3.TabIndex = 70;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(0, 1, 0);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = Color.White;
            textBox2.Location = new Point(22, 176);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 67;
            textBox2.Text = "ID ";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(23, 241);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 3);
            panel1.TabIndex = 66;
            // 
            // txt_id
            // 
            txt_id.BackColor = Color.FromArgb(0, 1, 0);
            txt_id.BorderStyle = BorderStyle.None;
            txt_id.Cursor = Cursors.IBeam;
            txt_id.Enabled = false;
            txt_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_id.ForeColor = Color.White;
            txt_id.Location = new Point(22, 209);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(250, 27);
            txt_id.TabIndex = 65;
            // 
            // dgv_service
            // 
            dgv_service.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_service.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_service.BackgroundColor = Color.FromArgb(0, 1, 0);
            dgv_service.BorderStyle = BorderStyle.Fixed3D;
            dgv_service.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_service.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_service.GridColor = Color.White;
            dgv_service.Location = new Point(24, 500);
            dgv_service.Name = "dgv_service";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_service.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_service.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(0, 1, 0);
            dataGridViewCellStyle3.Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkGray;
            dgv_service.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgv_service.RowTemplate.Height = 29;
            dgv_service.Size = new Size(1077, 288);
            dgv_service.TabIndex = 64;
            dgv_service.CellClick += dgv_service_CellClick;
            dgv_service.CellEndEdit += dgv_service_CellEndEdit;
            // 
            // service
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Midnight_Inn__5_;
            Controls.Add(panel4);
            Controls.Add(txt_price);
            Controls.Add(txt_name);
            Controls.Add(btn_search);
            Controls.Add(txt_search);
            Controls.Add(btn_delete);
            Controls.Add(btn_add);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
            Controls.Add(panel3);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(txt_id);
            Controls.Add(dgv_service);
            Name = "service";
            Size = new Size(1642, 833);
            Load += service_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_service).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel4;
        private TextBox txt_price;
        private TextBox txt_name;
        private Button btn_search;
        private TextBox txt_search;
        private Button btn_delete;
        private Button btn_add;
        private TextBox textBox7;
        private TextBox textBox5;
        private Panel panel3;
        private TextBox textBox2;
        private Panel panel1;
        private TextBox txt_id;
        private DataGridView dgv_service;
    }
}
