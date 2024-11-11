namespace PROJECT.FormControl
{
    partial class HoSoKhachHangItem
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
            tableLayoutPanel1 = new TableLayoutPanel();
            customPanel1 = new CustomPanel();
            button1 = new Button();
            customPanel2 = new CustomPanel();
            button2 = new Button();
            customPanel3 = new CustomPanel();
            button3 = new Button();
            tableLayoutPanel1.SuspendLayout();
            customPanel1.SuspendLayout();
            customPanel2.SuspendLayout();
            customPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(141, 185, 106);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(customPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(customPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(customPanel3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(560, 270);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // customPanel1
            // 
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(button1);
            customPanel1.Dock = DockStyle.Fill;
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.CadetBlue;
            customPanel1.GradientTopColor = Color.DodgerBlue;
            customPanel1.Location = new Point(3, 3);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(554, 84);
            customPanel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(554, 84);
            button1.TabIndex = 1;
            button1.Text = "Xử lý mẫu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // customPanel2
            // 
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(button2);
            customPanel2.Dock = DockStyle.Fill;
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.CadetBlue;
            customPanel2.GradientTopColor = Color.DodgerBlue;
            customPanel2.Location = new Point(3, 93);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(554, 84);
            customPanel2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(554, 84);
            button2.TabIndex = 2;
            button2.Text = "Hợp đồng";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // customPanel3
            // 
            customPanel3.BackColor = Color.White;
            customPanel3.BorderRadius = 30;
            customPanel3.Controls.Add(button3);
            customPanel3.Dock = DockStyle.Fill;
            customPanel3.ForeColor = Color.Black;
            customPanel3.GradientAngle = 90F;
            customPanel3.GradientBottomColor = Color.CadetBlue;
            customPanel3.GradientTopColor = Color.DodgerBlue;
            customPanel3.Location = new Point(3, 183);
            customPanel3.Name = "customPanel3";
            customPanel3.Size = new Size(554, 84);
            customPanel3.TabIndex = 5;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(0, 0);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(554, 84);
            button3.TabIndex = 3;
            button3.Text = "Đăng kí HĐ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // HoSoKhachHangItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(2);
            Name = "HoSoKhachHangItem";
            Text = "HoSoKhachHangItem";
            Resize += HoSoKhachHangItem_Resize;
            tableLayoutPanel1.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            customPanel2.ResumeLayout(false);
            customPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CustomPanel customPanel1;
        private Button button1;
        private CustomPanel customPanel2;
        private Button button2;
        private CustomPanel customPanel3;
        private Button button3;
    }
}