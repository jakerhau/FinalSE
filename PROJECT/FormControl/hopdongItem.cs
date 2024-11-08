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
    public partial class hopdongItem : Form
    {
        private Main1 main;
        private User user;
        public hopdongItem()
        {
            InitializeComponent();
        }
        public void setMainForm(Main1 main)
        {
            this.main = main;
        }
        public void setUser(User user)
        {
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main.ShowFormInPanel(new HopDong(user));
        }

        private void hopdongItem_Resize(object sender, EventArgs e)
        {
            ResizeFont(button1);
        }


        private void ResizeFont(Control control)
        {

            float fontSize = Math.Min(tableLayoutPanel1.Width, tableLayoutPanel1.Height) * 0.05f;

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
    }
}
