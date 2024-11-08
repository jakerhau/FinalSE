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
using PROJECT.Model;

using MongoDB.Driver;

namespace PROJECT
{
    public partial class resetEmailLabel : Form
    {
        private ForgotPwd parentform;
        public resetEmailLabel(ForgotPwd parentform)
        {
            InitializeComponent();
            this.parentform = parentform;
        }



        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            var admin = MongoHelper.GetUserCollection();
            var filter = Builders<User>.Filter.Eq("Email", rjTextBox1.Texts);
            var result = admin.Find(filter).FirstOrDefault();
            if (result == null) { MessageBox.Show("Email không tồn tại"); return; }
            Random random = new Random();        
            int code = random.Next(1000, 9999);
           
            new SendEmail().SendEmailToUser(rjTextBox1.Texts, "Your code is: " + code);
            
            checkEmailLabel form = new checkEmailLabel(parentform);
            form.setEmailVerify(rjTextBox1.Texts);
            form.setCode(code.ToString());
            parentform.openChildFormInContent(form);

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            parentform.Close();
        }
    }
}
