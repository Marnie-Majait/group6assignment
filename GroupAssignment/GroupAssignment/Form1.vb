Imports MySql.Data.MySqlClient
Public Class Form1
    Dim CONNECT As MySqlConnection
    Dim CONSTRING As String = "DATA SOURCE = localhost; USER id= root; DATABASE = assignment_database"
    Dim CMD As MySqlCommand
    Dim itemcoll(999) As String
    Dim da As MySqlDataAdapter
    Dim ds As DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "INSERT INTO assignment_table (First_Name, Last_Name, Contact_Num, Address, Email_Add, Item_Num, Quantity) values ('" & FNAMETXT.Text & "','" & LNAMETXT.Text & "','" & CNUMBER.Text & "','" & ADDTXT.Text & "','" & EMADDTXT.Text & "','" & ITEMTXT.Text & "','" & QTXT.Text & "')"
            CMD = New MySqlCommand(SQL, CONNECT)
            Dim i As Integer = CMD.ExecuteNonQuery
            If i <> 0 Then
                MsgBox("Record Saved", vbInformation, "Admin")
            Else
                MsgBox("Record Not Saved", vbCritical, "Admin")
            End If
            Call View()
            Call cleardata()
            CONNECT.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cleardata()
        ORDERTXT.Clear()
        FNAMETXT.Clear()
        LNAMETXT.Clear()
        CNUMBER.Clear()
        ADDTXT.Clear()
        EMADDTXT.Clear()
        ITEMTXT.Clear()
        QTXT.Clear()
    End Sub
    Public Sub View()
        Try
            ListView1.Items.Clear()
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim sql As String = "select * from assignment_table"
            CMD = New MySqlCommand(sql, CONNECT)
            da = New MySqlDataAdapter(CMD)
            ds = New DataSet
            da.Fill(ds, "Tables")
            For r = 0 To ds.Tables(0).Rows.Count - 1
                For c = 0 To ds.Tables(0).Columns.Count - 1
                    itemcoll(c) = ds.Tables(0).Rows(r)(c).ToString
                Next
                Dim lvitm As New ListViewItem(itemcoll)
                ListView1.Items.Add(lvitm)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CONNECT.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call View()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "Update assignment_table set First_Name = '" & FNAMETXT.Text & "', Last_Name = '" & LNAMETXT.Text & "',  Contact_Num = '" & CNUMBER.Text & "', Address = '" & ADDTXT.Text & "', Email_Add = '" & EMADDTXT.Text & "', Item_Num = '" & ITEMTXT.Text & "', Quantity = '" & QTXT.Text & "' where Order_Num = '" & ORDERTXT.Text & "'"
            CMD = New MySqlCommand(SQL, CONNECT)
            Dim i As Integer = CMD.ExecuteNonQuery
            If i <> 0 Then
                MsgBox("Record Updated", vbInformation, "Admin")
            Else
                MsgBox("Record Not Updated", vbCritical, "Admin")
            End If
            Call View()
            Call cleardata()
            CONNECT.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            CONNECT = New MySqlConnection(CONSTRING)
            CONNECT.Open()
            Dim SQL As String = "Delete from assignment_table where Order_Num = '" & ORDERTXT.Text & "'"
            CMD = New MySqlCommand(SQL, CONNECT)
            Dim i As Integer = CMD.ExecuteNonQuery
            If i <> 0 Then
                MsgBox("The record was deleted successfully", vbInformation, "Admin")
            Else
                MsgBox("The record cannot be deleted", vbCritical, "Admin")
            End If
            Call View()
            Call cleardata()
            CONNECT.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count > 0 Then
            ORDERTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(0).Text
            FNAMETXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(1).Text
            LNAMETXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(2).Text
            CNUMBER.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(3).Text
            ADDTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(4).Text
            EMADDTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(5).Text
            ITEMTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(6).Text
            QTXT.Text = ListView1.Items(ListView1.SelectedIndices(0)).SubItems(7).Text
        End If
    End Sub
End Class
