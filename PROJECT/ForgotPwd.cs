using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class ForgotPwd : Form
    {
        private Main1 mainForm;
        public ForgotPwd(Main1 mainform)
        {
            InitializeComponent();
            this.mainForm = mainform;
        }
        private Form currentChildForm;

        public void openChildFormInContent(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            ResetPanel.Controls.Add(childForm);
            ResetPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResizeFont(Control control)
        {
            try
            {
                float fontSize = Math.Min(panel1.Width, panel1.Height) * 0.02f;

                if (control is System.Windows.Forms.Label || control is System.Windows.Forms.Button || control is System.Windows.Forms.TextBox || control is System.Windows.Forms.ComboBox) // Kiểm tra control có chứa text
                {
                    control.Font = new Font(control.Font.FontFamily, fontSize);
                }
                // Đệ quy qua tất cả các control con
                foreach (Control childControl in control.Controls)
                {
                    ResizeFont(childControl);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }



        private void ForgotPwd_Load(object sender, EventArgs e)
        {
            openChildFormInContent(new resetEmailLabel(this));

        }

        private void ForgotPwd_Resize(object sender, EventArgs e)
        {
            ResizeFont(label1);
            ResizeFont(label2);
        }
    }
}
