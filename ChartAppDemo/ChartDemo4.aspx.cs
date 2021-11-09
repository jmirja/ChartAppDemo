using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChartAppDemo
{
    public partial class ChartDemo4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            // Read the data from XML file into DataSet
            ds.ReadXml(Server.MapPath("~/Students.xml"));

            // Specify the column that contains values for X-AXIS
            Chart1.Series["Series1"].XValueMember = "StudentName";
            // Specify the column that contains values for Y-AXIS
            Chart1.Series["Series1"].YValueMembers = "TotalMarks";
            // Set DataSet as the DataSource for the Chart control

            Chart1.DataSource = ds;
            // Finally call DataBind
            Chart1.DataBind();
        }
    }
}