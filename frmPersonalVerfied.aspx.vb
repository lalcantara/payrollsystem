
Partial Class frmPersonalVerfied
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtVerifiedInfo.Text = Request.Item("txtFirstName") & _
            Chr(13) & Chr(10) & Request.Item("txtLastName") & _
            Chr(13) & Chr(10) & Request.Item("txtPayRate") & _
            Chr(13) & Chr(10) & Request.Item("txtStartDate") & _
            Chr(13) & Chr(10) & Request.Item("txtEndDate")

        ' Condition statement for displaying if information was saved or not.
        If (clsDataLayer.SavePersonnel(Server.MapPath("PayrollSystem_DB.mdb"), Request.Item("txtFirstName"), Request.Item("txtLastName"), Request.Item("txtPayRate"), Request.Item("txtStartDate"), Request.Item("txtEndDate"))) Then

            Me.txtVerifiedInfo.Text = Me.txtVerifiedInfo.Text & Chr(13) & Chr(10) & "The information was successfully saved!"
        Else

            Me.txtVerifiedInfo.Text = Me.txtVerifiedInfo.Text & Chr(13) & Chr(10) & "The information was NOT saved."
        End If
    End Sub
End Class
