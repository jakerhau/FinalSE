namespace PROJECT.FormControl
{
    partial class HoSoKhachHangDangKiHopDong
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
            button2 = new Button();
            button1 = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            richTextBox4 = new TextBox();
            richTextBox3 = new TextBox();
            richTextBox2 = new TextBox();
            richTextBox1 = new TextBox();
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
            panel1.Size = new Size(556, 33);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(204, 19);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÍ HỢP ĐỒNG MỚI";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(2, 218);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(556, 50);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(313, 9);
            button2.Margin = new Padding(35, 9, 35, 9);
            button2.Name = "button2";
            button2.Size = new Size(208, 32);
            button2.TabIndex = 1;
            button2.Text = "Xác nhận";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PaleTurquoise;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(35, 9);
            button1.Margin = new Padding(35, 9, 35, 9);
            button1.Name = "button1";
            button1.Size = new Size(208, 32);
            button1.TabIndex = 0;
            button1.Text = "Xóa tất cả";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(richTextBox4, 1, 1);
            tableLayoutPanel1.Controls.Add(richTextBox3, 0, 1);
            tableLayoutPanel1.Controls.Add(richTextBox2, 1, 0);
            tableLayoutPanel1.Controls.Add(richTextBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(2, 39);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(556, 175);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = SystemColors.ScrollBar;
            richTextBox4.Dock = DockStyle.Fill;
            richTextBox4.Location = new Point(306, 111);
            richTextBox4.Margin = new Padding(28, 24, 28, 24);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.PlaceholderText = "Ngày kết thúc...";
            richTextBox4.Size = new Size(222, 23);
            richTextBox4.TabIndex = 7;
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = SystemColors.ScrollBar;
            richTextBox3.Dock = DockStyle.Fill;
            richTextBox3.Location = new Point(28, 111);
            richTextBox3.Margin = new Padding(28, 24, 28, 24);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.PlaceholderText = "Mã HĐ (tạo tự động)";
            richTextBox3.Size = new Size(222, 23);
            richTextBox3.TabIndex = 6;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.ScrollBar;
            richTextBox2.Dock = DockStyle.Fill;
            richTextBox2.Location = new Point(306, 24);
            richTextBox2.Margin = new Padding(28, 24, 28, 24);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.PlaceholderText = "Ngày bắt đầu...";
            richTextBox2.Size = new Size(222, 23);
            richTextBox2.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ScrollBar;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(28, 24);
            richTextBox1.Margin = new Padding(28, 24, 28, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.PlaceholderText = "Số liệu hợp đồng...";
            richTextBox1.Size = new Size(222, 23);
            richTextBox1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(560, 270);
            panel2.TabIndex = 4;
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
            tableLayoutPanel3.Size = new Size(560, 270);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // HoSoKhachHangDangKiHopDong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "HoSoKhachHangDangKiHopDong";
            Text = "HoSoKhachHangDangKiHopDong";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button2;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox richTextBox1;
        private TextBox richTextBox2;
        private TextBox richTextBox4;
        private TextBox richTextBox3;
    }
}