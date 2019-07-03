Imports System.Data.OleDb

Public Class frmAdd

    Dim Data_con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MainDB.accdb;")
    Dim Data_com As New OleDbCommand()



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Data_con.Open()
            Dim str As String = "insert into Admin values('" & txtId.Text & "', '" & txtName.Text & "', '" & txtSub.Text & "', '" & txtMob.Text & "',  '" & txtEmail.Text.ToString & "', '" & txtPass.Text & "')"
            Dim com As New OleDbCommand(str, Data_con)
            com.ExecuteNonQuery()
            Data_con.Close()
            MsgBox("Save Successfull")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
        frmAdmin.Show()
    End Sub
End Class