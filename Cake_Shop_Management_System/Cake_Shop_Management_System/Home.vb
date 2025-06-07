Public Class Home

    Private Sub AddOrderDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddOrderDetailsToolStripMenuItem.Click

        Dim prg As New Add_Order_Details
        prg.MdiParent = Me
        prg.Show()


    End Sub

    Private Sub UpdateOrderDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateOrderDetailsToolStripMenuItem.Click
        Dim prg As New Update_Order_Details
        prg.MdiParent = Me
        prg.Show()
    End Sub

    Private Sub DeleteOrderDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteOrderDetailsToolStripMenuItem.Click
        Dim prg As New Delete_Order_Details        
        prg.MdiParent = Me
        prg.Show()
    End Sub

    Private Sub SearchOrderDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchOrderDetailsToolStripMenuItem.Click
        Dim prg As New Search_Order_Details
        prg.MdiParent = Me
        prg.Show()
    End Sub

    Private Sub ViewOrderDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewOrderDetailsToolStripMenuItem.Click
        Dim prg As New View_Order_Details
        prg.MdiParent = Me
        prg.Show()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
       

    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem1.Click
        Me.Hide()

        Form1.Show()
    End Sub

    Private Sub STOCKDETAILSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOCKDETAILSToolStripMenuItem.Click
        Dim prg As New STOCK_DETAILS
        prg.MdiParent = Me
        prg.Show()
    End Sub

    Private Sub StockMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockMasterToolStripMenuItem.Click
        Dim prg As New Stock_Master
        prg.MdiParent = Me
        prg.Show()
    End Sub

   
    Private Sub INVOICEINFORMATIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INVOICEINFORMATIONToolStripMenuItem.Click
        Dim prg As New INVOICE_INFORMATION
        prg.MdiParent = Me
        prg.Show()
    End Sub

    Private Sub InvoiceDetalisToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoiceDetalisToolStripMenuItem.Click
        Dim prg As New Invoice_Detalis
        prg.MdiParent = Me
        prg.Show()
    End Sub

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class