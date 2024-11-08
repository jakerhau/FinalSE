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
    public partial class XuLyMauMain : Form
    {
        private string idCustomer;
        private Main1 main;
        public XuLyMauMain()
        {
            InitializeComponent();
        }
        public void setId(string idCustomer)
        {
            this.idCustomer = idCustomer;
        }
        public void setMain(Main1 main)
        {
            this.main = main;
        }

        private void XuLyMauMain_Load(object sender, EventArgs e)
        {
            var contract = MongoHelper.GetContractCollection();
            var status = MongoHelper.GetStatusCollection();
            var sample = MongoHelper.GetSampleCollection();

            var find = contract.Find(c => c.IdCustomer == ObjectId.Parse(idCustomer)).ToList();
            var findStatus = status.Find(_ => true).ToList();
            var findSample = sample.Find(_ => true).ToList();

            var list = from c in find
                       join s in findStatus on c.Id.ToString() equals s.IdContract.ToString()
                       join sa in findSample on s.Id.ToString() equals sa.IdStatus.ToString() into sampleGroup
                       from sa in sampleGroup.DefaultIfEmpty() // Left join với findSample
                       select new
                       {
                           Id = s != null ? s.Id.ToString() : "Chưa có sample",
                           TienTrinh = s.stt ?? "Chưa có tiến trình",
                           ContractId = c.Id.ToString(),
                       };
            dataGridView1.Rows.Clear();
            foreach (var item in list)
            {
                dataGridView1.Rows.Add(item.Id, item.ContractId, item.TienTrinh);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().Contains(searchText))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                var id = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();

                HoSoKhachHangXuLyMau form = new HoSoKhachHangXuLyMau();
                form.setId(id);
                form.setMain(main);
                main.ShowFormInPanel(form);
            }
        }

        private void XuLyMauMain_Resize(object sender, EventArgs e)
        {
            ResizeFont(this);
        }

        private void ResizeFont(Control control)
        {
            float fontSize = Math.Min(panel2.Width, panel2.Height) * 0.02f;

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
    }
}
