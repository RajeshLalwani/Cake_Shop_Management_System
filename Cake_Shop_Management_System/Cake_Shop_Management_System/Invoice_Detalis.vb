Imports System.Data
Imports System.Data.SqlClient
Public Class Invoice_Detalis

    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Enter Value First")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Insert Into invoice_dtls values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + ComboBox1.Text + "','" + TextBox5.Text + "')"
            cmd.ExecuteNonQuery()
            disp_data()

            MessageBox.Show("Record Insert SuccesFully")
        End If
    End Sub

    Private Sub Invoice_Detalis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "select * from invoice_dtls"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Enter Value First")
        Else
             cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Update invoice_dtls set Itemid='" + TextBox2.Text + "',Itemnm='" + TextBox3.Text + "',Qty='" + TextBox4.Text + "',Unitprice='" + ComboBox1.Text + "',TotalAmount='" + TextBox5.Text + "'where Invono='" + TextBox1.Text + "'"
            cmd.ExecuteNonQuery()
            disp_data()
            MessageBox.Show("Record Update SuccessFully")
        End If
        
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter Value First")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Delete from invoice_dtls where Invono='" + TextBox1.Text + "'"
            cmd.ExecuteNonQuery()
            disp_data()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            TextBox5.Clear()
            ComboBox1.Refresh()


            MessageBox.Show("Record Delete SuccesFully")
        End If

        
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class