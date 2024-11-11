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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using PROJECT.Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace PROJECT.FormControl
{
    public partial class ThongBao : Form
    {
        public ThongBao()
        {
            InitializeComponent();
        }
        private void ResizeFont(Control control)
        {
            try
            {
                float fontSize = Math.Min(panel1.Width, panel1.Height) * 0.05f;

                if (control is System.Windows.Forms.Label || control is System.Windows.Forms.ComboBox) // Kiểm tra control có chứa text
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
        private void ResizeFont1(Control control)
        {
            try
            {
                float fontSize = Math.Min(panel1.Width, panel1.Height) * 0.01f;

                if (control is System.Windows.Forms.Label || control is System.Windows.Forms.Button || control is System.Windows.Forms.ComboBox) // Kiểm tra control có chứa text
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

        private void ThongBao_Resize(object sender, EventArgs e)
        {
            //ResizeFont(this);
            ResizeFont1(tableLayoutPanel3);
        }

        private void ThongBao_Load(object sender, EventArgs e)
        {
            var contract = MongoHelper.GetContractCollection();
            var listContract = contract.AsQueryable<ContractModel>().ToList();

            DateTime now = DateTime.Now;

           

            foreach (var item in listContract)
            {
                DateTime date = item.DayEnd;
                TimeSpan time = date - now;
                int days = time.Days;

                if (days <= 7 && days >= 0)
                {
                    tableLayoutPanel3.RowCount += 1;


                    tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    // Create a new label
                    Label label = new Label
                    {
                        Text = "Hợp đồng " + item.Status + " sắp hết hạn " + date.ToString("dd/MM/yyyy"),
                        AutoSize = true,
                        Dock = DockStyle.Fill,
                        Font = new Font("Arial", 10, FontStyle.Underline),
                        ForeColor = Color.Red,
                        TextAlign = ContentAlignment.MiddleLeft,
                        BorderStyle = BorderStyle.Fixed3D
                    };

                    




                    tableLayoutPanel3.Controls.Add(label, 0, tableLayoutPanel3.RowCount - 1);
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //tìm kiếm thông báo dựa trên tablelayoutpanel
            string search = textBox1.Text;
            foreach (Control control in tableLayoutPanel3.Controls)
            {
                if (control is Label)
                {
                    if (control.Text.Contains(search))
                    {
                        control.Visible = true;
                    }
                    else
                    {
                        control.Visible = false;
                    }
                }
            }
        }
    }
}
