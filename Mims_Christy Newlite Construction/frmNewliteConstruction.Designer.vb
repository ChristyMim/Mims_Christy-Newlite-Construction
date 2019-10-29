<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewliteConstruction
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
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewShippingOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutNewliteConstructionCompanyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbShipTo = New System.Windows.Forms.ComboBox()
        Me.cmbShipFrom = New System.Windows.Forms.ComboBox()
        Me.lstFreightCompany = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRemoveAll = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnAddAll = New System.Windows.Forms.Button()
        Me.lstShip = New System.Windows.Forms.ListBox()
        Me.lstInventory = New System.Windows.Forms.ListBox()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnCalculateShippingCharge = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(992, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewShippingOrderToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'NewShippingOrderToolStripMenuItem
        '
        Me.NewShippingOrderToolStripMenuItem.Name = "NewShippingOrderToolStripMenuItem"
        Me.NewShippingOrderToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.NewShippingOrderToolStripMenuItem.Text = "&New Shipping Order"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutNewliteConstructionCompanyToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutNewliteConstructionCompanyToolStripMenuItem
        '
        Me.AboutNewliteConstructionCompanyToolStripMenuItem.Name = "AboutNewliteConstructionCompanyToolStripMenuItem"
        Me.AboutNewliteConstructionCompanyToolStripMenuItem.Size = New System.Drawing.Size(277, 22)
        Me.AboutNewliteConstructionCompanyToolStripMenuItem.Text = "&About Newlite Construction Company"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbShipTo)
        Me.GroupBox1.Controls.Add(Me.cmbShipFrom)
        Me.GroupBox1.Controls.Add(Me.lstFreightCompany)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 49)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(380, 225)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shipping Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Freight Company"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(210, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Ship to:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Ship from:"
        '
        'cmbShipTo
        '
        Me.cmbShipTo.FormattingEnabled = True
        Me.cmbShipTo.Items.AddRange(New Object() {"Birmingham, AL", "Gulfport, MS", "Jackson, MS", "Knoxville, TN", "Memphis, TN", "Mobile, AL", "Tupelo, MS"})
        Me.cmbShipTo.Location = New System.Drawing.Point(213, 59)
        Me.cmbShipTo.Name = "cmbShipTo"
        Me.cmbShipTo.Size = New System.Drawing.Size(121, 21)
        Me.cmbShipTo.Sorted = True
        Me.cmbShipTo.TabIndex = 2
        '
        'cmbShipFrom
        '
        Me.cmbShipFrom.FormattingEnabled = True
        Me.cmbShipFrom.Items.AddRange(New Object() {"Birmingham, AL", "Gulfport, MS", "Jackson, MS", "Knoxville, TN", "Memphis, TN", "Mobile, AL", "Tupelo, MS"})
        Me.cmbShipFrom.Location = New System.Drawing.Point(22, 59)
        Me.cmbShipFrom.Name = "cmbShipFrom"
        Me.cmbShipFrom.Size = New System.Drawing.Size(121, 21)
        Me.cmbShipFrom.Sorted = True
        Me.cmbShipFrom.TabIndex = 1
        '
        'lstFreightCompany
        '
        Me.lstFreightCompany.FormattingEnabled = True
        Me.lstFreightCompany.Items.AddRange(New Object() {"Mid-South Freight Company", "Southern Shipping", "Tri-State Transport", "USA Heavy Haulers, Inc."})
        Me.lstFreightCompany.Location = New System.Drawing.Point(22, 124)
        Me.lstFreightCompany.Name = "lstFreightCompany"
        Me.lstFreightCompany.Size = New System.Drawing.Size(185, 95)
        Me.lstFreightCompany.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnRemoveAll)
        Me.GroupBox2.Controls.Add(Me.btnRemove)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Controls.Add(Me.btnAddAll)
        Me.GroupBox2.Controls.Add(Me.lstShip)
        Me.GroupBox2.Controls.Add(Me.lstInventory)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 294)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(467, 205)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Equipment Selection"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(284, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Equipment to Ship"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Equipment in Inventory"
        '
        'btnRemoveAll
        '
        Me.btnRemoveAll.Location = New System.Drawing.Point(189, 161)
        Me.btnRemoveAll.Name = "btnRemoveAll"
        Me.btnRemoveAll.Size = New System.Drawing.Size(75, 23)
        Me.btnRemoveAll.TabIndex = 6
        Me.btnRemoveAll.Text = "<<"
        Me.btnRemoveAll.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(189, 132)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 5
        Me.btnRemove.Text = "<"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(189, 103)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = ">"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnAddAll
        '
        Me.btnAddAll.Location = New System.Drawing.Point(189, 74)
        Me.btnAddAll.Name = "btnAddAll"
        Me.btnAddAll.Size = New System.Drawing.Size(75, 23)
        Me.btnAddAll.TabIndex = 3
        Me.btnAddAll.Text = ">>"
        Me.btnAddAll.UseVisualStyleBackColor = True
        '
        'lstShip
        '
        Me.lstShip.FormattingEnabled = True
        Me.lstShip.Location = New System.Drawing.Point(287, 65)
        Me.lstShip.Name = "lstShip"
        Me.lstShip.Size = New System.Drawing.Size(138, 134)
        Me.lstShip.TabIndex = 1
        '
        'lstInventory
        '
        Me.lstInventory.FormattingEnabled = True
        Me.lstInventory.Items.AddRange(New Object() {"D65 Bulldozer", "D72 Bulldozer", "E1000 Excavator", "E450 Compact Excavator", "SC 200 Scraper", "ST 500 Skid Steer Loader"})
        Me.lstInventory.Location = New System.Drawing.Point(22, 65)
        Me.lstInventory.Name = "lstInventory"
        Me.lstInventory.Size = New System.Drawing.Size(138, 134)
        Me.lstInventory.TabIndex = 0
        '
        'lstResults
        '
        Me.lstResults.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 14
        Me.lstResults.Location = New System.Drawing.Point(563, 49)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(380, 438)
        Me.lstResults.TabIndex = 2
        '
        'btnCalculateShippingCharge
        '
        Me.btnCalculateShippingCharge.Location = New System.Drawing.Point(204, 524)
        Me.btnCalculateShippingCharge.Name = "btnCalculateShippingCharge"
        Me.btnCalculateShippingCharge.Size = New System.Drawing.Size(101, 43)
        Me.btnCalculateShippingCharge.TabIndex = 3
        Me.btnCalculateShippingCharge.Text = "Calculate" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Shipping Charge"
        Me.btnCalculateShippingCharge.UseVisualStyleBackColor = True
        '
        'frmNewliteConstruction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 579)
        Me.Controls.Add(Me.btnCalculateShippingCharge)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmNewliteConstruction"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewShippingOrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutNewliteConstructionCompanyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lstResults As ListBox
    Friend WithEvents cmbShipTo As ComboBox
    Friend WithEvents cmbShipFrom As ComboBox
    Friend WithEvents lstFreightCompany As ListBox
    Friend WithEvents lstShip As ListBox
    Friend WithEvents lstInventory As ListBox
    Friend WithEvents btnRemoveAll As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnAddAll As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCalculateShippingCharge As Button
End Class
