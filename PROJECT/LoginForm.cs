using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROJECT.Model;
using MongoDB.Driver;
using MongoDB.Bson;

namespace PROJECT
{
    public partial class LoginForm : Form
    {
        private Main1 MainForm;
        public LoginForm(Main1 mainform)
        {
            InitializeComponent();
            this.MainForm = mainform;
            welcomPanel.Paint += greenPanel_Paint;

        }

        private void LoginForm_Resize(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {

                control.Invalidate();

            }
        }

        private void greenPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            path.StartFigure();

            // đường cong trên
            path.AddBezier(
                formWidth * 0.14f, 0,
                formWidth * 0.02f, formHeight * 0.25f,
                formWidth * 0.038f, formHeight * 0.35f,
                formWidth * 0.04f, formHeight * 0.4f
            );

            //đường cong dưới
            path.AddBezier(
                formWidth * 0.04f, formHeight * 0.4f,
                formWidth * 0.06f, formHeight * 0.6f,
                formWidth * 0.18f, formHeight * 0.7f,
                formWidth * 0.1f, formHeight
            );

            // dóng hình dạng của khung
            path.AddLine(formWidth * 0.1f, formHeight, formWidth, formHeight);
            path.AddLine(formWidth, formHeight, formWidth, 0);
            path.AddLine(formWidth, 0, formWidth * 0.2f, 0);

            using (SolidBrush brush = new SolidBrush(ColorTranslator.FromHtml("#8DB96A")))
            {
                g.FillPath(brush, path);
            }

            path.Dispose();
        }

        private void signinBtn_Click(object sender, EventArgs e)
        {
            var Customer = MongoHelper.GetUserCollection();
            var filter = Builders<User>.Filter.Eq("Email", rjTextBox1.Texts);
            var result = Customer.Find(filter).FirstOrDefault();
            if (result == null || result.Password != rjTextBox2.Texts)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
                return;
            }
            MainForm.setUser(result);
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm.openForgotPwdForm();
        }
    }
}
