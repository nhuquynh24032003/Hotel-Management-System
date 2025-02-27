namespace hotel
{
    partial class addservice
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgv_service = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_service).BeginInit();
            SuspendLayout();
            // 
            // dgv_service
            // 
            dgv_service.AccessibleDescription = "";
            dgv_service.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_service.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv_service.BackgroundColor = Color.Black;
            dgv_service.BorderStyle = BorderStyle.Fixed3D;
            dgv_service.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgv_service.DefaultCellStyle = dataGridViewCellStyle1;
            dgv_service.GridColor = Color.White;
            dgv_service.Location = new Point(184, 78);
            dgv_service.Name = "dgv_service";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.InfoText;
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
            dgv_service.Size = new Size(478, 346);
            dgv_service.TabIndex = 65;
            dgv_service.CellClick += dgv_service_CellClick;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(291, 470);
            button3.Name = "button3";
            button3.Size = new Size(94, 45);
            button3.TabIndex = 95;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(449, 470);
            button1.Name = "button1";
            button1.Size = new Size(94, 45);
            button1.TabIndex = 96;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // addservice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(848, 692);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(dgv_service);
            Name = "addservice";
            Text = "addservice";
            Load += addservice_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_service).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgv_service;
        private Button button3;
        private Button button1;
    }
}