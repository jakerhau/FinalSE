using MongoDB.Bson;
using MongoDB.Driver;
using PROJECT.Model;
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

namespace PROJECT.FormControl
{
    public partial class ThongTinDoanhNghiep : Form
    {
        private string idCustomer;
        public ThongTinDoanhNghiep()
        {
            InitializeComponent();
        }
        public void setIdCustomer(string idCustomer)
        {
            this.idCustomer = idCustomer;
        }

        private void ThongTinDoanhNghiep_Load(object sender, EventArgs e)
        {

            var customer = MongoHelper.GetCustomerCollection();
            var find = customer.Find(c => c.Id == ObjectId.Parse(idCustomer)).FirstOrDefault();

            if (find != null)
            {
                label7.Text = find.Id.ToString();
                label8.Text = find.Name;
                label9.Text = find.EmailAddress;
                label10.Text = find.PhoneNumber.ToString();
                label11.Text = find.Address;
                label13.Text = find.RepresentativeName;
            }
        }
    }
}
