Imports System.Data
Imports System.Data.SqlClient

Public Class STOCK_DETAILS
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand

    Private Sub STOCK_DETAILS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        cmd.CommandText = "select * from stock_details"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Enter Value First")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into stock_details values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')"
            cmd.ExecuteNonQuery()
            disp_data()
            MessageBox.Show("Insert SuccessFully")
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim selectedGR As New DataGridViewRow
        selectedGR = DataGridView1.Rows(e.RowIndex)
        TextBox1.Text = selectedGR.Cells(0).Value
        TextBox2.Text = selectedGR.Cells(1).Value
        TextBox3.Text = selectedGR.Cells(2).Value
        TextBox4.Text = selectedGR.Cells(3).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Enter Value First")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "Update stock_details set itemid='" + TextBox2.Text + "',Qty='" + TextBox3.Text + "',Unit_prc='" + TextBox4.Text + "'where itemname='" + TextBox1.Text + "'"
            cmd.ExecuteNonQuery()

            disp_data()
            MessageBox.Show("Update SuccessFully")
        End If

       
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If TextBox1.Text = "" Then
            MsgBox("Enter Value First")
        Else
            cmd = con.CreateCommand
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from stock_details where itemname='" + TextBox1.Text + "'"
            cmd.ExecuteNonQuery()

            disp_data()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            MessageBox.Show("Delete SucceSsFully")
        End If

        

    End Sub

   

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Not e.KeyChar = Chr(Keys.Back) Then
            e.KeyChar = Nothing
            MessageBox.Show("Enter Number Only")
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Not e.KeyChar = Chr(Keys.Back) Then
            e.KeyChar = Nothing
            MessageBox.Show("Enter Number Only")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Char.IsNumber(e.KeyChar) = False And Not e.KeyChar = Chr(Keys.Back) Then
            e.KeyChar = Nothing
            MessageBox.Show("Enter Number Only")
        End If
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class