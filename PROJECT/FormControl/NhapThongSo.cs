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

namespace PROJECT
{
    public partial class NhapThongSo : Form
    {
        public NhapThongSo()
        {
            InitializeComponent();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            NhapthongsoPanel.RowCount++;
            NhapthongsoPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            CheckBox chk = new CheckBox { Dock = DockStyle.Fill, CheckAlign = ContentAlignment.MiddleCenter };

            ComboBox tenchitieu = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDown };
            tenchitieu.Items.AddRange(new object[] { "Turbidity", "PH", "TotalDissolvedSolids", "ColorDegree",
                "TotalSuspendedSolids", "BOD", "COD", "Ammonia", "TotalPhosphorus", "TotalNitrogen", "Sulfide", "TotalMineralOil" });
            ComboBox donvi = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDown };
            tenchitieu.SelectedIndexChanged += (s, args) =>
            {
                // Thay đổi text của tenchitieu khi chọn mục mới
                tenchitieu.Text = tenchitieu.SelectedItem.ToString();

                // Cập nhật đơn vị cho ComboBox donvi dựa trên chỉ tiêu đã chọn
                donvi.Items.Clear(); // Xóa các mục cũ trong donvi

                // Thêm đơn vị tương ứng cho từng chỉ tiêu
                switch (tenchitieu.SelectedItem.ToString())
                {
                    case "Turbidity":
                        donvi.Items.AddRange(new object[] { "NTU" }); // Đơn vị cho Turbidity
                        break;
                    case "PH":
                        donvi.Items.AddRange(new object[] { "pH" }); // Đơn vị cho PH
                        break;
                    case "TotalDissolvedSolids":
                        donvi.Items.AddRange(new object[] { "mg/L", "ppm" }); // Đơn vị cho Total Dissolved Solids
                        break;
                    case "ColorDegree":
                        donvi.Items.AddRange(new object[] { "Unit", "Degree" }); // Đơn vị cho Color Degree
                        break;
                    case "TotalSuspendedSolids":
                        donvi.Items.AddRange(new object[] { "mg/L", "ppm" }); // Đơn vị cho Total Suspended Solids
                        break;
                    case "BOD":
                        donvi.Items.AddRange(new object[] { "mg/L", "ppm" }); // Đơn vị cho BOD
                        break;
                    case "COD":
                        donvi.Items.AddRange(new object[] { "mg/L", "ppm" }); // Đơn vị cho COD
                        break;
                    case "Ammonia":
                        donvi.Items.AddRange(new object[] { "mg/L", "ppm" }); // Đơn vị cho Ammonia
                        break;
                    case "TotalPhosphorus":
                        donvi.Items.AddRange(new object[] { "mg/L", "ppm" }); // Đơn vị cho Total Phosphorus
                        break;
                    case "TotalNitrogen":
                        donvi.Items.AddRange(new object[] { "mg/L", "ppm" }); // Đơn vị cho Total Nitrogen
                        break;
                    case "Sulfide":
                        donvi.Items.AddRange(new object[] { "mg/L", "ppm" }); // Đơn vị cho Sulfide
                        break;
                    case "TotalMineralOil":
                        donvi.Items.AddRange(new object[] { "mg/L", "ppm" }); // Đơn vị cho Total Mineral Oil
                        break;
                    default:
                        donvi.Items.Clear(); // Nếu không có lựa chọn nào, xóa đơn vị
                        break;
                }
            };

            tenchitieu.TextChanged += (s, args) =>
            {
                if (!tenchitieu.Items.Contains(tenchitieu.Text))
                {
                    tenchitieu.SelectedIndex = -1;
                }
            };
            donvi.SelectedIndexChanged += (s, args) =>
            {
                donvi.Text = donvi.SelectedItem.ToString();
            };

            donvi.TextChanged += (s, args) =>
            {
                if (!donvi.Items.Contains(donvi.Text))
                {
                    donvi.SelectedIndex = -1;
                }
            };


            TextBox toida = new TextBox { Dock = DockStyle.Fill };
            TextBox toithieu = new TextBox { Dock = DockStyle.Fill };
            Button btn = new Button { Text = "Xóa", Dock = DockStyle.Fill };

