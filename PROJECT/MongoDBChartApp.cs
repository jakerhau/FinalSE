using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PROJECT
{
    public partial class MongoDBChartApp : Form
    {
        private IMongoCollection<BsonDocument>? collectionStandard;
        private IMongoCollection<BsonDocument>? collectionSample;
        private BsonDocument? standardDocument;
        private ListBox sampleListBox;

        private string idSample;

        public MongoDBChartApp()
        {
            InitializeComponent();
            InitializeMongoDB();
            LoadStandardDocument();

            // Initialize sampleListBox

            LoadSampleList();
        }
        public void setId(string idSample)
        {
            this.idSample = idSample;
        }

        private void InitializeMongoDB()
        {
            var client = new MongoClient("mongodb+srv://nxuandao1:52200294@cluster0.x11gh.mongodb.net/?retryWrites=true&w=majority&appName=Cluster0");
            var database = client.GetDatabase("FinalReportDatabase");
            collectionStandard = database.GetCollection<BsonDocument>("CompareStandard");
            collectionSample = database.GetCollection<BsonDocument>("Sample");
        }

        private void LoadStandardDocument()
        {
            standardDocument = collectionStandard?.Find(new BsonDocument()).FirstOrDefault();
        }

        private void LoadSampleList()
        {
            var sampleDocuments = collectionSample?.Find(new BsonDocument()).ToList();
            if (sampleDocuments != null)
            {
                foreach (var sample in sampleDocuments)
                {
                    string sampleName = sample.Contains("_id") ? sample["_id"].AsObjectId.ToString() : "Unnamed Sample";
                    sampleListBox.Items.Add(sampleName);
                }
                sampleListBox.SelectedIndexChanged += SampleListBox_SelectedIndexChanged;
            }
        }


        private void SampleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            chart1.Series.Clear();

            if (ObjectId.TryParse(sampleListBox.SelectedItem.ToString(), out ObjectId selectedSampleId))
            {
                var sampleDocument = collectionSample?.Find(new BsonDocument { { "_id", selectedSampleId } }).FirstOrDefault();

                if (standardDocument != null && sampleDocument != null)
                {
                    PlotComparisonChart(standardDocument, sampleDocument);
                }
            }
        }

        private void PlotComparisonChart(BsonDocument standardDoc, BsonDocument sampleDoc)
        {
            //Khai báo tên biểu đồ
            string chartAreaName = "ComparisonArea";

            //kiểm tra coi tên biểu đồ đã được sử dụng chưa
            if (chart1.ChartAreas.IndexOf(chartAreaName) == -1)
            {
                var chartArea = new ChartArea(chartAreaName);
                chart1.ChartAreas.Add(chartArea);
            }


            var seriesStandard = new Series("Standard Values")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Pink,
                IsValueShownAsLabel = true,
                CustomProperties = "PointWidth=0.6"
            };

            var seriesSample = new Series("Sample Values")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.Blue,
                IsValueShownAsLabel = true,
                CustomProperties = "PointWidth=0.6"
            };

            //kiểm tra rồi thêm các chart sample hay compare nếu nó chưa có
            if (!chart1.Series.Contains(seriesStandard))
            {
                chart1.Series.Add(seriesStandard);
            }

            if (!chart1.Series.Contains(seriesSample))
            {
                chart1.Series.Add(seriesSample);
            }

            //lưu trữ vị trí của các cột
            int index = 0;

            //duyệt các phần tử trong compare
            foreach (var element in standardDoc.Elements)
            {
                string label = element.Name;

                double? standardValue = null;
                if (standardDoc[element.Name].IsBsonArray)
                {
                    standardValue = standardDoc[element.Name].AsBsonArray[1].ToDouble();
                }
                else if (standardDoc[element.Name].IsDouble)
                {
                    standardValue = standardDoc[element.Name].ToDouble();
                }

                double? sampleValue = null;
                if (sampleDoc.Contains(label))
                {
                    if (sampleDoc[label].IsDouble)
                    {
                        sampleValue = sampleDoc[label].ToDouble();
                    }
                }

                if (standardValue.HasValue)
                {
                    DataPoint point = new DataPoint(index, standardValue.Value);
                    point.AxisLabel = label;
                    seriesStandard.Points.Add(point);
                }

                if (sampleValue.HasValue)
                {
                    DataPoint point = new DataPoint(index + 0.3, sampleValue.Value);
                    point.AxisLabel = label;
                    seriesSample.Points.Add(point);
                }

                index++;
            }

            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;

            chart1.ChartAreas[0].AxisX.IntervalAutoMode = IntervalAutoMode.FixedCount;
            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;

            chart1.Legends[0].Docking = Docking.Top;

            chart1.ChartAreas[0].AxisX.IsMarginVisible = true;
        }
    }
}
