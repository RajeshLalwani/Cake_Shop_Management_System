<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddOrderDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateOrderDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteOrderDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchOrderDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewOrderDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.STOCKDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RECEIVIEDSTOCKDETAILSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.INVOICEINFORMATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvoiceDetalisToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightGray
        Me.MenuStrip1.BackgroundImage = Global.Cake_Shop_Management_System.My.Resources.Resources.ChatGPT_Image_Jun_7__2025__05_23_17_PM
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem, Me.OrderToolStripMenuItem, Me.StockToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.LogoutToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1448, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddOrderDetailsToolStripMenuItem, Me.UpdateOrderDetailsToolStripMenuItem, Me.DeleteOrderDetailsToolStripMenuItem, Me.SearchOrderDetailsToolStripMenuItem, Me.ViewOrderDetailsToolStripMenuItem})
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(59, 24)
        Me.OrderToolStripMenuItem.Text = "Order"
        '
        'AddOrderDetailsToolStripMenuItem
        '
        Me.AddOrderDetailsToolStripMenuItem.Name = "AddOrderDetailsToolStripMenuItem"
        Me.AddOrderDetailsToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.AddOrderDetailsToolStripMenuItem.Text = "Add Order Details"
        '
        'UpdateOrderDetailsToolStripMenuItem
        '
        Me.UpdateOrderDetailsToolStripMenuItem.Name = "UpdateOrderDetailsToolStripMenuItem"
        Me.UpdateOrderDetailsToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.UpdateOrderDetailsToolStripMenuItem.Text = "Update Order Details"
        '
        'DeleteOrderDetailsToolStripMenuItem
        '
        Me.DeleteOrderDetailsToolStripMenuItem.Name = "DeleteOrderDetailsToolStripMenuItem"
        Me.DeleteOrderDetailsToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.DeleteOrderDetailsToolStripMenuItem.Text = "Delete Order Details"
        '
        'SearchOrderDetailsToolStripMenuItem
        '
        Me.SearchOrderDetailsToolStripMenuItem.Name = "SearchOrderDetailsToolStripMenuItem"
        Me.SearchOrderDetailsToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.SearchOrderDetailsToolStripMenuItem.Text = "Search Order Details"
        '
        'ViewOrderDetailsToolStripMenuItem
        '
        Me.ViewOrderDetailsToolStripMenuItem.Name = "ViewOrderDetailsToolStripMenuItem"
        Me.ViewOrderDetailsToolStripMenuItem.Size = New System.Drawing.Size(219, 24)
        Me.ViewOrderDetailsToolStripMenuItem.Text = "View Order Details"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STOCKDETAILSToolStripMenuItem, Me.StockMasterToolStripMenuItem, Me.RECEIVIEDSTOCKDETAILSToolStripMenuItem})
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.StockToolStripMenuItem.Text = "Stock"
        '
        'STOCKDETAILSToolStripMenuItem
        '
        Me.STOCKDETAILSToolStripMenuItem.Name = "STOCKDETAILSToolStripMenuItem"
        Me.STOCKDETAILSToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.STOCKDETAILSToolStripMenuItem.Text = "Stock details"
        '
        'StockMasterToolStripMenuItem
        '
        Me.StockMasterToolStripMenuItem.Name = "StockMasterToolStripMenuItem"
        Me.StockMasterToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.StockMasterToolStripMenuItem.Text = "Stock Master"
        '
        'RECEIVIEDSTOCKDETAILSToolStripMenuItem
        '
        Me.RECEIVIEDSTOCKDETAILSToolStripMenuItem.Name = "RECEIVIEDSTOCKDETAILSToolStripMenuItem"
        Me.RECEIVIEDSTOCKDETAILSToolStripMenuItem.Size = New System.Drawing.Size(163, 24)
        Me.RECEIVIEDSTOCKDETAILSToolStripMenuItem.Text = " "
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.INVOICEINFORMATIONToolStripMenuItem, Me.InvoiceDetalisToolStripMenuItem})
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.LogoutToolStripMenuItem.Text = "Invoice"
        '
        'INVOICEINFORMATIONToolStripMenuItem
        '
        Me.INVOICEINFORMATIONToolStripMenuItem.Name = "INVOICEINFORMATIONToolStripMenuItem"
        Me.INVOICEINFORMATIONToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.INVOICEINFORMATIONToolStripMenuItem.Text = "Invoice information"
        '
        'InvoiceDetalisToolStripMenuItem
        '
        Me.InvoiceDetalisToolStripMenuItem.Name = "InvoiceDetalisToolStripMenuItem"
        Me.InvoiceDetalisToolStripMenuItem.Size = New System.Drawing.Size(207, 24)
        Me.InvoiceDetalisToolStripMenuItem.Text = "Invoice Detalis"
        '
        'LogoutToolStripMenuItem1
        '
        Me.LogoutToolStripMenuItem1.Name = "LogoutToolStripMenuItem1"
        Me.LogoutToolStripMenuItem1.Size = New System.Drawing.Size(68, 24)
        Me.LogoutToolStripMenuItem1.Text = "Logout"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cake_Shop_Management_System.My.Resources.Resources.ChatGPT_Image_Jun_7__2025__05_23_17_PM
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1448, 767)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents HomeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddOrderDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateOrderDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteOrderDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchOrderDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewOrderDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents STOCKDETAILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RECEIVIEDSTOCKDETAILSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INVOICEINFORMATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InvoiceDetalisToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
