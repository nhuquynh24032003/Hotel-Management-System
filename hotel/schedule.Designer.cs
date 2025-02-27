namespace hotel
{
    partial class schedule
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
            textBox15 = new TextBox();
            panel8 = new Panel();
            textBox16 = new TextBox();
            ngayDat = new DateTimePicker();
            panel9 = new Panel();
            textBox17 = new TextBox();
            ngayTra = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox15
            // 
            textBox15.BackColor = SystemColors.InactiveCaptionText;
            textBox15.BorderStyle = BorderStyle.None;
            textBox15.Enabled = false;
            textBox15.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox15.ForeColor = SystemColors.Window;
            textBox15.Location = new Point(133, 70);
            textBox15.Name = "textBox15";
            textBox15.ReadOnly = true;
            textBox15.Size = new Size(155, 37);
            textBox15.TabIndex = 54;
            textBox15.Text = "Schedule";
            textBox15.TextChanged += textBox15_TextChanged;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Location = new Point(61, 229);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 3);
            panel8.TabIndex = 56;
            // 
            // textBox16
            // 
            textBox16.BackColor = Color.Black;
            textBox16.BorderStyle = BorderStyle.None;
            textBox16.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox16.ForeColor = Color.White;
            textBox16.Location = new Point(60, 160);
            textBox16.Name = "textBox16";
            textBox16.ReadOnly = true;
            textBox16.Size = new Size(189, 27);
            textBox16.TabIndex = 57;
            textBox16.Text = "Date check in";
            // 
            // ngayDat
            // 
            ngayDat.Location = new Point(60, 196);
            ngayDat.Name = "ngayDat";
            ngayDat.Size = new Size(250, 27);
            ngayDat.TabIndex = 58;
            // 
            // panel9
            // 
            panel9.BackColor = Color.White;
            panel9.Location = new Point(62, 345);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 3);
            panel9.TabIndex = 59;
            // 
            // textBox17
            // 
            textBox17.BackColor = Color.Black;
            textBox17.BorderStyle = BorderStyle.None;
            textBox17.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox17.ForeColor = Color.White;
            textBox17.Location = new Point(61, 276);
            textBox17.Name = "textBox17";
            textBox17.ReadOnly = true;
            textBox17.Size = new Size(189, 27);
            textBox17.TabIndex = 60;
            textBox17.Text = "Date check out";
            // 
            // ngayTra
            // 
            ngayTra.Location = new Point(61, 312);
            ngayTra.Name = "ngayTra";
            ngayTra.Size = new Size(250, 27);
            ngayTra.TabIndex = 61;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Silver;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(133, 404);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 64;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // schedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(373, 498);
            Controls.Add(ngayTra);
            Controls.Add(button1);
            Controls.Add(textBox17);
            Controls.Add(panel9);
            Controls.Add(textBox15);
            Controls.Add(ngayDat);
            Controls.Add(textBox16);
            Controls.Add(panel8);
            Name = "schedule";
            Text = "schedule";
            Load += schedule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox15;
        private Panel panel8;
        private TextBox textBox16;
        private DateTimePicker ngayDat;
        private Panel panel9;
        private TextBox textBox17;
        private DateTimePicker ngayTra;
        private Button button1;
    }
}