            // Thêm các control vào các cột của hàng mới
            NhapthongsoPanel.Controls.Add(chk, 0, NhapthongsoPanel.RowCount - 2);
            NhapthongsoPanel.Controls.Add(tenchitieu, 1, NhapthongsoPanel.RowCount - 2);
            NhapthongsoPanel.Controls.Add(donvi, 2, NhapthongsoPanel.RowCount - 2);
            NhapthongsoPanel.Controls.Add(toida, 3, NhapthongsoPanel.RowCount - 2);
            NhapthongsoPanel.Controls.Add(toithieu, 4, NhapthongsoPanel.RowCount - 2);


            // Di chuyển nút thêm hàng xuống cuối bảng
            NhapthongsoPanel.Controls.Add(btnAddRow, 0, NhapthongsoPanel.RowCount - 1);

            // Xử lý sự kiện xóa hàng cho nút "Xóa"
            btn.Click += (s, args) =>
            {
                int rowIndex = NhapthongsoPanel.GetRow(btn);
                foreach (Control control in NhapthongsoPanel.Controls)
                {
                    if (NhapthongsoPanel.GetRow(control) == rowIndex)
                    {
                        NhapthongsoPanel.Controls.Remove(control);
                    }
                }
                NhapthongsoPanel.RowStyles.RemoveAt(rowIndex);
                NhapthongsoPanel.RowCount--;
            };
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Control control in NhapthongsoPanel.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = true;
                }
            }
        }

        private void ResizeFont(Control control)
        {

            float fontSize = Math.Min(panel1.Width, panel1.Height) * 0.02f;

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

        private void button8_Click(object sender, EventArgs e)
        {
            foreach (Control control in NhapthongsoPanel.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CompareStandard compareStandard = new CompareStandard();
            compareStandard.Name = rjTextBox1.Texts;
            for (int rowIndex = 0; rowIndex < NhapthongsoPanel.RowCount - 1; rowIndex++)
            {
                // Get controls in the current row
                var checkBox = (CheckBox)NhapthongsoPanel.GetControlFromPosition(0, rowIndex);
                var tenchitieuComboBox = NhapthongsoPanel.GetControlFromPosition(1, rowIndex) as ComboBox;
                var toithieuTextBox = NhapthongsoPanel.GetControlFromPosition(4, rowIndex) as TextBox;
                var toidaTextBox = NhapthongsoPanel.GetControlFromPosition(3, rowIndex) as TextBox;

                // Process only if checkbox is checked
                if (checkBox != null && checkBox.Checked)
                {
                    // Get the min and max values as doubles
                    if (double.TryParse(toithieuTextBox.Text, out double minValue) && double.TryParse(toidaTextBox.Text, out double maxValue))
                    {
                        var values = new List<double> { maxValue, minValue };

                        // Determine the selected parameter and set the respective property
                        switch (tenchitieuComboBox.SelectedItem.ToString())
                        {
                            case "Turbidity":
                                compareStandard.Turbidity = values;
                                break;
                            case "PH":
                                compareStandard.PH = values;
                                break;
                            case "TotalDissolvedSolids":
                                compareStandard.TotalDissolvedSolids = values;
                                break;
                            case "ColorDegree":
                                compareStandard.ColorDegree = values;
                                break;
                            case "TotalSuspendedSolids":
                                compareStandard.TotalSuspendedSolids = values;
                                break;
                            case "BOD":
                                compareStandard.BOD = values;
                                break;
                            case "COD":
                                compareStandard.COD = values;
                                break;
                            case "Ammonia":
                                compareStandard.Ammonia = values;
                                break;
                            case "TotalPhosphorus":
                                compareStandard.TotalPhosphorus = values;
                                break;
                            case "TotalNitrogen":
                                compareStandard.TotalNitrogen = values;
                                break;
                            case "Sulfide":
                                compareStandard.Sulfide = values;
                                break;
                            case "TotalMineralOil":
                                compareStandard.TotalMineralOil = values;
                                break;
                        }
                    }
                }
            }
            var collection = MongoHelper.GetCompareStandardCollection();
            collection.InsertOne(compareStandard);
            Debug.WriteLine("Inserted new compare standard");
        }

        private void NhapThongSo_Resize(object sender, EventArgs e)
        {
            ResizeFont(this);
        }
    }
}