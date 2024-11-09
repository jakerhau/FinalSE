namespace Admin
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            startPanel = new Panel();
            MainPanel = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            adminLblPanel = new TableLayoutPanel();
            adminlbl = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            navPanel = new TableLayoutPanel();
            logoutbtn = new CustomControls.RJControls.RJButton();
            searchPanel = new TableLayoutPanel();
            searchBox = new CustomControls.RJControls.RJTextBox();
            rjButton1 = new CustomControls.RJControls.RJButton();
            ContentPanel = new Panel();
            btnPanel = new TableLayoutPanel();
            createnewbtn = new CustomControls.RJControls.RJButton();
            userbtn = new CustomControls.RJControls.RJButton();
            startPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            adminLblPanel.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            navPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            btnPanel.SuspendLayout();
            SuspendLayout();
            // 
            // startPanel
            // 
            startPanel.Controls.Add(MainPanel);
            startPanel.Dock = DockStyle.Fill;
            startPanel.Location = new Point(0, 0);
            startPanel.Name = "startPanel";
            startPanel.Size = new Size(889, 492);
            startPanel.TabIndex = 1;
            // 
            // MainPanel
            // 
            MainPanel.AutoSize = true;
            MainPanel.BackColor = Color.FromArgb(246, 246, 246);
            MainPanel.ColumnCount = 3;
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.02084F));
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.10191F));
            MainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 86.87725F));
            MainPanel.Controls.Add(tableLayoutPanel10, 1, 1);
            MainPanel.Controls.Add(tableLayoutPanel5, 1, 0);
            MainPanel.Controls.Add(adminLblPanel, 0, 0);
            MainPanel.Controls.Add(tableLayoutPanel3, 2, 1);
            MainPanel.Controls.Add(tableLayoutPanel7, 1, 2);
            MainPanel.Controls.Add(tableLayoutPanel4, 0, 1);
            MainPanel.Controls.Add(navPanel, 2, 0);
            MainPanel.Controls.Add(ContentPanel, 2, 2);
            MainPanel.Controls.Add(btnPanel, 0, 2);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.RowCount = 3;
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 11.9157314F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 1.79456174F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 86.28971F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            MainPanel.Size = new Size(889, 492);
            MainPanel.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.BackColor = Color.White;
            tableLayoutPanel10.ColumnCount = 1;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(106, 58);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel10.Size = new Size(9, 8);
            tableLayoutPanel10.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(106, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(9, 58);
            tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.BackColor = Color.White;
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 0);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(9, 58);
            tableLayoutPanel6.TabIndex = 2;
            // 
            // adminLblPanel
            // 
            adminLblPanel.ColumnCount = 1;
            adminLblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            adminLblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            adminLblPanel.Controls.Add(adminlbl, 0, 0);
            adminLblPanel.Dock = DockStyle.Fill;
            adminLblPanel.Location = new Point(3, 3);
            adminLblPanel.Name = "adminLblPanel";
            adminLblPanel.RowCount = 1;
            adminLblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            adminLblPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            adminLblPanel.Size = new Size(100, 52);
            adminLblPanel.TabIndex = 0;
            // 
            // adminlbl
            // 
            adminlbl.AutoSize = true;
            adminlbl.Dock = DockStyle.Fill;
            adminlbl.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            adminlbl.Location = new Point(2, 0);
            adminlbl.Margin = new Padding(2, 0, 2, 0);
            adminlbl.Name = "adminlbl";
            adminlbl.Size = new Size(96, 52);
            adminlbl.TabIndex = 4;
            adminlbl.Text = "ADMINATOR";
            adminlbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(115, 58);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(774, 8);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.BackColor = Color.White;
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(774, 8);
            tableLayoutPanel8.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.BackColor = Color.White;
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(106, 66);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(9, 426);
            tableLayoutPanel7.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.White;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 58);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(106, 8);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // navPanel
            // 
            navPanel.ColumnCount = 2;
            navPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.99479F));
            navPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.005209F));
            navPanel.Controls.Add(logoutbtn, 1, 0);
            navPanel.Controls.Add(searchPanel, 0, 0);
            navPanel.Dock = DockStyle.Fill;
            navPanel.Location = new Point(118, 3);
            navPanel.Name = "navPanel";
            navPanel.RowCount = 1;
            navPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            navPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            navPanel.Size = new Size(768, 52);
            navPanel.TabIndex = 5;
            // 
            // logoutbtn
            // 
            logoutbtn.Anchor = AnchorStyles.Right;
            logoutbtn.BackColor = Color.FromArgb(246, 246, 246);
            logoutbtn.BackgroundColor = Color.FromArgb(246, 246, 246);
            logoutbtn.BorderColor = Color.PaleVioletRed;
            logoutbtn.BorderRadius = 1;
            logoutbtn.BorderSize = 0;
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logoutbtn.ForeColor = Color.Black;
            logoutbtn.Location = new Point(602, 3);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(163, 46);
            logoutbtn.TabIndex = 6;
            logoutbtn.Text = "Đăng xuất";
            logoutbtn.TextColor = Color.Black;
            logoutbtn.UseVisualStyleBackColor = false;
            logoutbtn.Click += logoutbtn_Click_1;
            // 
            // searchPanel
            // 
            searchPanel.AutoSize = true;
            searchPanel.ColumnCount = 2;
            searchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.019F));
            searchPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8.981002F));
            searchPanel.Controls.Add(searchBox, 0, 0);
            searchPanel.Controls.Add(rjButton1, 1, 0);
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Location = new Point(30, 10);
            searchPanel.Margin = new Padding(30, 10, 30, 10);
            searchPanel.Name = "searchPanel";
            searchPanel.RowCount = 1;
            searchPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            searchPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            searchPanel.Size = new Size(539, 32);
            searchPanel.TabIndex = 6;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            searchBox.BackColor = SystemColors.Window;
            searchBox.BorderColor = Color.Gray;
            searchBox.BorderFocusColor = Color.FromArgb(224, 224, 224);
            searchBox.BorderRadius = 0;
            searchBox.BorderSize = 1;
            searchBox.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchBox.ForeColor = Color.FromArgb(64, 64, 64);
            searchBox.Location = new Point(0, 1);
            searchBox.Margin = new Padding(0);
            searchBox.Multiline = false;
            searchBox.Name = "searchBox";
            searchBox.Padding = new Padding(10, 7, 10, 7);
            searchBox.PasswordChar = false;
            searchBox.PlaceholderColor = Color.DarkGray;
            searchBox.PlaceholderText = "";
            searchBox.Size = new Size(490, 30);
            searchBox.TabIndex = 6;
            searchBox.Texts = "";
            searchBox.UnderlinedStyle = true;
            searchBox.Click += searchBox_Click;
            searchBox.Enter += searchBox_Enter_1;
            // 
            // rjButton1
            // 
            rjButton1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            rjButton1.BackColor = Color.FromArgb(246, 246, 246);
            rjButton1.BackgroundColor = Color.FromArgb(246, 246, 246);
            rjButton1.BorderColor = Color.FromArgb(246, 246, 246);
            rjButton1.BorderRadius = 0;
            rjButton1.BorderSize = 0;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.ForeColor = Color.White;
            rjButton1.Image = Properties.Resources.search_interface_symbol1;
            rjButton1.Location = new Point(490, 3);
            rjButton1.Margin = new Padding(0);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(49, 26);
            rjButton1.TabIndex = 6;
            rjButton1.TextColor = Color.White;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // ContentPanel
            // 
            ContentPanel.Dock = DockStyle.Fill;
            ContentPanel.Location = new Point(118, 69);
            ContentPanel.Name = "ContentPanel";
            ContentPanel.Size = new Size(768, 420);
            ContentPanel.TabIndex = 6;
            // 
            // btnPanel
            // 
            btnPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnPanel.ColumnCount = 1;
            btnPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            btnPanel.Controls.Add(createnewbtn, 0, 1);
            btnPanel.Controls.Add(userbtn, 0, 0);
            btnPanel.Location = new Point(3, 116);
            btnPanel.Margin = new Padding(3, 50, 3, 3);
            btnPanel.Name = "btnPanel";
            btnPanel.RowCount = 2;
            btnPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            btnPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            btnPanel.Size = new Size(100, 150);
            btnPanel.TabIndex = 4;
            // 
            // createnewbtn
            // 
            createnewbtn.BackColor = Color.FromArgb(246, 246, 246);
            createnewbtn.BackgroundColor = Color.FromArgb(246, 246, 246);
            createnewbtn.BorderColor = Color.Silver;
            createnewbtn.BorderRadius = 15;
            createnewbtn.BorderSize = 0;
            createnewbtn.Dock = DockStyle.Fill;
            createnewbtn.FlatAppearance.BorderSize = 0;
            createnewbtn.FlatStyle = FlatStyle.Flat;
            createnewbtn.ForeColor = Color.Black;
            createnewbtn.Location = new Point(0, 75);
            createnewbtn.Margin = new Padding(0);
            createnewbtn.Name = "createnewbtn";
            createnewbtn.Size = new Size(100, 75);
            createnewbtn.TabIndex = 6;
            createnewbtn.Text = "TẠO MỚI\r\n";
            createnewbtn.TextColor = Color.Black;
            createnewbtn.UseVisualStyleBackColor = false;
            createnewbtn.Click += createnewbtn_Click;
            // 
            // userbtn
            // 
            userbtn.BackColor = Color.FromArgb(246, 246, 246);
            userbtn.BackgroundColor = Color.FromArgb(246, 246, 246);
            userbtn.BorderColor = Color.Silver;
            userbtn.BorderRadius = 15;
            userbtn.BorderSize = 0;
            userbtn.Dock = DockStyle.Fill;
            userbtn.FlatAppearance.BorderSize = 0;
            userbtn.FlatStyle = FlatStyle.Flat;
            userbtn.ForeColor = Color.Black;
            userbtn.Location = new Point(0, 0);
            userbtn.Margin = new Padding(0);
            userbtn.Name = "userbtn";
            userbtn.Size = new Size(100, 75);
            userbtn.TabIndex = 5;
            userbtn.Text = "NHÂN VIÊN";
            userbtn.TextColor = Color.Black;
            userbtn.UseVisualStyleBackColor = false;
            userbtn.Click += userbtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 492);
            Controls.Add(startPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "E.Lab";
            Load += Form2_Load;
            startPanel.ResumeLayout(false);
            startPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            adminLblPanel.ResumeLayout(false);
            adminLblPanel.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            navPanel.ResumeLayout(false);
            navPanel.PerformLayout();
            searchPanel.ResumeLayout(false);
            btnPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel startPanel;
        private TableLayoutPanel MainPanel;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel adminLblPanel;
        private Label adminlbl;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel navPanel;
        private CustomControls.RJControls.RJButton logoutbtn;
        private TableLayoutPanel searchPanel;
        private CustomControls.RJControls.RJTextBox searchBox;
        private CustomControls.RJControls.RJButton rjButton1;
        private Panel ContentPanel;
        private TableLayoutPanel btnPanel;
        private CustomControls.RJControls.RJButton createnewbtn;
        private CustomControls.RJControls.RJButton userbtn;
    }
}