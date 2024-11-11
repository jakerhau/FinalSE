using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using PROJECT.Model;
using MongoDB.Bson;
using System.Diagnostics;
using MigraDoc.DocumentObjectModel.Tables;

namespace PROJECT.FormControl
{
    public partial class HoSoKHDKDN : Form
    {
        private User u;
        private Main1 main;
        private IMongoCollection<Customer> customer = MongoHelper.GetCustomerCollection();
        public HoSoKHDKDN()
        {
            InitializeComponent();
        }
        public void setUser(User u)
        {
            this.u = u;
        }
        public void setMain(Main1 main)
        {
            this.main = main;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Padding = new Padding(10, 5, 10, 5);
            }
        }

        private void HoSoKHDKDN_Load_1(object sender, EventArgs e)
        {
            var customer = MongoHelper.GetCustomerCollection();
            var contract = MongoHelper.GetContractCollection();

            var listCustomer = customer.Find(_ => true).ToList();
            var listContract = contract.Find(_ => true).ToList();

            if (!dataGridView1.Columns.Contains("OriginalMaDN"))
            {
                dataGridView1.Columns.Add("OriginalMaDN", "OriginalMaDN");
                dataGridView1.Columns["OriginalMaDN"].Visible = false; // Ẩn cột này
            }



            var list = from c in listContract
                       join cus in listCustomer on c.IdCustomer.ToString() equals cus.Id.ToString()
                       where c.IdUser == u.Id
                       select new
                       {
                           Id = cus.Id.ToString(),
                           TenKhachHang = cus.Name,
                           TinhTrang = tinhTrang(c.DayEnd),
                           MaDoanhNghiep = cus.IdBusiness
                       };

            var listNotContract = from cus in listCustomer
                                  join con in listContract on cus.Id equals con.IdCustomer into contractGroup
                                  from subCon in contractGroup.DefaultIfEmpty()
                                  where subCon == null
                                  select new
                                  {
                                      Id = cus.Id.ToString(),
                                      TenKhachHang = cus.Name,
                                      TinhTrang = "Chưa ký hợp đồng",
                                      MaDoanhNghiep = cus.IdBusiness
                                  };
            dataGridView1.Rows.Clear();
            foreach (var item in listNotContract)
            {
                dataGridView1.Rows.Add(item.Id, item.TenKhachHang, item.TinhTrang);
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["OriginalMaDN"].Value = item.MaDoanhNghiep;
            }
            foreach (var item in list)
            {
                bool check = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == item.Id)
                    {
                        check = true;

                        if (row.Cells[2].Value.ToString() == "Còn hạn" && item.TinhTrang == "Hết hạn")
                        {
                            row.Cells[1].Value = item.TenKhachHang;
                            row.Cells[2].Value = item.TinhTrang;
                        }
                        break;
                    }
                }
                if (!check)
                {
                    dataGridView1.Rows.Add(item.Id, item.TenKhachHang, item.TinhTrang);
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["OriginalMaDN"].Value = item.MaDoanhNghiep;
                }
            }
        }
        private string tinhTrang(DateTime time)
        {
            if (time < DateTime.Now)
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
            try
            {
                float fontSize = Math.Min(panel2.Width, panel2.Height) * 0.02f;

                if (control is System.Windows.Forms.Label  || control is System.Windows.Forms.ComboBox) // Kiểm tra control có chứa text
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
            }catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string maDN = row.Cells["OriginalMaDN"].Value.ToString();
                string id = row.Cells[0].Value.ToString();
                string name = row.Cells[1].Value.ToString();

                if (id.Contains(textBox1.Text) || name.Contains(textBox1.Text) || maDN.Contains(textBox1.Text)) { 
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
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string id = row.Cells[0].Value.ToString();

                ThongTinDoanhNghiep tt = new ThongTinDoanhNghiep();
                tt.setIdCustomer(id);
                main.ShowFormInPanel(tt);

                HoSoKhachHangItem hskh = new HoSoKhachHangItem(main);
                hskh.setCutomerId(id);
                hskh.setUser(u);
                main.ShowPanelItem(hskh);
            }
        }

        private void HoSoKHDKDN_Resize(object sender, EventArgs e)
        {
            ResizeFont(this);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "MaDoanhNghiep" && e.Value != null)
            {
                string idCustomer = e.Value.ToString();
                var customers = customer.Find(c => c.Id == ObjectId.Parse(idCustomer)).FirstOrDefault();
                if (customers != null)
                {
                    e.Value = customers.IdBusiness;
                }
            }
        }
    }
}
