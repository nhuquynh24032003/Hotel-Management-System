namespace hotel
{
    partial class booked
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
            dgv_hd = new DataGridView();
            button1 = new Button();
            txt_search = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_hd).BeginInit();
            SuspendLayout();
            // 
            // dgv_hd
            // 
            dgv_hd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_hd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_hd.BackgroundColor = Color.Black;
            dgv_hd.BorderStyle = BorderStyle.Fixed3D;
            dgv_hd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_hd.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_hd.GridColor = Color.White;
            dgv_hd.Location = new Point(37, 292);
            dgv_hd.Name = "dgv_hd";
            dgv_hd.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 1, 0);
            dataGridViewCellStyle2.Font = new Font("Dubai", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkGray;
            dgv_hd.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv_hd.RowTemplate.Height = 29;
            dgv_hd.Size = new Size(1013, 370);
            dgv_hd.TabIndex = 65;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = Properties.Resources.search_1_5;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(1014, 232);
            button1.Name = "button1";
            button1.Size = new Size(28, 27);
            button1.TabIndex = 89;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txt_search
            // 
            txt_search.BackColor = Color.Black;
            txt_search.Cursor = Cursors.IBeam;
            txt_search.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.ForeColor = Color.White;
            txt_search.Location = new Point(737, 227);
            txt_search.Name = "txt_search";
            txt_search.PlaceholderText = "Search";
            txt_search.Size = new Size(313, 38);
            txt_search.TabIndex = 88;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(490, 704);
            button4.Name = "button4";
            button4.Size = new Size(133, 40);
            button4.TabIndex = 110;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // booked
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Midnight_Inn__9_;
            Controls.Add(button4);
            Controls.Add(button1);
            Controls.Add(txt_search);
            Controls.Add(dgv_hd);
            Name = "booked";
            Size = new Size(1639, 842);
            Load += booked_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_hd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_hd;
        private Button button1;
        private TextBox txt_search;
        private Button button4;
    }
}
