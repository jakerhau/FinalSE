namespace PROJECT
{
    partial class FormPDF
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbCustomerName = new TextBox();
            tbCustomerAddress = new TextBox();
            tbSampleAdress = new TextBox();
            tbSampleType = new TextBox();
            tbDateLayMau = new TextBox();
            tbDateThuNghiem = new TextBox();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            idSample = new TextBox();
            label8 = new Label();
            panel4 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            button1 = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 54);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(692, 22);
            label1.TabIndex = 3;
            label1.Text = "KẾT QUẢ PHÂN TÍCH";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 8;
            label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(2, 22);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 9;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(2, 44);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 10;
            label4.Text = "Vị trí lấy mẫu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(2, 66);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(56, 15);
            label5.TabIndex = 11;
            label5.Text = "Loại mẫu";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(2, 88);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 12;
            label6.Text = "Ngày lấy mẫu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(2, 110);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(100, 15);
            label7.TabIndex = 13;
            label7.Text = "Ngày thử nghiệm";
            // 
            // tbCustomerName
            // 
            tbCustomerName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCustomerName.Location = new Point(186, 2);
            tbCustomerName.Margin = new Padding(2);
            tbCustomerName.Name = "tbCustomerName";
            tbCustomerName.Size = new Size(508, 23);
            tbCustomerName.TabIndex = 20;
            // 
            // tbCustomerAddress
            // 
            tbCustomerAddress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbCustomerAddress.Location = new Point(186, 24);
            tbCustomerAddress.Margin = new Padding(2);
            tbCustomerAddress.Name = "tbCustomerAddress";
            tbCustomerAddress.Size = new Size(508, 23);
            tbCustomerAddress.TabIndex = 21;
            // 
            // tbSampleAdress
            // 
            tbSampleAdress.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSampleAdress.Location = new Point(186, 46);
            tbSampleAdress.Margin = new Padding(2);
            tbSampleAdress.Name = "tbSampleAdress";
            tbSampleAdress.Size = new Size(508, 23);
            tbSampleAdress.TabIndex = 22;
            // 
            // tbSampleType
            // 
            tbSampleType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbSampleType.Location = new Point(186, 68);
            tbSampleType.Margin = new Padding(2);
            tbSampleType.Name = "tbSampleType";
            tbSampleType.Size = new Size(508, 23);
            tbSampleType.TabIndex = 23;
            // 
            // tbDateLayMau
            // 
            tbDateLayMau.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDateLayMau.Location = new Point(186, 90);
            tbDateLayMau.Margin = new Padding(2);
            tbDateLayMau.Name = "tbDateLayMau";
            tbDateLayMau.Size = new Size(508, 23);
            tbDateLayMau.TabIndex = 24;
            // 
            // tbDateThuNghiem
            // 
            tbDateThuNghiem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDateThuNghiem.Location = new Point(186, 112);
            tbDateThuNghiem.Margin = new Padding(2);
            tbDateThuNghiem.Name = "tbDateThuNghiem";
            tbDateThuNghiem.Size = new Size(508, 23);
            tbDateThuNghiem.TabIndex = 25;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(2, 89);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(696, 219);
            dataGridView1.TabIndex = 27;
            // 
            // Column1
            // 
            Column1.HeaderText = "TT";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Chỉ tiêu phân tích";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Đơn vị";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Phương pháp phân tích";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Số liệu mẫu";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Kết quả";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 477);
            panel1.TabIndex = 36;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 2);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.36478F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.7924538F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.679245F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.037736F));
            tableLayoutPanel1.Size = new Size(700, 477);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 312);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(696, 132);
            panel2.TabIndex = 31;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.5593567F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.44064F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 4);
            tableLayoutPanel2.Controls.Add(label7, 0, 5);
            tableLayoutPanel2.Controls.Add(tbCustomerName, 1, 0);
            tableLayoutPanel2.Controls.Add(tbCustomerAddress, 1, 1);
            tableLayoutPanel2.Controls.Add(tbDateThuNghiem, 1, 5);
            tableLayoutPanel2.Controls.Add(tbSampleAdress, 1, 2);
            tableLayoutPanel2.Controls.Add(tbDateLayMau, 1, 4);
            tableLayoutPanel2.Controls.Add(tbSampleType, 1, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Size = new Size(696, 132);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(2, 2);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(696, 83);
            panel3.TabIndex = 32;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel3.Controls.Add(label1, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Margin = new Padding(2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 65.71429F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 34.2857132F));
            tableLayoutPanel3.Size = new Size(696, 83);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(idSample, 0, 0);
            tableLayoutPanel4.Controls.Add(label8, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(2, 2);
            tableLayoutPanel4.Margin = new Padding(2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(692, 50);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // idSample
            // 
            idSample.Location = new Point(2, 2);
            idSample.Margin = new Padding(2);
            idSample.Name = "idSample";
            idSample.Size = new Size(163, 23);
            idSample.TabIndex = 31;
            idSample.KeyDown += textBox1_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(348, 0);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(342, 50);
            label8.TabIndex = 0;
            label8.Text = "      CÔNG TY TNHH GIẢI PHÁP MÔI TRƯỜNG\n      PHÒNG PHÂN TÍCH CHẤT LƯỢNG MÔI TRƯỜNG\n      Đ/C: 144 Chu Văn An, P. 26, Q. Bình Thạnh, Tp. HCM\n      ĐT: 028 6290 2086     Email: info@dainam-enviro.com  ";
            // 
            // panel4
            // 
            panel4.Controls.Add(tableLayoutPanel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(2, 448);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(696, 27);
            panel4.TabIndex = 33;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.7263565F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.830986F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.4426575F));
            tableLayoutPanel5.Controls.Add(button1, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(696, 27);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(264, 2);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(147, 23);
            button1.TabIndex = 0;
            button1.Text = "EXPORT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(258, 0);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 37;
            // 
            // FormPDF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 477);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "FormPDF";
            Text = "FormPDF";
            Load += FormPDF_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            panel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbCustomerName;
        private TextBox tbCustomerAddress;
        private TextBox tbSampleAdress;
        private TextBox tbSampleType;
        private TextBox tbDateLayMau;
        private TextBox tbDateThuNghiem;
        private DataGridView dataGridView1;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private TextBox idSample;
        private Label label8;
        private Panel panel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button button1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
