Imports Microsoft.VisualBasic
' System.Data namespace provides ADO.NET data technology
Imports System.Data
Imports System.Data.OleDb

Imports System
Imports System.Net

Public Class clsDataLayer
    ' This function gets the user activity from the tblUserActivity
    Public Shared Function GetUserActivity(ByVal Database As String) As dsUserActivity
        ' Variables declared
        Dim DS As dsUserActivity
        Dim sqlConn As OleDbConnection
        Dim sqlDA As OleDbDataAdapter

        ' Connection object
        sqlConn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source=" & Database & "")

        ' Instantiates a new data adapter
        sqlDA = New OleDbDataAdapter("select * from tblUserActivity", sqlConn)

        ' New object variable
        DS = New dsUserActivity

        ' Adds or refreshes rows
        sqlDA.Fill(DS.tblUserActivity)

        Return DS
    End Function

    ' This function saves the user activity
    Public Shared Function SaveUserActivity(ByVal Database As String, ByVal FormAccessed As String)
        ' Creates new OleDBConnection
        Dim conn As New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source=" & Database & "")
        conn.Open()
        Dim command As OleDbCommand = conn.CreateCommand()
        Dim strSQL As String

        strSQL = "Insert into tblUserActivity (UserIP, FormAccessed) values ('" & _
        GetIP4Address() & "', '" & FormAccessed & "')"

        command.CommandType = CommandType.Text
        command.CommandText = strSQL
        command.ExecuteNonQuery()
        conn.Close()
    End Function

    ' This Function gets the IP Address
    Public Shared Function GetIP4Address() As String
        Dim IP4Address As String = String.Empty

        For Each IPA As IPAddress In Dns.GetHostAddresses(HttpContext.Current.Request.UserHostAddress)
            If IPA.AddressFamily.ToString() = "InterNetwork" Then
                IP4Address = IPA.ToString()
                Exit For
            End If
        Next

        If IP4Address <> String.Empty Then
            Return IP4Address
        End If

        For Each IPA As IPAddress In Dns.GetHostAddresses(Dns.GetHostName())
            If IPA.AddressFamily.ToString() = "InterNetwork" Then
                IP4Address = IPA.ToString()
                Exit For
            End If
        Next

        Return IP4Address
    End Function

    ' This function saves the SavePersonnel
    Public Shared Function SavePersonnel(ByVal Database As String, ByVal FirstName As String, ByVal LastName As String, ByVal PayRate As Integer, ByVal StartDate As DateTime, ByVal EndDate As DateTime)

        ' Variable declared for transaction
        Dim myTransaction As System.Data.OleDb.OleDbTransaction

        Try

            ' Variables declared
            Dim conn As New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" & _
            "Data Source=" & Database & "")
            conn.Open()
            Dim command As OleDbCommand = conn.CreateCommand()
            Dim strSQL As String

            ' Start a local transaction
            myTransaction = conn.BeginTransaction

            ' SQL command to insert columns into a table
            strSQL = "Insert into tblPersonnel (FirstName, LastName, PayRate, StartDate, EndDate) values ('" & _
            FirstName & "', '" & LastName & "', " & PayRate & ", '" & StartDate & "', '" & EndDate & "')"

            ' Executes the data source
            command.CommandType = CommandType.Text
            command.CommandText = strSQL

            ' Executes the transaction
            command.Transaction = myTransaction

            ' SQL method to return number of rows affected
            command.ExecuteNonQuery()

            ' Commit transaction to save changes and complete the current transaction
            myTransaction.Commit()

            ' Closeing the connection
            conn.Close()

            SavePersonnel = True


        Catch ex As Exception

            ' Rollback command for reverting the transaction back to the original state
            myTransaction.Rollback()

            SavePersonnel = False
        End Try
    End Function

    Public Shared Function GetPersonnel(ByVal Database As String) As dsPersonnel
        Dim DS As dsPersonnel
        Dim sqlConn As OleDbConnection
        Dim sqlDA As OleDbDataAdapter

        sqlConn = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source=" & Database & "")

        sqlDA = New OleDbDataAdapter("select * from tblPersonnel", sqlConn)

        DS = New dsPersonnel

        sqlDA.Fill(DS.tblPersonnel)

        Return DS
    End Function

    ' This function verifies a user in the tblUserTable
    Public Shared Function VerifyUser(ByVal Database As String, ByVal UserName As String, ByVal UserPassword As String) As dsUser
        ' Variables declared
        Dim DS As dsUser
        Dim sqlConn As OleDbConnection
        Dim sqlDA As OleDbDataAdapter

        ' Connection Object
        sqlConn = New OleDbConnection("PROVIDER=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source=" & Database & "")

        ' DataAdapter Object
        sqlDA = New OleDbDataAdapter("Select SecurityLevel from tblUserLogin where UserName like '" & UserName & "' and UserPassword like '" & UserPassword & "'", sqlConn)

        ' New object variable
        DS = New dsUser

        ' Adds or refreshes rows in the UserLogin table
        sqlDA.Fill(DS.tblUserLogin)

        ' Returns new object variable
        Return DS

    End Function
End Class
