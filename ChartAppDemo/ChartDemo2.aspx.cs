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
    public partial class ChartDemo2 : System.Web.UI.Page
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


                // remove xAxiseValue and YAxisValue from the series of the chart before using below code

/*                // Specify the column name that contains values for X-Axis
                Chart1.Series["Series1"].XValueMember = "StudentName";
                // Specify the column name that contains values for Y-Axis
                Chart1.Series["Series1"].YValueMembers = "TotalMarks";*/
                // Set the datasource
                Chart1.DataSource = rdr;
                // Finally call DataBind()
                Chart1.DataBind();
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

            this.Chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(
                typeof(SeriesChartType), DropDownList1.SelectedValue);
        }
    }
}