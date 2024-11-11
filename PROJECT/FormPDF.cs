using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing.Text;
using System.Data;
using PROJECT.Model;

using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Borders;
using PdfWriter = iText.Kernel.Pdf.PdfWriter;
using PdfDocument = iText.Kernel.Pdf.PdfDocument;
using Document = iText.Layout.Document;
using PdfFont = iText.Kernel.Font.PdfFont;
using Paragraph = iText.Layout.Element.Paragraph;


using System;
using System.Windows.Forms;
using iText.Kernel.Pdf.Canvas;
using iText.IO.Font;
using PdfEncodings = iText.IO.Font.PdfEncodings;
using iText.StyledXmlParser.Jsoup.Nodes;
using iText.IO.Image;
using iText.Kernel.Pdf.Canvas.Draw;

using iTextImage = iText.Layout.Element.Image; 
using iTextHorizontalAlignment = iText.Layout.Properties.HorizontalAlignment;
using System.Diagnostics;
using PROJECT.Services;



namespace PROJECT
{
    public partial class FormPDF : Form
    {
        private IMongoDatabase _mongoDatabase;
        private string inputIdSample;
        private string inputId;
        private ObjectId user;

        private string GetStandardForField(string fieldName)
        {
            switch (fieldName)
            {
                case "Turbidity": return "TCVN 6185:2015 (C)";
                case "PH": return "TCVN 6492:2011";
                case "TotalDissolvedSolids": return "SMEWW 5520B&F:2023";
                case "ColorDegree": return "TCVN 6185:2015 (C)";
                case "BOD": return "TCVN 6001-1:2008";
                case "COD": return "SMEWW 5220C:2017";
                case "TotalMineralOil": return "SMEWW 5520B&F:2023";
                case "Sulfide": return "SMEWW 4500-S2.B&D:2017";
                case "Ammonia": return "TCVN 6179-1:1996";
                case "TotalNitrogen": return "SMEWW 4500-NO3.E:2017 TCVN 6202:2008";
                case "TotalSuspendedSolids": return "TCVN 6001-1:2008";
                default: return "TCVN 6202:2008";
            }
        }
        public void setId(string id)
        {
            this.inputId = id;
        }
        public void setIdUser(ObjectId id)
        {
            this.user = id;
        }

        public FormPDF()
        {
            InitializeComponent();
            string connectionString = "mongodb+srv://nxuandao1:52200294@cluster0.x11gh.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
            var client = new MongoClient(connectionString);
            _mongoDatabase = client.GetDatabase("FinalReportDatabase");
        }


        private void ExportToPdf()
        {
            try
            {
                //tạo tên file
                string filePath = "KetQuaThuNghiem.pdf";
                //tạo file pdf mới
                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);
                    //Tạo đường dẫn tương đối đến font chữ
                    string fontPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "DejaVuSans.ttf");
                    Debug.WriteLine(fontPath);

                    // Kiểm tra xem font có tồn tại không
                    if (!System.IO.File.Exists(fontPath))
                    {
                        MessageBox.Show("Không tìm thấy font DejaVuSans.ttf. Vui lòng kiểm tra lại đường dẫn.");
                        return;
                    }

                    // Sử dụng font DejaVuSans
                    PdfFont font = PdfFontFactory.CreateFont(fontPath, PdfEncodings.IDENTITY_H);
                    document.SetFont(font);

                    //Tạo đường đẫn dến file hình ảnh logo
                    string logoPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "logo.png");
                    Debug.WriteLine(logoPath);

                    if (!File.Exists(logoPath))
                    {
                        MessageBox.Show("Không tìm thấy logo. Vui lòng kiểm tra lại đường dẫn.");
                        return;
                    }

                    iTextImage logo = new iTextImage(ImageDataFactory.Create(logoPath)).SetWidth(150);
                    logo.SetHorizontalAlignment(iTextHorizontalAlignment.LEFT);


