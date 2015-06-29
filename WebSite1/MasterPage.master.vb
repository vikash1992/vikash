Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Web.Services
Partial Class MasterPage
    Inherits System.Web.UI.MasterPage
    <WebMethod()> _
    Public Shared Function GetAutoCompleteData(ByVal SEARCH As String) As List(Of String)
        '  MsgBox(COMMENT)
        Dim result As New List(Of String)()
        Using coon As New SqlConnection("Data Source=vikash;Integrated Security=true;Initial Catalog=clg2015")
            Using cmdd As New SqlCommand("select DISTINCT SEARCH from SEARCH where SEARCH LIKE '%'+@SearchText+'%'", coon)
                coon.Open()
                cmdd.Parameters.AddWithValue("@SearchText", SEARCH)
                Dim dr As SqlDataReader = cmdd.ExecuteReader()
                While dr.Read()
                    ''  MsgBox("COMMENT")
                    result.Add(dr("SEARCH").ToString())
                End While
                Return result
            End Using
        End Using
    End Function
    Public Function ThumbnailCallback() As Boolean
        Return False
    End Function
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim ss As String
        Dim img As String
        If Session("ID") <> "" Then
            Try


                img = Session("ID")
                Dim path As String = Server.MapPath("~/pro_image/" + Session("img") + ".png")

                Dim image As System.Drawing.Image = System.Drawing.Image.FromFile(path)
                Using thumbnail As System.Drawing.Image = image.GetThumbnailImage(50, 40, New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback), IntPtr.Zero)
                    Using memoryStream As New MemoryStream()
                        thumbnail.Save(memoryStream, ImageFormat.Png)
                        Dim bytes As [Byte]() = New [Byte](memoryStream.Length - 1) {}
                        memoryStream.Position = 0
                        memoryStream.Read(bytes, 0, CInt(bytes.Length))
                        Dim base64String As String = Convert.ToBase64String(bytes, 0, bytes.Length)
                        ss = "data:image/png;base64," & base64String



                    End Using

                End Using
            Catch ex As Exception

            End Try

        End If
        Dim Logout As New MenuItem("Logout", "Logout", "", "")


        Dim user As New MenuItem(Session("uname"), Session("uname"), "", "")
        Dim Login As New MenuItem("[Log_In]", "[Log_In]", "", "Default3.aspx")
        Dim profile As New MenuItem("", "", ss, "Profile.aspx")

        Dim s As String
        Try


            s = Session("uname").ToString
            If s <> "" Then
                NavigationMenu.Items.RemoveAt(0)

                NavigationMenu.Items.Add(user)
                NavigationMenu.Items(0).ChildItems.Add(profile)
                NavigationMenu.Items(0).ChildItems.Add(Logout)



            ElseIf s = "" Then

                NavigationMenu.Items.RemoveAt(0)
                NavigationMenu.Items.Add(Login)


            End If
        Catch ex As Exception

        End Try

    End Sub

 
    Protected Sub NavigationMenu_MenuItemClick(ByVal sender As Object, ByVal e As System.Web.UI.WebControls.MenuEventArgs) Handles NavigationMenu.MenuItemClick
        If NavigationMenu.SelectedValue = "Logout" Then
            Session.Add("uname", "")
            Session.Clear()
            Response.Redirect("Default3.aspx")

        ElseIf NavigationMenu.SelectedValue = "[Log_In]" Then
            Response.Redirect("Default3.aspx")
        End If

        ''   Response.Redirect("Default3.aspx")
    End Sub

    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click


        Response.Redirect("Home.aspx")
    End Sub

    
    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click


        Session.Add("search", Request.Form("txtSearch"))
        Dim s As String = Session("search").ToString
        Dim parts As String() = s.Split(New Char() {","c})
        Dim part As String
        Dim COUNT As Integer = 0
        Session.Add("city", "")
        Session.Add("state", "")
        ''   MsgBox(Session("search"))
        If Session("search") <> "" Then

            For Each part In parts
                If COUNT = 0 Then
                    Session.Add("one", part)
                ElseIf COUNT = 1 Then
                    Session.Add("two", part)
                ElseIf COUNT = 2 Then
                    Session.Add("three", part)
                End If
                COUNT = COUNT + 1
                ''  MsgBox(part)
            Next
        Else
            Session.Add("one", "")
            Session.Add("two", "")
            Session.Add("three", "")

        End If
        Response.Redirect("search.aspx")
    End Sub
End Class

