using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.FormControl;
using PROJECT.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PROJECT
{
    public partial class Main1 : Form
    {
        private User user;
        private Form currentChildForm;
        public Main1()
        {
            InitializeComponent();
        }

        public void setUser(User user)
        {
            this.user = user;
            label1.Text = user.Username;
        }

        public void openChildFormInContent(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel1.Controls.Add(childForm);
            panel1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void ShowFormInPanel(Form form)
        {
            paneDesktop.Controls.Clear(); // Xóa các điều khiển hiện có trong panel

            // Tạo một panel chứa cho form
            Panel innerPanel = new Panel();
            innerPanel.Dock = DockStyle.Fill; // Đặt lấp đầy panel chính
            innerPanel.Padding = new Padding(20); // Thêm khoảng cách (margin) 20 pixel ở tất cả các bên

            form.TopLevel = false; // Đặt form không phải là Top Level
            form.FormBorderStyle = FormBorderStyle.None; // Bỏ viền cho form
            form.Dock = DockStyle.Fill; // Đặt form lấp đầy toàn bộ panel chứa

            innerPanel.Controls.Add(form); // Thêm form vào panel chứa
            paneDesktop.Controls.Add(innerPanel); // Thêm panel chứa vào panel chính
            form.Show(); // Hiển thị form
        }

        public void ShowPanelItem(Form form)
        {
            panelItem.Controls.Clear(); // Xóa các điều khiển hiện có trong panel

            // Tạo một panel chứa cho form
            Panel innerPanel = new Panel();
            innerPanel.Dock = DockStyle.Fill; // Đặt lấp đầy panel chính
            innerPanel.Padding = new Padding(20); // Thêm khoảng cách (margin) 20 pixel ở tất cả các bên

            form.TopLevel = false; // Đặt form không phải là Top Level
            form.FormBorderStyle = FormBorderStyle.None; // Bỏ viền cho form
            form.Dock = DockStyle.Fill; // Đặt form lấp đầy toàn bộ panel chứa

            innerPanel.Controls.Add(form); // Thêm form vào panel chứa
            panelItem.Controls.Add(innerPanel); // Thêm panel chứa vào panel chính
            form.Show(); // Hiển thị form
        }




        private void ResizeFont(Control control)
        {

            float fontSize = Math.Min(panel1.Width, panel1.Height) * 0.02f;

            if (control is System.Windows.Forms.Label || control is System.Windows.Forms.Button || control is System.Windows.Forms.TextBox || control is System.Windows.Forms.ComboBox) // Kiểm tra control có chứa text
            {
                control.Font = new Font(control.Font.FontFamily, fontSize);
            }
            // Đệ quy qua tất cả các control con
            foreach (Control childControl in control.Controls)
            {
                ResizeFont(childControl);
            }
        }


        private System.Windows.Forms.Button currentButton = null;


        private void SelectButton(System.Windows.Forms.Button button)
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(246, 246, 246);
            }

            button.BackColor = Color.FromArgb(141, 185, 106); // Màu khi được chọn
            currentButton = button;
        }





        private void button2_Click_1(object sender, EventArgs e)
        {
            SelectButton(rjButton1);
            HoSoKHDKDNItem hskhdkdnitem = new HoSoKHDKDNItem();
            hskhdkdnitem.setUser(user);
            hskhdkdnitem.setMainForm(this);

            ShowPanelItem(hskhdkdnitem);
            HoSoKHDKDN hskhdkdn = new HoSoKHDKDN();
            hskhdkdn.setUser(user);
            hskhdkdn.setMain(this);
            ShowFormInPanel(hskhdkdn);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SelectButton(rjButton2);
            hopdongItem hdit = new hopdongItem();
            hdit.setUser(user);
            hdit.setMainForm(this);
            ShowPanelItem(hdit);
            HopDong hd = new HopDong(user);
            ShowFormInPanel(hd);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SelectButton(rjButton4);
            NhapThongSo nts = new NhapThongSo();
            ShowFormInPanel(nts);
            panelItem.Controls.Clear();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SelectButton(rjButton3);
            LoginForm loginForm = new LoginForm(this);
            openChildFormInContent(loginForm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectButton(button1j);
            ThongBao thongbaoform = new ThongBao();
            ShowFormInPanel(thongbaoform);
            panelItem.Controls.Clear();
        }

        private void Main1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main1_Load(object sender, EventArgs e)
        {
            openChildFormInContent(new LoginForm(this));
        }

        private void paneDesktop_Paint(object sender, PaintEventArgs e)
        {

        }
        public void openForgotPwdForm()
        {
            ForgotPwd loginform = new ForgotPwd(this);
            loginform.TopLevel = false;
            loginform.FormBorderStyle = FormBorderStyle.None;
            loginform.Dock = DockStyle.Fill;
            panel1.Controls.Add(loginform);
            panel1.Tag = loginform;
            loginform.BringToFront();
            loginform.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Main1_Resize(object sender, EventArgs e)
        {
            ResizeFont(button1j);
            ResizeFont(rjButton1);
            ResizeFont(rjButton2);
            ResizeFont(rjButton3);
            ResizeFont(rjButton4);
            ResizeFont(label1);



        }
    }
}
