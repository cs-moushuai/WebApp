using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;
using WebApp.AppCode;

namespace WebApp
{
    public partial class ShowAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            string cmd = "SELECT * FROM user";
            DataTable dt = da.QueryData(cmd);
            EmployeeInfo.DataSource = dt;
            EmployeeInfo.DataBind();
        }
        /*
        protected void Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            string deparment_id = DepartmentDDL.SelectedValue;
            DataAccess da = new DataAccess();
            string cmd = $"SELECT * FROM user WHERE department_id = {deparment_id}";
            DataTable dt = da.QueryData(cmd);
            DepartmentInfo.DataSource = dt;
            DepartmentInfo.DataBind();
        }*/
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            EmployeeInfo.PageIndex = e.NewPageIndex;
        }
    }
}