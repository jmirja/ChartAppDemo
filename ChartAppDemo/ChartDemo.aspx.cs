using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace ChartAppDemo
{
    public partial class ChartDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Call Get ChartData() method in the PageLoad event
                GetChartData();
                GetChartTypes();
            }
        }

        private void GetChartData()
        {
            // Retrieve the Series to which we want to add DataPoints
            Series series = Chart1.Series["Series1"];
            // Add X and Y values using AddXY() method
            series.Points.AddXY("Mark", 800);
            series.Points.AddXY("Steve", 900);
            series.Points.AddXY("John", 700);
            series.Points.AddXY("Mary", 900);
            series.Points.AddXY("Ben", 600);
        }

        private void GetChartTypes()
        {
            foreach (int chartType in Enum.GetValues(typeof(SeriesChartType)))
            {
                ListItem li = new ListItem(Enum.GetName(typeof(SeriesChartType),
                    chartType), chartType.ToString());
                DropDownList1.Items.Add(li);
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Call Get ChartData() method when the user select a different chart type
            GetChartData();

            this.Chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(
                typeof(SeriesChartType), DropDownList1.SelectedValue);
        }
    }
}