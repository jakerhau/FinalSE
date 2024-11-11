using MongoDB.Bson;
using MongoDB.Driver;
using PROJECT.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
                if (c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var contract = MongoHelper.GetContractCollection();

            string[] formats = { "dd/MM/yyyy" };

            DateTime dayStart, dayEnd;

            if (!DateTime.TryParseExact(richTextBox2.Text, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out dayStart))
            {
                MessageBox.Show("Ngày bắt đầu không hợp lệ. Vui lòng nhập đúng định dạng dd/MM/yyyy.");
                return;
            }

            if (!DateTime.TryParseExact(richTextBox4.Text, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out dayEnd))
            {
                MessageBox.Show("Ngày kết thúc không hợp lệ. Vui lòng nhập đúng định dạng dd/MM/yyyy.");
                return;
            }

            contract.InsertOne(new ContractModel
            {
                IdCustomer = new ObjectId(idCustomer),
                IdUser = u.Id,
                DayStart = dayStart,
                DayEnd = dayEnd,
                Status = int.Parse(richTextBox3.Text),
            });


            MessageBox.Show("Đăng kí hợp đồng thành công");
        }
        private void ResizeFont(Control control)
        {
            try
            {
                float fontSize = Math.Min(panel1.Width, panel1.Height) * 0.2f;

                if (control is System.Windows.Forms.TextBox || control is System.Windows.Forms.Label) // Kiểm tra control có chứa text
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

        private void HoSoKhachHangDangKiHopDong_Resize(object sender, EventArgs e)
        {
            ResizeFont(this);
        }

        private void richTextBox3_Leave(object sender, EventArgs e)
        {
            //phải là số
            if (!int.TryParse(richTextBox3.Text, out int result))
            {
                MessageBox.Show("Mã hợp đồng phải là số");
                richTextBox3.Text = "";
            }
        }

        private void richTextBox2_Leave(object sender, EventArgs e)
        {
            string[] formats = { "dd/MM/yyyy" };
            if (richTextBox2.Text == "")
            {
                return;
            }
            if (!DateTime.TryParseExact(richTextBox2.Text, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
            {
                MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập theo định dạng dd/mm/yyyy.");
                richTextBox2.Text = "";
            }

            
        }

        private void richTextBox4_Leave(object sender, EventArgs e)
        {
            string[] formats = { "dd/MM/yyyy" };
            if (richTextBox4.Text == "")
            {
                return;
            }
            if (!DateTime.TryParseExact(richTextBox4.Text, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
            {
                MessageBox.Show("Ngày không hợp lệ. Vui lòng nhập theo định dạng dd/mm/yyyy.");
                richTextBox4.Text = "";
            }
        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
