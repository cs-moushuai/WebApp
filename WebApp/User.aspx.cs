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
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccess da = new DataAccess();
            string cmd = "SELECT * FROM department";
            DataTable dt = da.QueryData(cmd);
            DepartmentDDL.DataSource = dt;
            DepartmentDDL.DataTextField = "name";
            DepartmentDDL.DataValueField = "id";
            DepartmentDDL.DataBind();
            if (NameTxt.Text != "") return;
            string sqlQuery = "SELECT * FROM user";
            dt = da.QueryData(sqlQuery);
            foreach (DataRow dr in dt.Rows) {
                string id = (String)dr[0].ToString().Trim();
                if (id == Session["id"].ToString()) { 
                    NameTxt.Text = (String)dr[1].ToString().Trim();
                    PswTxt.Text = (String)dr[2].ToString().Trim();
                    SexRL.SelectedValue = (String)dr[3].ToString().Trim();
                    AgeTxt.Text = (String)dr[4].ToString().Trim();
                    DepartmentDDL.SelectedValue = (String)dr[5].ToString().Trim();
                    HobbyDDL.SelectedValue = (String)dr[6].ToString().Trim();
                    Img.ImageUrl = (String)dr[7].ToString().Trim();
                    break;
                }
            }
        }
        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
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
            ImgFileUpload.SaveAs(folderPath + Path.GetFileName(ImgFileUpload.FileName));
            
            //Display the Picture in Image control.
            Img.ImageUrl = "./Files/" + Path.GetFileName(ImgFileUpload.FileName);
            //LblInfo.Text = Path.GetFullPath(ImgFileUpload.FileName);
        }
        protected void UpdateBtn_Click(object sender, EventArgs e) {
            //读取的是旧的数据，是因为点击update后会刷新
            string name, psw, sex, age, hobby, img, departmentName, departmentID;
            string sqlUpdate;
            name = NameTxt.Text;
            psw = PswTxt.Text;
            sex = SexRL.SelectedValue;
            age = AgeTxt.Text;
            departmentName = DepartmentDDL.SelectedItem.Text;
            departmentID = DepartmentDDL.SelectedValue;
            hobby = HobbyDDL.SelectedValue;
            img = Img.ImageUrl;
            sqlUpdate = $"UPDATE `user`"+
                        $" SET name = '{name}', psw = '{psw}', sex = '{sex}', age = {age}, department_id = {departmentID}, hobby = '{hobby}', imgUrl = '{img}'"+
                        $" WHERE id = {Session["id"]}";

            DataAccess da = new DataAccess();
            da.ChangeData(sqlUpdate);
            
            //string sqlInsert = $"INSERT INTO user VALUES (NULL, '{name}', '{psw}', '{sex}', '{age}', '{like}', '{img}');";
            //LblInfo.Text = sqlUpdate;

            string strName = "用户名：" + name;
            string strPsw = "<br>密码：" + psw;
            string strSex = "<br>性别：" + sex;
            string strAge = "<br>年龄：" + age;
            string strDep = "<br>部门：" + departmentName;
            string strHobby = "<br>爱好：" + hobby;
            string strImg = "<br>照片：" + img;
            string strEnd = "<br>修改成功";
            LblInfo.Text = strName + strPsw + strSex + strAge + strDep + strHobby + strImg + strEnd;
        }
        protected void QueryBtn_Click(object sender, EventArgs e) {
            DataAccess da = new DataAccess();
            string sqlQuery = "SELECT * FROM user";
            DataTable dt = da.QueryData(sqlQuery);
            LblInfo.Text = "";
            foreach (DataRow dr in dt.Rows) {
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

        }
    }
}