#!/usr/bin/env python3

mp = {
        "TextBox1": "NameTxt",
        "TextBox2": "PswTxt",
        "RadioButtonList1": "SexRL",
        "TextBox3": "AgeTxt",
        "DropDownList1": "HobbyDDL",
        "Image1": "Img",
        "FileUpload1": "ImgFileUpload",
}
txt = ""
with open('./User.aspx.cs') as f:
        txt = f.read()
        for k, v in mp.items():
                txt = txt.replace(k, v)
with open('./User.aspx.cs', 'w') as f:
        f.write(txt)