Imports System.Text.RegularExpressions
 
Partial Class Reg
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
     Dim da As New Data.OleDb.OleDbDataAdapter
     Dim con As New Data.OleDb.OleDbConnection
    Dim dtr As Data.OleDb.OleDbDataReader
    Dim c As New conn
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Label1.Visible = False
        If Not IsPostBack Then
            ''    MsgBox("")

        End If
        ''   Button1.CssClass = "openModal"

    End Sub
     
 
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        Dim phoneNumber As New Regex("\d{10}")


        Dim isHuman As Boolean = captchaBox.Validate(txtCaptcha.Text)
        txtCaptcha.Text = Nothing
        If TextBox1.Text = "" Then
            Label1.Text = " First Name  "
        ElseIf TextBox3.Text = "" Then
            Label1.Text = "Last Name"
        ElseIf TextBox2.Text = "" Then
            Label1.Text = "Email"
        ElseIf Not email.IsMatch(TextBox2.Text) Then
            Label1.Text = "Wrong Email formet"
        ElseIf TextBox4.Text = "" And TextBox5.Text = "" Then
            Label1.Text = "PassWord"
        ElseIf TextBox5.Text <> TextBox4.Text Then
            Label1.Text = "Password Not Match"
        ElseIf TextBox6.Text = "" Then
            Label1.Text = "Mobile No.."
        ElseIf TextBox6.Text.Length <> 10 Then
            Label1.Text = "Mobile No .. only 10 degit use "
        ElseIf Not phoneNumber.IsMatch(TextBox6.Text) Then
            Label1.Text = "Mobile No no String Allow...!"
        ElseIf DropDownList4.Text = "Gender" Then
            Label1.Text = "Gender"
        ElseIf Not isHuman Then
            Label1.Text = "Wrong Captcha "

        Else



            Dim ss As String
            Dim I As Integer = 1
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = " select * from REGIS where EMAIL='" & TextBox2.Text & "' "
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                
                I = 0

            End While
            c.cnn.Close()



            If I = 0 Then

                Label1.Text = "This Email user already exist ...! "
            Else
                cmd.Connection = c.connect()
                cmd.CommandType = Data.CommandType.Text
                cmd.CommandText = "insert into REGIS(NAME,PASSWORD,EMAIL,GENDER,MOBILE) VALUES('" & TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "','" & DropDownList4.Text & "'," & Val(TextBox6.Text) & ")"
                cmd.ExecuteNonQuery()
                MsgBox("your data are saved")

                c.cnn.Close()
                Session.Add("uname", "")
                Response.Redirect("Default3.aspx")
            End If
        End If
        '' Button1.CssClass = "openModal"
    End Sub

    Protected Sub DropDownList4_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList4.SelectedIndexChanged

    End Sub

    Protected Sub TextBox5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    
End Class
