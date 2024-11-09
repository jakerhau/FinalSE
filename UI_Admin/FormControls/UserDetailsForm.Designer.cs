using Admin.FormControls;

namespace Admin
{
    partial class UserDetailsForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            MainPanel = new Panel();
            customPanel1 = new CustomPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            permitUser = new Label();
            nameUser = new Label();
            idUser = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            rjButton4 = new CustomControls.RJControls.RJButton();
            rjButton3 = new CustomControls.RJControls.RJButton();
            rjButton2 = new CustomControls.RJControls.RJButton();
            rjButton1 = new CustomControls.RJControls.RJButton();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            customPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(MainPanel, 0, 2);
            tableLayoutPanel1.Controls.Add(customPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Microsoft New Tai Lue", 11.25F, FontStyle.Bold);
            tableLayoutPanel1.Location = new Point(20, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.512196F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7073174F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 78.78049F));
            tableLayoutPanel1.Size = new Size(760, 410);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(3, 90);
            MainPanel.Name = "MainPanel";
            MainPanel.Padding = new Padding(20);
            MainPanel.Size = new Size(754, 317);
            MainPanel.TabIndex = 3;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customPanel1.BackColor = Color.FromArgb(224, 224, 224);
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(tableLayoutPanel2);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.FromArgb(224, 224, 224);
            customPanel1.GradientTopColor = Color.FromArgb(224, 224, 224);
            customPanel1.Location = new Point(3, 3);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(754, 33);
            customPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.FromArgb(224, 224, 224);
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(permitUser, 2, 0);
            tableLayoutPanel2.Controls.Add(nameUser, 1, 0);
            tableLayoutPanel2.Controls.Add(idUser, 0, 0);
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(754, 33);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // permitUser
            // 
            permitUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            permitUser.AutoSize = true;
            permitUser.BackColor = Color.FromArgb(224, 224, 224);
            permitUser.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            permitUser.Location = new Point(505, 0);
            permitUser.Name = "permitUser";
            permitUser.Size = new Size(246, 33);
            permitUser.TabIndex = 3;
            permitUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameUser
            // 
            nameUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameUser.AutoSize = true;
            nameUser.BackColor = Color.FromArgb(224, 224, 224);
            nameUser.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameUser.Location = new Point(254, 0);
            nameUser.Name = "nameUser";
            nameUser.Size = new Size(245, 33);
            nameUser.TabIndex = 2;
            nameUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // idUser
            // 
            idUser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            idUser.AutoSize = true;
            idUser.BackColor = Color.FromArgb(224, 224, 224);
            idUser.Font = new Font("Bahnschrift SemiCondensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idUser.Location = new Point(3, 0);
            idUser.Name = "idUser";
            idUser.Size = new Size(245, 33);
            idUser.TabIndex = 1;
            idUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 4;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(rjButton4, 3, 0);
            tableLayoutPanel3.Controls.Add(rjButton3, 2, 0);
            tableLayoutPanel3.Controls.Add(rjButton2, 1, 0);
            tableLayoutPanel3.Controls.Add(rjButton1, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 42);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(4, 2, 4, 4);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(754, 42);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // rjButton4
            // 
            rjButton4.BackColor = Color.FromArgb(217, 217, 217);
            rjButton4.BackgroundColor = Color.FromArgb(217, 217, 217);
            rjButton4.BorderColor = Color.PaleVioletRed;
            rjButton4.BorderRadius = 0;
            rjButton4.BorderSize = 0;
            rjButton4.Dock = DockStyle.Fill;
            rjButton4.FlatAppearance.BorderSize = 0;
            rjButton4.FlatStyle = FlatStyle.Flat;
            rjButton4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            rjButton4.ForeColor = Color.Black;
            rjButton4.Location = new Point(567, 5);
            rjButton4.Margin = new Padding(5, 3, 5, 3);
            rjButton4.Name = "rjButton4";
            rjButton4.Size = new Size(178, 30);
            rjButton4.TabIndex = 3;
            rjButton4.Text = "Xóa";
            rjButton4.TextColor = Color.Black;
            rjButton4.UseVisualStyleBackColor = false;
            rjButton4.Click += rjButton4_Click;
            // 
            // rjButton3
            // 
            rjButton3.BackColor = Color.FromArgb(207, 255, 105);
            rjButton3.BackgroundColor = Color.FromArgb(207, 255, 105);
            rjButton3.BorderColor = Color.PaleVioletRed;
            rjButton3.BorderRadius = 0;
            rjButton3.BorderSize = 0;
            rjButton3.Dock = DockStyle.Fill;
            rjButton3.FlatAppearance.BorderSize = 0;
            rjButton3.FlatStyle = FlatStyle.Flat;
            rjButton3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            rjButton3.ForeColor = Color.Black;
            rjButton3.Location = new Point(381, 5);
            rjButton3.Margin = new Padding(5, 3, 5, 3);
            rjButton3.Name = "rjButton3";
            rjButton3.Size = new Size(176, 30);
            rjButton3.TabIndex = 2;
            rjButton3.Text = "Đổi mật khẩu";
            rjButton3.TextColor = Color.Black;
            rjButton3.UseVisualStyleBackColor = false;
            rjButton3.Click += rjButton3_Click;
            // 
            // rjButton2
            // 
            rjButton2.BackColor = Color.FromArgb(217, 217, 217);
            rjButton2.BackgroundColor = Color.FromArgb(217, 217, 217);
            rjButton2.BorderColor = Color.PaleVioletRed;
            rjButton2.BorderRadius = 0;
            rjButton2.BorderSize = 0;
            rjButton2.Dock = DockStyle.Fill;
            rjButton2.FlatAppearance.BorderSize = 0;
            rjButton2.FlatStyle = FlatStyle.Flat;
            rjButton2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            rjButton2.ForeColor = Color.Black;
            rjButton2.Location = new Point(195, 5);
            rjButton2.Margin = new Padding(5, 3, 5, 3);
            rjButton2.Name = "rjButton2";
            rjButton2.Size = new Size(176, 30);
            rjButton2.TabIndex = 1;
            rjButton2.Text = "Lịch sử";
            rjButton2.TextColor = Color.Black;
            rjButton2.UseVisualStyleBackColor = false;
            rjButton2.Click += rjButton2_Click;
            // 
            // rjButton1
            // 
            rjButton1.BackColor = Color.FromArgb(207, 255, 105);
            rjButton1.BackgroundColor = Color.FromArgb(207, 255, 105);
            rjButton1.BorderColor = Color.PaleVioletRed;
            rjButton1.BorderRadius = 0;
            rjButton1.BorderSize = 0;
            rjButton1.Dock = DockStyle.Fill;
            rjButton1.FlatAppearance.BorderSize = 0;
            rjButton1.FlatStyle = FlatStyle.Flat;
            rjButton1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            rjButton1.ForeColor = Color.Black;
            rjButton1.Location = new Point(9, 5);
            rjButton1.Margin = new Padding(5, 3, 5, 3);
            rjButton1.Name = "rjButton1";
            rjButton1.Size = new Size(176, 30);
            rjButton1.TabIndex = 0;
            rjButton1.Text = "Thông tin";
            rjButton1.TextColor = Color.Black;
            rjButton1.UseVisualStyleBackColor = false;
            rjButton1.Click += rjButton1_Click;
            // 
            // UserDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserDetailsForm";
            Text = "Form1";
            Load += UserDetailsForm_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private CustomPanel customPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label permitUser;
        private Label nameUser;
        private Label idUser;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomControls.RJControls.RJButton rjButton4;
        private CustomControls.RJControls.RJButton rjButton3;
        private CustomControls.RJControls.RJButton rjButton2;
        private CustomControls.RJControls.RJButton rjButton1;
        private Panel MainPanel;
    }
}