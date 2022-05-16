using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication2
{
    public partial class Second : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            string paras1 = Request.QueryString["Paras1"].ToString();
            Response.Write("接受到参数：" + paras1);
            string paras2 = Request.QueryString["Paras2"].ToString();
            Response.Write("接受到参数：" + paras2);*/
            //Response.Write("UserName: "+Session["userName"]+"\n");
            //Response.Write("Psw:" + Session["psw"]);
            string connection = "Server=localhost;Uid=root;Database=homework;Port=3306;";
            MySqlConnection conn = new MySqlConnection(connection);
            string sqlQuery = "SELECT * FROM user";
            MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
            conn.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            while (dr.Read()) {
                string name = (String)dr[1].ToString().Trim();
                string psw = (String)dr[2].ToString().Trim();
                if (name == Session["userName"].ToString() && psw == Session["psw"].ToString()) { 
                    Data.Text = "用户名：" + name;
                    Data.Text += "<br>密码：" + psw;
                    Data.Text += "<br>性别：" + (String)dr[3].ToString().Trim();
                    Data.Text += "<br>年龄：" + (String)dr[4].ToString().Trim();
                    Data.Text += "<br>爱好：" + (String)dr[5].ToString().Trim();
                    Data.Text += "<br>照片：";
                    Image1.ImageUrl = (String)dr[6].ToString().Trim();
                    break;
                }
            }
            conn.Close();
        }
    }
}