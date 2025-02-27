namespace hotel
{
    partial class mana_customer
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
            button1 = new Button();
            txt_search = new TextBox();
            dgv_cus = new DataGridView();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_cus).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.BackgroundImage = Properties.Resources.search_1_5;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1588, 205);
            button1.Name = "button1";
            button1.Size = new Size(23, 25);
            button1.TabIndex = 75;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.FromArgb(64, 64, 64);
            txt_search.Cursor = Cursors.IBeam;
            txt_search.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.ForeColor = Color.White;
            txt_search.Location = new Point(1307, 199);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search";
            txt_search.Size = new Size(313, 38);
            txt_search.TabIndex = 74;
            // 
            // dgv_cus
            // 
            dgv_cus.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_cus.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_cus.BackgroundColor = Color.FromArgb(98, 98, 98);
            dgv_cus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_cus.GridColor = Color.White;
            dgv_cus.Location = new Point(752, 243);
            dgv_cus.Name = "dgv_cus";
            dgv_cus.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(98, 98, 98);
            dataGridViewCellStyle1.Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkGray;
            dgv_cus.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_cus.RowTemplate.Height = 29;
            dgv_cus.Size = new Size(868, 433);
            dgv_cus.TabIndex = 63;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(1146, 731);
            button4.Name = "button4";
            button4.Size = new Size(133, 40);
            button4.TabIndex = 110;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // mana_customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Midnight_Inn__8_;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(txt_search);
            Controls.Add(dgv_cus);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "mana_customer";
            Size = new Size(1641, 830);
            Load += mana_customer_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_cus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox txt_search;
        private DataGridView dgv_cus;
        private Button button4;
    }
}
