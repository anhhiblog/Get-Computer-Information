<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGCI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGCI))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMBProduct = New System.Windows.Forms.TextBox()
        Me.txtMBManufacture = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lvStorage = New System.Windows.Forms.ListView()
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtHDModel = New System.Windows.Forms.TextBox()
        Me.txtHDType = New System.Windows.Forms.TextBox()
        Me.txtHDSize = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lvMemory = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtMemType = New System.Windows.Forms.TextBox()
        Me.txtMemSpeed = New System.Windows.Forms.TextBox()
        Me.txtMemSize = New System.Windows.Forms.TextBox()
        Me.txtMemSlots = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lvNetwork = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtNWAdapter = New System.Windows.Forms.TextBox()
        Me.txtNWMac = New System.Windows.Forms.TextBox()
        Me.txtNWIp = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtProcessor = New System.Windows.Forms.TextBox()
        Me.txtWinVer = New System.Windows.Forms.TextBox()
        Me.txtOS = New System.Windows.Forms.TextBox()
        Me.txtPCName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tsMenu = New System.Windows.Forms.ToolStrip()
        Me.tsbExportHtml = New System.Windows.Forms.ToolStripButton()
        Me.tsbAbout = New System.Windows.Forms.ToolStripButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tsMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox2.Controls.Add(Me.txtMBProduct)
        Me.GroupBox2.Controls.Add(Me.txtMBManufacture)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(409, 112)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 78)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mainboard"
        '
        'txtMBProduct
        '
        Me.txtMBProduct.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtMBProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMBProduct.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMBProduct.ForeColor = System.Drawing.Color.Blue
        Me.txtMBProduct.Location = New System.Drawing.Point(96, 46)
        Me.txtMBProduct.Name = "txtMBProduct"
        Me.txtMBProduct.ReadOnly = True
        Me.txtMBProduct.ShortcutsEnabled = False
        Me.txtMBProduct.Size = New System.Drawing.Size(199, 23)
        Me.txtMBProduct.TabIndex = 1
        '
        'txtMBManufacture
        '
        Me.txtMBManufacture.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtMBManufacture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMBManufacture.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMBManufacture.ForeColor = System.Drawing.Color.Blue
        Me.txtMBManufacture.Location = New System.Drawing.Point(96, 17)
        Me.txtMBManufacture.Name = "txtMBManufacture"
        Me.txtMBManufacture.ReadOnly = True
        Me.txtMBManufacture.ShortcutsEnabled = False
        Me.txtMBManufacture.Size = New System.Drawing.Size(199, 23)
        Me.txtMBManufacture.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(43, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Product"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(10, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 16)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Manufacturer"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox3.Controls.Add(Me.lvStorage)
        Me.GroupBox3.Controls.Add(Me.txtHDModel)
        Me.GroupBox3.Controls.Add(Me.txtHDType)
        Me.GroupBox3.Controls.Add(Me.txtHDSize)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(409, 196)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 171)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Storage"
        '
        'lvStorage
        '
        Me.lvStorage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lvStorage.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader7, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.lvStorage.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvStorage.ForeColor = System.Drawing.Color.Blue
        Me.lvStorage.FullRowSelect = True
        Me.lvStorage.GridLines = True
        Me.lvStorage.HideSelection = False
        Me.lvStorage.Location = New System.Drawing.Point(6, 74)
        Me.lvStorage.MultiSelect = False
        Me.lvStorage.Name = "lvStorage"
        Me.lvStorage.Size = New System.Drawing.Size(291, 90)
        Me.lvStorage.TabIndex = 2
        Me.lvStorage.UseCompatibleStateImageBehavior = False
        Me.lvStorage.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Volume"
        Me.ColumnHeader7.Width = 105
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Size"
        Me.ColumnHeader9.Width = 90
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Free Space"
        Me.ColumnHeader10.Width = 90
        '
        'txtHDModel
        '
        Me.txtHDModel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtHDModel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHDModel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHDModel.ForeColor = System.Drawing.Color.Blue
        Me.txtHDModel.Location = New System.Drawing.Point(55, 46)
        Me.txtHDModel.Name = "txtHDModel"
        Me.txtHDModel.ReadOnly = True
        Me.txtHDModel.ShortcutsEnabled = False
        Me.txtHDModel.Size = New System.Drawing.Size(240, 23)
        Me.txtHDModel.TabIndex = 1
        '
        'txtHDType
        '
        Me.txtHDType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtHDType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHDType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHDType.ForeColor = System.Drawing.Color.Blue
        Me.txtHDType.Location = New System.Drawing.Point(197, 17)
        Me.txtHDType.Name = "txtHDType"
        Me.txtHDType.ReadOnly = True
        Me.txtHDType.ShortcutsEnabled = False
        Me.txtHDType.Size = New System.Drawing.Size(98, 23)
        Me.txtHDType.TabIndex = 1
        '
        'txtHDSize
        '
        Me.txtHDSize.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtHDSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHDSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHDSize.ForeColor = System.Drawing.Color.Blue
        Me.txtHDSize.Location = New System.Drawing.Point(55, 18)
        Me.txtHDSize.Name = "txtHDSize"
        Me.txtHDSize.ReadOnly = True
        Me.txtHDSize.ShortcutsEnabled = False
        Me.txtHDSize.Size = New System.Drawing.Size(98, 23)
        Me.txtHDSize.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Model"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(159, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 16)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(21, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Size"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox5.Controls.Add(Me.lvMemory)
        Me.GroupBox5.Controls.Add(Me.txtMemType)
        Me.GroupBox5.Controls.Add(Me.txtMemSpeed)
        Me.GroupBox5.Controls.Add(Me.txtMemSize)
        Me.GroupBox5.Controls.Add(Me.txtMemSlots)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(5, 112)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(392, 146)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Memory"
        '
        'lvMemory
        '
        Me.lvMemory.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lvMemory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvMemory.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvMemory.ForeColor = System.Drawing.Color.Blue
        Me.lvMemory.FullRowSelect = True
        Me.lvMemory.GridLines = True
        Me.lvMemory.HideSelection = False
        Me.lvMemory.Location = New System.Drawing.Point(9, 48)
        Me.lvMemory.MultiSelect = False
        Me.lvMemory.Name = "lvMemory"
        Me.lvMemory.Size = New System.Drawing.Size(374, 90)
        Me.lvMemory.TabIndex = 2
        Me.lvMemory.UseCompatibleStateImageBehavior = False
        Me.lvMemory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "No."
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Size"
        Me.ColumnHeader4.Width = 65
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Speed"
        Me.ColumnHeader5.Width = 90
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Manufacturer"
        Me.ColumnHeader6.Width = 143
        '
        'txtMemType
        '
        Me.txtMemType.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtMemType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemType.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemType.ForeColor = System.Drawing.Color.Blue
        Me.txtMemType.Location = New System.Drawing.Point(331, 19)
        Me.txtMemType.Name = "txtMemType"
        Me.txtMemType.ReadOnly = True
        Me.txtMemType.ShortcutsEnabled = False
        Me.txtMemType.Size = New System.Drawing.Size(52, 23)
        Me.txtMemType.TabIndex = 1
        '
        'txtMemSpeed
        '
        Me.txtMemSpeed.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtMemSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemSpeed.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemSpeed.ForeColor = System.Drawing.Color.Blue
        Me.txtMemSpeed.Location = New System.Drawing.Point(206, 19)
        Me.txtMemSpeed.Name = "txtMemSpeed"
        Me.txtMemSpeed.ReadOnly = True
        Me.txtMemSpeed.ShortcutsEnabled = False
        Me.txtMemSpeed.Size = New System.Drawing.Size(81, 23)
        Me.txtMemSpeed.TabIndex = 1
        '
        'txtMemSize
        '
        Me.txtMemSize.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtMemSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemSize.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemSize.ForeColor = System.Drawing.Color.Blue
        Me.txtMemSize.Location = New System.Drawing.Point(109, 19)
        Me.txtMemSize.Name = "txtMemSize"
        Me.txtMemSize.ReadOnly = True
        Me.txtMemSize.ShortcutsEnabled = False
        Me.txtMemSize.Size = New System.Drawing.Size(45, 23)
        Me.txtMemSize.TabIndex = 1
        '
        'txtMemSlots
        '
        Me.txtMemSlots.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtMemSlots.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMemSlots.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemSlots.ForeColor = System.Drawing.Color.Blue
        Me.txtMemSlots.Location = New System.Drawing.Point(44, 19)
        Me.txtMemSlots.Name = "txtMemSlots"
        Me.txtMemSlots.ReadOnly = True
        Me.txtMemSlots.ShortcutsEnabled = False
        Me.txtMemSlots.Size = New System.Drawing.Size(24, 23)
        Me.txtMemSlots.TabIndex = 1
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(293, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 16)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "Type"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(160, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 16)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Speed"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(75, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 16)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Size"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(6, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 16)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Slots"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox4.Controls.Add(Me.lvNetwork)
        Me.GroupBox4.Controls.Add(Me.txtNWAdapter)
        Me.GroupBox4.Controls.Add(Me.txtNWMac)
        Me.GroupBox4.Controls.Add(Me.txtNWIp)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(5, 264)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(392, 173)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Network"
        '
        'lvNetwork
        '
        Me.lvNetwork.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.lvNetwork.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvNetwork.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvNetwork.ForeColor = System.Drawing.Color.Blue
        Me.lvNetwork.FullRowSelect = True
        Me.lvNetwork.GridLines = True
        Me.lvNetwork.HideSelection = False
        Me.lvNetwork.Location = New System.Drawing.Point(9, 74)
        Me.lvNetwork.MultiSelect = False
        Me.lvNetwork.Name = "lvNetwork"
        Me.lvNetwork.Size = New System.Drawing.Size(374, 90)
        Me.lvNetwork.TabIndex = 2
        Me.lvNetwork.UseCompatibleStateImageBehavior = False
        Me.lvNetwork.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Connection ID"
        Me.ColumnHeader1.Width = 168
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "MAC address"
        Me.ColumnHeader2.Width = 200
        '
        'txtNWAdapter
        '
        Me.txtNWAdapter.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNWAdapter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNWAdapter.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNWAdapter.ForeColor = System.Drawing.Color.Blue
        Me.txtNWAdapter.Location = New System.Drawing.Point(70, 45)
        Me.txtNWAdapter.Name = "txtNWAdapter"
        Me.txtNWAdapter.ReadOnly = True
        Me.txtNWAdapter.ShortcutsEnabled = False
        Me.txtNWAdapter.Size = New System.Drawing.Size(313, 23)
        Me.txtNWAdapter.TabIndex = 1
        '
        'txtNWMac
        '
        Me.txtNWMac.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNWMac.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNWMac.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNWMac.ForeColor = System.Drawing.Color.Blue
        Me.txtNWMac.Location = New System.Drawing.Point(242, 17)
        Me.txtNWMac.Name = "txtNWMac"
        Me.txtNWMac.ReadOnly = True
        Me.txtNWMac.ShortcutsEnabled = False
        Me.txtNWMac.Size = New System.Drawing.Size(141, 23)
        Me.txtNWMac.TabIndex = 1
        '
        'txtNWIp
        '
        Me.txtNWIp.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtNWIp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNWIp.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNWIp.ForeColor = System.Drawing.Color.Blue
        Me.txtNWIp.Location = New System.Drawing.Point(70, 17)
        Me.txtNWIp.Name = "txtNWIp"
        Me.txtNWIp.ReadOnly = True
        Me.txtNWIp.ShortcutsEnabled = False
        Me.txtNWIp.Size = New System.Drawing.Size(130, 23)
        Me.txtNWIp.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(15, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Adapter"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(206, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(34, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "MAC"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(49, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "IP"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.GroupBox1.Controls.Add(Me.txtProcessor)
        Me.GroupBox1.Controls.Add(Me.txtWinVer)
        Me.GroupBox1.Controls.Add(Me.txtOS)
        Me.GroupBox1.Controls.Add(Me.txtPCName)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(5, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(707, 76)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Summary"
        '
        'txtProcessor
        '
        Me.txtProcessor.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtProcessor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProcessor.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProcessor.ForeColor = System.Drawing.Color.Blue
        Me.txtProcessor.Location = New System.Drawing.Point(386, 46)
        Me.txtProcessor.Name = "txtProcessor"
        Me.txtProcessor.ReadOnly = True
        Me.txtProcessor.ShortcutsEnabled = False
        Me.txtProcessor.Size = New System.Drawing.Size(313, 23)
        Me.txtProcessor.TabIndex = 2
        '
        'txtWinVer
        '
        Me.txtWinVer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtWinVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWinVer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWinVer.ForeColor = System.Drawing.Color.Blue
        Me.txtWinVer.Location = New System.Drawing.Point(115, 45)
        Me.txtWinVer.Name = "txtWinVer"
        Me.txtWinVer.ReadOnly = True
        Me.txtWinVer.ShortcutsEnabled = False
        Me.txtWinVer.Size = New System.Drawing.Size(199, 23)
        Me.txtWinVer.TabIndex = 3
        '
        'txtOS
        '
        Me.txtOS.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOS.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOS.ForeColor = System.Drawing.Color.Blue
        Me.txtOS.Location = New System.Drawing.Point(386, 17)
        Me.txtOS.Name = "txtOS"
        Me.txtOS.ReadOnly = True
        Me.txtOS.ShortcutsEnabled = False
        Me.txtOS.Size = New System.Drawing.Size(245, 23)
        Me.txtOS.TabIndex = 1
        '
        'txtPCName
        '
        Me.txtPCName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtPCName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPCName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPCName.ForeColor = System.Drawing.Color.Blue
        Me.txtPCName.Location = New System.Drawing.Point(115, 16)
        Me.txtPCName.Name = "txtPCName"
        Me.txtPCName.ReadOnly = True
        Me.txtPCName.ShortcutsEnabled = False
        Me.txtPCName.Size = New System.Drawing.Size(153, 23)
        Me.txtPCName.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(107, 16)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Windows Version"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(320, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Processor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(274, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Operating System"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(53, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PC Name"
        '
        'tsMenu
        '
        Me.tsMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tsMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbExportHtml, Me.tsbAbout})
        Me.tsMenu.Location = New System.Drawing.Point(0, 0)
        Me.tsMenu.Name = "tsMenu"
        Me.tsMenu.Size = New System.Drawing.Size(716, 25)
        Me.tsMenu.TabIndex = 1
        Me.tsMenu.Text = "ToolStrip1"
        '
        'tsbExportHtml
        '
        Me.tsbExportHtml.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbExportHtml.Image = CType(resources.GetObject("tsbExportHtml.Image"), System.Drawing.Image)
        Me.tsbExportHtml.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbExportHtml.Name = "tsbExportHtml"
        Me.tsbExportHtml.Size = New System.Drawing.Size(80, 22)
        Me.tsbExportHtml.Text = "Export HTML"
        '
        'tsbAbout
        '
        Me.tsbAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbAbout.Image = CType(resources.GetObject("tsbAbout.Image"), System.Drawing.Image)
        Me.tsbAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAbout.Name = "tsbAbout"
        Me.tsbAbout.Size = New System.Drawing.Size(44, 22)
        Me.tsbAbout.Text = "About"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(473, 413)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(187, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "GET COMPUTER INFORMATION"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GetComputerInfo.My.Resources.Resources.gci
        Me.PictureBox1.Location = New System.Drawing.Point(524, 385)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(87, 25)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmGCI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(716, 441)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.tsMenu)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGCI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GCI"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tsMenu.ResumeLayout(False)
        Me.tsMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPCName As TextBox
    Friend WithEvents txtOS As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProcessor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtMBProduct As TextBox
    Friend WithEvents txtMBManufacture As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtHDModel As TextBox
    Friend WithEvents txtHDType As TextBox
    Friend WithEvents txtHDSize As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtNWAdapter As TextBox
    Friend WithEvents txtNWMac As TextBox
    Friend WithEvents txtNWIp As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lvNetwork As ListView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents lvMemory As ListView
    Friend WithEvents txtMemSize As TextBox
    Friend WithEvents txtMemSlots As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtMemType As TextBox
    Friend WithEvents txtMemSpeed As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents lvStorage As ListView
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents txtWinVer As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tsMenu As ToolStrip
    Friend WithEvents tsbAbout As ToolStripButton
    Friend WithEvents tsbExportHtml As ToolStripButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label17 As Label
End Class
