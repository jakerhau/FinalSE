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
using MongoDB.Bson;

namespace PROJECT.FormControl
{
    internal partial class HopDong : Form
    {
        private User user;
        private IMongoCollection<User> userCollection;
        private IMongoCollection<ContractModel> contractCollection;
        private IMongoCollection<Status> statusCollection;
        private IMongoCollection<Customer> customerCollection;
        private Main1 main;
        public HopDong(User user, Main1 main)
        {
            this.user = user;
            this.main = main;
            InitializeComponent();
        }
        public void setMain(Main1 main)
        {
            this.main = main;
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
                                   TinhTrangXuLy = status.stt,
                                   OriginalMaHD = contract.Id.ToString(),
                                   OriginalMaDN = customer.Id.ToString()
                               };

            if (!dataGridView1.Columns.Contains("OriginalMaHD"))
            {
                dataGridView1.Columns.Add("OriginalMaHD", "OriginalMaHD");
                dataGridView1.Columns["OriginalMaHD"].Visible = false;
            }

            if (!dataGridView1.Columns.Contains("OriginalMaDN"))
            {
                dataGridView1.Columns.Add("OriginalMaDN", "OriginalMaDN");
                dataGridView1.Columns["OriginalMaDN"].Visible = false;
            }

            dataGridView1.Rows.Clear();
            foreach (var item in contractData)
            {
                if (dataGridView1.Rows.Cast<DataGridViewRow>().Any(row => row.Cells["MaHD"].Value.ToString().Equals(item.MaHD)))
                {
                    continue;
                }
                var row = dataGridView1.Rows.Add(item.MaHD, item.MaDN, item.TinhTrangXuLy);
                dataGridView1.Rows[row].Cells["OriginalMaHD"].Value = item.MaHD;
                dataGridView1.Rows[row].Cells["OriginalMaDN"].Value = item.MaDN;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string originalMaHD = row.Cells["OriginalMaHD"].Value?.ToString().ToLower() ?? string.Empty;
                string originalMaDN = row.Cells["OriginalMaDN"].Value?.ToString().ToLower() ?? string.Empty;
                string maHD = row.Cells["MaHD"].Value?.ToString().ToLower() ?? string.Empty;
                string maDN = row.Cells["MaDN"].Value?.ToString().ToLower() ?? string.Empty;

                if (originalMaHD.Contains(keyword) || originalMaDN.Contains(keyword) || maHD.Contains(keyword) || maDN.Contains(keyword))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
        //private String tinhTrangHopDong(DateTime time)
        //{
        //    DateTime now = DateTime.Now;
        //    if (time < now)
        //    {
        //        return "Hết hạn";
        //    }
        //    return "Còn hạn";
        //}
        private void ResizeFont(Control control)
        {
            try
            {
                float fontSize = Math.Min(panel1.Width, panel1.Height) * 0.02f;

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
                        row.Height = (int)(newFontSize * 5f);
                    }
                }
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

        private void HopDong_Resize(object sender, EventArgs e)
        {
            ResizeFont(this);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "MaHD" && e.Value != null)
            {
                string originalValue = e.Value.ToString();
                e.Value = originalValue.Length > 5 ? originalValue.Substring(originalValue.Length - 5) : originalValue;

                dataGridView1.Rows[e.RowIndex].Cells["OriginalMaHD"].Value = originalValue;
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "MaDN" && e.Value != null)
            {
                string idCustomer = e.Value.ToString();
                var customer = customerCollection.Find(c => c.Id == ObjectId.Parse(idCustomer)).FirstOrDefault();
                if (customer != null)
                {
                    e.Value = customer.IdBusiness;

                    dataGridView1.Rows[e.RowIndex].Cells["OriginalMaDN"].Value = customer.IdBusiness;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idContract = dataGridView1.Rows[e.RowIndex].Cells["OriginalMaHD"].Value.ToString();
            XuLyMauMain_readonly form = new XuLyMauMain_readonly();
            form.setId(idContract);
            try
            {
                form.setIdUser(user.Id);
            } catch (Exception ex) {
                Debug.WriteLine(ex.Message);
            }
            main.ShowFormInPanel(form);
        }
    }
}
