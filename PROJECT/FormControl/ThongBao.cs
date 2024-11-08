using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            float fontSize = Math.Min(panel1.Width, panel1.Height) * 0.05f;

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

        private void ThongBao_Resize(object sender, EventArgs e)
        {
            ResizeFont(this);
        }
    }
}
