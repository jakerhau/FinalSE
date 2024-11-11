using Admin.Models;
using CustomControls.RJControls;
using MongoDB.Bson;
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



namespace Admin
{
    public partial class AddUser : Form
    {
        private static readonly byte[] key = Encoding.UTF8.GetBytes("yourEncryptionKey123");
        private static readonly byte[] iv = Encoding.UTF8.GetBytes("yourIV1234567890");
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
                    RJTextBox rjTextBox = (RJTextBox)c;
                    if (string.IsNullOrEmpty(rjTextBox.Texts))
                    {
                        Debug.WriteLine("Empty");
                        MessageBox.Show("Điền đầy đủ thông tin");
                        return;
                    }
                }
            }

            User addUser = new User
            {
                Username = rjTextBox1.Texts,
                Password = SimpleAesEncryption.Encrypt(rjTextBox2.Texts),
                Email = rjTextBox5.Texts,
                Department = rjTextBox6.Texts,
                Permit = "",
                IdAdmin = idAdmin,
                DayOfBirth = DateTime.ParseExact(rjTextBox4.Texts, "dd/MM/yyyy", null)

            };
            MongoHelper.GetUserCollection().InsertOne(addUser);

            //create operation

            Operation operation = new Operation
            {
                IdUser = addUser.Id,
                LoginTime = new List<DateTime>(),
                LogoutTime = new List<DateTime>(),
                StatisticalMerge = new List<DateTime>(),
                StatisticalCustomer = new List<DateTime>(),
                ExportReport = new List<DateTime>(),
                InputTime = new List<DateTime>()
            };
            MongoHelper.GetOperationCollection().InsertOne(operation);
            DialogResult result = MessageBox.Show(
                "Thêm người dùng thành công",
                "Thông báo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void rjTextBox4_Leave(object sender, EventArgs e)
        {
            //nhập đúng định dạng dd/mm/yy
            if (!DateTime.TryParseExact(rjTextBox4.Texts, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime date))
            {
                MessageBox.Show("Nhập đúng định dạng dd/MM/yyyy");
                rjTextBox4.Focus();
            }
        }
    }
}
