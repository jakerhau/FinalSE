using Admin.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin
{
    public partial class userListForm : Form
    {
        private MainForm form2;
        public userListForm(MainForm parentform)
        {
            InitializeComponent();
            form2 = parentform;
            form2.Onsearch += SearchInDataGridView;
        }

        private void userListForm_Load(object sender, EventArgs e)
        {
            foreach (User user in MongoHelper.GetUserCollection().Find(_ => true).ToList())
            {
                dataGridView1.Rows.Add(user.Id, user.Username, user.Permit);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string nameValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string permitValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();


            form2.openChildFormInContent(new UserDetailsForm(idValue, nameValue, permitValue));

        }
        private void SearchInDataGridView(string keyword)
        {
            keyword = keyword.ToLower();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[1].Value.ToString().ToLower().Contains(keyword) || row.Cells[0].Value.ToString().ToLower().Contains(keyword))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }


    }
}
