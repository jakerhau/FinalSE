using CustomControls.RJControls;
using MongoDB.Bson;
using MongoDB.Driver;
using PROJECT.Model;
using PROJECT.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJECT.FormControl
{
    public partial class dangkiDNmoi : Form
    {
        private ObjectId idUser;
        public dangkiDNmoi(ObjectId id)
        {
            this.idUser = id;
            InitializeComponent();
        }
        private void rjButton1_Click(object sender, EventArgs e)
        {
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is RJTextBox)
                {
                    ((RJTextBox)c).Texts = "";
                }
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {

            var customer = MongoHelper.GetCustomerCollection();

            int phoneNumber;
            if (!int.TryParse(rjTextBox4.Texts, out phoneNumber))
            {
                MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }
            //check IdBusiness is exist
            int idBusiness;
            bool isParsed = int.TryParse(rjTextBox5.Texts, out idBusiness);
            var check = customer.Find(c => c.IdBusiness == (isParsed ? idBusiness : 0)).FirstOrDefault();
            if (check != null)
            {
                MessageBox.Show("Mã số đã tồn tại");
                return;
            }
            try
            {
                var customerData = new Customer
                {
                    Name = rjTextBox1.Texts,
                    EmailAddress = rjTextBox2.Texts,
                    Address = rjTextBox3.Texts,
                    PhoneNumber = phoneNumber,
                    IdBusiness = idBusiness,
                    RepresentativeName = rjTextBox6.Texts
                };
                customer.InsertOne(customerData);
                MessageBox.Show("Đăng kí doanh nghiệp thành công");
                OperationServices.RecordStatisticalCustomer(idUser);
            } catch (Exception ex) {
                MessageBox.Show("Đăng kí doanh nghiệp thất bại");
            }     
        }
    }
}
