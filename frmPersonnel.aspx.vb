
Partial Class frmPersonnel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' Public shared function SaveUserActivity
        clsDataLayer.SaveUserActivity(Server.MapPath("PayrollSystem_DB.mdb"), "frmPersonnel")

        ' If statement to set visibility of submit and cancel buttons
        If Session.Item("SecurityLevel") = "A" Then
            Me.btnCancel.Visible = True
            Me.btnSubmit.Visible = True

            ' Sets visibility to false if SecurityLevel is not "A"
        Else
            Me.btnCancel.Visible = False
            Me.btnSubmit.Visible = False

        End If

    End Sub
End Class
