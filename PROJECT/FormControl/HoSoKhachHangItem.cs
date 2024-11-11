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
    public partial class HoSoKhachHangItem : Form
    {
        private Main1 main1;
        private string CustomerID;
        private User u;
        public HoSoKhachHangItem(Main1 main1)
        {
            InitializeComponent();
            this.main1 = main1;
        }
        public void setCutomerId(string CustomerID)
        {
            this.CustomerID = CustomerID;
        }
        public void setUser(User u)
        {
            this.u = u;
        }
        //private Panel XuLyMauMain;

        //private void ShowFormInPanel(Form form)
        //{
        //    //XuLyMauMain.Controls.Clear(); // Xóa các điều khiển hiện có trong panel

        //    // Tạo một panel chứa cho form
        //    Panel innerPanel = new Panel();
        //    innerPanel.Dock = DockStyle.Fill; // Đặt lấp đầy panel chính
        //    innerPanel.Padding = new Padding(20); // Thêm khoảng cách (margin) 20 pixel ở tất cả các bên

        //    form.TopLevel = false; // Đặt form không phải là Top Level
        //    form.FormBorderStyle = FormBorderStyle.None; // Bỏ viền cho form
        //    form.Dock = DockStyle.Fill; // Đặt form lấp đầy toàn bộ panel chứa

        //    innerPanel.Controls.Add(form); // Thêm form vào panel chứa
        //    //XuLyMauMain.Controls.Add(innerPanel); // Thêm panel chứa vào panel chính
        //    form.Show(); // Hiển thị form
        //}


        private void button1_Click(object sender, EventArgs e)
        {
            XuLyMauMain hskhit = new XuLyMauMain();
            hskhit.setId(this.CustomerID);
            hskhit.setMain(this.main1);
            main1.ShowFormInPanel(hskhit);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HoSoKhachHangHopDong hskhhd = new HoSoKhachHangHopDong(u.Id);
            hskhhd.setIdCustomer(this.CustomerID);
            hskhhd.setMain(this.main1);
            main1.ShowFormInPanel(hskhhd);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HoSoKhachHangDangKiHopDong dkhd = new HoSoKhachHangDangKiHopDong();
            dkhd.setUser(this.u);
            dkhd.setIdCustomer(this.CustomerID);
            main1.ShowFormInPanel(dkhd);
        }

        private void ResizeFont(Control control)
        {
            try
            {
                float fontSize = Math.Min(tableLayoutPanel1.Width, tableLayoutPanel1.Height) * 0.05f;

                if (control is System.Windows.Forms.Label || control is System.Windows.Forms.Button) // Kiểm tra control có chứa text
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

        private void HoSoKhachHangItem_Resize(object sender, EventArgs e)
        {
            ResizeFont(this);
        }
    }
}
