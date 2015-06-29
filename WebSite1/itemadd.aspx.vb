
Partial Class itemadd
    Inherits System.Web.UI.Page
    Dim cmd As New Data.OleDb.OleDbCommand
    Dim da As New Data.OleDb.OleDbDataAdapter
    Dim con As New Data.OleDb.OleDbConnection
    Dim c As New conn
    Dim dtr As Data.OleDb.OleDbDataReader
    ''  Dim i As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not IsPostBack Then
        '    Dim script As String = "$(document).ready(function () { $('[id*=btnSubmit]').click(); });"
        '    ClientScript.RegisterStartupScript(Me.GetType, "load", script, True)
        'End If
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
        End If
        ''  TextBox6.Visible = False
        ''    DropDownList8.Text = (Session("type"))
        TextBox3.Text = Session("uname")
        'If Not IsPostBack Then


        'If Session("type") = "NEW_ITEM" Then
        '    DropDownList4.Items.Clear()
        '        DropDownList4.Items.Add("Select")

        '    DropDownList4.Items.Add("Car")
        '    DropDownList4.Items.Add("Bike")
        '    DropDownList4.Items.Add("House")
        '    DropDownList4.Items.Add("Electronic_Item")
        '    DropDownList4.Items.Add("Other")
        'ElseIf Session("type") = "OLD_ITEM" Then
        '        DropDownList4.Items.Clear()
        '        DropDownList4.Items.Add("Select")

        '    DropDownList4.Items.Add("Car")
        '    DropDownList4.Items.Add("Bike")
        '    DropDownList4.Items.Add("House")
        '    DropDownList4.Items.Add("Electronic_Item")
        '    DropDownList4.Items.Add("Other")
        'ElseIf Session("type") = "ON_RENT" Then
        '        DropDownList4.Items.Clear()
        '        DropDownList4.Items.Add("Select")

        '    DropDownList4.Items.Add("Car")
        '    DropDownList4.Items.Add("Bike")
        '    DropDownList4.Items.Add("House")
        '    DropDownList4.Items.Add("Other")
        'ElseIf Session("type") = "CONSTRACTOR" Then
        '        DropDownList4.Items.Clear()
        '        DropDownList4.Items.Add("Select")

        '    DropDownList4.Items.Add("Electrician")
        '    DropDownList4.Items.Add("Painter")
        '    DropDownList4.Items.Add("Carpenter")
        '    DropDownList4.Items.Add("Other")
        '    End If

        'End If


    End Sub

    Protected Sub DropDownList4_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList4.Load
      
    End Sub

    Protected Sub DropDownList4_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList4.SelectedIndexChanged, DropDownList8.SelectedIndexChanged
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

        'If DropDownList4.Text <> "Other" Then
        '    DropDownList5.Visible = True
        '    TextBox6.Visible = False
        'ElseIf DropDownList4.Text = "Other" Then
        '    DropDownList5.Visible = False
        '    TextBox6.Visible = True

        'End If
        'If DropDownList4.Text = "Car" Then
        '    DropDownList5.Items.Clear()
        '    DropDownList5.Items.Add("Select")

        '    DropDownList5.Items.Add("Honda")
        '    DropDownList5.Items.Add("Tata")
        '    DropDownList5.Items.Add("Toyta")
        '    DropDownList5.Items.Add("Hyundai")
        '    DropDownList5.Items.Add("Other")
        'ElseIf DropDownList4.Text = "Bike" Then
        '    DropDownList5.Items.Clear()
        '    DropDownList5.Items.Add("Select")

        '    DropDownList5.Items.Add("Honda")
        '    DropDownList5.Items.Add("Hero")
        '    DropDownList5.Items.Add("bajaj")
        '    DropDownList5.Items.Add("Other")
        'ElseIf DropDownList4.Text = "House" Then
        '    DropDownList5.Items.Clear()
        '    DropDownList5.Items.Add("Select")

        '    DropDownList5.Items.Add("House")
        '    DropDownList5.Items.Add("1BHK")
        '    DropDownList5.Items.Add("2BHK")
        '    DropDownList5.Items.Add("2BHK+")
        '    DropDownList5.Items.Add("Other")

        'ElseIf DropDownList4.Text = "Electronic_Item" Then
        '    DropDownList5.Items.Clear()
        '    DropDownList5.Items.Add("Select")
        '    DropDownList5.Items.Add("Mobile")
        '    DropDownList5.Items.Add("Tab")
        '    DropDownList5.Items.Add("TV")
        '    DropDownList5.Items.Add("Other")
        'ElseIf DropDownList4.Text = "Electrician" Then
        '    DropDownList5.Items.Clear()
        '    DropDownList5.Items.Add("Select")
        '    DropDownList5.Items.Add("AC/Cooler...")
        '    DropDownList5.Items.Add("TV/CD/DVD..")
        '    DropDownList5.Items.Add("Water Filter...")
        '    DropDownList5.Items.Add("Fans/Mixer...")
        '    DropDownList5.Items.Add("Other")
        'ElseIf DropDownList4.Text = "Painter" Then
        '    DropDownList5.Items.Clear()
        '    DropDownList5.Items.Add("Select")
        '    DropDownList5.Items.Add("All")
        'ElseIf DropDownList4.Text = "Carpenter" Then
        '    DropDownList5.Items.Clear()
        '    DropDownList5.Items.Add("Select")
        '    DropDownList5.Items.Add("All")
        'Else
        'End If
    End Sub

    Protected Sub DropDownList4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList4.TextChanged
      
       End Sub

    Protected Sub DropDownList5_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList5.SelectedIndexChanged
        'If DropDownList5.Text = "Other" Then
        '    TextBox6.Visible = True
        'Else
        '    TextBox6.Visible = False

        'End If
    End Sub

    
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        'MsgBox(DropDownList4.Text)
        'MsgBox(DropDownList5.Text)
        'MsgBox(DropDownList6.Text)
        'MsgBox(DropDownList7.Text)

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
            cmd.CommandText = "insert into ITEM_DETAIL(XYX,RID,IID,TYPE,ITEM_TYPE,SUB_ITEM_TYPE,ABOUT,MOBILE,STATE,CITY,ADDRESS) VALUES('" & TextBox11.Text & "'," & Val(Session("ID")) & "," & Val(Session("TID")) & ",'" & DropDownList8.Text & "','" & DropDownList4.Text & "','" & DropDownList5.Text & "', '" & TextBox7.Text & "'," & Val(TextBox8.Text) & ",'" & DropDownList6.Text & "','" & DropDownList7.Text & "','" & TextBox10.Text & "')"
            cmd.ExecuteNonQuery()

            c.cnn.Close()
            Dim SEARC As String
            SEARC = (DropDownList8.Text + "," + DropDownList4.Text + "," + DropDownList5.Text).ToString
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            cmd.CommandText = "insert into SEARCH(SEARCH) VALUES('" & SEARC & "')"
            cmd.ExecuteNonQuery()
            MsgBox("your data are saved")
            c.cnn.Close()


            Dim ss As String
            cmd.Connection = c.connect()
            cmd.CommandType = Data.CommandType.Text
            ss = " select top 1 *  from ITEM_DETAIL where RID=" & Val(Session("ID")) & " order by PID DESC"
            cmd.CommandText = ss
            dtr = cmd.ExecuteReader()
            While dtr.Read() = True
                Session.Add("PID", dtr("PID"))
            End While
            c.cnn.Close()
            Response.Redirect("AddPictureItem.aspx")


        End If
      
    End Sub

    Protected Sub DropDownList7_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DropDownList7.SelectedIndexChanged

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
End Class
