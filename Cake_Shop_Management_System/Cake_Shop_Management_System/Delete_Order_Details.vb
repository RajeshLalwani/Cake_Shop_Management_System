Imports System.Data
Imports System.Data.SqlClient
Public Class Delete_Order_Details
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim cmd1 As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Dim index As Integer = 0
    Dim i As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        ComboBox1.ResetText()
        DateTimePicker1.Refresh()
        TextBox6.Clear()
        ComboBox2.ResetText()
        TextBox8.Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "delete from Order_Info where Order_ID=" & TextBox1.Text & " "
        cmd.ExecuteNonQuery()
        MsgBox("Data Deleted Successfully...")
        con.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "select * from Order_Info where Order_ID='" & TextBox1.Text & "' "
        Dim dap As New SqlDataAdapter(cmd)
        Dim dtbl As New DataTable
        dap.Fill(dtbl)
        If dtbl.Rows.Count() > 0 Then
            TextBox2.Text = dtbl.Rows(0)(1).ToString()
            ComboBox1.Text = dtbl.Rows(0)(2).ToString()
            TextBox4.Text = dtbl.Rows(0)(3).ToString()
            DateTimePicker1.Value = dtbl.Rows(0)(4).ToString()
            TextBox6.Text = dtbl.Rows(0)(5)
            ComboBox2.Text = dtbl.Rows(0)(6).ToString()
            TextBox8.Text = dtbl.Rows(0)(7).ToString()
        Else
            MsgBox("no record found")

            TextBox1.Clear()
            TextBox2.Clear()
            ComboBox1.ResetText()
            DateTimePicker1.ResetText()
            TextBox6.Clear()
            ComboBox2.ResetText()
            TextBox8.Clear()
        End If
        con.Close()
    End Sub

    Private Sub Delete_Order_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Raj Resumes\Projects\Cake_Shop_Management_System\Cake_Shop_Management_System\DataBase.mdf;Integrated Security=True;User Instance=True"
    End Sub
End Class