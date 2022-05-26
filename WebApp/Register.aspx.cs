using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using MySql.Data.MySqlClient;
using WebApp.AppCode;
using System.Data;

namespace WebApp
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            DataAccess da = new DataAccess();
            string cmd = "SELECT * FROM department";
            DataTable dt = da.QueryData(cmd);
            DepartmentDDL.DataSource = dt;
            DepartmentDDL.DataTextField = "name";
            DepartmentDDL.DataValueField = "id";
            DepartmentDDL.DataBind();
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
        protected void RegBtn_Click(object sender, EventArgs e) {
            string name = NameTxt.Text;
            string psw = PswTxt.Text;
            string sex = SexRL.SelectedValue;
            string age = AgeTxt.Text;
            string departmentName = DepartmentDDL.SelectedItem.Text;
            string departmentID = DepartmentDDL.SelectedValue;
            string hobby = HobbyDDL.SelectedValue;
            string img = Img.ImageUrl;

            

            string sqlInsert = $"INSERT INTO user VALUES (NULL, '{name}', '{psw}', '{sex}', '{age}', '{departmentID}', '{hobby}', '{img}');";
            DataAccess da = new DataAccess();
            da.ChangeData(sqlInsert);
            string strName = "用户名：" + name;
            string strPsw = "<br>密码：" + psw;
            string strSex = "<br>性别：" + sex;
            string strAge = "<br>年龄：" + age;
            string strDep = "<br>部门：" + departmentName;
            string strHobby = "<br>爱好：" + hobby;
            string strImg = "<br>照片：" + img;
            string strEnd = "<br>注册成功";
            LblInfo.Text = strName + strPsw + strSex + strAge + strDep + strHobby + strImg + strEnd;
        }
    }
}