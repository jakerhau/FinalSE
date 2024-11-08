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
using System.Diagnostics.Contracts;
using System.Diagnostics;

namespace PROJECT.FormControl
{
    internal partial class HopDong : Form
    {
        private User user;
        private IMongoCollection<User> userCollection;
        private IMongoCollection<ContractModel> contractCollection;
        private IMongoCollection<Status> statusCollection;
        private IMongoCollection<Customer> customerCollection;
        public HopDong(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void HopDong_Load(object sender, EventArgs e)
        {
            userCollection = MongoHelper.GetUserCollection();
            contractCollection = MongoHelper.GetContractCollection();
            statusCollection = MongoHelper.GetStatusCollection();
            customerCollection = MongoHelper.GetCustomerCollection();


            var contracts = contractCollection.Find(contract => contract.IdUser == user.Id).ToList();

            var statuses = statusCollection.Find(_ => true).ToList();
            var customers = customerCollection.Find(_ => true).ToList();


            var contractData = from contract in contracts
                               join status in statuses on contract.Id equals status.IdContract
                               join customer in customers on contract.IdCustomer equals customer.Id
                               where contract.IdUser == user.Id
                               select new
                               {
                                   MaHD = contract.Id.ToString(),
                                   MaDN = customer.Id.ToString(),
                                   TinhTrangXuLy = status.stt
                               };
            dataGridView1.Rows.Clear();
            foreach (var item in contractData)
            {
                dataGridView1.Rows.Add(item.MaHD, item.MaDN, item.TinhTrangXuLy);
            }
        }
        private String tinhTrangHopDong(DateTime time)
        {
            DateTime now = DateTime.Now;
            if (time < now)
            {
                return "Hết hạn";
            }
            return "Còn hạn";
        }
        private void ResizeFont(Control control)
        {
            float fontSize = Math.Min(panel1.Width, panel1.Height) * 0.02f;

            if (control is System.Windows.Forms.Label || control is System.Windows.Forms.Button || control is System.Windows.Forms.ComboBox) // Kiểm tra control có chứa text
            {
                control.Font = new Font(control.Font.FontFamily, fontSize);
            }
            else if (control is DataGridView)
            {
                float newFontSize = this.Width * 0.01f; // Điều chỉnh tỷ lệ tùy theo nhu cầu
                if (newFontSize < 8) newFontSize = 8; // Kích thước font tối thiểu
                else if (newFontSize > 15) newFontSize = 15; // Kích thước font tối đa

                // Cập nhật font chữ cho các hàng trong DataGridView
                dataGridView1.DefaultCellStyle.Font = new Font(dataGridView1.DefaultCellStyle.Font.FontFamily, newFontSize);

                // Cập nhật font chữ cho tiêu đề cột
                dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(dataGridView1.ColumnHeadersDefaultCellStyle.Font.FontFamily, newFontSize);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    row.Height = (int)(newFontSize * 5f); // Điều chỉnh chiều cao của mỗi hàng, tỷ lệ có thể thay đổi
                }
            }
            // Đệ quy qua tất cả các control con
            foreach (Control childControl in control.Controls)
            {
                ResizeFont(childControl);
            }
        }

        private void HopDong_Resize(object sender, EventArgs e)
        {
            ResizeFont(this);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dataGridView1.Columns[e.ColumnIndex].Name == "MaHD"|| dataGridView1.Columns[e.ColumnIndex].Name == "MaDN") && e.Value != null)
            {
                string originalValue = e.Value.ToString();
                e.Value = originalValue.Length > 5 ? originalValue.Substring(originalValue.Length - 5) : originalValue;
            }
        }
    }
}
