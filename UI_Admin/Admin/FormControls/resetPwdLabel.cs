using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.Models;
using MongoDB.Driver;
using System.Security.Cryptography;


namespace Admin.FormControls
{
    public partial class resetPwdLabel : Form
    {
        private ForgotPwd parentform;
        private String emailVerify;
        

        public resetPwdLabel(ForgotPwd parentform)
        {
            InitializeComponent();
            this.parentform = parentform;
        }
        public void SetEmailVerify(String emailVerify)
        {
            this.emailVerify = emailVerify;
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            var Admin = MongoHelper.GetAdminCollection();
            if(rjTextBox1.Texts != rjTextBox2.Texts)
            {
                MessageBox.Show("Mật khẩu không trùng khớp");
                return;
            }
            var filter = Builders<AdminModel>.Filter.Eq("Email", emailVerify);
            var update = Builders<AdminModel>.Update.Set("Password", SimpleAesEncryption.Encrypt(rjTextBox1.Texts));
            Admin.UpdateOne(filter, update);

            MessageBox.Show("Đặt lại mật khẩu thành công");
            parentform.Close();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            parentform.openChildFormInContent(new checkEmailLabel(parentform));
        }
    }
}
