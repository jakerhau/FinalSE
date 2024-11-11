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
                label7.Text = find.IdBusiness.ToString();
                label8.Text = find.Name;
                label9.Text = find.EmailAddress;
                label10.Text = find.PhoneNumber.ToString();
                label11.Text = find.Address;
                label13.Text = find.RepresentativeName;
            }
        }
        private void ResizeFont(Control control)
        {
            try
            {
                float fontSize = Math.Min(panel1.Width, panel1.Height) * 0.04f;

                if (control is System.Windows.Forms.Label || control is System.Windows.Forms.Button || control is System.Windows.Forms.TextBox || control is System.Windows.Forms.ComboBox) // Kiểm tra control có chứa text
                {
                    control.Font = new Font(control.Font.FontFamily, fontSize);
                }
                // Đệ quy qua tất cả các control con
                foreach (Control childControl in control.Controls)
                {
                    ResizeFont(childControl);
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }
        private void ResizeFont1(Control control)
        {
            try
            {
                float fontSize = Math.Min(panel1.Width, panel1.Height) * 0.02f;

                if (control is System.Windows.Forms.Label || control is System.Windows.Forms.Button || control is System.Windows.Forms.TextBox || control is System.Windows.Forms.ComboBox) // Kiểm tra control có chứa text
                {
                    control.Font = new Font(control.Font.FontFamily, fontSize);
                }
                // Đệ quy qua tất cả các control con
                foreach (Control childControl in control.Controls)
                {
                    ResizeFont1(childControl);
                }
            } catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void ThongTinDoanhNghiep_Resize(object sender, EventArgs e)
        {
            ResizeFont(this);
            ResizeFont1(tableLayoutPanel1);
        }
    }
}
