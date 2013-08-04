
Partial Class frmLoginCheck
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Variable declared
        Dim dsUserLogin As dsUser

        ' Variable for select statement declared
        Dim SecurityLevel As String

        ' Verify user mechanism
        dsUserLogin = clsDataLayer.VerifyUser(Server.MapPath("PayrollSystem_DB.mdb"), Request.Item("txtUserName"), Request.Item("txtPassword"))

        ' If statement for incorrect login attempts
        If dsUserLogin.tblUserLogin.Count < 1 Then
            lblStatus.Text = "The User Name and/or Password are incorrect." & Chr(13) & Chr(10) & _
            "Please try again."

            ' If statement for incorrect login and sends email
            If clsBusinessLayer.SendEmail("admin@theburt.com", _
                "burt16@gmail.com", "", "", "Login Incorrect", _
                "The login failed for UserName: " & Request.Item("txtUserName") & _
                " Password: " & Request.Item("txtPassword")) Then

                lblStatus.Text = lblStatus.Text & " Your incorrect login information was sent to burt16@gmail.com"

            End If

            Exit Sub

        End If

        ' Declaration of SecurityLevel variable to dataset and database table
        SecurityLevel = dsUserLogin.tblUserLogin(0).SecurityLevel.ToString

        ' Start of select statement
        Select Case SecurityLevel

            Case "A"
                ' Sets SecurityLevel to A
                Session.Item("SecurityLevel") = "A"
                Response.Redirect("frmPersonnel.aspx")
            Case "U"
                ' Sets SecurityLevell to U
                Session.Item("SecurityLevel") = "U"
                Response.Redirect("frmPersonnel.aspx")
            Case Else
                lblStatus.Text = "The User Name and/or Password are incorrect." & Chr(13) & Chr(10) & _
                "Please try again."
        End Select
    End Sub
End Class
