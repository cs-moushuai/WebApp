using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.IO;

namespace WebApplication2
{
    public partial class Second : System.Web.UI.Page
    {
        string id;
        string name, psw, sex, age, like, img;
        string sqlUpdate;
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
                id = (String)dr[0].ToString().Trim();
            }
            conn.Close();
            name = TextBox1.Text;
            psw = TextBox2.Text;
            sex = RadioButtonList1.SelectedValue;
            age = TextBox3.Text;
            like = DropDownList1.SelectedValue;
            img = Image1.ImageUrl;
            sqlUpdate = $"UPDATE `user`"+
                        $" SET name = '{name}', psw = '{psw}', sex = '{sex}', age = '{age}', hobby = '{like}', imgUrl = '{img}'"+
                        $" WHERE iduser = {id}; ";
            sqlQuery = "SELECT * FROM user";
            comm = new MySqlCommand(sqlQuery, conn);
            conn.Open();
            dr = comm.ExecuteReader();
            while (dr.Read()) {
                id = (String)dr[0].ToString().Trim();
                string name2 = (String)dr[1].ToString().Trim();
                string psw2 = (String)dr[2].ToString().Trim();
                if (name2 == Session["userName"].ToString() && psw2 == Session["psw"].ToString()) { 
                    TextBox1.Text = name2;
                    TextBox2.Text = psw2;
                    RadioButtonList1.SelectedValue = (String)dr[3].ToString().Trim();
                    TextBox3.Text = (String)dr[4].ToString().Trim();
                    DropDownList1.SelectedValue = (String)dr[5].ToString().Trim();
                    Image1.ImageUrl = (String)dr[6].ToString().Trim();
                    break;
                }
            }
            conn.Close();
        }
        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void UploadFile(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("./Files/");

            //Check whether Directory (Folder) exists.
            if (!Directory.Exists(folderPath))
            {
                //If Directory (Folder) does not exists Create it.
                Directory.CreateDirectory(folderPath);
            }

            //Save the File to the Directory (Folder).
            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
            
            //Display the Picture in Image control.
            Image1.ImageUrl = "./Files/" + Path.GetFileName(FileUpload1.FileName);
            //LblInfo.Text = Path.GetFullPath(FileUpload1.FileName);
        }
        protected void UpdateBtn_Click(object sender, EventArgs e) {
            //读取的是旧的数据，是因为点击update后会刷新

            string connection = "Server=localhost;Uid=root;Database=homework;Port=3306;";
            MySqlConnection conn = new MySqlConnection(connection);
            
            //string sqlInsert = $"INSERT INTO user VALUES (NULL, '{name}', '{psw}', '{sex}', '{age}', '{like}', '{img}');";
            //LblInfo.Text = sqlUpdate;
            MySqlCommand comm = new MySqlCommand(sqlUpdate, conn);
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

            string strName = "用户名：" + name;
            string strPsw = "<br>密码：" + psw;
            string strSex = "<br>性别：" + sex;
            string strAge = "<br>年龄：" + age;
            string strLike = "<br>爱好：" + like;
            string strImg = "<br>照片：" + img;
            string strEnd = "<br>修改成功";
            LblInfo.Text = strName + strPsw + strSex + strAge + strLike + strImg + strEnd;
        }
        protected void QueryBtn_Click(object sender, EventArgs e) {
            string connection = "Server=localhost;Uid=root;Database=homework;Port=3306;";
            MySqlConnection conn = new MySqlConnection(connection);
            string sqlQuery = "SELECT * FROM user";
            MySqlCommand comm = new MySqlCommand(sqlQuery, conn);
            conn.Open();
            MySqlDataReader dr = comm.ExecuteReader();
            LblInfo.Text = "";
            while (dr.Read()) {
                /*
                string id2 = (String)dr[0].ToString().Trim();
                string name2 = (String)dr[1].ToString().Trim();
                string psw2 = (String)dr[2].ToString().Trim();
                string sex2 = (String)dr[3].ToString().Trim();
                string age2 = (String)dr[4].ToString().Trim();
                string hobby2 = (String)dr[5].ToString().Trim();
                string img2 = (String)dr[6].ToString().Trim();*/
                for (int i=0; i<6; i++) {
                    LblInfo.Text += $"{(String)dr[i].ToString().Trim()}, ";
                }
                LblInfo.Text += $"{(String)dr[6].ToString().Trim()}<br/>";
                //LblInfo.Text += $"{id2}, {name2}, {psw2}, {sex2}, {age2}, {hobby2}, {img2}";
            }
            conn.Close();

        }
    }
}