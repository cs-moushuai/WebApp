using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace WebApplication2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            Response.Write("<h1 align='center'>Hello World!!</h1>");
            
            int[] arr = new[] { 12, 23, 30, 6, 50, 11 };
            Caculator ca = new Caculator(arr);
            int max = ca.Max();
            int min = ca.Min();
            double avg = ca.Avg();
            Response.Write("<h1><a href='Second.aspx?Paras1="+max+"&Paras2="+avg+"'>二级页面</a></h1>");
            //Response.Write("<h1><a href='Second.aspx?Paras1=" + max + "'>二级页面</a></h1>");
            Response.Write("<h1>数据分析结果：最大值：" + max.ToString() + "最小值：" + min.ToString() + "</h1>");
            Response.Write("<h1>在线人数：" + int.Parse(Application["count"].ToString()) + "</h1>");*/
            Session["userName"] = NameTxt.Text.ToString();
            Session["psw"] = PswTxt.Text.ToString();
            

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
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
                    Response.Redirect("Second.aspx");
                    conn.Close();
                    return;
                }
            }
            conn.Close();
            Response.Write("<script>alert('用户名或密码错误，请先注册...')</script>");

        }
        protected void ExitBtn_Click(object sender, EventArgs e)
        {
            //Lblinfo.Text = NameTxt.Text.ToString();
            Response.Redirect("PageData.aspx");

        }
        protected void CountBtn_Click(object sender, EventArgs e)
        {
            int[] arr = new int[100];
            int num = 0;
            string s=InputData.Text;
            int ind=0;
            for (int i = 0; i < s.Length; i++) {
                if (s[i] == ',') {
                    arr[ind++] = num;
                    num = 0;
                } else if (s[i] == ' ') {
                } else {
                    num = num * 10 + s[i] - '0';
              
                }
            }
            arr[ind++] = num;
            int[] arr2 = new int[ind];
            for (int i = 0; i < ind; i++) {
                arr2[i] = arr[i];
            }
            Caculator ca = new Caculator(arr2);
            Result.Text = "Avg: " + ca.Avg().ToString() + " Sum: "+ca.Sum() + " Max: " + ca.Max() + " Min: " + ca.Min();

        }
    }
}