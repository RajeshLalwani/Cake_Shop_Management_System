Imports System.Data
Imports System.Data.SqlClient
Public Class Update_Order_Details
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
        cmd.CommandText = "update Order_Info set Cust_Name='" & TextBox2.Text & "', Cake_Name='" & ComboBox1.Text & "', Cake_Flavour='" & TextBox4.Text & "', Order_Date='" & DateTimePicker1.Text & "', Contact_No='" & TextBox6.Text & "', Cake_Quantity='" & ComboBox2.Text & "', Cake_Price='" & TextBox8.Text & "' where Order_ID=" & TextBox1.Text & " "
        cmd.ExecuteNonQuery()
        MsgBox("Data Updated Successfully...")
        con.Close()




        'con.Open()
        'cmd.Connection = con
        'cmd.CommandText = "insert into  Order_Info (Cust_Name, Cake_Name, Cake_Flavour, Order_Date, Contact_No, Cake_Quantity, Cake_Price) values('" + TextBox2.Text + "','" + ComboBox1.Text + "','" + TextBox4.Text + "','" + DateTimePicker1.Value + "','" + TextBox6.Text + "','" + ComboBox2.Text + "','" + TextBox8.Text + "')"
        'cmd.ExecuteNonQuery()
        'disp_data()
        'MessageBox.Show("Record Insert Succesfully...")

        'cmd1.Connection = con
        ''cmd1.CommandText = "insert into  orderinfo values('" + TextBox2.Text + "','" + ComboBox1.Text + "','" + TextBox4.Text + "','" + DateTimePicker1.Value + "','" + TextBox6.Text + "'," + ComboBox2.Text + ",'" + TextBox8.Text + "')"
        'cmd1.CommandText = "select ORDER_ID from Order_Info"
        'cmd1.ExecuteNonQuery()
        'da.SelectCommand = cmd1
        'da.Fill(dt)
        'If dt.Rows.Count > 0 Then

        '    TextBox1.Text = ((dt.Rows(dt.Rows.Count - 1)(0)) + 1).ToString

        'Else
        '    MsgBox("no  record found")
        'End If
        'con.Close()
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

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Update_Order_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Raj Resumes\Projects\TY\PC-66\113_Ronak\PROJECT II\Project\Cake_Shop_Management_System\Cake_Shop_Management_System\DataBase.mdf;Integrated Security=True;User Instance=True")
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "200 GM" Then
            TextBox8.Text = "Rs.150"
        ElseIf ComboBox2.Text = "250 GM" Then
            TextBox8.Text = "Rs.200"
        ElseIf ComboBox2.Text = "500 GM" Then
            TextBox8.Text = "Rs.400"
        ElseIf ComboBox2.Text = "750 GM" Then
            TextBox8.Text = "Rs. 650"
        ElseIf ComboBox2.Text = "1 KG" Then
            TextBox8.Text = "Rs.800"


        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub
End Class