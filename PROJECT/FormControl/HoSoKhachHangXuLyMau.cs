using MongoDB.Bson;
using MongoDB.Driver;
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
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace PROJECT.FormControl
{
    public partial class HoSoKhachHangXuLyMau : Form
    {
        private string idStatus;
        private Main1 main;
        private IMongoCollection<BsonDocument> sampleCollection;
        private IMongoCollection<Status> statusCollection;
        private IMongoCollection<Sample> sampleCol;
        private string idSample;
        private bool existSample = false;
        public HoSoKhachHangXuLyMau()
        {
            InitializeComponent();
        }
        public void setId(string idStatus)
        {
            this.idStatus = idStatus;
        }
        public void setMain(Main1 main)
        {
            this.main = main;
        }
        public void setBool(bool existSample)
        {
            this.existSample = existSample;
        }


        private void btnAddRow_Click(object sender, EventArgs e)
        {
            NhapthongsoPanel.SuspendLayout();
            NhapthongsoPanel.RowCount++;
            NhapthongsoPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            CheckBox chk = new CheckBox { Dock = DockStyle.Fill, CheckAlign = ContentAlignment.MiddleCenter };

            ComboBox tenchitieu = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDown };
            tenchitieu.Items.AddRange(new object[] { "Turbidity", "PH", "TotalDissolvedSolids", "ColorDegree",
                "TotalSuspendedSolids", "BOD", "COD", "Ammonia", "TotalPhosphorus", "TotalNitrogen", "Sulfide", "TotalMineralOil" });
            ComboBox donvi = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDown };
            tenchitieu.SelectedIndexChanged += (s, args) =>
            {
                tenchitieu.Text = tenchitieu.SelectedItem.ToString();

                donvi.Items.Clear();

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

            // Thêm các control vào các cột của hàng mới
            NhapthongsoPanel.Controls.Add(chk, 0, NhapthongsoPanel.RowCount - 2);
            NhapthongsoPanel.Controls.Add(tenchitieu, 1, NhapthongsoPanel.RowCount - 2);
            NhapthongsoPanel.Controls.Add(donvi, 2, NhapthongsoPanel.RowCount - 2);
            NhapthongsoPanel.Controls.Add(toida, 3, NhapthongsoPanel.RowCount - 2);
            NhapthongsoPanel.Controls.Add(toithieu, 4, NhapthongsoPanel.RowCount - 2);


            // Di chuyển nút thêm hàng xuống cuối bảng
            NhapthongsoPanel.Controls.Add(btnAddRow, 0, NhapthongsoPanel.RowCount - 1);

            // Xử lý sự kiện xóa hàng cho nút "Xóa"


            NhapthongsoPanel.ResumeLayout();

        }

        private void button2_Click(object sender, EventArgs e)
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

            float fontSize = Math.Min(panel2.Width, panel2.Height) * 0.02f;

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

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Control control in NhapthongsoPanel.Controls)
            {
                if (control is CheckBox)
                {
                    ((CheckBox)control).Checked = false;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            newSample();
            compareFunction(comboBox1.Text);
            updateStatus();
        }
        private void SetUnits(ComboBox tenchitieu, ComboBox donvi)
        {
            donvi.Items.Clear();
            switch (tenchitieu.Text)
            {
                case "Turbidity":
                    donvi.Items.AddRange(new object[] { "NTU" });
                    break;
                case "PH":
                    donvi.Items.AddRange(new object[] { "pH" });
                    break;
                case "TotalDissolvedSolids":
                    donvi.Items.AddRange(new object[] { "mg/L", "ppm" });
                    break;
                case "ColorDegree":
                    donvi.Items.AddRange(new object[] { "Unit", "Degree" });
                    break;
                case "TotalSuspendedSolids":
                    donvi.Items.AddRange(new object[] { "mg/L", "ppm" });
                    break;
                case "BOD":
                    donvi.Items.AddRange(new object[] { "mg/L", "ppm" });
                    break;
                case "COD":
                    donvi.Items.AddRange(new object[] { "mg/L", "ppm" });
                    break;
                case "Ammonia":
                    donvi.Items.AddRange(new object[] { "mg/L", "ppm" });
                    break;
                case "TotalPhosphorus":
                    donvi.Items.AddRange(new object[] { "mg/L", "ppm" });
                    break;
                case "TotalNitrogen":
                    donvi.Items.AddRange(new object[] { "mg/L", "ppm" });
                    break;
                case "Sulfide":
                    donvi.Items.AddRange(new object[] { "mg/L", "ppm" });
                    break;
                case "TotalMineralOil":
                    donvi.Items.AddRange(new object[] { "mg/L", "ppm" });
                    break;
            }
        }
        private void newSample()
        {
            sampleCollection = MongoHelper.GetDatabase().GetCollection<BsonDocument>("Sample");
            if (existSample)
            {
                MessageBox.Show("Mẫu đã tồn tại");
                return;
            }
            var document = new BsonDocument {
                { "IdStatus", ObjectId.Parse(idStatus)},
                { "Name", textBox3.Text },
                { "IdSam", int.TryParse(textBox1.Text, out int num) ? num : 0},
            };



            for (int row = 0; row < NhapthongsoPanel.RowCount; row++)
            {
                // Kiểm tra nếu CheckBox tồn tại ở cột 0
                var checkBoxControl = NhapthongsoPanel.GetControlFromPosition(0, row) as CheckBox;
                if (checkBoxControl == null || !checkBoxControl.Checked)
                    continue;

                // Lấy tên trường từ cột 1
                var columnNameControl = NhapthongsoPanel.GetControlFromPosition(1, row);
                string columnName = string.Empty;

                if (columnNameControl is ComboBox comboBoxName)
                {
                    columnName = comboBoxName.Text;
                }

                var dataControl = NhapthongsoPanel.GetControlFromPosition(3, row);
                string dataValue = string.Empty;

                if (dataControl is TextBox textBoxData)
                {
                    dataValue = textBoxData.Text;
                }

                // Thêm tên trường và dữ liệu vào BsonDocument nếu columnName không trống
                if (!string.IsNullOrEmpty(columnName))
                {
                    document.Add(columnName, double.TryParse(dataValue, out double number) ? number : 0);
                }
            }
            try
            {
                sampleCollection.InsertOne(document);
                MessageBox.Show("Thêm mẫu thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text = "Thêm mẫu thất bại" + ex.Message);
            }
        }


        private void HoSoKhachHangXuLyMau_Load(object sender, EventArgs e)
        {
            

            statusCollection = MongoHelper.GetStatusCollection();
            sampleCol = MongoHelper.GetSampleCollection();

            var findStatus = statusCollection.Find(s => s.Id == ObjectId.Parse(idStatus)).FirstOrDefault();
            var findSample = sampleCol.Find(s => s.IdStatus == ObjectId.Parse(idStatus)).FirstOrDefault();

           
            

            for (int i = 0; i < 12; i++)
            {
                btnAddRow_Click(sender, e);
            }
            if (findSample == null)
            {
                existSample = false;
            }
            else
            {
                idSample = findSample.Id.ToString();
                existSample = true;
                textBox1.Text = findSample.IdSam.ToString();
                textBox2.Text = findStatus.Address;
                textBox3.Text = findSample.Name;
                textBox4.Text = findStatus.Deadline.ToString();
                loadData(findSample);
                //find result of sample
                var resultCollection = MongoHelper.GetResultCollection();
                var findResult = resultCollection.Find(r => r.IdSample == findSample.Id).FirstOrDefault();
                loadResutl(findResult.ToBsonDocument());
            }
            var compareStandard = MongoHelper.GetCompareStandardCollection();
            var findCompareStandard = compareStandard.Find(_ => true).ToList();
            foreach (var item in findCompareStandard)
            {
                comboBox1.Items.Add(item.Name);
            }
        }
        private void loadData(Sample e)
        {
            BsonDocument document = e.ToBsonDocument();
            document.Remove("_id");
            document.Remove("Name");
            document.Remove("IdSam");
            document.Remove("IdStatus");
            Debug.WriteLine(document.ToString());
            var attributeNames = new List<string>(document.Names);
            for (int row = 1; row < attributeNames.Count + 1 && row < NhapthongsoPanel.RowCount; row++)
            {
                string attributeName = attributeNames[row - 1]; // row - 1 để truy cập đúng phần tử từ attributeNames

                // Lấy control ComboBox ở cột 1
                var columnNameControl = NhapthongsoPanel.GetControlFromPosition(1, row);
                if (columnNameControl is ComboBox comboBoxName)
                {
                    comboBoxName.Items.Clear(); // Xóa các mục cũ
                    comboBoxName.Items.Add(attributeName); // Thêm tên thuộc tính vào ComboBox
                    comboBoxName.SelectedIndex = 0; // Đặt thuộc tính hiện tại là thuộc tính đầu tiên
                }

                // Lấy control TextBox ở cột 3 và cập nhật giá trị
                var valueControl = NhapthongsoPanel.GetControlFromPosition(3, row);
                if (valueControl is TextBox textBoxValue && document.Contains(attributeName))
                {
                    textBoxValue.Text = document[attributeName].ToString();
                }
            }
        }

        private void compareFunction(String name)
        {
            var compareStandard = MongoHelper.GetCompareStandardCollection();
            var findCompareStandard = compareStandard.Find(c => c.Name == name).FirstOrDefault();

            sampleCol = MongoHelper.GetSampleCollection();
            var sort = Builders<Sample>.Sort.Descending("Id");
            var findSample = sampleCol.Find(_ => true).Sort(sort).Limit(1).FirstOrDefault();
            this.idSample = findSample.Id.ToString();


            var result = MongoHelper.GetDatabase().GetCollection<BsonDocument>("Result");
            var resultList = Process(findSample, findCompareStandard);

            var resultDocument = new BsonDocument
            {
                { "IdSample", findSample.Id },
                { "IdStatus", findSample.IdStatus },
            };
            foreach (var item in resultList)
            {
                resultDocument.Add(item.Key, item.Value);
            }
            result.InsertOne(resultDocument);
            loadResutl(resultDocument);
        }
        private void loadResutl(BsonDocument resultDocument)
        {
            //load result into column 5 of NhapthongsoPanel
            for (int row = 0; row < NhapthongsoPanel.RowCount; row++)
            {
                var columnNameControl = NhapthongsoPanel.GetControlFromPosition(1, row);
                string columnName = string.Empty;

                if (columnNameControl is ComboBox comboBoxName)
                {
                    columnName = comboBoxName.Text;
                }

                if (!string.IsNullOrEmpty(columnName))
                {
                    var resultValue = resultDocument.GetValue(columnName);
                    if (resultValue != null)
                    {
                        var resultControl = NhapthongsoPanel.GetControlFromPosition(4, row);
                        if (resultControl is TextBox textBoxResult)
                        {
                            textBoxResult.Text = resultValue.ToString();
                        }
                    }
                }
            }
        }
        public string calculate(List<double> data, double value)
        {
            var max = data[1];
            var min = data[0];
            if (value > max)
            {
                return $"Cao hơn {value - max}";
            }
            else if (value < min)
            {
                return $"Thấp hơn {min - value}";
            }
            return "Đạt chuẩn";
        }
        public Dictionary<string, string> Process(Sample sample, CompareStandard compareStandard)
        {
            var result = new Dictionary<string, string>();
            var comparisons = new Dictionary<string, Func<Sample, CompareStandard, string>>
            {
                {
                    "Turbidity",
                    (s, cs) => calculate(cs.Turbidity, s.Turbidity)
                },
                {
                    "PH",
                    (s, cs) => calculate(cs.PH, s.PH)
                },
                {
                    "TotalDissolvedSolids",
                    (s, cs) => calculate(cs.TotalDissolvedSolids, s.TotalDissolvedSolids)
                },
                {
                    "ColorDegree",
                    (s, cs) => calculate(cs.ColorDegree, s.ColorDegree)
                },
                {
                    "TotalSuspendedSolids",
                    (s, cs) => calculate(cs.TotalSuspendedSolids, s.TotalSuspendedSolids)
                },
                {
                    "BOD",
                    (s, cs) => calculate(cs.BOD, s.BOD)
                },
                {
                    "COD",
                    (s, cs) => calculate(cs.COD, s.COD)
                },
                {
                    "Ammonia",
                    (s, cs) => calculate(cs.Ammonia, s.Ammonia)
                },
                {
                    "TotalPhosphorus",
                    (s, cs) => calculate(cs.TotalPhosphorus, s.TotalPhosphorus)
                },
                {
                    "TotalNitrogen",
                    (s, cs) => calculate(cs.TotalNitrogen, s.TotalNitrogen)
                },
                {
                    "Sulfide",
                    (s, cs) => calculate(cs.Sulfide, s.Sulfide)
                },
                {
                    "TotalMineralOil",
                    (s, cs) => calculate(cs.TotalMineralOil, s.TotalMineralOil)
                },
            };
            foreach (var property in comparisons)
            {
                result.Add(property.Key, property.Value(sample, compareStandard));
            }
            return result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormPDF formPDF = new FormPDF();
            formPDF.setId(idSample);
            formPDF.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MongoDBChartApp form = new MongoDBChartApp();
            form.setId(idSample);
            form.Show();
        }
        private void updateStatus()
        {
            //update address, status, deadline, IdResult of status exist
            statusCollection = MongoHelper.GetStatusCollection();
            var resultCollection = MongoHelper.GetResultCollection();
            var resultId = resultCollection.Find(r => r.IdStatus == ObjectId.Parse(idStatus)).FirstOrDefault().Id;

            var filter = Builders<Status>.Filter.Eq("_id", ObjectId.Parse(idStatus));
            var update = Builders<Status>.Update
                .Set("TimeResult", DateTime.Now)
                .Set("Address", textBox2.Text)
                .Set("Deadline", textBox4.Text)
                .Set("stt", (DateTime.Parse(textBox4.Text)))
                .Set("IdResult", resultId);


            statusCollection.UpdateOne(filter, update);


        }

        private void HoSoKhachHangXuLyMau_Resize(object sender, EventArgs e)
        {
            ResizeFont(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            sampleCol = MongoHelper.GetSampleCollection();
            var findSample = sampleCol.Find(s => s.IdSam == int.Parse(textBox1.Text)).FirstOrDefault();
            if (findSample != null)
                MessageBox.Show("Mau da ton tai");
        }
    }
}