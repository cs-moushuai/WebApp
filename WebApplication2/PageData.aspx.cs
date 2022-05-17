using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using MySql.Data.MySqlClient;
using WebApplication2.AppCode;

namespace WebApplication2
{
    public partial class PageData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
        protected void RegBtn_Click(object sender, EventArgs e) {
            string name = TextBox1.Text;
            string psw = TextBox2.Text;
            string sex = RadioButtonList1.SelectedValue;
            string age = TextBox3.Text;
            string like = DropDownList1.SelectedValue;
            string img = Image1.ImageUrl;

            

            string sqlInsert = $"INSERT INTO user VALUES (NULL, '{name}', '{psw}', '{sex}', '{age}', '{like}', '{img}');";
            DataAccess da = new DataAccess();
            da.ChangeData(sqlInsert);
            string strName = "用户名：" + name;
            string strPsw = "<br>密码：" + psw;
            string strSex = "<br>性别：" + sex;
            string strAge = "<br>年龄：" + age;
            string strLike = "<br>爱好：" + like;
            string strImg = "<br>照片：" + img;
            string strEnd = "<br>注册成功";
            LblInfo.Text = strName + strPsw + strSex + strAge + strLike + strImg + strEnd;
            /*
            MySqlDataReader dr = comm.ExecuteReader();
            if (dr.Read()) {
                Data.Text = (String)dr[1].ToString().Trim();
                Data.Text += " " + (String)dr[2].ToString().Trim();
                Data.Text += " " + (String)dr[3].ToString().Trim();
                Data.Text += " " + (String)dr[4].ToString().Trim();
                Data.Text += " " + (String)dr[5].ToString().Trim();
                Data.Text += " " + (String)dr[6].ToString().Trim();
            }
            */
            //ImageButton1.ImageUrl = FileUpload1.PostedFile.ToString();
            //Console.WriteLine(LblInfo.Text);
        }
    }
}