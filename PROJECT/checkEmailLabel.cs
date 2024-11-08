using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT
{
    public partial class checkEmailLabel : Form
    {
        private ForgotPwd parentform;
        private String code;
        private String emailVerify;
        public checkEmailLabel(ForgotPwd mainForm)
        {
            InitializeComponent();
            this.parentform = mainForm;
        }

        public void setCode(String code)
        {
            this.code = code;
        }
        public void setEmailVerify(String emailVerify)
        {
            this.emailVerify = emailVerify;
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (code.Equals(rjTextBox1.Texts))
            {
                resetPwdLabel form = new resetPwdLabel(parentform);
                form.SetEmailVerify(emailVerify);
                parentform.openChildFormInContent(form);
            } else { 
                MessageBox.Show("Mã xác nhận không đúng");
            }
        }
        private void rjButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
            parentform.openChildFormInContent(new resetEmailLabel(parentform));
        }
    }
}
