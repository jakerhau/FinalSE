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
    public partial class HoSoKHDKDNItem : Form
    {
        private Main1 main;
        private User user;
        public HoSoKHDKDNItem()
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
            main.ShowFormInPanel(new dangkiDNmoi());
        }

        private void ResizeFont(Control control)
        {

            float fontSize = Math.Min(panel1.Width, panel1.Height) * 0.05f;

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

        private void HoSoKHDKDNItem_Resize(object sender, EventArgs e)
        {
            ResizeFont(this);
        }
    }
}