                    Paragraph companyName = new Paragraph("CÔNG TY TNHH GIẢI PHÁP MÔI TRƯỜNG ĐẠI NAM")
                        .SetFontSize(12)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER);

                    Paragraph detailName = new Paragraph("PHÒNG PHÂN TÍCH CHẤT LƯỢNG MÔI TRƯỜNG")
                       .SetFontSize(11)
                       .SetBold()
                       .SetTextAlignment(TextAlignment.CENTER);

                    Paragraph AddressName = new Paragraph("Đ/C: 144 Chu Văn An, P. 26, Q. Bình Thạnh, Tp. HCM")
                       .SetFontSize(10)
                       .SetBold()
                       .SetTextAlignment(TextAlignment.CENTER);

                    Paragraph aboutName = new Paragraph("ĐT: 028 6290 2086  \t Email: info@dainam-enviro.com")
                       .SetFontSize(9)
                       .SetBold()
                       .SetTextAlignment(TextAlignment.CENTER);

                    Table headerTable = new Table(2).UseAllAvailableWidth();

                    headerTable.AddCell(new Cell().Add(logo).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT));

                    Cell companyInfoCell = new Cell().SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.CENTER);
                    companyInfoCell.Add(companyName);
                    companyInfoCell.Add(detailName);
                    companyInfoCell.Add(AddressName);
                    companyInfoCell.Add(aboutName);

                    headerTable.AddCell(companyInfoCell);

                    document.Add(headerTable);




                    // Thêm đường gạch ngang dưới header
                    LineSeparator lineSeparator = new LineSeparator(new SolidLine());
                    document.Add(lineSeparator);


                    // Thêm tiêu đề PDF
                    Paragraph title = new Paragraph("\nKẾT QUẢ PHÂN TÍCH\n")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFontSize(18)
                        .SetBold();
                    document.Add(title);

                    // Thêm thông tin từ các label và textbox
                    document.Add(new Paragraph("Tên khách hàng: " + (tbCustomerName.Text ?? "N/A")));
                    document.Add(new Paragraph("Địa chỉ: " + (tbCustomerAddress.Text ?? "N/A")));
                    document.Add(new Paragraph("Địa chỉ lấy mẫu: " + (tbSampleAdress.Text ?? "N/A")));
                    document.Add(new Paragraph("Loại mẫu: " + (tbSampleType.Text ?? "N/A")));
                    document.Add(new Paragraph("Ngày lấy mẫu: " + (tbDateLayMau.Text ?? "N/A")));
                    document.Add(new Paragraph("Ngày phân tích: " + (tbDateThuNghiem.Text ?? "N/A")));

                    // Thêm khoảng cách giữa phần thông tin và bảng
                    document.Add(new Paragraph("\n"));

                    // Tạo bảng PDF với số cột tương ứng
                    Table table = new Table(new float[] { 1, 3, 2, 3, 2, 2 });
                    table.SetWidth(UnitValue.CreatePercentValue(100));

                    // Thêm tiêu đề các cột vào bảng
                    table.AddHeaderCell("TT");
                    table.AddHeaderCell("Chỉ tiêu phân tích");
                    table.AddHeaderCell("Đơn vị");
                    table.AddHeaderCell("Phương pháp phân tích");
                    table.AddHeaderCell("Số liệu mẫu");
                    table.AddHeaderCell("Kết quả");

                    // Duyệt qua các hàng của DataGridView và thêm vào bảng PDF
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow) continue; // Bỏ qua hàng mới

                        // Check for null and convert to string
                        table.AddCell(row.Cells[0].Value?.ToString() ?? "");  // Số thứ tự (TT)
                        table.AddCell(row.Cells[1].Value?.ToString() ?? "");  // Chỉ tiêu thử nghiệm
                        table.AddCell(row.Cells[2].Value?.ToString() ?? "");  // Đơn vị
                        table.AddCell(row.Cells[3].Value?.ToString() ?? "");  // Phương pháp thử nghiệm
                        table.AddCell(row.Cells[4].Value?.ToString() ?? "");  //Số liệu mẫu 
                        table.AddCell(row.Cells[5].Value?.ToString() ?? "");  // Kết quả

                    }

                    // Thêm bảng vào document PDF
                    document.Add(table);

                    document.Add(new Paragraph("\n"));
                    Paragraph note = new Paragraph("Ghi chú: \n")
                        .SetFontSize(11)
                        .SetBold()
                        .SetItalic()
                        .SetTextAlignment(TextAlignment.LEFT);
                    document.Add(note);

                    //Paragraph tbnote = new Paragraph(tbNote.Text ?? "N/A")
                    //    .SetFontSize(10)
                    //    .SetTextAlignment(TextAlignment.LEFT);
                    //document.Add(tbnote);



                    Paragraph dateexport = new Paragraph("Hồ Chí Minh, ngày \t tháng \t năm \t")
                        .SetFontSize(9)
                        .SetItalic()
                        .SetTextAlignment(TextAlignment.RIGHT);
                    document.Add(dateexport);

                    // Tạo các paragraph cho footer
                    Paragraph PPTCL = new Paragraph("P.PHÂN TÍCH CHẤT LƯỢNG")
                        .SetFontSize(10)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.LEFT);

                    Paragraph PKSCL = new Paragraph("P.KIỂM SOÁT CHẤT LƯỢNG")
                        .SetFontSize(10)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER);

                    Paragraph PTGD = new Paragraph("P.TỔNG GIÁM ĐỐC")
                        .SetFontSize(10)
                        .SetBold()
                        .SetTextAlignment(TextAlignment.CENTER);

                    // Tạo footerTable với 3 cột và thêm các ô vào footerTable
                    Table footerTable = new Table(3).UseAllAvailableWidth();
                    footerTable.AddCell(new Cell().Add(PPTCL).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT));
                    footerTable.AddCell(new Cell().Add(PKSCL).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT));
                    footerTable.AddCell(new Cell().Add(PTGD).SetBorder(Border.NO_BORDER).SetTextAlignment(TextAlignment.LEFT));

                    // Thêm footerTable vào document
                    document.Add(footerTable);




                    // Đóng file PDF
                    document.Close();
                }

                MessageBox.Show("PDF đã được tạo thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tạo PDF: " + ex.Message);
            }
        }



        private bool dataExistsStatusSampleID = false;

        //private void idSample_KeyDown(object sender, KeyEventArgs e)
        //{
        //    MessageBox.Show("");
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        string connectionString = "mongodb+srv://nxuandao1:52200294@cluster0.x11gh.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
        //        var client = new MongoClient(connectionString);
        //        _mongoDatabase = client.GetDatabase("FinalReportDatabase");
        //        string userInput = idSample.Text;
        //        inputIdSample = userInput;

        //        if (!string.IsNullOrEmpty(userInput))
        //        {
        //            try
        //            {
        //                // Convert userInput to ObjectId
        //                var objectId = new ObjectId(userInput);

        //                var collection = _mongoDatabase.GetCollection<BsonDocument>("Sample");
        //                var filter = Builders<BsonDocument>.Filter.Eq("_id", objectId);

        //                var document = collection.Find(filter).FirstOrDefault();

        //                if (document != null)
        //                {
        //                    dataExistsStatusSampleID = true;
        //                    FetchCustomerName();
        //                }
        //                else
        //                {
        //                    dataExistsStatusSampleID = false;
        //                    MessageBox.Show("No matching data found.");
        //                }
        //            }
        //            catch (FormatException)
        //            {
        //                MessageBox.Show("Invalid ObjectId format.");
        //            }
        //        }
        //    }
        //}

        private void tbCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataExistsStatusSampleID)
            {
                FetchCustomerName(); // Call the shared method here as well
            }
        }


        private void FetchCustomerName()
        {
            try
            {
                string connectionString = "mongodb+srv://nxuandao1:52200294@cluster0.x11gh.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0";
                var client = new MongoClient(connectionString);
                _mongoDatabase = client.GetDatabase("FinalReportDatabase");

                var ipIdSample = inputIdSample;

                if (string.IsNullOrEmpty(ipIdSample))
                {
                    MessageBox.Show("Please enter a valid sample ID.");
                    return;
                }

                var idSample = new ObjectId(ipIdSample);

                var sampleCollection = _mongoDatabase.GetCollection<BsonDocument>("Sample");
                var sampleFilter = Builders<BsonDocument>.Filter.Eq("_id", idSample);
                var sample = sampleCollection.Find(sampleFilter).FirstOrDefault();

                if (sample == null)
                {
                    MessageBox.Show("Sample data not found.");
                    return;
                }

                tbSampleType.Text = sample["Name"].AsString;



                dataGridView1.Rows.Clear();

                var resultCollection = _mongoDatabase.GetCollection<BsonDocument>("Result");
                var resultFilter = Builders<BsonDocument>.Filter.Eq("IdSample", idSample); // Liên kết với IdSample từ bảng Result
                var result = resultCollection.Find(resultFilter).FirstOrDefault();

                var customFieldNames = new Dictionary<string, string>
            {
                { "Turbidity", "Độ đục" },
                { "PH", "Độ PH" },
                { "TotalDissolvedSolids", "Tổng chất rắn hòa tan" },
                { "ColorDegree", "Màu sắc" },
                { "TotalSuspendedSolids", "Tổng chất rắn lơ lửng" },
                { "BOD", "Nhu cầu oxy sinh học (BOD)" },
                { "COD", "Nhu cầu oxy hóa học (COD)" },
                { "Ammonia", "Amoniac" },
                { "TotalPhosphorus", "Tổng phốt pho" },
                { "TotalNitrogen", "Tổng nitơ" },
                { "Sulfide", "Sulfide" },
                { "TotalMineralOil", "Tổng dầu khoáng" }
            };

                // Đếm số thứ tự
                int rowNumber = 1;

                // Lặp qua tất cả các trường trong document sample
                foreach (var element in sample.Elements)
                {
                    if (element.Name == "_id" || element.Name == "IdStatus" || element.Name == "Name" || element.Name == "IdSam")
                        continue;


                    string SampleValue = sample != null && sample.Contains(element.Name) ? Math.Round(Convert.ToDecimal(sample[element.Name]), 2).ToString() : "N/A";
                    //string SampleValue = sample != null && sample.Contains(element.Name) ? string.Format("{0:F2}", sample[element.Name]): "N/A";




                    string fieldName = customFieldNames.ContainsKey(element.Name) ? customFieldNames[element.Name] : element.Name;
                    string unit = element.Name == "PH" ? "-" : "mg/L";
                    if (element.Name == "Turbidity") unit = "Pt-Co";
                    string pptn = GetStandardForField(element.Name);

                    // Lấy giá trị từ bảng Result tương ứng
                    string resultValue = result != null && result.Contains(element.Name) ? result[element.Name].ToString() : "N/A";

                    dataGridView1.Rows.Add(
                        rowNumber.ToString(),
                        fieldName,
                        unit,
                        pptn,
                        SampleValue,
                        resultValue
                    );
                    rowNumber++;
                }

                if (result == null)
                {
                    MessageBox.Show("Result data not found.");
                }

                // Hàm để lấy tiêu chuẩn TCVN



                // Lấy IdStatus từ sample
                var idStatus = sample["IdStatus"].AsObjectId;

                var statusCollection = _mongoDatabase.GetCollection<BsonDocument>("Status");
                var statusFilter = Builders<BsonDocument>.Filter.Eq("_id", idStatus);
                var status = statusCollection.Find(statusFilter).FirstOrDefault();
                if (status == null)
                {
                    MessageBox.Show("Status data not found.");
                    return;
                }

                tbSampleAdress.Text = status["Address"].AsString;

                var getTimeField = status["GetTime"];
                if (getTimeField.IsBsonDateTime)
                {
                    var getTimeDate = getTimeField.ToUniversalTime();
                    tbDateLayMau.Text = getTimeDate.ToString("dd/MM/yyyy");
                }
                else if (getTimeField.IsString)
                {
                    tbDateLayMau.Text = getTimeField.AsString;
                }
                else
                {
                    MessageBox.Show("Invalid data for GetTime.");
                }

                var timeResultField = status["TimeResult"];
                if (timeResultField.IsBsonDateTime)
                {
                    var timeResultDate = timeResultField.ToUniversalTime();
                    tbDateThuNghiem.Text = timeResultDate.ToString("dd/MM/yyyy");
                }
                else if (timeResultField.IsString)
                {
                    tbDateThuNghiem.Text = timeResultField.AsString;
                }
                else
                {
                    MessageBox.Show("Invalid data for TimeResult.");
                }

                //var contractCollection = _mongoDatabase.GetCollection<BsonDocument>("Contract");
                //var contractFilter = Builders<BsonDocument>.Filter.Eq("IdStatus", idStatus);
                //var contract = contractCollection.Find(contractFilter).FirstOrDefault();
                //if (contract == null)
                //{
                //    MessageBox.Show("Contract data not found.");
                //    return;
                //}

                //var idContract = contract["_id"].AsObjectId;

                //var customerCollection = _mongoDatabase.GetCollection<BsonDocument>("Customers");
                //var customerFilter = Builders<BsonDocument>.Filter.Eq("IdContract", idContract);
                //var customer = customerCollection.Find(customerFilter).FirstOrDefault();

                //if (customer == null)
                //{
                //    MessageBox.Show("Customer data not found.");
                //    return;
                //}

                //tbCustomerName.Text = customer["Name"].AsString;
                //tbCustomerAddress.Text = customer["Address"].AsString;

                var SampleCollection = MongoHelper.GetSampleCollection();
                var ContractCollection = MongoHelper.GetContractCollection();
                var CustomerCollection = MongoHelper.GetCustomerCollection();
                var StatusCollection = MongoHelper.GetStatusCollection();

                var sampleData = SampleCollection.Find(_ => true).ToList();
                var contractData = ContractCollection.Find(_ => true).ToList();
                var statusData = StatusCollection.Find(_ => true).ToList();
                var customerData = CustomerCollection.Find(_ => true).ToList();

                var list = from s in sampleData
                           join st in statusData on s.IdStatus.ToString() equals st.Id.ToString()
                           join c in contractData on st.IdContract.ToString() equals c.Id.ToString()
                           join cu in customerData on c.IdCustomer.ToString() equals cu.Id.ToString()
                           where s.Id.ToString() == ipIdSample
                           select new
                           {
                               CustomerName = cu.Name,
                               CustomerAddress = cu.Address
                           };

                foreach (var item in list)
                {
                    tbCustomerName.Text = item.CustomerName;
                    tbCustomerAddress.Text = item.CustomerAddress;
                }

                //var contractCollection = _mongoDatabase.GetCollection<BsonDocument>("Contract");
                //var contractFilter = Builders<BsonDocument>.Filter.Eq("IdStatus", idStatus);
                //var contract = contractCollection.Find(contractFilter).FirstOrDefault();
                //if (contract == null)
                //{
                //    MessageBox.Show("Contract data not found.");
                //    return;
                //}

                //if (!contract.Contains("IdCustomer"))
                //{
                //    MessageBox.Show("IdCustomer not found in contract.");
                //    return;
                //}
                //var idCustomer = contract["IdCustomer"].AsObjectId;

                //var customerCollection = _mongoDatabase.GetCollection<BsonDocument>("Customers");
                //var customerFilter = Builders<BsonDocument>.Filter.Eq("_id", idCustomer);
                //var customer = customerCollection.Find(customerFilter).FirstOrDefault();

                //if (customer == null)
                //{
                //    MessageBox.Show("Customer data not found.");
                //    return;
                //}

                //// Hiển thị thông tin khách hàng
                //tbCustomerName.Text = customer["Name"].AsString;
                //tbCustomerAddress.Text = customer["Address"].AsString;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }



        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dataExistsStatusSampleID)
            {
                MessageBox.Show(inputIdSample);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            OperationServices.RecordExportReport(user);
            ExportToPdf();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string userInput = idSample.Text;
                inputIdSample = userInput;

                if (!string.IsNullOrEmpty(userInput))
                {
                    try
                    {
                        dataExistsStatusSampleID = true;
                        FetchCustomerName();
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Invalid ObjectId format.");
                    }
                }
            }
        }

        private void FormPDF_Load(object sender, EventArgs e)
        {
            idSample.Text = inputId;
            textBox1_KeyDown(sender, new KeyEventArgs(Keys.Enter));
        }
    }
}