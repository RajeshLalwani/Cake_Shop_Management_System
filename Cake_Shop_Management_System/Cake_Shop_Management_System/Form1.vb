Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.Open()
        cmd.Connection = con
        cmd.CommandText = " select * from Log_in where userid='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'"
        cmd.ExecuteNonQuery()
        da.SelectCommand = cmd
        da.Fill(dt)
        If (TextBox1.Text = "" And TextBox2.Text = "") Then
            MsgBox("Enter User ID And Password")
        ElseIf (dt.Rows.Count > 0) Then
            TextBox1.Clear()
            TextBox2.Clear()
            MessageBox.Show("Logged in Successfully...")

            Me.Hide()
            Home.Show()


            'home.Show()
            Me.Hide()
        Else
            MsgBox("User ID OR Password does not match...")
        End If
        con.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Raj Resumes\Projects\Cake_Shop_Management_System\Cake_Shop_Management_System\DataBase.mdf;Integrated Security=True;User Instance=True"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
