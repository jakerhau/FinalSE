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
    public partial class XuLyMauMain_readonly : Form
    {
        private string idContract;
        private Main1 main;
        private ObjectId idUser;
        public XuLyMauMain_readonly()
        {
            InitializeComponent();
        }
        public void setId(string id)
        {
            this.idContract = id;
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

            var find = contract.Find(c => c.Id == ObjectId.Parse(idContract)).ToList();
            var findStatus = status.Find(_ => true).ToList();
            var findSample = sample.Find(_ => true).ToList();

            if (!dataGridView1.Columns.Contains("OriginalID"))
            {
                dataGridView1.Columns.Add("OriginalID", "OriginalID");
                dataGridView1.Columns["OriginalID"].Visible = false;
            }

            var list = from c in find
                       join s in findStatus on c.Id.ToString() equals s.IdContract.ToString()
                       join sa in findSample on s.Id.ToString() equals sa.IdStatus.ToString() into sampleGroup
                       from sa in sampleGroup.DefaultIfEmpty()
                       select new
                       {
                           Id = s != null ? s.Id.ToString() : "Chưa có sample",
                           TienTrinh = s.stt ?? "Chưa có tiến trình",
                           ContractId = c.Id.ToString(),
                           OriginalID = sa != null ? sa.Id.ToString() : "Chưa có mẫu"
                       };
            dataGridView1.Rows.Clear();
            foreach (var item in list)
            {
                 dataGridView1.Rows.Add(item.Id, item.ContractId, item.TienTrinh);
                 dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["OriginalID"].Value = item.OriginalID;
                 Debug.WriteLine(item.OriginalID);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                string originalId = dataGridView1.Rows[rowIndex].Cells["OriginalID"].Value.ToString();
                //Debug.WriteLine(originalId);
                FormPDF formPDF = new FormPDF();
                formPDF.setId(originalId);
                formPDF.setIdUser(idUser);
                formPDF.Show();
            }
        }

        private void XuLyMauMain_Resize(object sender, EventArgs e)
        {
            ResizeFont(this);
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
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "MaHD" && e.Value != null)
            {
                string originalValue = e.Value.ToString();
                e.Value = originalValue.Length > 5 ? originalValue.Substring(originalValue.Length - 5) : originalValue;
            }
            //thay id bằng idsam
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "ID" && e.Value != null)
            {
                string idSample = e.Value.ToString();
                var sample = MongoHelper.GetSampleCollection();
                var findSample = sample.Find(s => s.IdStatus.ToString() == idSample).FirstOrDefault();
                if (findSample != null)
                {
                    e.Value = findSample.IdSam.ToString();
                }
                else
                    e.Value = idSample.Length > 5 ? idSample.Substring(idSample.Length - 5) : idSample;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //ID, MaHd, OriginalId
                string id = row.Cells["ID"].Value.ToString().ToLower();
                string maHD = row.Cells["MaHD"].Value.ToString().ToLower();
                string originalId = row.Cells["OriginalID"].Value.ToString().ToLower();

                if (id.Contains(searchText) || maHD.Contains(searchText) || originalId.Contains(searchText))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }

        public void setIdUser(ObjectId id)
        {
            idUser = id;
        }
    }
}
