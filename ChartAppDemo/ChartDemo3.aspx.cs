using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

namespace ChartAppDemo
{
    public partial class ChartDemo3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                GetChartData();
                GetChartTypes();
            }
        }

        private void GetChartData()
        {
            string cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("Select StudentName, TotalMarks from Students", con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                // Pass the datareader object that contains the chart data and
                // specify the column to be used for X-AXIS values. The other
                // column values will be automatically used for Y-AXIS
                Chart1.DataBindTable(rdr, "StudentName");
            }
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
            GetChartData();
            // Retrieve the series by index and then
            // set the ChartType property value
            this.Chart1.Series[0].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), DropDownList1.SelectedValue);

            // Alternatively, FirstOrDefault() linq method can also be used


            // this.Chart1.Series.FirstOrDefault().ChartType = (SeriesChartType)
            // Enum.Parse(typeof(SeriesChartType), DropDownList1.SelectedValue);
        }
    }
}