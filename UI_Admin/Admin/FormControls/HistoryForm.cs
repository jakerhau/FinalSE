using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin.Models;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Admin
{
    public partial class HistoryForm : Form
    {
        private string idUser;
        public HistoryForm(string idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var opeCollection = MongoHelper.GetOperationCollection();
            var findOp = opeCollection.Find(x => x.IdUser == ObjectId.Parse(idUser)).FirstOrDefault();
            if (findOp != null)
            {
                AddTimesToDataGridView(findOp.LoginTime, "Đăng nhập");
                AddTimesToDataGridView(findOp.LogoutTime, "Đăng xuất");
                AddTimesToDataGridView(findOp.StatisticalMerge, "Statistical Merge");
                AddTimesToDataGridView(findOp.StatisticalCustomer, "Statistical Customer");
                AddTimesToDataGridView(findOp.ExportReport, "Xuất Report");
                AddTimesToDataGridView(findOp.InputTime, "Nhập Input");
            }
            else
                MessageBox.Show("Không tìm thấy dữ liệu");
        }
        private void AddTimesToDataGridView(List<DateTime> times, string action)
        {
            if (times != null && times.Count > 0)
            {
                foreach (var time in times)
                {
                    dataGridView1.Rows.Add(time.ToString("dd/MM/yyyy HH:mm:ss"), action);
                }
            }
        }
    }
}
