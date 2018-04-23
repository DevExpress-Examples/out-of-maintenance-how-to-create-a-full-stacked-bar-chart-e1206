using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace Series_FullStackedBarChart {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl FullStackedBarChart = new ChartControl();

            // Create two full-stacked bar series.
            Series series1 = new Series("Series 1", ViewType.FullStackedBar);
            Series series2 = new Series("Series 2", ViewType.FullStackedBar);

            // Add points to them.
            series1.Points.Add(new SeriesPoint(1, 10));
            series1.Points.Add(new SeriesPoint(2, 12));
            series1.Points.Add(new SeriesPoint(3, 14));
            series1.Points.Add(new SeriesPoint(4, 17));

            series2.Points.Add(new SeriesPoint(1, 15));
            series2.Points.Add(new SeriesPoint(2, 18));
            series2.Points.Add(new SeriesPoint(3, 25));
            series2.Points.Add(new SeriesPoint(4, 33));

            // Add both series to the chart.
            FullStackedBarChart.Series.AddRange(new Series[] { series1, series2 });

            // Set the numerical argument scale types for the series,
            // as it is qualitative, by default.
            series1.ArgumentScaleType = ScaleType.Numerical;
            series2.ArgumentScaleType = ScaleType.Numerical;

            // Access the view-type-specific options of the series.
            ((FullStackedBarSeriesView)series1.View).BarWidth = 0.4;

            // Access the type-specific options of the diagram.
            ((XYDiagram)FullStackedBarChart.Diagram).Rotated = true;

            // Hide the legend (if necessary).
            FullStackedBarChart.Legend.Visible = false;

            // Add the chart to the form.
            FullStackedBarChart.Dock = DockStyle.Fill;
            this.Controls.Add(FullStackedBarChart);
        }
    }
}