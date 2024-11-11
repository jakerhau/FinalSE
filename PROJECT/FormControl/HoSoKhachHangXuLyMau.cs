using MongoDB.Bson;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Driver;
using PROJECT.Model;
using PROJECT.Services;
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
        private ObjectId idUser;
        private Main1 main;
        private IMongoCollection<BsonDocument> sampleCollection;
        private IMongoCollection<Status> statusCollection = MongoHelper.GetStatusCollection();
        private IMongoCollection<Sample> sampleCol = MongoHelper.GetSampleCollection();
        private IMongoCollection<CompareStandard> compareCol = MongoHelper.GetCompareStandardCollection();
        private string idSample;
        private bool existSample;

        public HoSoKhachHangXuLyMau(ObjectId id)
        {
            this.idUser = id;
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
                        donvi.Items.AddRange(new object[] { "mg/L" }); // Đơn vị cho Total Dissolved Solids
                        break;
                    case "ColorDegree":
                        donvi.Items.AddRange(new object[] { "Unit" }); // Đơn vị cho Color Degree
                        break;
                    case "TotalSuspendedSolids":
                        donvi.Items.AddRange(new object[] { "mg/L" }); // Đơn vị cho Total Suspended Solids
                        break;
                    case "BOD":
                        donvi.Items.AddRange(new object[] { "mg/L" }); // Đơn vị cho BOD
                        break;
                    case "COD":
                        donvi.Items.AddRange(new object[] { "mg/L" }); // Đơn vị cho COD
                        break;
                    case "Ammonia":
                        donvi.Items.AddRange(new object[] { "mg/L" }); // Đơn vị cho Ammonia
                        break;
                    case "TotalPhosphorus":
                        donvi.Items.AddRange(new object[] { "mg/L" }); // Đơn vị cho Total Phosphorus
                        break;
                    case "TotalNitrogen":
                        donvi.Items.AddRange(new object[] { "mg/L" }); // Đơn vị cho Total Nitrogen
                        break;
                    case "Sulfide":
                        donvi.Items.AddRange(new object[] { "mg/L" }); // Đơn vị cho Sulfide
                        break;
                    case "TotalMineralOil":
                        donvi.Items.AddRange(new object[] { "mg/L" }); // Đơn vị cho Total Mineral Oil
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
            toida.KeyPress += (s, args) =>
            {
                // Kiểm tra nếu ký tự nhập không phải là số hoặc không phải là dấu chấm
                if (!char.IsControl(args.KeyChar) && !char.IsDigit(args.KeyChar) && args.KeyChar != '.')
                {
                    args.Handled = true; // Ngăn chặn ký tự không hợp lệ
                }
                // Ngăn chặn nhập nhiều dấu chấm
                if (args.KeyChar == '.' && ((TextBox)s).Text.Contains("."))
                {
                    args.Handled = true;
                }
            };
            toida.Leave += (s, args) =>
            {
                if (!string.IsNullOrWhiteSpace(toida.Text) && !decimal.TryParse(toida.Text, out _))
                {
                    MessageBox.Show("Vui lòng nhập một số hợp lệ.");
                    toida.Focus(); 
                }
            };
            TextBox ketqua = new TextBox { Dock = DockStyle.Fill };
            // Tạo CheckBox cho cột 5 và cột 6 thay vì ComboBox loaiMau
            CheckBox loaiMauThucDia = new CheckBox { Dock = DockStyle.Fill, CheckAlign = ContentAlignment.MiddleCenter };
            CheckBox loaiMauPhongThi = new CheckBox { Dock = DockStyle.Fill, CheckAlign = ContentAlignment.MiddleCenter };

            loaiMauThucDia.CheckedChanged += (sender, e) =>
            {
                if (loaiMauThucDia.Checked)
                {
                    loaiMauPhongThi.Checked = false; // Bỏ chọn loaiMauPhongThi nếu loaiMauThucDia được chọn
                }
            };

            // Sự kiện khi loaiMauPhongThi thay đổi trạng thái
            loaiMauPhongThi.CheckedChanged += (sender, e) =>
            {
                if (loaiMauPhongThi.Checked)
                {
                    loaiMauThucDia.Checked = false; // Bỏ chọn loaiMauThucDia nếu loaiMauPhongThi được chọn
                }
            };


            // Thêm các control vào các cột của hàng mới
            NhapthongsoPanel.Controls.Add(chk, 0, NhapthongsoPanel.RowCount - 2);
            NhapthongsoPanel.Controls.Add(tenchitieu, 1, NhapthongsoPanel.RowCount - 2);
            NhapthongsoPanel.Controls.Add(donvi, 2, NhapthongsoPanel.RowCount - 2);
            NhapthongsoPanel.Controls.Add(toida, 3, NhapthongsoPanel.RowCount - 2);
            NhapthongsoPanel.Controls.Add(loaiMauThucDia, 4, NhapthongsoPanel.RowCount - 2); // Thêm CheckBox cho cột 5
            NhapthongsoPanel.Controls.Add(loaiMauPhongThi, 5, NhapthongsoPanel.RowCount - 2); // Thêm CheckBox cho cột 6
            NhapthongsoPanel.Controls.Add(ketqua, 6, NhapthongsoPanel.RowCount - 2);

            // Di chuyển nút thêm hàng xuống cuối bảng
            NhapthongsoPanel.Controls.Add(btnAddRow, 0, NhapthongsoPanel.RowCount - 1);

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
            try
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
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
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
            if (!ValidateSampleTypes())
            {
                return;
            }
            else
            {
                OperationServices.RecordInputTime(idUser);
                newSample();
                compareFunction(comboBox1.Text);
                updateStatus();
                saveSampleType();
            }
        }
        private bool ValidateSampleTypes()
        {
            foreach (Control control in NhapthongsoPanel.Controls)
            {
                if (NhapthongsoPanel.GetColumn(control) == 1 && control is ComboBox tenchitieu && tenchitieu.SelectedItem != null)
                {
                    var loaiMauThucDia = NhapthongsoPanel.GetControlFromPosition(4, NhapthongsoPanel.GetRow(control)) as CheckBox;
                    var loaiMauPhongThi = NhapthongsoPanel.GetControlFromPosition(5, NhapthongsoPanel.GetRow(control)) as CheckBox;

                    // Kiểm tra nếu cả hai checkbox đều không được chọn
                    if (loaiMauThucDia?.Checked == false && loaiMauPhongThi?.Checked == false)
                    {
                        string chiTieu = tenchitieu.SelectedItem.ToString();
                        MessageBox.Show($"Vui lòng chọn loại mẫu cho chỉ tiêu '{chiTieu}'.");
                        return false; // Trả về false nếu chưa chọn loại mẫu
                    }
                }
            }
            //kiểm tra 3 cái textbox và 1 cái combobox có trống không
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return false;
            }
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tiêu chuẩn so sánh");
                return false;
            }
            return true; // Trả về true nếu tất cả đều đã chọn loại mẫu
        }
        private void saveSampleType()
        {
            try
            {
                if (!ObjectId.TryParse(idSample, out var objectId))
                {
                    MessageBox.Show("Invalid IdSample format.");
                    return;
                }

                var sampleTypeDocument = new BsonDocument
                {
                    {"IdSample", objectId}
                };

                foreach (Control control in NhapthongsoPanel.Controls)
                {
                    if (NhapthongsoPanel.GetColumn(control) == 1 && control is ComboBox tenchitieu && tenchitieu.SelectedItem != null)
                    {
                        string chiTieu = tenchitieu.SelectedItem.ToString();
                        Debug.WriteLine("Chỉ tiêu: " + chiTieu);

                        var loaiMauThucDia = NhapthongsoPanel.GetControlFromPosition(4, NhapthongsoPanel.GetRow(control)) as CheckBox;
                        var loaiMauPhongThi = NhapthongsoPanel.GetControlFromPosition(5, NhapthongsoPanel.GetRow(control)) as CheckBox;

                        string sampleType = loaiMauThucDia?.Checked == true ? "TD" : loaiMauPhongThi?.Checked == true ? "PTN" : null;

                        if (sampleType != null)
                        {
                            sampleTypeDocument.Add(chiTieu, sampleType);
                        }
                    }
                }

                var sampleTypeCollection = MongoHelper.GetCollection<BsonDocument>("SampleType");
                if (sampleTypeCollection == null)
                {
                    Debug.WriteLine("Failed to connect to the collection.");
                }
                else
                {
                    Debug.WriteLine("Successfully connected to the collection.");
                }

                var filter = new BsonDocument("IdSample", objectId);
                var update = new BsonDocument
                {
                    {"$set", sampleTypeDocument}
                };
                var result = sampleTypeCollection.UpdateOne(filter, update, new UpdateOptions { IsUpsert = true });
                //show result
                Debug.WriteLine("Save" + (result.IsAcknowledged ? " success" : " failed"));

                if (result.IsAcknowledged)
                {
                    if (result.ModifiedCount > 0)
                    {
                        Debug.WriteLine("Sample type data updated successfully.");
                    }
                    else if (result.UpsertedId != null)
                    {
                        Debug.WriteLine("Sample type data inserted successfully.");
                    }
                    else
                    {
                        Debug.WriteLine("Sample type data was not modified.");
                    }
                }
                else
                {
                    MessageBox.Show("Failed to save sample type data: Operation not acknowledged.");
                }
            }
            catch (MongoWriteException ex)
            {
                Debug.WriteLine("MongoDB write error: " + ex.Message);
                MessageBox.Show("Error saving sample type data: " + ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Unexpected error: " + ex.Message);
                MessageBox.Show("Unexpected error: " + ex.Message);
            }
        }
        //private void updateSample(string id)
        //{
        //    try
        //    {
        //        var findSample = sampleCol.Find(s => s.Id == ObjectId.Parse(id)).FirstOrDefault();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Mẫu không tồn tại" + ex);
        //    }
        //    var document = new BsonDocument();
        //    for (int row = 0; row < NhapthongsoPanel.RowCount; row++)
        //    {
        //        var checkBoxControl = NhapthongsoPanel.GetControlFromPosition(0, row) as CheckBox;
        //        if (checkBoxControl == null || !checkBoxControl.Checked)
        //            continue;

        //        // Lấy tên trường từ cột 1
        //        var columnNameControl = NhapthongsoPanel.GetControlFromPosition(1, row);
        //        string columnName = string.Empty;

        //        if (columnNameControl is ComboBox comboBoxName)
        //        {
        //            columnName = comboBoxName.Text;
        //        }

        //        var dataControl = NhapthongsoPanel.GetControlFromPosition(3, row);
        //        string dataValue = string.Empty;

        //        if (dataControl is TextBox textBoxData)
        //        {
        //            dataValue = textBoxData.Text;
        //        }

        //        if (!string.IsNullOrEmpty(columnName))
        //        {
        //            document.Add(columnName, double.TryParse(dataValue, out double number) ? number : 0);
        //        }
        //    }
        //    try
        //    {
        //        sampleCol.UpdateOne(s => s.Id == ObjectId.Parse(id), new BsonDocument("$set", document));
        //        MessageBox.Show("Cập nhật mẫu thành công");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(Text = "Cập nhật mẫu thất bại" + ex.Message);
        //    }
        //}
        private void updateSample()
        {
            var findSample = sampleCol.Find(s => s.Id == ObjectId.Parse(idSample)).FirstOrDefault();
            if (findSample == null)
            {
                MessageBox.Show("Mẫu không tồn tại");
                return;
            }
            var updates = new List<UpdateDefinition<Sample>>();
            for (int row = 0; row < NhapthongsoPanel.RowCount; row++)
            {
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

                if (!string.IsNullOrEmpty(columnName))
                {
                    if (double.TryParse(dataValue, out double number))
                    {
                        var update = Builders<Sample>.Update.Set(columnName, number);
                        updates.Add(update);
                    }
                    else
                    {
                        MessageBox.Show($"Giá trị của {columnName} không hợp lệ.");
                    }
                }
            }
            if (updates.Count > 0)
            {
                var combineUpdate = Builders<Sample>.Update.Combine(updates);
                sampleCol.UpdateOne(s => s.Id == ObjectId.Parse(idSample), combineUpdate);
                MessageBox.Show("Cập nhật mẫu thành công");
            } else
            {
                MessageBox.Show("Không có dữ liệu để cập nhật");
            }
        }
        private void newSample()
        {
            sampleCollection = MongoHelper.GetDatabase().GetCollection<BsonDocument>("Sample");
            if (existSample)
            {
                updateSample();
                return;
            }
            var document = new BsonDocument {
                { "IdStatus", ObjectId.Parse(idStatus)},
                { "Name", textBox3.Text },
                { "IdSam", int.TryParse(textBox1.Text, out int num) ? num : 0},
            };



            for (int row = 0; row < NhapthongsoPanel.RowCount; row++)
            {
                var checkBoxControl = NhapthongsoPanel.GetControlFromPosition(0, row) as CheckBox;
                if (checkBoxControl == null || !checkBoxControl.Checked)
                    continue;
                                            
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
            var findCompare = compareCol.Find(c => c.Id == findStatus.IdCompare).FirstOrDefault();



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
                loadData(findSample.Id.ToString());
                loadSampleType(findSample.Id.ToString());
                comboBox1.Text = findCompare.Name;
                var resultCollection = MongoHelper.GetResultCollection();
                var findResult = resultCollection.Find(r => r.IdSample == findSample.Id).FirstOrDefault();
                if (findResult != null)
                    loadResutl(findResult.ToBsonDocument());
            }
            var compareStandard = MongoHelper.GetCompareStandardCollection();
            var findCompareStandard = compareStandard.Find(_ => true).ToList();
            foreach (var item in findCompareStandard)
            {
                comboBox1.Items.Add(item.Name);
            }
        }

        private void loadSampleType(string v)
        {
            var collection = MongoHelper.GetDatabase().GetCollection<BsonDocument>("SampleType");

            if (ObjectId.TryParse(v, out var id))
            {
                Debug.WriteLine($"Searching for document with IdSample: {id}");
                var document = collection.Find(new BsonDocument("IdSample", id)).FirstOrDefault();

                if (document != null)
                {
                    foreach (Control control in NhapthongsoPanel.Controls)
                    {
                        if (NhapthongsoPanel.GetColumn(control) == 1 && control is ComboBox tenchitieu && tenchitieu.SelectedItem != null)
                        {
                            string chiTieu = tenchitieu.SelectedItem.ToString();
                            if (document.Contains(chiTieu))
                            {
                                string sampleType = document[chiTieu].AsString;
                                var checkboxColumn6 = NhapthongsoPanel.GetControlFromPosition(5, NhapthongsoPanel.GetRow(control)) as CheckBox;
                                var checkboxColumn5 = NhapthongsoPanel.GetControlFromPosition(4, NhapthongsoPanel.GetRow(control)) as CheckBox;

                                if (sampleType == "PTN")
                                {
                                    checkboxColumn6.Checked = true;
                                }
                                else
                                {
                                    checkboxColumn5.Checked = true;
                                }
                            }
                            else
                            {
                                Debug.WriteLine($"Field '{chiTieu}' not found in document.");
                            }
                        }
                    }
                }
                else
                {
                    Debug.WriteLine("Document not found for IdSample.");
                }
            }
            else
            {
                Debug.WriteLine("Invalid ObjectId format.");
            }
        }

        private void loadData(String e)
        {
            var collection = MongoHelper.GetDatabase().GetCollection<BsonDocument>("Sample");

            var document = collection.Find(new BsonDocument("_id", ObjectId.Parse(e))).FirstOrDefault();
            if (document != null)
            {
                document.Remove("_id");
                document.Remove("Name");
                document.Remove("IdSam");
                document.Remove("IdStatus");

                var unitsDictionary = new Dictionary<string, string>
                {
                    { "Turbidity", "NTU" },
                    { "PH", "pH" },
                    { "TotalDissolvedSolids", "mg/L" },
                    { "ColorDegree", "Unit" },
                    { "TotalSuspendedSolids", "mg/L" },
                    { "BOD", "mg/L" },
                    { "COD", "mg/L" },
                    { "Ammonia", "mg/L" },
                    { "TotalPhosphorus", "mg/L" },
                    { "TotalNitrogen", "mg/L" },
                    { "Sulfide", "mg/L" },
                    { "TotalMineralOil", "mg/L" }
                };

                int row = 1;
                foreach (var attribute in document)
                {
                    string attributeName = attribute.Name;

                    if (!unitsDictionary.ContainsKey(attributeName))
                        continue;
                    var checkBoxControl = NhapthongsoPanel.GetControlFromPosition(0, row);
                    if (checkBoxControl is CheckBox checkBox)
                    {
                        checkBox.Checked = true;
                    }
                    var columnNameControl = NhapthongsoPanel.GetControlFromPosition(1, row);
                    if (columnNameControl is ComboBox comboBoxName)
                    {
                        comboBoxName.Items.Clear();
                        comboBoxName.Items.Add(attributeName);
                        comboBoxName.SelectedIndex = 0;
                    }

                    var unitControl = NhapthongsoPanel.GetControlFromPosition(2, row);
                    if (unitControl is ComboBox comboBoxUnit)
                    {
                        comboBoxUnit.Items.Clear();
                        comboBoxUnit.Items.Add(unitsDictionary[attributeName]);
                        comboBoxUnit.SelectedIndex = 0;
                    }

                    var valueControl = NhapthongsoPanel.GetControlFromPosition(3, row);
                    if (valueControl is TextBox textBoxValue)
                    {
                        textBoxValue.Text = attribute.Value.ToString();
                    }

                    row++;
                }
            }
            else
            {
                Debug.WriteLine("Không tìm thấy tài liệu với _id tương ứng.");
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
            var filter = Builders<BsonDocument>.Filter.Eq("IdSample", findSample.Id);
            var resultExist = result.Find(filter).FirstOrDefault();
            if (resultExist != null)
            {
                var updateDefinition = new BsonDocument("$set", resultDocument);
                result.UpdateOne(filter, updateDefinition);
                MessageBox.Show("Result data updated successfully.");
            } else
            {
                result.InsertOne(resultDocument);
                MessageBox.Show("Result data saved successfully.");
            }
            try
            {
                loadResutl(resultDocument);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        private void loadResutl(BsonDocument resultDocument)
        {
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
                    try
                    {
                        var resultValue = resultDocument.GetValue(columnName);
                        if (resultValue != null)
                        {
                            var resultControl = NhapthongsoPanel.GetControlFromPosition(6, row);
                            if (resultControl is TextBox textBoxResult)
                            {
                                textBoxResult.Text = resultValue.ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine(ex.Message);
                    }
                }
            }
        }
        public string calculate(List<double> data, double value)
        {
            if (data == null || data.Count < 2)
            {
                return "Đạt chuẩn";
            }
            try
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
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return "Lỗi";
            }
        }
        public Dictionary<string, string> Process(Sample sample, CompareStandard compareStandard)
        {
            var result = new Dictionary<string, string>();
            if (compareStandard == null)
            {
                return result;
            }
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
            formPDF.setIdUser(idUser);
            formPDF.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MongoDBChartApp form = new MongoDBChartApp(idSample);
            form.Show();
        }
        private void updateStatus()
        {
            //update address, status, deadline, IdResult of status exist
            statusCollection = MongoHelper.GetStatusCollection();
            var resultCollection = MongoHelper.GetResultCollection();
            var result = resultCollection.Find(r => r.IdStatus == ObjectId.Parse(idStatus)).FirstOrDefault();
            if (result == null)
            {
                Debug.WriteLine("Result not found");
                return;
            }
            var resultId = result.Id;
            var filter = Builders<Status>.Filter.Eq("_id", ObjectId.Parse(idStatus));
            var update = Builders<Status>.Update
                .Set("IdCompare", findCompareId())
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
            try
            {
                sampleCol = MongoHelper.GetSampleCollection();
                int idSam = int.Parse(textBox1.Text); // Chuyển đổi chuỗi thành số nguyên

                var findSample = sampleCol.Find(s => s.IdSam == idSam).FirstOrDefault();

                if (findSample != null && !existSample)
                {
                    MessageBox.Show("Mẫu đã tồn tại");
                }
            }
            catch (FormatException)
            {

                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
            {
                try
                {
                    DateTime.Parse(textBox4.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Không đúng định dạng mm/dd/yy");
                }
            }

        }
        private ObjectId findCompareId()
        {
            var findCompareStandard = compareCol.Find(c => c.Name == comboBox1.Text).FirstOrDefault();
            if (findCompareStandard == null)
            {
                MessageBox.Show("Không tìm thấy chuẩn so sánh");
                return ObjectId.Empty;
            }
            return findCompareStandard.Id;
        }
    }
}