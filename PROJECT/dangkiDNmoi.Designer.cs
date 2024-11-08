namespace PROJECT.FormControl
{
    partial class dangkiDNmoi
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
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            rjButton1 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            rjTextBox6 = new CustomControls.RJControls.RJTextBox();
            rjTextBox5 = new CustomControls.RJControls.RJTextBox();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            rjTextBox3 = new CustomControls.RJControls.RJTextBox();
            rjTextBox4 = new CustomControls.RJControls.RJTextBox();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            panel2 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(2, 2);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(628, 38);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(195, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 19);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÍ DOANH NGHIỆP MỚI";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(rjButton1, 0, 0);
            tableLayoutPanel2.Controls.Add(rjButton2, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 246);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(628, 57);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rjButton1.BackColor = Color.FromArgb(141, 185, 106);
            rjButton1.BackgroundColor = Color.FromArgb(141, 185, 106);
            rjButton1.BorderColor = Color.FromArgb(141, 185, 106);
            rjButton1.BorderRadius = 15;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjButton1.ForeColor = Color.White;
            rjButton1.Location = new Point(82, 15);
            rjButton1.Margin = new Padding(40, 15, 40, 15);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(150, 27);
            rjButton1.TabIndex = 3;
            rjButton1.Text = "Xóa tất cả";
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // rjButton2
            // 
            rjButton2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            rjButton2.BackColor = Color.FromArgb(141, 185, 106);
            rjButton2.BackgroundColor = Color.FromArgb(141, 185, 106);
            rjButton2.BorderColor = Color.FromArgb(141, 185, 106);
            rjButton2.BorderRadius = 15;
            rjButton2.BorderSize = 0;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rjButton2.ForeColor = Color.White;
            rjButton2.Location = new Point(396, 15);
            rjButton2.Margin = new Padding(40, 15, 40, 15);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(150, 27);
            rjButton2.TabIndex = 2;
            rjButton2.Text = "Xác nhận";
            rjButton2.TextColor = Color.White;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(rjTextBox6, 1, 2);
            tableLayoutPanel1.Controls.Add(rjTextBox5, 0, 2);
            tableLayoutPanel1.Controls.Add(rjTextBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(rjTextBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(rjTextBox4, 1, 1);
            tableLayoutPanel1.Controls.Add(rjTextBox2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 44);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(628, 198);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // rjTextBox6
            // 
            rjTextBox6.BackColor = Color.LightGray;
            rjTextBox6.BorderColor = Color.LightGray;
            rjTextBox6.BorderFocusColor = Color.Silver;
            rjTextBox6.BorderRadius = 7;
            rjTextBox6.BorderSize = 2;
            rjTextBox6.Dock = DockStyle.Fill;
            rjTextBox6.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox6.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox6.Location = new Point(338, 158);
            rjTextBox6.Margin = new Padding(24, 28, 24, 28);
            rjTextBox6.Multiline = false;
            rjTextBox6.Name = "rjTextBox6";
            rjTextBox6.Padding = new Padding(10, 7, 10, 7);
            rjTextBox6.PasswordChar = false;
            rjTextBox6.PlaceholderColor = Color.DimGray;
            rjTextBox6.PlaceholderText = "Nhập tên người đại diện";
            rjTextBox6.Size = new Size(266, 32);
            rjTextBox6.TabIndex = 19;
            rjTextBox6.Texts = "";
            rjTextBox6.UnderlinedStyle = false;
            // 
            // rjTextBox5
            // 
            rjTextBox5.BackColor = Color.LightGray;
            rjTextBox5.BorderColor = Color.LightGray;
            rjTextBox5.BorderFocusColor = Color.Silver;
            rjTextBox5.BorderRadius = 7;
            rjTextBox5.BorderSize = 2;
            rjTextBox5.Dock = DockStyle.Fill;
            rjTextBox5.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox5.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox5.Location = new Point(24, 158);
            rjTextBox5.Margin = new Padding(24, 28, 24, 28);
            rjTextBox5.Multiline = false;
            rjTextBox5.Name = "rjTextBox5";
            rjTextBox5.Padding = new Padding(10, 7, 10, 7);
            rjTextBox5.PasswordChar = false;
            rjTextBox5.PlaceholderColor = Color.DimGray;
            rjTextBox5.PlaceholderText = "Nhập ID Bussiness";
            rjTextBox5.Size = new Size(266, 32);
            rjTextBox5.TabIndex = 18;
            rjTextBox5.Texts = "";
            rjTextBox5.UnderlinedStyle = false;
            // 
            // rjTextBox1
            // 
            rjTextBox1.BackColor = Color.LightGray;
            rjTextBox1.BorderColor = Color.LightGray;
            rjTextBox1.BorderFocusColor = Color.Silver;
            rjTextBox1.BorderRadius = 7;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Dock = DockStyle.Fill;
            rjTextBox1.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(24, 28);
            rjTextBox1.Margin = new Padding(24, 28, 24, 28);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.DimGray;
            rjTextBox1.PlaceholderText = "Nhập tên doanh nghiệp";
            rjTextBox1.Size = new Size(266, 32);
            rjTextBox1.TabIndex = 17;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox3
            // 
            rjTextBox3.BackColor = Color.LightGray;
            rjTextBox3.BorderColor = Color.LightGray;
            rjTextBox3.BorderFocusColor = Color.Silver;
            rjTextBox3.BorderRadius = 7;
            rjTextBox3.BorderSize = 2;
            rjTextBox3.Dock = DockStyle.Fill;
            rjTextBox3.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox3.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox3.Location = new Point(24, 93);
            rjTextBox3.Margin = new Padding(24, 28, 24, 28);
            rjTextBox3.Multiline = false;
            rjTextBox3.Name = "rjTextBox3";
            rjTextBox3.Padding = new Padding(10, 7, 10, 7);
            rjTextBox3.PasswordChar = false;
            rjTextBox3.PlaceholderColor = Color.DimGray;
            rjTextBox3.PlaceholderText = "Nhập địa chỉ";
            rjTextBox3.Size = new Size(266, 32);
            rjTextBox3.TabIndex = 13;
            rjTextBox3.Texts = "";
            rjTextBox3.UnderlinedStyle = false;
            // 
            // rjTextBox4
            // 
            rjTextBox4.BackColor = Color.LightGray;
            rjTextBox4.BorderColor = Color.LightGray;
            rjTextBox4.BorderFocusColor = Color.Silver;
            rjTextBox4.BorderRadius = 7;
            rjTextBox4.BorderSize = 2;
            rjTextBox4.Dock = DockStyle.Fill;
            rjTextBox4.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox4.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox4.Location = new Point(338, 93);
            rjTextBox4.Margin = new Padding(24, 28, 24, 28);
            rjTextBox4.Multiline = false;
            rjTextBox4.Name = "rjTextBox4";
            rjTextBox4.Padding = new Padding(10, 7, 10, 7);
            rjTextBox4.PasswordChar = false;
            rjTextBox4.PlaceholderColor = Color.DimGray;
            rjTextBox4.PlaceholderText = "Nhập số điện thoại...";
            rjTextBox4.Size = new Size(266, 32);
            rjTextBox4.TabIndex = 6;
            rjTextBox4.Texts = "";
            rjTextBox4.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            rjTextBox2.BackColor = Color.LightGray;
            rjTextBox2.BorderColor = Color.LightGray;
            rjTextBox2.BorderFocusColor = Color.Silver;
            rjTextBox2.BorderRadius = 7;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Dock = DockStyle.Fill;
            rjTextBox2.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(338, 28);
            rjTextBox2.Margin = new Padding(24, 28, 24, 28);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.DimGray;
            rjTextBox2.PlaceholderText = "Nhập email...";
            rjTextBox2.Size = new Size(266, 32);
            rjTextBox2.TabIndex = 5;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(632, 305);
            panel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel3.Controls.Add(panel1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.5555553F));
            tableLayoutPanel3.Size = new Size(632, 305);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // dangkiDNmoi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 305);
            Controls.Add(panel2);
            Name = "dangkiDNmoi";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private CustomControls.RJControls.RJButton rjButton1;
        private CustomControls.RJControls.RJButton rjButton2;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomControls.RJControls.RJTextBox rjTextBox4;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomControls.RJControls.RJTextBox rjTextBox3;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomControls.RJControls.RJTextBox rjTextBox6;
        private CustomControls.RJControls.RJTextBox rjTextBox5;
    }
}