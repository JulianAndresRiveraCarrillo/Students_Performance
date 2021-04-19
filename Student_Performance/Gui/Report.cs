using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Student_Performance.Model;

namespace Student_Performance.Gui
{
    public partial class Report : Form
    {
        private GraphManager gm;
        private int report;

        public Report(DataTable table, string at, int rep)
        {
            InitializeComponent();
            gm = new GraphManager();
            gm.generateGraph(table, at);
            report = rep;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            List<Student> info = gm.Info;

            switch (report)
            {
                case 1:
                    chart1.Titles[0].Text = "Percentage of Genders";
                    chart1.Series["Series1"].ChartType = SeriesChartType.Pie;
                    chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    for (int i = 0; i < info.Count; i++)
                    {
                        chart1.Series["Series1"].Points.AddXY(info[i].V1, info[i].V2);
                    }
                    break;

                case 2:
                    chart1.Titles[0].Text = "Percentage of Race/Ethnicity";
                    chart1.Series["Series1"].ChartType = SeriesChartType.Column;
                    chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    for (int i = 0; i < info.Count; i++)
                    {
                        chart1.Series["Series1"].Points.AddXY(info[i].V1, info[i].V2);
                    }
                   
                    break;

                case 3:
                    chart1.Titles[0].Text = "Percentage of Parental Level";
                    chart1.Series["Series1"].ChartType = SeriesChartType.Point;
                    chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    for (int i = 0; i < info.Count; i++)
                    {
                        chart1.Series["Series1"].Points.AddXY(info[i].V1, info[i].V2);
                    }

                    break;

                case 4:
                    chart1.Titles[0].Text = "Percentage of Lunch";
                    chart1.Series["Series1"].ChartType = SeriesChartType.Bar;
                    chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    for (int i = 0; i < info.Count; i++)
                    {
                        chart1.Series["Series1"].Points.AddXY(info[i].V1, info[i].V2);
                    }

                    break;

                case 5:
                    chart1.Titles[0].Text = "Percentage of Test Preparation ";
                    chart1.Series["Series1"].ChartType = SeriesChartType.Area;
                    chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    for (int i = 0; i < info.Count; i++)
                    {
                        chart1.Series["Series1"].Points.AddXY(info[i].V1, info[i].V2);
                    }

                    break;
            }
        }
    }
}
