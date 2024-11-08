using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using PROJECT.FormControl;
using PROJECT.Model;
namespace PROJECT
{
    public partial class HoSoKhachHangHopDong : Form
    {
        private string idCustomer;
        private Main1 main;
        private IMongoCollection<ContractModel> contract = MongoHelper.GetContractCollection();
        private IMongoCollection<Status> status = MongoHelper.GetStatusCollection();
        private IMongoCollection<Customer> customer = MongoHelper.GetCustomerCollection();
        public HoSoKhachHangHopDong()
        {
            InitializeComponent();
        }
        public void setIdCustomer(string idCustomer)
        {
            this.idCustomer = idCustomer;
        }
        public void setMain(Main1 main)
        {
            this.main = main;
        }

        private void HoSoKhachHangHopDong_Load(object sender, EventArgs e)
        {
            var contractList = contract.Find(_ => true).ToList();
            var customerList = customer.Find(_ => true).ToList();
            var statusList = status.Find(_ => true).ToList();
            // lấy danh sách hợp đồng tương ứng với khách hàng và xem tình trạng xử lý ở status
            var listContractOfCus = from c in contractList
                                    join cus in customerList on c.IdCustomer.ToString() equals cus.Id.ToString()
                                    join st in statusList on c.Id.ToString() equals st.IdContract.ToString() into statusGroup
                                    from st in statusGroup.DefaultIfEmpty() // Left join với statusList
                                    where cus.Id.ToString() == idCustomer
                                    select new
                                    {
                                        Id = c.Id.ToString(),
                                        TenKhachHang = cus.Id.ToString(),
                                        TinhTrangHopDong = tinhTrang(c.DayEnd),
                                        TinhTrangXuLy = st != null ? st.stt : "Chưa có tiến trình xử lý" // Hiển thị trạng thái mặc định nếu chưa có
                                    };
            dataGridView1.Rows.Clear();
            foreach (var item in listContractOfCus)
            {
                bool exists = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["MaHD"].Value != null && row.Cells["MaHD"].Value.ToString() == item.Id)
                    {
                        exists = true;
                        break;
                    }
                }
                if (!exists)
                {
                    dataGridView1.Rows.Add(item.Id, item.TenKhachHang, item.TinhTrangHopDong, item.TinhTrangXuLy);
                }
            }
        }
        private String tinhTrang(DateTime dayEnd)
        {
            if (dayEnd < DateTime.Now)
            {
                return "Hết hạn";
            }
            else
            {
                return "Còn hạn";
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();
            //kiểm tra giống với search
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString().ToLower().Contains(searchText)
                    || row.Cells[0].Value.ToString().ToLower().Contains(searchText))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idContract = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string idCustomer = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            //tạo status dựa trên contract vừa tạo

            var contractList = contract.Find(c => c.Id == ObjectId.Parse(idContract)).FirstOrDefault();
            var customerList = customer.Find(cus => cus.Id == ObjectId.Parse(idCustomer)).FirstOrDefault();
            status.InsertOne(new Status
            {
                Address = "",
                GetTime = DateTime.Now,
                stt = "Waiting",
                IdContract = ObjectId.Parse(idContract),
            });
            var statusList = status.Find(_ => true).ToList();
            var st = statusList.Last();

            HoSoKhachHangXuLyMau form = new HoSoKhachHangXuLyMau();
            form.setId(st.Id.ToString());
            form.setBool(true);

            main.ShowFormInPanel(form);
        }

        private void HoSoKhachHangHopDong_Resize(object sender, EventArgs e)
        {
            ResizeFont(this);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((dataGridView1.Columns[e.ColumnIndex].Name == "MaHD" || dataGridView1.Columns[e.ColumnIndex].Name == "MaDN") && e.Value != null)
            {
                string originalValue = e.Value.ToString();
                e.Value = originalValue.Length > 5 ? originalValue.Substring(originalValue.Length - 5) : originalValue;
            }
        }
    }
}
