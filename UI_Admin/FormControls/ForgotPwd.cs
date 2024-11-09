using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin.FormControls
{
    public partial class ForgotPwd : Form
    {
        private MainForm mainForm;
        public ForgotPwd(MainForm mainform)
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

       

        private void ForgotPwd_Load(object sender, EventArgs e)
        {
            openChildFormInContent(new resetEmailLabel(this));

        }
    }
}
