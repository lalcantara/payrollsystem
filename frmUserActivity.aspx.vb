
Partial Class frmUserActivity
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ' Declares the DataSet
            Dim myDataSet As New dsUserActivity

            ' Fill the dataset with what is returned from the function
            myDataSet = clsDataLayer.GetUserActivity(Server.MapPath("PayrollSystem_DB.mdb"))

            ' Sets the DataGrid to the DataSource based on the table
            grdUserActivity.DataSource = myDataSet.Tables("tblUserActivity")

            ' Binds the dataGrid
            grdUserActivity.DataBind()
        End If

    End Sub
End Class
