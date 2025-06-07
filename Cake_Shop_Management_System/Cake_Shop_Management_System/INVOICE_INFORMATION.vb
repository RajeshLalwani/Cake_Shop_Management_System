Imports System.Data
Imports System.Data.SqlClient

Public Class INVOICE_INFORMATION

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
            MsgBox("Enter Value First")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Insert into invoice_info values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DateTimePicker1.Value + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "')"
            cmd.ExecuteNonQuery()

            disp_data()
            MsgBox("Insert SuccessFully")
        End If
    End Sub

    Private Sub INVOICE_INFORMATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\ASUS\Documents\Raj Resumes\Projects\TY\PC-66\113_Ronak\PROJECT II\Project\Cake_Shop_Management_System\Cake_Shop_Management_System\DataBase.mdf;Integrated Security=True;User Instance=True")
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        con.Open()
        disp_data()
    End Sub

    Private Sub disp_data()
        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from invoice_info "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

   
    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedGR As DataGridViewRow
        selectedGR = DataGridView1.Rows(e.RowIndex)
        TextBox1.Text = selectedGR.Cells(0).Value
        TextBox2.Text = selectedGR.Cells(1).Value
        TextBox3.Text = selectedGR.Cells(2).Value
        TextBox4.Text = selectedGR.Cells(3).Value
        DateTimePicker1.Value = selectedGR.Cells(4).Value
        TextBox6.Text = selectedGR.Cells(5).Value
        TextBox7.Text = selectedGR.Cells(6).Value
        TextBox8.Text = selectedGR.Cells(7).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Then
            MsgBox("Enter Value First")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Update invoice_info set Custname='" + TextBox2.Text + "',Surname='" + TextBox3.Text + "',Custcontact='" + TextBox4.Text + "',Invoicedate='" + DateTimePicker1.Value + "',Custadd='" + TextBox6.Text + "',Totalquan='" + TextBox7.Text + "',totalamount='" + TextBox8.Text + "' where invoiceno='" + TextBox1.Text + "'"
            cmd.ExecuteNonQuery()
            disp_data()
            MsgBox("Update SuccessFully")
        End If

        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Value First")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from invoice_info where invoiceno='" + TextBox1.Text + "'"
            cmd.ExecuteNonQuery()

            disp_data()
            MsgBox("Delete Successfully")
        End If

        
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        'If Char.IsNumber(e.KeyChar) = False And Not e.KeyChar = Chr(Keys.Back) Then
        '    e.KeyChar = Nothing
        'Else
        '    MsgBox("Error: Please Enter Numbers Only...")
        'End If
    End Sub
End Class