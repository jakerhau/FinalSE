using Admin.Models;
using CustomControls.RJControls;
using MongoDB.Bson;
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
    public partial class AddUser : Form
    {
        public ObjectId idAdmin;
        public AddUser(ObjectId idAdmin)
        {
            InitializeComponent();
            this.idAdmin = idAdmin;
        }

        private void Confirmbtn_Click(object sender, EventArgs e)
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is RJTextBox)
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        MessageBox.Show("Điền đầy đủ thông tin");
                        return;
                    }
                }
            }
            User addUser = new User
            {
                Username = rjTextBox1.Texts,
                Password = rjTextBox2.Texts,
                Email = rjTextBox5.Texts,
                Department = rjTextBox6.Texts,
                Permit = "",
                IdAdmin = idAdmin,
                DayOfBirth = DateTime.ParseExact(rjTextBox4.Texts, "dd/MM/yyyy", null)
                
            };
            MongoHelper.GetUserCollection().InsertOne(addUser);
            DialogResult result = MessageBox.Show(
                "Thêm người dùng thành công",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}
