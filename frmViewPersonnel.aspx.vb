
Partial Class frmViewPersonnel
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ' Declares the DataSet
            Dim myDataSet As New dsPersonnel

            ' Fill the dataset with what is returned from the function
            myDataSet = clsDataLayer.GetPersonnel(Server.MapPath("PayrollSystem_DB.mdb"))

            'Sets the DataGrid to the DataSource based on the table
            grdViewPersonnel.DataSource = myDataSet.Tables("tblPersonnel")

            ' Binds the DataGrid
            grdViewPersonnel.DataBind()

        End If
    End Sub
End Class
