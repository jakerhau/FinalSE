using Admin.FormControls;
using Admin.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace Admin
{
    public partial class MainForm : Form
    {
        private AdminModel admin;
        public MainForm()
        {
            InitializeComponent();
        }
        public void setAdmin(AdminModel admin)
        {
            this.admin = admin;
        }

        private Button currentButton = null;

        private Form currentChildForm;

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
            ContentPanel.Controls.Add(childForm);
            ContentPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void openLoginForm()
        {
            LoginForm loginform = new LoginForm(this);
            loginform.TopLevel = false;
            loginform.FormBorderStyle = FormBorderStyle.None;
            loginform.Dock = DockStyle.Fill;
            startPanel.Controls.Add(loginform);
            startPanel.Tag = loginform;
            loginform.BringToFront();
            loginform.Show();
        }

        private void SelectButton(Button button)
        {
            // Đặt lại màu của nút hiện đang được chọn (nếu có)
            if (currentButton != null)
            {
                currentButton.BackColor = SystemColors.Control; // Màu mặc định
            }

            // Đổi màu cho nút mới
            button.BackColor = Color.FromArgb(246, 246, 246); // Màu khi được chọn
            currentButton = button; // Cập nhật nút hiện tại
        }

        public void openForgotPwdForm()
        {
            ForgotPwd loginform = new ForgotPwd(this);
            loginform.TopLevel = false;
            loginform.FormBorderStyle = FormBorderStyle.None;
            loginform.Dock = DockStyle.Fill;
            startPanel.Controls.Add(loginform);
            startPanel.Tag = loginform;
            loginform.BringToFront();
            loginform.Show();
        }

        //public void openResetPwdForm()
        //{
        //    checkEmailLabel loginform = new checkEmailLabel(this);
        //    loginform.TopLevel = false;
        //    loginform.FormBorderStyle = FormBorderStyle.None;
        //    loginform.Dock = DockStyle.Fill;
        //    startPanel.Controls.Add(loginform);
        //    startPanel.Tag = loginform;
        //    loginform.BringToFront();
        //    loginform.Show();
        //}











        private void adminLblPanel_Resize(object sender, EventArgs e)
        {
            int panelWidth = adminLblPanel.Width;
            int panelHeight = adminLblPanel.Height;

            // Điều chỉnh tỷ lệ dựa trên chiều cao hoặc chiều rộng của panel
            float fontSize = Math.Max(panelWidth, panelHeight) * 0.1f; // Điều chỉnh hệ số nếu cần
            adminlbl.Font = new Font(adminlbl.Font.FontFamily, fontSize, adminlbl.Font.Style);
        }



        private void logoutbtn_Resize(object sender, EventArgs e)
        {
            float fontSize = Math.Max(navPanel.Width, navPanel.Height) * 0.013f;
            logoutbtn.Font = new Font(adminlbl.Font.FontFamily, fontSize, adminlbl.Font.Style);
        }

        private void btnPanel_Resize(object sender, EventArgs e)
        {
            float fontSize = Math.Max(btnPanel.Width, btnPanel.Height) * 0.06f;
            userbtn.Font = new Font(adminlbl.Font.FontFamily, fontSize, adminlbl.Font.Style);
            createnewbtn.Font = new Font(adminlbl.Font.FontFamily, fontSize, adminlbl.Font.Style);

        }



        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Texts == "Search...")
            {
                searchBox.Texts = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            searchBox.Texts = "Search...";
            searchBox.ForeColor = Color.Gray;
            openLoginForm();
            openChildFormInContent(new userListForm(this));


        }



        private void userbtn_Click(object sender, EventArgs e)
        {
            SelectButton(userbtn);
            openChildFormInContent(new userListForm(this));

        }

        private void createnewbtn_Click(object sender, EventArgs e)
        {
            SelectButton(createnewbtn);
            openChildFormInContent(new AddUser(admin.Id));
        }

        private void searchBox_Click(object sender, EventArgs e)
        {
            if (searchBox.Texts == "Search...")
            {
                searchBox.Texts = "";
                searchBox.ForeColor = Color.Black;
            }
        }

        private void searchBox_Enter_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text) || searchBox.Text == "Search...")
            {
                searchBox.Text = "Search..."; // Đặt chữ "search" nếu rỗng
            }
            else
            {
                searchBox.ForeColor = Color.Black; // Đặt màu chữ nếu có nội dung
            }
        }

        private void logoutbtn_Click_1(object sender, EventArgs e)
        {
            openLoginForm();
        }
        public string getSearchText()
        {
            return this.searchBox.Texts;
        }

        public event Action<string> Onsearch;
        private void rjButton1_Click(object sender, EventArgs e)
        {
            string keyword = getSearchText();
            Onsearch?.Invoke(keyword);
        }
    }
}
