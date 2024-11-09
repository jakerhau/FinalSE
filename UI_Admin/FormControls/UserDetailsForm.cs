using Admin.Models;
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

namespace Admin
{
    public partial class UserDetailsForm : Form
    {
        private string idValue;
        private string nameValue;
        private string permitValue;
        public UserDetailsForm(string idValue, string nameValue, string permitValue)
        {
            InitializeComponent();

            this.idValue = idValue;
            this.nameValue = nameValue;
            this.permitValue = permitValue;

            showUserInfo(this.idValue, this.nameValue, this.permitValue);


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
            MainPanel.Controls.Add(childForm);
            MainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void showUserInfo(string idValue, string nameValue, string permitValue)
        {


            idUser.Text = this.idValue ?? "Null";
            nameUser.Text = this.nameValue ?? "Null";
            permitUser.Text = this.permitValue ?? "Null";
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            openChildFormInContent(new DetailsForm(idValue));
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            openChildFormInContent(new HistoryForm(idValue));
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            openChildFormInContent(new ChangePwdForm(idValue));
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
            "Bạn có chắc chắn muốn xóa?",
            "Xác nhận",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                DeleteUser();
                this.Close();
            }
        }
        private void DeleteUser()
        {
            //MongoHelper.ConnectToMongoService();
            try
            {
                var _userCollection = MongoHelper.GetUserCollection();
                var filter = Builders<User>.Filter.Eq("Id", ObjectId.Parse(idValue));
                _userCollection.DeleteOne(filter);
                DialogResult result = MessageBox.Show(
                    "Xóa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối MongoDB thất bại");
                return;
            }
        }
        private void UserDetailsForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
