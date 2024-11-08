using MongoDB.Bson;
using MongoDB.Driver;
using PROJECT.Model;
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
    public partial class HoSoKhachHangDangKiHopDong : Form
    {
        private User u;
        private string idCustomer;
        public HoSoKhachHangDangKiHopDong()
        {
            InitializeComponent();
        }
        public void setUser(User u)
        {
            this.u = u;
        }
        public void setIdCustomer(string idCustomer)
        {
            this.idCustomer = idCustomer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tableLayoutPanel1 clear richTextBox.text
            foreach (Control c in tableLayoutPanel1.Controls)
            {
                if (c is RichTextBox)
                {
                    ((RichTextBox)c).Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var contract = MongoHelper.GetContractCollection();
            //save data to contract

            contract.InsertOne(new ContractModel
            {
                IdCustomer = new ObjectId(idCustomer),
                IdUser = u.Id,
                DayStart = DateTime.Parse(richTextBox2.Text),
                DayEnd = DateTime.Parse(richTextBox4.Text),
                Status = int.Parse(richTextBox1.Text),
            });

            
            MessageBox.Show("Đăng kí hợp đồng thành công");
        }
    }
}
