using MongoDB.Bson;
using MongoDB.Driver;
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

namespace Admin
{
    public partial class ChangePwdForm : Form
    {
        private string idUser;
        public ChangePwdForm(string idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn đổi mật khẩu?", 
            "Xác nhận", 
            MessageBoxButtons.YesNo, 
            MessageBoxIcon.Question 
        );

            if (result == DialogResult.Yes)
            {
                UpdatePassword();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn đã chọn No.");
            }
        }
        private void UpdatePassword()
        {
            var _userCollection = MongoHelper.GetUserCollection();
            var filter = Builders<User>.Filter.Eq("Id", ObjectId.Parse(idUser));
            if (rjTextBox1.Texts != rjTextBox2.Texts)
            {
                MessageBox.Show("Không trùng mật khẩu mới");
                return;
            }
            if (label4.Text == rjTextBox1.Texts)
            {
                MessageBox.Show("Không được trùng mật khẩu cũ");
                return;
            }
            var update = Builders<User>.Update.Set("Password", rjTextBox1.Texts);
            _userCollection.UpdateOne(filter, update);
            MessageBox.Show("Đổi mật khẩu thành công");
        }
        private void ChangePwdForm_Load(object sender, EventArgs e)
        {
            var _userCollection = MongoHelper.GetUserCollection();
            var User = _userCollection.Find(x => x.Id == ObjectId.Parse(idUser)).FirstOrDefault();
            label3.Text = User.Username;
            label4.Text = User.Password;
        }
    }
}
