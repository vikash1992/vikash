Imports System.IO
Imports System.Net
Imports System.Net.Mail
Imports System.Configuration
Partial Class ForgetPassword
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim ss As String
        Dim COND As String = 0
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        ss = " select * from REGIS where EMAIL='" & TextBox1.Text & "'"
        cmd.CommandText = ss
        dtr = cmd.ExecuteReader()
        While dtr.Read() = True
            COND = 1
        End While
        c.cnn.Close()

        If COND = 1 Then
            Try
                Dim sec As String = (Val(Now.Millisecond) * Val(Now.Second)).ToString
                Session.Add("code", sec)
                Session.Add("mail", TextBox1.Text)
                sec = "Code:  " + sec
                Dim [to] As String = TextBox1.Text
                Dim from As String = "viewindia75@gmail.com"
                Dim subject As String = "Code"
                Dim body As String = sec
                Using mm As New MailMessage("viewindia75@gmail.com", TextBox1.Text)
                    mm.Subject = "Code"
                    mm.Body = sec
                    'If fuAttachment.HasFile Then
                    '    Dim FileName As String = Path.GetFileName(fuAttachment.PostedFile.FileName)
                    '    mm.Attachments.Add(New Attachment(fuAttachment.PostedFile.InputStream, FileName))
                    'End If
                    mm.IsBodyHtml = False
                    Dim smtp As New SmtpClient()
                    smtp.Host = "smtp.gmail.com"
                    smtp.EnableSsl = True
                    Dim NetworkCred As New NetworkCredential("viewindia75@gmail.com", "vikash11021992")
                    smtp.UseDefaultCredentials = True
                    smtp.Credentials = NetworkCred
                    smtp.Port = 587
                    smtp.Send(mm)
                    ClientScript.RegisterStartupScript(Me.GetType, "alert", "alert('Email sent.');", True)
                End Using
                Response.Redirect("Changepassword.aspx")
            Catch ex As Exception
                Label1.Text = "Error ! Re_try  "
            End Try
        Else
            Label1.Text = "Unregistered Mail ! "
        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim script As String = "$(document).ready(function () { $('[id*=btnSubmit]').click(); });"
            ClientScript.RegisterStartupScript(Me.GetType, "load", script, True)
        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        ''System.Threading.Thread.Sleep(5000)
        Response.Redirect("Default3.aspx")
    End Sub

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
