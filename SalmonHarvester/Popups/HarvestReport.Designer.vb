<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HarvestReport
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
        Me.components = New System.ComponentModel.Container()
        Dim Label31 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim RepIDLabel1 As System.Windows.Forms.Label
        Dim StarveDateTimeLabel As System.Windows.Forms.Label
        Dim SiteIDLabel As System.Windows.Forms.Label
        Dim RepCommentsLabel As System.Windows.Forms.Label
        Dim EndWeightLabel As System.Windows.Forms.Label
        Dim StartWeightLabel As System.Windows.Forms.Label
        Dim AverageWeightLabel As System.Windows.Forms.Label
        Dim CageNoLabel As System.Windows.Forms.Label
        Dim VesselIDLabel As System.Windows.Forms.Label
        Dim HarvestIDLabel As System.Windows.Forms.Label
        Dim Label34 As System.Windows.Forms.Label
        Dim Label33 As System.Windows.Forms.Label
        Dim Label32 As System.Windows.Forms.Label
        Dim DeliveryDateLabel As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim TempSiteLabel As System.Windows.Forms.Label
        Dim TempWellLabel As System.Windows.Forms.Label
        Dim ConditionIDLabel As System.Windows.Forms.Label
        Dim FishCountLabel As System.Windows.Forms.Label
        Dim SkipperIDLabel As System.Windows.Forms.Label
        Dim PortIDLabel As System.Windows.Forms.Label
        Dim SkipperCommentsLabel As System.Windows.Forms.Label
        Dim EndTimeLabel As System.Windows.Forms.Label
        Dim StartTimeLabel As System.Windows.Forms.Label
        Dim ArrivalTimeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HarvestReport))
        Me.HarvestTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientDS = New MfgControl.AdvancedHMI.ClientDS()
        Me.ConditionTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VesselTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiteTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RepIDComboBox1 = New System.Windows.Forms.ComboBox()
        Me.StarveDateTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SiteIDComboBox = New System.Windows.Forms.ComboBox()
        Me.RepCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.EndWeightTextBox = New System.Windows.Forms.TextBox()
        Me.StartWeightTextBox = New System.Windows.Forms.TextBox()
        Me.AverageWeightTextBox = New System.Windows.Forms.TextBox()
        Me.CageNoTextBox = New System.Windows.Forms.TextBox()
        Me.VesselIDComboBox = New System.Windows.Forms.ComboBox()
        Me.HarvestIDTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBBiomass = New System.Windows.Forms.TextBox()
        Me.TempSiteTextBox = New System.Windows.Forms.TextBox()
        Me.TempWellTextBox = New System.Windows.Forms.TextBox()
        Me.ConditionIDComboBox = New System.Windows.Forms.ComboBox()
        Me.FishCountTextBox = New System.Windows.Forms.TextBox()
        Me.SkipperIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SkipperTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkipperCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.PortIDComboBox = New System.Windows.Forms.ComboBox()
        Me.PortTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HarvestTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HarvestTBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintForm2 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Label31 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        RepIDLabel1 = New System.Windows.Forms.Label()
        StarveDateTimeLabel = New System.Windows.Forms.Label()
        SiteIDLabel = New System.Windows.Forms.Label()
        RepCommentsLabel = New System.Windows.Forms.Label()
        EndWeightLabel = New System.Windows.Forms.Label()
        StartWeightLabel = New System.Windows.Forms.Label()
        AverageWeightLabel = New System.Windows.Forms.Label()
        CageNoLabel = New System.Windows.Forms.Label()
        VesselIDLabel = New System.Windows.Forms.Label()
        HarvestIDLabel = New System.Windows.Forms.Label()
        Label34 = New System.Windows.Forms.Label()
        Label33 = New System.Windows.Forms.Label()
        Label32 = New System.Windows.Forms.Label()
        DeliveryDateLabel = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        TempSiteLabel = New System.Windows.Forms.Label()
        TempWellLabel = New System.Windows.Forms.Label()
        ConditionIDLabel = New System.Windows.Forms.Label()
        FishCountLabel = New System.Windows.Forms.Label()
        SkipperIDLabel = New System.Windows.Forms.Label()
        PortIDLabel = New System.Windows.Forms.Label()
        SkipperCommentsLabel = New System.Windows.Forms.Label()
        EndTimeLabel = New System.Windows.Forms.Label()
        StartTimeLabel = New System.Windows.Forms.Label()
        ArrivalTimeLabel = New System.Windows.Forms.Label()
        CType(Me.HarvestTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConditionTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VesselTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiteTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SkipperTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PortTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HarvestTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HarvestTBindingNavigator.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label31
        '
        Label31.AutoSize = True
        Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label31.Location = New System.Drawing.Point(693, 81)
        Label31.Name = "Label31"
        Label31.Size = New System.Drawing.Size(54, 16)
        Label31.TabIndex = 103
        Label31.Text = "Tonnes"
        '
        'Label30
        '
        Label30.AutoSize = True
        Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label30.Location = New System.Drawing.Point(693, 53)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(54, 16)
        Label30.TabIndex = 102
        Label30.Text = "Tonnes"
        '
        'Label29
        '
        Label29.AutoSize = True
        Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label29.Location = New System.Drawing.Point(292, 78)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(23, 16)
        Label29.TabIndex = 101
        Label29.Text = "kg"
        '
        'RepIDLabel1
        '
        RepIDLabel1.AutoSize = True
        RepIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        RepIDLabel1.Location = New System.Drawing.Point(32, 160)
        RepIDLabel1.Name = "RepIDLabel1"
        RepIDLabel1.Size = New System.Drawing.Size(129, 16)
        RepIDLabel1.TabIndex = 99
        RepIDLabel1.Text = "Site Representative:"
        '
        'StarveDateTimeLabel
        '
        StarveDateTimeLabel.AutoSize = True
        StarveDateTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StarveDateTimeLabel.Location = New System.Drawing.Point(372, 25)
        StarveDateTimeLabel.Name = "StarveDateTimeLabel"
        StarveDateTimeLabel.Size = New System.Drawing.Size(82, 16)
        StarveDateTimeLabel.TabIndex = 89
        StarveDateTimeLabel.Text = "Starve Date:"
        '
        'SiteIDLabel
        '
        SiteIDLabel.AutoSize = True
        SiteIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SiteIDLabel.Location = New System.Drawing.Point(32, 22)
        SiteIDLabel.Name = "SiteIDLabel"
        SiteIDLabel.Size = New System.Drawing.Size(34, 16)
        SiteIDLabel.TabIndex = 87
        SiteIDLabel.Text = "Site:"
        '
        'RepCommentsLabel
        '
        RepCommentsLabel.AutoSize = True
        RepCommentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        RepCommentsLabel.Location = New System.Drawing.Point(32, 106)
        RepCommentsLabel.Name = "RepCommentsLabel"
        RepCommentsLabel.Size = New System.Drawing.Size(75, 16)
        RepCommentsLabel.TabIndex = 75
        RepCommentsLabel.Text = "Comments:"
        '
        'EndWeightLabel
        '
        EndWeightLabel.AutoSize = True
        EndWeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        EndWeightLabel.Location = New System.Drawing.Point(372, 78)
        EndWeightLabel.Name = "EndWeightLabel"
        EndWeightLabel.Size = New System.Drawing.Size(170, 16)
        EndWeightLabel.TabIndex = 73
        EndWeightLabel.Text = "Cage Tonnage Remaining:"
        '
        'StartWeightLabel
        '
        StartWeightLabel.AutoSize = True
        StartWeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        StartWeightLabel.Location = New System.Drawing.Point(372, 53)
        StartWeightLabel.Name = "StartWeightLabel"
        StartWeightLabel.Size = New System.Drawing.Size(160, 16)
        StartWeightLabel.TabIndex = 71
        StartWeightLabel.Text = "Cage Pre-Uplift Tonnage:"
        '
        'AverageWeightLabel
        '
        AverageWeightLabel.AutoSize = True
        AverageWeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        AverageWeightLabel.Location = New System.Drawing.Point(32, 81)
        AverageWeightLabel.Name = "AverageWeightLabel"
        AverageWeightLabel.Size = New System.Drawing.Size(108, 16)
        AverageWeightLabel.TabIndex = 69
        AverageWeightLabel.Text = "Average Weight:"
        '
        'CageNoLabel
        '
        CageNoLabel.AutoSize = True
        CageNoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CageNoLabel.Location = New System.Drawing.Point(32, 52)
        CageNoLabel.Name = "CageNoLabel"
        CageNoLabel.Size = New System.Drawing.Size(65, 16)
        CageNoLabel.TabIndex = 67
        CageNoLabel.Text = "Cage No:"
        '
        'VesselIDLabel
        '
        VesselIDLabel.AutoSize = True
        VesselIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VesselIDLabel.Location = New System.Drawing.Point(42, 135)
        VesselIDLabel.Name = "VesselIDLabel"
        VesselIDLabel.Size = New System.Drawing.Size(93, 16)
        VesselIDLabel.TabIndex = 104
        VesselIDLabel.Text = "Vessel Name:"
        '
        'HarvestIDLabel
        '
        HarvestIDLabel.AutoSize = True
        HarvestIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HarvestIDLabel.Location = New System.Drawing.Point(447, 136)
        HarvestIDLabel.Name = "HarvestIDLabel"
        HarvestIDLabel.Size = New System.Drawing.Size(133, 16)
        HarvestIDLabel.TabIndex = 102
        HarvestIDLabel.Text = "Delivery/Harvest No:"
        '
        'Label34
        '
        Label34.AutoSize = True
        Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label34.Location = New System.Drawing.Point(322, 59)
        Label34.Name = "Label34"
        Label34.Size = New System.Drawing.Size(23, 16)
        Label34.TabIndex = 105
        Label34.Text = "kg"
        '
        'Label33
        '
        Label33.AutoSize = True
        Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label33.Location = New System.Drawing.Point(583, 118)
        Label33.Name = "Label33"
        Label33.Size = New System.Drawing.Size(21, 16)
        Label33.TabIndex = 104
        Label33.Text = "°C"
        '
        'Label32
        '
        Label32.AutoSize = True
        Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label32.Location = New System.Drawing.Point(241, 118)
        Label32.Name = "Label32"
        Label32.Size = New System.Drawing.Size(21, 16)
        Label32.TabIndex = 103
        Label32.Text = "°C"
        '
        'DeliveryDateLabel
        '
        DeliveryDateLabel.AutoSize = True
        DeliveryDateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DeliveryDateLabel.Location = New System.Drawing.Point(559, 171)
        DeliveryDateLabel.Name = "DeliveryDateLabel"
        DeliveryDateLabel.Size = New System.Drawing.Size(83, 16)
        DeliveryDateLabel.TabIndex = 101
        DeliveryDateLabel.Text = "Time at Pier:"
        '
        'Label28
        '
        Label28.AutoSize = True
        Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Label28.Location = New System.Drawing.Point(30, 59)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(138, 16)
        Label28.TabIndex = 98
        Label28.Text = "Est. Biomass Uplifted:"
        '
        'TempSiteLabel
        '
        TempSiteLabel.AutoSize = True
        TempSiteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TempSiteLabel.Location = New System.Drawing.Point(374, 118)
        TempSiteLabel.Name = "TempSiteLabel"
        TempSiteLabel.Size = New System.Drawing.Size(115, 16)
        TempSiteLabel.TabIndex = 83
        TempSiteLabel.Text = "Site Temperature:"
        '
        'TempWellLabel
        '
        TempWellLabel.AutoSize = True
        TempWellLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        TempWellLabel.Location = New System.Drawing.Point(30, 118)
        TempWellLabel.Name = "TempWellLabel"
        TempWellLabel.Size = New System.Drawing.Size(119, 16)
        TempWellLabel.TabIndex = 81
        TempWellLabel.Text = "Well Temperature:"
        '
        'ConditionIDLabel
        '
        ConditionIDLabel.AutoSize = True
        ConditionIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        ConditionIDLabel.Location = New System.Drawing.Point(30, 87)
        ConditionIDLabel.Name = "ConditionIDLabel"
        ConditionIDLabel.Size = New System.Drawing.Size(95, 16)
        ConditionIDLabel.TabIndex = 79
        ConditionIDLabel.Text = "Fish Condition:"
        '
        'FishCountLabel
        '
        FishCountLabel.AutoSize = True
        FishCountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        FishCountLabel.Location = New System.Drawing.Point(30, 31)
        FishCountLabel.Name = "FishCountLabel"
        FishCountLabel.Size = New System.Drawing.Size(127, 16)
        FishCountLabel.TabIndex = 77
        FishCountLabel.Text = "Np. of Fish Counted:"
        '
        'SkipperIDLabel
        '
        SkipperIDLabel.AutoSize = True
        SkipperIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        SkipperIDLabel.Location = New System.Drawing.Point(33, 285)
        SkipperIDLabel.Name = "SkipperIDLabel"
        SkipperIDLabel.Size = New System.Drawing.Size(74, 16)
        SkipperIDLabel.TabIndex = 62
        SkipperIDLabel.Text = "Skipper ID:"
        '
        'PortIDLabel
        '
        PortIDLabel.AutoSize = True
        PortIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        PortIDLabel.Location = New System.Drawing.Point(432, 171)
        PortIDLabel.Name = "PortIDLabel"
        PortIDLabel.Size = New System.Drawing.Size(88, 16)
        PortIDLabel.TabIndex = 60
        PortIDLabel.Text = "Delivery Port:"
        '
        'SkipperCommentsLabel
        '
        SkipperCommentsLabel.AutoSize = True
        SkipperCommentsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        SkipperCommentsLabel.Location = New System.Drawing.Point(30, 230)
        SkipperCommentsLabel.Name = "SkipperCommentsLabel"
        SkipperCommentsLabel.Size = New System.Drawing.Size(125, 16)
        SkipperCommentsLabel.TabIndex = 58
        SkipperCommentsLabel.Text = "Skipper Comments:"
        '
        'EndTimeLabel
        '
        EndTimeLabel.AutoSize = True
        EndTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        EndTimeLabel.Location = New System.Drawing.Point(298, 171)
        EndTimeLabel.Name = "EndTimeLabel"
        EndTimeLabel.Size = New System.Drawing.Size(69, 16)
        EndTimeLabel.TabIndex = 54
        EndTimeLabel.Text = "End Time:"
        '
        'StartTimeLabel
        '
        StartTimeLabel.AutoSize = True
        StartTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        StartTimeLabel.Location = New System.Drawing.Point(164, 171)
        StartTimeLabel.Name = "StartTimeLabel"
        StartTimeLabel.Size = New System.Drawing.Size(72, 16)
        StartTimeLabel.TabIndex = 52
        StartTimeLabel.Text = "Start Time:"
        '
        'ArrivalTimeLabel
        '
        ArrivalTimeLabel.AutoSize = True
        ArrivalTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        ArrivalTimeLabel.Location = New System.Drawing.Point(30, 171)
        ArrivalTimeLabel.Name = "ArrivalTimeLabel"
        ArrivalTimeLabel.Size = New System.Drawing.Size(83, 16)
        ArrivalTimeLabel.TabIndex = 50
        ArrivalTimeLabel.Text = "Arrival Time:"
        '
        'HarvestTBindingSource
        '
        Me.HarvestTBindingSource.DataMember = "HarvestT"
        Me.HarvestTBindingSource.DataSource = Me.ClientDS
        '
        'ClientDS
        '
        Me.ClientDS.DataSetName = "ClientDS"
        Me.ClientDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConditionTBindingSource
        '
        Me.ConditionTBindingSource.DataMember = "ConditionT"
        Me.ConditionTBindingSource.DataSource = Me.ClientDS
        '
        'VesselTBindingSource
        '
        Me.VesselTBindingSource.DataMember = "VesselT"
        Me.VesselTBindingSource.DataSource = Me.ClientDS
        '
        'SiteTBindingSource
        '
        Me.SiteTBindingSource.DataMember = "SiteT"
        Me.SiteTBindingSource.DataSource = Me.ClientDS
        '
        'RepTBindingSource
        '
        Me.RepTBindingSource.DataMember = "RepT"
        Me.RepTBindingSource.DataSource = Me.ClientDS
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Label31)
        Me.GroupBox1.Controls.Add(Label30)
        Me.GroupBox1.Controls.Add(Label29)
        Me.GroupBox1.Controls.Add(RepIDLabel1)
        Me.GroupBox1.Controls.Add(Me.RepIDComboBox1)
        Me.GroupBox1.Controls.Add(StarveDateTimeLabel)
        Me.GroupBox1.Controls.Add(Me.StarveDateTimeDateTimePicker)
        Me.GroupBox1.Controls.Add(SiteIDLabel)
        Me.GroupBox1.Controls.Add(Me.SiteIDComboBox)
        Me.GroupBox1.Controls.Add(RepCommentsLabel)
        Me.GroupBox1.Controls.Add(Me.RepCommentsTextBox)
        Me.GroupBox1.Controls.Add(EndWeightLabel)
        Me.GroupBox1.Controls.Add(Me.EndWeightTextBox)
        Me.GroupBox1.Controls.Add(StartWeightLabel)
        Me.GroupBox1.Controls.Add(Me.StartWeightTextBox)
        Me.GroupBox1.Controls.Add(AverageWeightLabel)
        Me.GroupBox1.Controls.Add(Me.AverageWeightTextBox)
        Me.GroupBox1.Controls.Add(CageNoLabel)
        Me.GroupBox1.Controls.Add(Me.CageNoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 188)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(757, 226)
        Me.GroupBox1.TabIndex = 107
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Section 1: To be completed by Site Representative"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(33, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(345, 16)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Signed: ........................................................................." & _
    "......................."
        '
        'RepIDComboBox1
        '
        Me.RepIDComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HarvestTBindingSource, "RepID", True))
        Me.RepIDComboBox1.DataSource = Me.RepTBindingSource
        Me.RepIDComboBox1.DisplayMember = "Rep"
        Me.RepIDComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RepIDComboBox1.FormattingEnabled = True
        Me.RepIDComboBox1.Location = New System.Drawing.Point(165, 155)
        Me.RepIDComboBox1.Name = "RepIDComboBox1"
        Me.RepIDComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.RepIDComboBox1.TabIndex = 100
        Me.RepIDComboBox1.ValueMember = "RepID"
        '
        'StarveDateTimeDateTimePicker
        '
        Me.StarveDateTimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HarvestTBindingSource, "StarveDateTime", True))
        Me.StarveDateTimeDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.StarveDateTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.StarveDateTimeDateTimePicker.Location = New System.Drawing.Point(546, 23)
        Me.StarveDateTimeDateTimePicker.Name = "StarveDateTimeDateTimePicker"
        Me.StarveDateTimeDateTimePicker.Size = New System.Drawing.Size(141, 22)
        Me.StarveDateTimeDateTimePicker.TabIndex = 90
        '
        'SiteIDComboBox
        '
        Me.SiteIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HarvestTBindingSource, "SiteID", True))
        Me.SiteIDComboBox.DataSource = Me.SiteTBindingSource
        Me.SiteIDComboBox.DisplayMember = "Site"
        Me.SiteIDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SiteIDComboBox.FormattingEnabled = True
        Me.SiteIDComboBox.Location = New System.Drawing.Point(165, 22)
        Me.SiteIDComboBox.Name = "SiteIDComboBox"
        Me.SiteIDComboBox.Size = New System.Drawing.Size(121, 24)
        Me.SiteIDComboBox.TabIndex = 88
        Me.SiteIDComboBox.ValueMember = "SiteID"
        '
        'RepCommentsTextBox
        '
        Me.RepCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "RepComments", True))
        Me.RepCommentsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.RepCommentsTextBox.Location = New System.Drawing.Point(165, 103)
        Me.RepCommentsTextBox.Multiline = True
        Me.RepCommentsTextBox.Name = "RepCommentsTextBox"
        Me.RepCommentsTextBox.Size = New System.Drawing.Size(585, 46)
        Me.RepCommentsTextBox.TabIndex = 76
        '
        'EndWeightTextBox
        '
        Me.EndWeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "EndWeight", True))
        Me.EndWeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.EndWeightTextBox.Location = New System.Drawing.Point(546, 75)
        Me.EndWeightTextBox.Name = "EndWeightTextBox"
        Me.EndWeightTextBox.Size = New System.Drawing.Size(141, 22)
        Me.EndWeightTextBox.TabIndex = 74
        '
        'StartWeightTextBox
        '
        Me.StartWeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "StartWeight", True))
        Me.StartWeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.StartWeightTextBox.Location = New System.Drawing.Point(546, 49)
        Me.StartWeightTextBox.Name = "StartWeightTextBox"
        Me.StartWeightTextBox.Size = New System.Drawing.Size(141, 22)
        Me.StartWeightTextBox.TabIndex = 72
        '
        'AverageWeightTextBox
        '
        Me.AverageWeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "AverageWeight", True))
        Me.AverageWeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.AverageWeightTextBox.Location = New System.Drawing.Point(165, 75)
        Me.AverageWeightTextBox.Name = "AverageWeightTextBox"
        Me.AverageWeightTextBox.Size = New System.Drawing.Size(121, 22)
        Me.AverageWeightTextBox.TabIndex = 70
        '
        'CageNoTextBox
        '
        Me.CageNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "CageNo", True))
        Me.CageNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.CageNoTextBox.Location = New System.Drawing.Point(165, 49)
        Me.CageNoTextBox.Name = "CageNoTextBox"
        Me.CageNoTextBox.Size = New System.Drawing.Size(121, 22)
        Me.CageNoTextBox.TabIndex = 68
        '
        'VesselIDComboBox
        '
        Me.VesselIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HarvestTBindingSource, "VesselID", True))
        Me.VesselIDComboBox.DataSource = Me.VesselTBindingSource
        Me.VesselIDComboBox.DisplayMember = "Vessel"
        Me.VesselIDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VesselIDComboBox.FormattingEnabled = True
        Me.VesselIDComboBox.Location = New System.Drawing.Point(177, 131)
        Me.VesselIDComboBox.Name = "VesselIDComboBox"
        Me.VesselIDComboBox.Size = New System.Drawing.Size(121, 24)
        Me.VesselIDComboBox.TabIndex = 105
        Me.VesselIDComboBox.ValueMember = "VesselID"
        '
        'HarvestIDTextBox
        '
        Me.HarvestIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "HarvestID", True))
        Me.HarvestIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.HarvestIDTextBox.Location = New System.Drawing.Point(621, 133)
        Me.HarvestIDTextBox.Name = "HarvestIDTextBox"
        Me.HarvestIDTextBox.Size = New System.Drawing.Size(68, 22)
        Me.HarvestIDTextBox.TabIndex = 103
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Label34)
        Me.GroupBox2.Controls.Add(Label33)
        Me.GroupBox2.Controls.Add(Label32)
        Me.GroupBox2.Controls.Add(DeliveryDateLabel)
        Me.GroupBox2.Controls.Add(Label28)
        Me.GroupBox2.Controls.Add(Me.TBBiomass)
        Me.GroupBox2.Controls.Add(TempSiteLabel)
        Me.GroupBox2.Controls.Add(Me.TempSiteTextBox)
        Me.GroupBox2.Controls.Add(TempWellLabel)
        Me.GroupBox2.Controls.Add(Me.TempWellTextBox)
        Me.GroupBox2.Controls.Add(ConditionIDLabel)
        Me.GroupBox2.Controls.Add(Me.ConditionIDComboBox)
        Me.GroupBox2.Controls.Add(FishCountLabel)
        Me.GroupBox2.Controls.Add(SkipperIDLabel)
        Me.GroupBox2.Controls.Add(Me.FishCountTextBox)
        Me.GroupBox2.Controls.Add(Me.SkipperIDComboBox)
        Me.GroupBox2.Controls.Add(PortIDLabel)
        Me.GroupBox2.Controls.Add(Me.SkipperCommentsTextBox)
        Me.GroupBox2.Controls.Add(Me.PortIDComboBox)
        Me.GroupBox2.Controls.Add(SkipperCommentsLabel)
        Me.GroupBox2.Controls.Add(EndTimeLabel)
        Me.GroupBox2.Controls.Add(StartTimeLabel)
        Me.GroupBox2.Controls.Add(ArrivalTimeLabel)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 491)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(757, 362)
        Me.GroupBox2.TabIndex = 108
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Section 2: To be completed by Wellboat Skipper"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "DeliveryDateTime", True))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox4.Location = New System.Drawing.Point(562, 197)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(128, 22)
        Me.TextBox4.TabIndex = 110
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "EndDateTime", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.Location = New System.Drawing.Point(301, 197)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(128, 22)
        Me.TextBox3.TabIndex = 109
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "StartDateTime", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox2.Location = New System.Drawing.Point(167, 197)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(128, 22)
        Me.TextBox2.TabIndex = 108
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "ArrivalDateTime", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TextBox1.Location = New System.Drawing.Point(33, 197)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 22)
        Me.TextBox1.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(33, 329)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 16)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Signed: ........................................................................." & _
    "......................."
        '
        'TBBiomass
        '
        Me.TBBiomass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TBBiomass.Location = New System.Drawing.Point(165, 56)
        Me.TBBiomass.Name = "TBBiomass"
        Me.TBBiomass.Size = New System.Drawing.Size(151, 22)
        Me.TBBiomass.TabIndex = 97
        '
        'TempSiteTextBox
        '
        Me.TempSiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "TempSite", True))
        Me.TempSiteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TempSiteTextBox.Location = New System.Drawing.Point(518, 115)
        Me.TempSiteTextBox.Name = "TempSiteTextBox"
        Me.TempSiteTextBox.Size = New System.Drawing.Size(59, 22)
        Me.TempSiteTextBox.TabIndex = 84
        '
        'TempWellTextBox
        '
        Me.TempWellTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "TempWell", True))
        Me.TempWellTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.TempWellTextBox.Location = New System.Drawing.Point(165, 112)
        Me.TempWellTextBox.Name = "TempWellTextBox"
        Me.TempWellTextBox.Size = New System.Drawing.Size(70, 22)
        Me.TempWellTextBox.TabIndex = 82
        '
        'ConditionIDComboBox
        '
        Me.ConditionIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ConditionTBindingSource, "Condition", True))
        Me.ConditionIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HarvestTBindingSource, "ConditionID", True))
        Me.ConditionIDComboBox.DataSource = Me.ConditionTBindingSource
        Me.ConditionIDComboBox.DisplayMember = "Condition"
        Me.ConditionIDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ConditionIDComboBox.FormattingEnabled = True
        Me.ConditionIDComboBox.Location = New System.Drawing.Point(165, 84)
        Me.ConditionIDComboBox.Name = "ConditionIDComboBox"
        Me.ConditionIDComboBox.Size = New System.Drawing.Size(151, 24)
        Me.ConditionIDComboBox.TabIndex = 80
        Me.ConditionIDComboBox.ValueMember = "ConditionID"
        '
        'FishCountTextBox
        '
        Me.FishCountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "FishCount", True))
        Me.FishCountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.FishCountTextBox.Location = New System.Drawing.Point(165, 25)
        Me.FishCountTextBox.Name = "FishCountTextBox"
        Me.FishCountTextBox.Size = New System.Drawing.Size(151, 22)
        Me.FishCountTextBox.TabIndex = 78
        '
        'SkipperIDComboBox
        '
        Me.SkipperIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HarvestTBindingSource, "SkipperID", True))
        Me.SkipperIDComboBox.DataSource = Me.SkipperTBindingSource
        Me.SkipperIDComboBox.DisplayMember = "Skipper"
        Me.SkipperIDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SkipperIDComboBox.FormattingEnabled = True
        Me.SkipperIDComboBox.Location = New System.Drawing.Point(165, 282)
        Me.SkipperIDComboBox.Name = "SkipperIDComboBox"
        Me.SkipperIDComboBox.Size = New System.Drawing.Size(121, 24)
        Me.SkipperIDComboBox.TabIndex = 63
        Me.SkipperIDComboBox.ValueMember = "SkipperID"
        '
        'SkipperTBindingSource
        '
        Me.SkipperTBindingSource.DataMember = "SkipperT"
        Me.SkipperTBindingSource.DataSource = Me.ClientDS
        '
        'SkipperCommentsTextBox
        '
        Me.SkipperCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "SkipperComments", True))
        Me.SkipperCommentsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.SkipperCommentsTextBox.Location = New System.Drawing.Point(165, 230)
        Me.SkipperCommentsTextBox.Multiline = True
        Me.SkipperCommentsTextBox.Name = "SkipperCommentsTextBox"
        Me.SkipperCommentsTextBox.Size = New System.Drawing.Size(585, 46)
        Me.SkipperCommentsTextBox.TabIndex = 59
        '
        'PortIDComboBox
        '
        Me.PortIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HarvestTBindingSource, "PortID", True))
        Me.PortIDComboBox.DataSource = Me.PortTBindingSource
        Me.PortIDComboBox.DisplayMember = "Port"
        Me.PortIDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.PortIDComboBox.FormattingEnabled = True
        Me.PortIDComboBox.Location = New System.Drawing.Point(435, 195)
        Me.PortIDComboBox.Name = "PortIDComboBox"
        Me.PortIDComboBox.Size = New System.Drawing.Size(121, 24)
        Me.PortIDComboBox.TabIndex = 61
        Me.PortIDComboBox.ValueMember = "PortID"
        '
        'PortTBindingSource
        '
        Me.PortTBindingSource.DataMember = "PortT"
        Me.PortTBindingSource.DataSource = Me.ClientDS
        '
        'HarvestTBindingNavigator
        '
        Me.HarvestTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HarvestTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HarvestTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HarvestTBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HarvestTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HarvestTBindingNavigatorSaveItem})
        Me.HarvestTBindingNavigator.Location = New System.Drawing.Point(0, 856)
        Me.HarvestTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HarvestTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HarvestTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HarvestTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HarvestTBindingNavigator.Name = "HarvestTBindingNavigator"
        Me.HarvestTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HarvestTBindingNavigator.Size = New System.Drawing.Size(773, 25)
        Me.HarvestTBindingNavigator.TabIndex = 109
        Me.HarvestTBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'HarvestTBindingNavigatorSaveItem
        '
        Me.HarvestTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HarvestTBindingNavigatorSaveItem.Image = CType(resources.GetObject("HarvestTBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.HarvestTBindingNavigatorSaveItem.Name = "HarvestTBindingNavigatorSaveItem"
        Me.HarvestTBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.HarvestTBindingNavigatorSaveItem.Text = "Save Data"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.Johnson_Marine
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(10, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(246, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 110
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(434, 46)
        Me.Label1.TabIndex = 111
        Me.Label1.Text = "Wellboat Delivery Form"
        '
        'PrintForm2
        '
        Me.PrintForm2.DocumentName = "document"
        Me.PrintForm2.Form = Me
        Me.PrintForm2.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm2.PrinterSettings = CType(resources.GetObject("PrintForm2.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm2.PrintFileName = Nothing
        '
        'HarvestReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(773, 881)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.HarvestTBindingNavigator)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(VesselIDLabel)
        Me.Controls.Add(Me.VesselIDComboBox)
        Me.Controls.Add(HarvestIDLabel)
        Me.Controls.Add(Me.HarvestIDTextBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "HarvestReport"
        Me.Text = "Harvest Report"
        CType(Me.HarvestTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConditionTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VesselTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiteTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SkipperTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PortTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HarvestTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HarvestTBindingNavigator.ResumeLayout(False)
        Me.HarvestTBindingNavigator.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HarvestTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VesselTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientDS As ClientDS
    Friend WithEvents SiteTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConditionTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RepIDComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents StarveDateTimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SiteIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents RepCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndWeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartWeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AverageWeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CageNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VesselIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HarvestIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TBBiomass As System.Windows.Forms.TextBox
    Friend WithEvents TempSiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TempWellTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConditionIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FishCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SkipperIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SkipperCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PortIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents HarvestTBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HarvestTBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SkipperTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PortTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PrintForm2 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
