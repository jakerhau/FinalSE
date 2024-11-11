using Admin.FormControls;

namespace Admin
{
    partial class LoginForm
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
            PictureBox pictureBox4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            linkLabel1 = new LinkLabel();
            rjTextBox2 = new CustomControls.RJControls.RJTextBox();
            label3 = new Label();
            passwordPanel = new TableLayoutPanel();
            customPanel2 = new CustomPanel();
            signinBtn = new CustomControls.RJControls.RJButton();
            rjTextBox1 = new CustomControls.RJControls.RJTextBox();
            customPanel1 = new CustomPanel();
            usernamePanel = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            welcomPanel = new TableLayoutPanel();
            greenPanel = new Panel();
            LoginPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            pictureBox3 = new PictureBox();
            tableLayoutPanel6 = new TableLayoutPanel();
            pictureBox5 = new PictureBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            pictureBox6 = new PictureBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            passwordPanel.SuspendLayout();
            customPanel2.SuspendLayout();
            customPanel1.SuspendLayout();
            usernamePanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            welcomPanel.SuspendLayout();
            greenPanel.SuspendLayout();
            LoginPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Fill;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(339, 223);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Gray;
            linkLabel1.AutoSize = true;
            linkLabel1.Dock = DockStyle.Right;
            linkLabel1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.ForeColor = SystemColors.ButtonFace;
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.Gainsboro;
            linkLabel1.Location = new Point(276, 99);
            linkLabel1.Margin = new Padding(3, 0, 40, 0);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 41);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Quên mật khẩu?";
            linkLabel1.TextAlign = ContentAlignment.MiddleRight;
            linkLabel1.VisitedLinkColor = Color.White;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // rjTextBox2
            // 
            rjTextBox2.AutoSize = true;
            rjTextBox2.BackColor = Color.LightGray;
            rjTextBox2.BorderColor = Color.Transparent;
            rjTextBox2.BorderFocusColor = Color.Transparent;
            rjTextBox2.BorderRadius = 0;
            rjTextBox2.BorderSize = 2;
            rjTextBox2.Dock = DockStyle.Fill;
            rjTextBox2.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox2.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox2.Location = new Point(48, 0);
            rjTextBox2.Margin = new Padding(0);
            rjTextBox2.Multiline = false;
            rjTextBox2.Name = "rjTextBox2";
            rjTextBox2.Padding = new Padding(10, 7, 10, 7);
            rjTextBox2.PasswordChar = false;
            rjTextBox2.PlaceholderColor = Color.Transparent;
            rjTextBox2.PlaceholderText = "";
            rjTextBox2.Size = new Size(200, 31);
            rjTextBox2.TabIndex = 2;
            rjTextBox2.Texts = "";
            rjTextBox2.UnderlinedStyle = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Image = Properties.Resources.password;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 30);
            label3.TabIndex = 0;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = Color.White;
            passwordPanel.ColumnCount = 2;
            passwordPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.35484F));
            passwordPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.6451645F));
            passwordPanel.Controls.Add(rjTextBox2, 1, 0);
            passwordPanel.Controls.Add(label3, 0, 0);
            passwordPanel.Location = new Point(2, 2);
            passwordPanel.Margin = new Padding(0);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.RowCount = 1;
            passwordPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            passwordPanel.Size = new Size(248, 30);
            passwordPanel.TabIndex = 1;
            // 
            // customPanel2
            // 
            customPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            customPanel2.BackColor = Color.White;
            customPanel2.BorderRadius = 30;
            customPanel2.Controls.Add(passwordPanel);
            customPanel2.ForeColor = Color.Black;
            customPanel2.GradientAngle = 90F;
            customPanel2.GradientBottomColor = Color.White;
            customPanel2.GradientTopColor = Color.White;
            customPanel2.Location = new Point(145, 66);
            customPanel2.Margin = new Padding(0, 0, 40, 0);
            customPanel2.Name = "customPanel2";
            customPanel2.Size = new Size(252, 33);
            customPanel2.TabIndex = 2;
            // 
            // signinBtn
            // 
            signinBtn.BackColor = Color.Silver;
            signinBtn.BackgroundColor = Color.Silver;
            signinBtn.BorderColor = Color.Silver;
            signinBtn.BorderRadius = 15;
            signinBtn.BorderSize = 0;
            signinBtn.Dock = DockStyle.Right;
            signinBtn.FlatAppearance.BorderSize = 0;
            signinBtn.FlatStyle = FlatStyle.Flat;
            signinBtn.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            signinBtn.ForeColor = Color.White;
            signinBtn.Location = new Point(207, 143);
            signinBtn.Margin = new Padding(3, 3, 80, 3);
            signinBtn.Name = "signinBtn";
            signinBtn.Size = new Size(150, 37);
            signinBtn.TabIndex = 4;
            signinBtn.Text = "Đăng nhập";
            signinBtn.TextColor = Color.White;
            signinBtn.UseVisualStyleBackColor = false;
            signinBtn.Click += signinBtn_Click;
            // 
            // rjTextBox1
            // 
            rjTextBox1.AutoSize = true;
            rjTextBox1.BackColor = Color.LightGray;
            rjTextBox1.BorderColor = Color.Transparent;
            rjTextBox1.BorderFocusColor = Color.Transparent;
            rjTextBox1.BorderRadius = 0;
            rjTextBox1.BorderSize = 2;
            rjTextBox1.Dock = DockStyle.Fill;
            rjTextBox1.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rjTextBox1.ForeColor = Color.FromArgb(64, 64, 64);
            rjTextBox1.Location = new Point(48, 0);
            rjTextBox1.Margin = new Padding(0);
            rjTextBox1.Multiline = false;
            rjTextBox1.Name = "rjTextBox1";
            rjTextBox1.Padding = new Padding(10, 7, 10, 7);
            rjTextBox1.PasswordChar = false;
            rjTextBox1.PlaceholderColor = Color.Transparent;
            rjTextBox1.PlaceholderText = "";
            rjTextBox1.Size = new Size(200, 31);
            rjTextBox1.TabIndex = 3;
            rjTextBox1.Texts = "";
            rjTextBox1.UnderlinedStyle = true;
            // 
            // customPanel1
            // 
            customPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            customPanel1.BackColor = Color.White;
            customPanel1.BorderRadius = 30;
            customPanel1.Controls.Add(usernamePanel);
            customPanel1.ForeColor = Color.Black;
            customPanel1.GradientAngle = 90F;
            customPanel1.GradientBottomColor = Color.White;
            customPanel1.GradientTopColor = Color.White;
            customPanel1.Location = new Point(145, 0);
            customPanel1.Margin = new Padding(0, 0, 40, 0);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(252, 33);
            customPanel1.TabIndex = 0;
            // 
            // usernamePanel
            // 
            usernamePanel.BackColor = Color.White;
            usernamePanel.ColumnCount = 2;
            usernamePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.35484F));
            usernamePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.6451645F));
            usernamePanel.Controls.Add(rjTextBox1, 1, 0);
            usernamePanel.Controls.Add(label2, 0, 0);
            usernamePanel.Location = new Point(2, 2);
            usernamePanel.Margin = new Padding(0);
            usernamePanel.Name = "usernamePanel";
            usernamePanel.RowCount = 1;
            usernamePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            usernamePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            usernamePanel.Size = new Size(248, 30);
            usernamePanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Image = Properties.Resources.user;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(42, 30);
            label2.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift Light", 60F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(3, 78);
            label1.Name = "label1";
            label1.Size = new Size(437, 96);
            label1.TabIndex = 0;
            label1.Text = "Welcome !";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(customPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(customPanel2, 0, 2);
            tableLayoutPanel2.Controls.Add(linkLabel1, 0, 3);
            tableLayoutPanel2.Controls.Add(signinBtn, 0, 4);
            tableLayoutPanel2.Location = new Point(3, 204);
            tableLayoutPanel2.Margin = new Padding(3, 30, 3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 18.181818F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.727272F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.727272F));
            tableLayoutPanel2.Size = new Size(437, 183);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // welcomPanel
            // 
            welcomPanel.ColumnCount = 1;
            welcomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            welcomPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            welcomPanel.Controls.Add(label1, 0, 0);
            welcomPanel.Controls.Add(tableLayoutPanel2, 0, 1);
            welcomPanel.Dock = DockStyle.Fill;
            welcomPanel.Location = new Point(0, 0);
            welcomPanel.Name = "welcomPanel";
            welcomPanel.RowCount = 2;
            welcomPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 39.30041F));
            welcomPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60.69959F));
            welcomPanel.Size = new Size(443, 444);
            welcomPanel.TabIndex = 0;
            // 
            // greenPanel
            // 
            greenPanel.Controls.Add(welcomPanel);
            greenPanel.Dock = DockStyle.Fill;
            greenPanel.Location = new Point(354, 3);
            greenPanel.Name = "greenPanel";
            greenPanel.Size = new Size(443, 444);
            greenPanel.TabIndex = 0;
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(tableLayoutPanel1);
            LoginPanel.Dock = DockStyle.Fill;
            LoginPanel.Location = new Point(0, 0);
            LoginPanel.Margin = new Padding(2, 1, 2, 1);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(800, 450);
            LoginPanel.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.875F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.125F));
            tableLayoutPanel1.Controls.Add(greenPanel, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(345, 444);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 2);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel7, 0, 3);
            tableLayoutPanel3.Controls.Add(panel2, 0, 4);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 23.1981983F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 6.98198175F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 7.882883F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 10.36036F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 51.3513527F));
            tableLayoutPanel3.Size = new Size(345, 444);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.05128F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.9487152F));
            tableLayoutPanel4.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel4.Controls.Add(pictureBox2, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(339, 97);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.Remove_bg_ai_1730821409811;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.Remove_bg_ai_1730821502671;
            pictureBox2.Location = new Point(168, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(168, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.4102554F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.5897427F));
            tableLayoutPanel5.Controls.Add(pictureBox3, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 106);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(339, 25);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = Properties.Resources.Remove_bg_ai_1730821555685;
            pictureBox3.Location = new Point(278, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 3;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.81711F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.5191746F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.3205128F));
            tableLayoutPanel6.Controls.Add(pictureBox5, 1, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 137);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel6.Size = new Size(339, 29);
            tableLayoutPanel6.TabIndex = 3;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = Properties.Resources.Remove_bg_ai_1730821476148;
            pictureBox5.Location = new Point(199, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(pictureBox6, 0, 0);
            tableLayoutPanel8.Dock = DockStyle.Left;
            tableLayoutPanel8.Location = new Point(3, 3);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Size = new Size(123, 23);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Fill;
            pictureBox6.Image = Properties.Resources.Remove_bg_ai_1730821502671;
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(55, 17);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 1;
            pictureBox6.TabStop = false;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 3;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6282043F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.6282043F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.42308F));
            tableLayoutPanel7.Controls.Add(pictureBox7, 2, 0);
            tableLayoutPanel7.Controls.Add(pictureBox8, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 172);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Size = new Size(339, 40);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // pictureBox7
            // 
            pictureBox7.Dock = DockStyle.Right;
            pictureBox7.Image = Properties.Resources.Remove_bg_ai_1730821502671;
            pictureBox7.Location = new Point(269, 3);
            pictureBox7.Margin = new Padding(3, 3, 3, 10);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(67, 27);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 1;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Dock = DockStyle.Fill;
            pictureBox8.Image = Properties.Resources.Remove_bg_ai_1730821569773;
            pictureBox8.Location = new Point(62, 3);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(53, 34);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 2;
            pictureBox8.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 218);
            panel2.Name = "panel2";
            panel2.Size = new Size(339, 223);
            panel2.TabIndex = 5;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Login";
            Resize += LoginForm_Resize;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            customPanel2.ResumeLayout(false);
            customPanel1.ResumeLayout(false);
            usernamePanel.ResumeLayout(false);
            usernamePanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            welcomPanel.ResumeLayout(false);
            welcomPanel.PerformLayout();
            greenPanel.ResumeLayout(false);
            LoginPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private LinkLabel linkLabel1;
        private CustomControls.RJControls.RJTextBox rjTextBox2;
        private Label label3;
        private TableLayoutPanel passwordPanel;
        private CustomPanel customPanel2;
        private CustomControls.RJControls.RJButton signinBtn;
        private CustomControls.RJControls.RJTextBox rjTextBox1;
        private CustomPanel customPanel1;
        private TableLayoutPanel usernamePanel;
        private Label label2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel welcomPanel;
        private Panel greenPanel;
        private Panel LoginPanel;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel5;
        private PictureBox pictureBox3;
        private TableLayoutPanel tableLayoutPanel6;
        private PictureBox pictureBox5;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel2;
        private PictureBox pictureBox7;
        private TableLayoutPanel tableLayoutPanel8;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
    }
}