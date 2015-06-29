
Partial Class Edit
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ss As String

        If Not IsPostBack Then
            DropDownList6.Items.Clear()
            DropDownList6.Items.Add("State")

            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = "SELECT * FROM STATE"
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                DropDownList6.Items.Add(dtr("STATE"))
            End While
            c.cnn.Close()



            DropDownList8.Items.Add("Type")
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = "select  DISTINCT TYPE from TYPE"
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                DropDownList8.Items.Add(dtr("TYPE"))
            End While
            c.cnn.Close()

            ''  TextBox6.Visible = False
            ''    DropDownList8.Text = (Session("type"))
            TextBox3.Text = Session("uname")


            Dim I As Integer = 1
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = "select top 1 * from ITEMS_IMAGES,ITEM_DETAIL,REGIS  WHERE ITEM_DETAIL.PID=ITEMS_IMAGES.PID AND REGIS .ID =ITEM_DETAIL .RID and ITEMS_IMAGES.PID=" & Val(Session("PID")) & " "
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                ''   MsgBox(dtr(""))
                DropDownList8.Text = dtr("TYPE")
                DropDownList4.Items.Add(dtr("ITEM_TYPE"))
                DropDownList5.Items.Add(dtr("SUB_ITEM_TYPE"))
                DropDownList6.Text = dtr("STATE")
                DropDownList7.Items.Add(dtr("CITY"))
                TextBox4.Text = dtr("EMAIL")
                TextBox8.Text = dtr("MOBILE")
                TextBox7.Text = dtr("ABOUT")
                TextBox10.Text = dtr("ADDRESS")
                TextBox11.Text = dtr("XYX")

            End While
            c.cnn.Close()
        End If

    End Sub

    Protected Sub DropDownList8_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList8.SelectedIndexChanged
        DropDownList4.Items.Clear()
        Dim ss As String
        DropDownList4.Items.Add("Sub Type")
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        ss = "select  DISTINCT ITEM_TYPE from TYPE where TYPE='" & DropDownList8.Text & "'"
        cmd.CommandText = ss
        dtr = cmd.ExecuteReader()
        While dtr.Read() = True
            DropDownList4.Items.Add(dtr("ITEM_TYPE"))
        End While
        c.cnn.Close()
    End Sub

    Protected Sub DropDownList4_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList4.SelectedIndexChanged
        DropDownList5.Items.Clear()
        Dim ss As String
        DropDownList5.Items.Add("Company")
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        ss = "select  DISTINCT SUB_ITEM from SUBITEM where ITEM='" & DropDownList4.Text & "'"
        cmd.CommandText = ss
        dtr = cmd.ExecuteReader()
        While dtr.Read() = True
            DropDownList5.Items.Add(dtr("SUB_ITEM"))
        End While
        c.cnn.Close()

    End Sub

    Protected Sub DropDownList5_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList5.SelectedIndexChanged

    End Sub

    Protected Sub DropDownList6_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList6.SelectedIndexChanged
        DropDownList7.Items.Clear()
        DropDownList7.Items.Add("City")

        Dim ss As String
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        ss = "SELECT * FROM CITY WHERE SID='" & DropDownList6.Text & "'"
        cmd.CommandText = ss
        dtr = cmd.ExecuteReader()
        While dtr.Read() = True
            DropDownList7.Items.Add(dtr("CITY"))
        End While
        c.cnn.Close()
    End Sub

    Protected Sub DropDownList7_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList7.SelectedIndexChanged

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If DropDownList8.Text = "Type" Then
            Label1.Text = "Select Type"
        ElseIf TextBox3.Text = "" Then
            Label1.Text = "Enter User_Name"
        ElseIf DropDownList4.Text = "Sub Type" Then
            Label1.Text = "Select Sub Type"
        ElseIf DropDownList5.Text = "Company" Then
            Label1.Text = "Select Company"
        ElseIf TextBox7.Text = "" Then
            Label1.Text = "Enter About product"
        ElseIf TextBox8.Text = "" Then
            Label1.Text = "Enter Mobile No..."
        ElseIf DropDownList6.Text = "State" Then
            Label1.Text = "Select State"
        ElseIf DropDownList7.Text = "City" Then
            Label1.Text = "Select City"
        Else





            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            cmd.CommandText = "update ITEM_DETAIL set TYPE='" & DropDownList8.Text & "', ITEM_TYPE='" & DropDownList4.Text & "', SUB_ITEM_TYPE='" & DropDownList5.Text & "', STATE= '" & DropDownList6.Text & "' , CITY='" & DropDownList7.Text & "',MOBILE=" & Val(TextBox8.Text) & ", ABOUT='" & TextBox7.Text & "',ADDRESS='" & TextBox10.Text & "',XYX=" & Val(TextBox11.Text) & " where ITEM_DETAIL.PID=" & Val(Session("PID")) & ""
            cmd.ExecuteNonQuery()

            c.cnn.Close()
            Dim sss As String
            sss = (DropDownList8.Text + "," + DropDownList4.Text + "," + DropDownList5.Text).ToString
            ''  MsgBox(sss)
            Dim ss As String
            Dim I As Integer = 0
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = "SELECT * FROM SEARCH WHERE SEARCH='" & sss & "'"
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                I = 1
            End While
            c.cnn.Close()

            If (I = 0) Then
                cmd.Connection = c.connect()
                cmd.CommandType = Data.CommandType.Text
                cmd.CommandText = "INSERT INTO SEARCH(SEARCH) VALUES('" & sss & "')"
                cmd.ExecuteNonQuery()
                MsgBox(sss)
                c.cnn.Close()
            End If
            Response.Redirect("AddPictureItem.aspx")
        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        cmd.CommandText = "delete from ITEM_DETAIL where PID=" & Val(Session("PID")) & ""
        dtr = cmd.ExecuteReader()

        c.cnn.Close()
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        cmd.CommandText = "delete from ITEMS_IMAGES where PID=" & Val(Session("PID")) & ""
        dtr = cmd.ExecuteReader()

        c.cnn.Close()
        cmd.Connection = c.connect()
        cmd.CommandType = Data.CommandType.Text
        cmd.CommandText = "delete from COMMENT where PID=" & Val(Session("PID")) & ""
        dtr = cmd.ExecuteReader()

        c.cnn.Close()
        Response.Redirect("Profile.aspx")
    End Sub
End Class
