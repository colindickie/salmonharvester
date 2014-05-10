<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim SkipperIDLabel As System.Windows.Forms.Label
        Dim PortIDLabel As System.Windows.Forms.Label
        Dim SkipperCommentsLabel As System.Windows.Forms.Label
        Dim EndTimeLabel As System.Windows.Forms.Label
        Dim StartTimeLabel As System.Windows.Forms.Label
        Dim ArrivalTimeLabel As System.Windows.Forms.Label
        Dim StarveDateTimeLabel As System.Windows.Forms.Label
        Dim SiteIDLabel As System.Windows.Forms.Label
        Dim VesselIDLabel As System.Windows.Forms.Label
        Dim TempSiteLabel As System.Windows.Forms.Label
        Dim TempWellLabel As System.Windows.Forms.Label
        Dim ConditionIDLabel As System.Windows.Forms.Label
        Dim FishCountLabel As System.Windows.Forms.Label
        Dim RepCommentsLabel As System.Windows.Forms.Label
        Dim EndWeightLabel As System.Windows.Forms.Label
        Dim StartWeightLabel As System.Windows.Forms.Label
        Dim AverageWeightLabel As System.Windows.Forms.Label
        Dim CageNoLabel As System.Windows.Forms.Label
        Dim HarvestIDLabel As System.Windows.Forms.Label
        Dim Label28 As System.Windows.Forms.Label
        Dim RepIDLabel1 As System.Windows.Forms.Label
        Dim DeliveryDateLabel As System.Windows.Forms.Label
        Dim Label29 As System.Windows.Forms.Label
        Dim Label30 As System.Windows.Forms.Label
        Dim Label31 As System.Windows.Forms.Label
        Dim Label32 As System.Windows.Forms.Label
        Dim Label33 As System.Windows.Forms.Label
        Dim Label34 As System.Windows.Forms.Label
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabMain = New System.Windows.Forms.TabPage()
        Me.ShBResetAll = New MfgControl.AdvancedHMI.SHButton()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.TabMachine = New System.Windows.Forms.TabPage()
        Me.ShBReset = New MfgControl.AdvancedHMI.SHButton()
        Me.LabelRepeat = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.CounterMachineLifeL = New MfgControl.AdvancedHMI.Counter()
        Me.CounterMachineLifeH = New MfgControl.AdvancedHMI.Counter()
        Me.CounterMachineLife = New MfgControl.AdvancedHMI.Counter()
        Me.CounterMachineDay = New MfgControl.AdvancedHMI.Counter()
        Me.GBSettings = New System.Windows.Forms.GroupBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.ButtonSaveTimings = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NUGateCloseDelay = New System.Windows.Forms.NumericUpDown()
        Me.NUhammerdelay = New System.Windows.Forms.NumericUpDown()
        Me.NUknifedelay = New System.Windows.Forms.NumericUpDown()
        Me.NUknifetime = New System.Windows.Forms.NumericUpDown()
        Me.NUlifttime = New System.Windows.Forms.NumericUpDown()
        Me.NUGateOpendelay = New System.Windows.Forms.NumericUpDown()
        Me.CBMachineAutoOverride = New System.Windows.Forms.CheckBox()
        Me.LabMachine = New System.Windows.Forms.Label()
        Me.ButNext = New System.Windows.Forms.Button()
        Me.ButPrev = New System.Windows.Forms.Button()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabLog = New System.Windows.Forms.TabPage()
        Me.LabelWarning = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DateTimePickerLog = New System.Windows.Forms.DateTimePicker()
        Me.TabChart = New System.Windows.Forms.TabPage()
        Me.ButtonResetEnd = New System.Windows.Forms.Button()
        Me.ButtonResetStart = New System.Windows.Forms.Button()
        Me.DateTimePickerEnd = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerStart = New System.Windows.Forms.DateTimePicker()
        Me.DataGridViewChart = New System.Windows.Forms.DataGridView()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonAddSkipper = New System.Windows.Forms.Button()
        Me.ButtonAddPort = New System.Windows.Forms.Button()
        Me.DeliveryDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.HarvestTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientDS = New MfgControl.AdvancedHMI.ClientDS()
        Me.TBBiomass = New System.Windows.Forms.TextBox()
        Me.TempSiteTextBox = New System.Windows.Forms.TextBox()
        Me.TempWellTextBox = New System.Windows.Forms.TextBox()
        Me.ConditionIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ConditionTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FishCountTextBox = New System.Windows.Forms.TextBox()
        Me.SkipperIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SkipperTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SkipperCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.PortIDComboBox = New System.Windows.Forms.ComboBox()
        Me.PortTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EndDateTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StartDateTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ArrivalTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RepIDComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RepTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ButtonAddRep = New System.Windows.Forms.Button()
        Me.ButtonAddSite = New System.Windows.Forms.Button()
        Me.StarveDateTimeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SiteIDComboBox = New System.Windows.Forms.ComboBox()
        Me.SiteTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepCommentsTextBox = New System.Windows.Forms.TextBox()
        Me.EndWeightTextBox = New System.Windows.Forms.TextBox()
        Me.StartWeightTextBox = New System.Windows.Forms.TextBox()
        Me.AverageWeightTextBox = New System.Windows.Forms.TextBox()
        Me.CageNoTextBox = New System.Windows.Forms.TextBox()
        Me.ButtonPrint = New System.Windows.Forms.Button()
        Me.ButtonAddVessel = New System.Windows.Forms.Button()
        Me.VesselIDComboBox = New System.Windows.Forms.ComboBox()
        Me.VesselTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HarvestIDTextBox = New System.Windows.Forms.TextBox()
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
        Me.TabSettings = New System.Windows.Forms.TabPage()
        Me.CBReverseDisplay = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TBoverridewait = New System.Windows.Forms.TextBox()
        Me.TBHammerDelay = New System.Windows.Forms.TextBox()
        Me.TBKnifeDelay = New System.Windows.Forms.TextBox()
        Me.CBSettingsAutooverride = New System.Windows.Forms.CheckBox()
        Me.TBKnifeTime = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.TBLiftTime = New System.Windows.Forms.TextBox()
        Me.TBGateCloseDelay = New System.Windows.Forms.TextBox()
        Me.TBGateOpenDelay = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CBSecondScreen = New System.Windows.Forms.CheckBox()
        Me.ButtonSaveSettings = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBLogPath = New System.Windows.Forms.TextBox()
        Me.TBNoMachines = New System.Windows.Forms.TextBox()
        Me.TBVessel = New System.Windows.Forms.TextBox()
        Me.TabHelp = New System.Windows.Forms.TabPage()
        Me.LbHelpVersion = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TimerLog = New System.Windows.Forms.Timer(Me.components)
        Me.NUoverridewate = New System.Windows.Forms.NumericUpDown()
        Me.Label42 = New System.Windows.Forms.Label()
        SkipperIDLabel = New System.Windows.Forms.Label()
        PortIDLabel = New System.Windows.Forms.Label()
        SkipperCommentsLabel = New System.Windows.Forms.Label()
        EndTimeLabel = New System.Windows.Forms.Label()
        StartTimeLabel = New System.Windows.Forms.Label()
        ArrivalTimeLabel = New System.Windows.Forms.Label()
        StarveDateTimeLabel = New System.Windows.Forms.Label()
        SiteIDLabel = New System.Windows.Forms.Label()
        VesselIDLabel = New System.Windows.Forms.Label()
        TempSiteLabel = New System.Windows.Forms.Label()
        TempWellLabel = New System.Windows.Forms.Label()
        ConditionIDLabel = New System.Windows.Forms.Label()
        FishCountLabel = New System.Windows.Forms.Label()
        RepCommentsLabel = New System.Windows.Forms.Label()
        EndWeightLabel = New System.Windows.Forms.Label()
        StartWeightLabel = New System.Windows.Forms.Label()
        AverageWeightLabel = New System.Windows.Forms.Label()
        CageNoLabel = New System.Windows.Forms.Label()
        HarvestIDLabel = New System.Windows.Forms.Label()
        Label28 = New System.Windows.Forms.Label()
        RepIDLabel1 = New System.Windows.Forms.Label()
        DeliveryDateLabel = New System.Windows.Forms.Label()
        Label29 = New System.Windows.Forms.Label()
        Label30 = New System.Windows.Forms.Label()
        Label31 = New System.Windows.Forms.Label()
        Label32 = New System.Windows.Forms.Label()
        Label33 = New System.Windows.Forms.Label()
        Label34 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabMain.SuspendLayout()
        Me.TabMachine.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GBSettings.SuspendLayout()
        CType(Me.NUGateCloseDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUhammerdelay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUknifedelay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUknifetime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUlifttime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUGateOpendelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabLog.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabChart.SuspendLayout()
        CType(Me.DataGridViewChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.HarvestTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConditionTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkipperTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PortTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RepTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiteTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VesselTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HarvestTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.HarvestTBindingNavigator.SuspendLayout()
        Me.TabSettings.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TabHelp.SuspendLayout()
        CType(Me.NUoverridewate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkipperIDLabel
        '
        SkipperIDLabel.AutoSize = True
        SkipperIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        SkipperIDLabel.Location = New System.Drawing.Point(33, 319)
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
        EndTimeLabel.Location = New System.Drawing.Point(300, 171)
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
        'StarveDateTimeLabel
        '
        StarveDateTimeLabel.AutoSize = True
        StarveDateTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StarveDateTimeLabel.Location = New System.Drawing.Point(489, 25)
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
        'VesselIDLabel
        '
        VesselIDLabel.AutoSize = True
        VesselIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VesselIDLabel.Location = New System.Drawing.Point(76, 12)
        VesselIDLabel.Name = "VesselIDLabel"
        VesselIDLabel.Size = New System.Drawing.Size(93, 16)
        VesselIDLabel.TabIndex = 85
        VesselIDLabel.Text = "Vessel Name:"
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
        ConditionIDLabel.Size = New System.Drawing.Size(173, 16)
        ConditionIDLabel.TabIndex = 79
        ConditionIDLabel.Text = "Condition of Fish Uploaded:"
        '
        'FishCountLabel
        '
        FishCountLabel.AutoSize = True
        FishCountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        FishCountLabel.Location = New System.Drawing.Point(30, 31)
        FishCountLabel.Name = "FishCountLabel"
        FishCountLabel.Size = New System.Drawing.Size(154, 16)
        FishCountLabel.TabIndex = 77
        FishCountLabel.Text = "Number of Fish Counted:"
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
        EndWeightLabel.Location = New System.Drawing.Point(489, 78)
        EndWeightLabel.Name = "EndWeightLabel"
        EndWeightLabel.Size = New System.Drawing.Size(170, 16)
        EndWeightLabel.TabIndex = 73
        EndWeightLabel.Text = "Cage Tonnage Remaining:"
        '
        'StartWeightLabel
        '
        StartWeightLabel.AutoSize = True
        StartWeightLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        StartWeightLabel.Location = New System.Drawing.Point(489, 53)
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
        'HarvestIDLabel
        '
        HarvestIDLabel.AutoSize = True
        HarvestIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HarvestIDLabel.Location = New System.Drawing.Point(532, 19)
        HarvestIDLabel.Name = "HarvestIDLabel"
        HarvestIDLabel.Size = New System.Drawing.Size(133, 16)
        HarvestIDLabel.TabIndex = 65
        HarvestIDLabel.Text = "Delivery/Harvest No:"
        '
        'Label28
        '
        Label28.AutoSize = True
        Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Label28.Location = New System.Drawing.Point(30, 59)
        Label28.Name = "Label28"
        Label28.Size = New System.Drawing.Size(176, 16)
        Label28.TabIndex = 98
        Label28.Text = "Estimated Biomass Uplifted:"
        '
        'RepIDLabel1
        '
        RepIDLabel1.AutoSize = True
        RepIDLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        RepIDLabel1.Location = New System.Drawing.Point(32, 164)
        RepIDLabel1.Name = "RepIDLabel1"
        RepIDLabel1.Size = New System.Drawing.Size(129, 16)
        RepIDLabel1.TabIndex = 99
        RepIDLabel1.Text = "Site Representative:"
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
        'Label29
        '
        Label29.AutoSize = True
        Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label29.Location = New System.Drawing.Point(346, 78)
        Label29.Name = "Label29"
        Label29.Size = New System.Drawing.Size(23, 16)
        Label29.TabIndex = 101
        Label29.Text = "kg"
        '
        'Label30
        '
        Label30.AutoSize = True
        Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label30.Location = New System.Drawing.Point(810, 53)
        Label30.Name = "Label30"
        Label30.Size = New System.Drawing.Size(54, 16)
        Label30.TabIndex = 102
        Label30.Text = "Tonnes"
        '
        'Label31
        '
        Label31.AutoSize = True
        Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label31.Location = New System.Drawing.Point(810, 81)
        Label31.Name = "Label31"
        Label31.Size = New System.Drawing.Size(54, 16)
        Label31.TabIndex = 103
        Label31.Text = "Tonnes"
        '
        'Label32
        '
        Label32.AutoSize = True
        Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label32.Location = New System.Drawing.Point(293, 118)
        Label32.Name = "Label32"
        Label32.Size = New System.Drawing.Size(21, 16)
        Label32.TabIndex = 103
        Label32.Text = "°C"
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
        'Label34
        '
        Label34.AutoSize = True
        Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label34.Location = New System.Drawing.Point(374, 59)
        Label34.Name = "Label34"
        Label34.Size = New System.Drawing.Size(23, 16)
        Label34.TabIndex = 105
        Label34.Text = "kg"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabMain)
        Me.TabControl1.Controls.Add(Me.TabMachine)
        Me.TabControl1.Controls.Add(Me.TabLog)
        Me.TabControl1.Controls.Add(Me.TabChart)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabSettings)
        Me.TabControl1.Controls.Add(Me.TabHelp)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.MinimumSize = New System.Drawing.Size(1100, 620)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1250, 680)
        Me.TabControl1.TabIndex = 0
        '
        'TabMain
        '
        Me.TabMain.Controls.Add(Me.ShBResetAll)
        Me.TabMain.Controls.Add(Me.LabelTotal)
        Me.TabMain.Location = New System.Drawing.Point(4, 22)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMain.Size = New System.Drawing.Size(1242, 654)
        Me.TabMain.TabIndex = 0
        Me.TabMain.Text = "Main"
        Me.TabMain.UseVisualStyleBackColor = True
        '
        'ShBResetAll
        '
        Me.ShBResetAll.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Blue
        Me.ShBResetAll.CommComponent = Nothing
        Me.ShBResetAll.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large
        Me.ShBResetAll.Location = New System.Drawing.Point(726, 539)
        Me.ShBResetAll.Name = "ShBResetAll"
        Me.ShBResetAll.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet
        Me.ShBResetAll.PLCAddressClick = ""
        Me.ShBResetAll.PLCAddressVisible = ""
        Me.ShBResetAll.Size = New System.Drawing.Size(75, 110)
        Me.ShBResetAll.TabIndex = 50
        Me.ShBResetAll.Text = "Reset Counters"
        '
        'LabelTotal
        '
        Me.LabelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 62.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.ForeColor = System.Drawing.Color.Red
        Me.LabelTotal.Location = New System.Drawing.Point(473, 562)
        Me.LabelTotal.MaximumSize = New System.Drawing.Size(250, 100)
        Me.LabelTotal.MinimumSize = New System.Drawing.Size(180, 50)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(247, 87)
        Me.LabelTotal.TabIndex = 49
        Me.LabelTotal.Text = "0"
        Me.LabelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabMachine
        '
        Me.TabMachine.Controls.Add(Me.ShBReset)
        Me.TabMachine.Controls.Add(Me.LabelRepeat)
        Me.TabMachine.Controls.Add(Me.GroupBox4)
        Me.TabMachine.Controls.Add(Me.GBSettings)
        Me.TabMachine.Controls.Add(Me.LabMachine)
        Me.TabMachine.Controls.Add(Me.ButNext)
        Me.TabMachine.Controls.Add(Me.ButPrev)
        Me.TabMachine.Controls.Add(Me.Label27)
        Me.TabMachine.Controls.Add(Me.Label26)
        Me.TabMachine.Controls.Add(Me.Label25)
        Me.TabMachine.Controls.Add(Me.Label24)
        Me.TabMachine.Controls.Add(Me.Label23)
        Me.TabMachine.Controls.Add(Me.Label22)
        Me.TabMachine.Controls.Add(Me.Label21)
        Me.TabMachine.Controls.Add(Me.Label20)
        Me.TabMachine.Location = New System.Drawing.Point(4, 22)
        Me.TabMachine.Name = "TabMachine"
        Me.TabMachine.Padding = New System.Windows.Forms.Padding(3)
        Me.TabMachine.Size = New System.Drawing.Size(1242, 654)
        Me.TabMachine.TabIndex = 1
        Me.TabMachine.Text = "Machine"
        Me.TabMachine.UseVisualStyleBackColor = True
        '
        'ShBReset
        '
        Me.ShBReset.ButtonColor = MfgControl.AdvancedHMI.Controls.PushButton.ButtonColors.Green
        Me.ShBReset.CommComponent = Nothing
        Me.ShBReset.LegendPlate = MfgControl.AdvancedHMI.Controls.PushButton.LegendPlates.Large
        Me.ShBReset.Location = New System.Drawing.Point(706, 499)
        Me.ShBReset.Name = "ShBReset"
        Me.ShBReset.OutputType = MfgControl.AdvancedHMI.Controls.PushButton.OutputTypes.MomentarySet
        Me.ShBReset.PLCAddressClick = "B3:0/1"
        Me.ShBReset.PLCAddressVisible = ""
        Me.ShBReset.Size = New System.Drawing.Size(75, 110)
        Me.ShBReset.TabIndex = 39
        Me.ShBReset.Text = "Reset Counter"
        '
        'LabelRepeat
        '
        Me.LabelRepeat.AutoSize = True
        Me.LabelRepeat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelRepeat.ForeColor = System.Drawing.Color.Red
        Me.LabelRepeat.Location = New System.Drawing.Point(425, 467)
        Me.LabelRepeat.Name = "LabelRepeat"
        Me.LabelRepeat.Size = New System.Drawing.Size(113, 18)
        Me.LabelRepeat.TabIndex = 38
        Me.LabelRepeat.Text = "Repeat Cycle:"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label38)
        Me.GroupBox4.Controls.Add(Me.Label37)
        Me.GroupBox4.Controls.Add(Me.CounterMachineLifeL)
        Me.GroupBox4.Controls.Add(Me.CounterMachineLifeH)
        Me.GroupBox4.Controls.Add(Me.CounterMachineLife)
        Me.GroupBox4.Controls.Add(Me.CounterMachineDay)
        Me.GroupBox4.Location = New System.Drawing.Point(423, 490)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(277, 119)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Counters"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label38.Location = New System.Drawing.Point(42, 59)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(102, 17)
        Me.Label38.TabIndex = 51
        Me.Label38.Text = "Life Counter:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label37.Location = New System.Drawing.Point(42, 27)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(70, 17)
        Me.Label37.TabIndex = 39
        Me.Label37.Text = "Counter:"
        '
        'CounterMachineLifeL
        '
        Me.CounterMachineLifeL.BackColor = System.Drawing.Color.White
        Me.CounterMachineLifeL.BooleanDisplay = MfgControl.AdvancedHMI.Counter.BooleanDisplayOption.TrueFalse
        Me.CounterMachineLifeL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CounterMachineLifeL.CommComponent = Nothing
        Me.CounterMachineLifeL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.CounterMachineLifeL.ForeColor = System.Drawing.Color.Black
        Me.CounterMachineLifeL.Hidden = False
        Me.CounterMachineLifeL.HighlightColor = System.Drawing.Color.Red
        Me.CounterMachineLifeL.HighlightKeyCharacter = "!"
        Me.CounterMachineLifeL.intValue = 0
        Me.CounterMachineLifeL.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CounterMachineLifeL.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.CounterMachineLifeL.KeypadMinValue = 0.0R
        Me.CounterMachineLifeL.KeypadText = Nothing
        Me.CounterMachineLifeL.KeypadWidth = 300
        Me.CounterMachineLifeL.Location = New System.Drawing.Point(94, 88)
        Me.CounterMachineLifeL.Name = "CounterMachineLifeL"
        Me.CounterMachineLifeL.NumericFormat = "#,###"
        Me.CounterMachineLifeL.PLCAddressKeypad = ""
        Me.CounterMachineLifeL.PLCAddressValue = ""
        Me.CounterMachineLifeL.PLCAddressVisible = ""
        Me.CounterMachineLifeL.PollRate = 0
        Me.CounterMachineLifeL.Size = New System.Drawing.Size(65, 20)
        Me.CounterMachineLifeL.TabIndex = 50
        Me.CounterMachineLifeL.Text = "0"
        Me.CounterMachineLifeL.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CounterMachineLifeL.Value = "0"
        Me.CounterMachineLifeL.ValuePrefix = Nothing
        Me.CounterMachineLifeL.ValueScaleFactor = 1.0R
        Me.CounterMachineLifeL.ValueSuffix = Nothing
        '
        'CounterMachineLifeH
        '
        Me.CounterMachineLifeH.BackColor = System.Drawing.Color.White
        Me.CounterMachineLifeH.BooleanDisplay = MfgControl.AdvancedHMI.Counter.BooleanDisplayOption.TrueFalse
        Me.CounterMachineLifeH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CounterMachineLifeH.CommComponent = Nothing
        Me.CounterMachineLifeH.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.CounterMachineLifeH.ForeColor = System.Drawing.Color.Black
        Me.CounterMachineLifeH.Hidden = False
        Me.CounterMachineLifeH.HighlightColor = System.Drawing.Color.Red
        Me.CounterMachineLifeH.HighlightKeyCharacter = "!"
        Me.CounterMachineLifeH.intValue = 0
        Me.CounterMachineLifeH.KeypadFont = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.CounterMachineLifeH.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.CounterMachineLifeH.KeypadMinValue = 0.0R
        Me.CounterMachineLifeH.KeypadText = Nothing
        Me.CounterMachineLifeH.KeypadWidth = 300
        Me.CounterMachineLifeH.Location = New System.Drawing.Point(183, 88)
        Me.CounterMachineLifeH.Name = "CounterMachineLifeH"
        Me.CounterMachineLifeH.NumericFormat = "#,###"
        Me.CounterMachineLifeH.PLCAddressKeypad = ""
        Me.CounterMachineLifeH.PLCAddressValue = ""
        Me.CounterMachineLifeH.PLCAddressVisible = ""
        Me.CounterMachineLifeH.PollRate = 0
        Me.CounterMachineLifeH.Size = New System.Drawing.Size(76, 20)
        Me.CounterMachineLifeH.TabIndex = 49
        Me.CounterMachineLifeH.Text = "0"
        Me.CounterMachineLifeH.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CounterMachineLifeH.Value = "0"
        Me.CounterMachineLifeH.ValuePrefix = Nothing
        Me.CounterMachineLifeH.ValueScaleFactor = 1.0R
        Me.CounterMachineLifeH.ValueSuffix = Nothing
        '
        'CounterMachineLife
        '
        Me.CounterMachineLife.BackColor = System.Drawing.Color.White
        Me.CounterMachineLife.BooleanDisplay = MfgControl.AdvancedHMI.Counter.BooleanDisplayOption.TrueFalse
        Me.CounterMachineLife.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CounterMachineLife.CommComponent = Nothing
        Me.CounterMachineLife.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CounterMachineLife.ForeColor = System.Drawing.Color.Black
        Me.CounterMachineLife.Hidden = False
        Me.CounterMachineLife.HighlightColor = System.Drawing.Color.Red
        Me.CounterMachineLife.HighlightKeyCharacter = "!"
        Me.CounterMachineLife.intValue = 0
        Me.CounterMachineLife.KeypadFont = New System.Drawing.Font("Let's go Digital", 10.0!)
        Me.CounterMachineLife.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.CounterMachineLife.KeypadMinValue = 0.0R
        Me.CounterMachineLife.KeypadText = Nothing
        Me.CounterMachineLife.KeypadWidth = 300
        Me.CounterMachineLife.Location = New System.Drawing.Point(183, 58)
        Me.CounterMachineLife.Name = "CounterMachineLife"
        Me.CounterMachineLife.NumericFormat = "#,##0"
        Me.CounterMachineLife.PLCAddressKeypad = ""
        Me.CounterMachineLife.PLCAddressValue = ""
        Me.CounterMachineLife.PLCAddressVisible = ""
        Me.CounterMachineLife.PollRate = 0
        Me.CounterMachineLife.Size = New System.Drawing.Size(76, 20)
        Me.CounterMachineLife.TabIndex = 48
        Me.CounterMachineLife.Text = "0"
        Me.CounterMachineLife.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CounterMachineLife.Value = "0"
        Me.CounterMachineLife.ValuePrefix = Nothing
        Me.CounterMachineLife.ValueScaleFactor = 1.0R
        Me.CounterMachineLife.ValueSuffix = Nothing
        '
        'CounterMachineDay
        '
        Me.CounterMachineDay.BackColor = System.Drawing.Color.White
        Me.CounterMachineDay.BooleanDisplay = MfgControl.AdvancedHMI.Counter.BooleanDisplayOption.TrueFalse
        Me.CounterMachineDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CounterMachineDay.CommComponent = Nothing
        Me.CounterMachineDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CounterMachineDay.ForeColor = System.Drawing.Color.Black
        Me.CounterMachineDay.Hidden = False
        Me.CounterMachineDay.HighlightColor = System.Drawing.Color.Red
        Me.CounterMachineDay.HighlightKeyCharacter = "!"
        Me.CounterMachineDay.intValue = 0
        Me.CounterMachineDay.KeypadFont = New System.Drawing.Font("Let's go Digital", 10.0!)
        Me.CounterMachineDay.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.CounterMachineDay.KeypadMinValue = 0.0R
        Me.CounterMachineDay.KeypadText = Nothing
        Me.CounterMachineDay.KeypadWidth = 300
        Me.CounterMachineDay.Location = New System.Drawing.Point(183, 27)
        Me.CounterMachineDay.Name = "CounterMachineDay"
        Me.CounterMachineDay.NumericFormat = "#,##0"
        Me.CounterMachineDay.PLCAddressKeypad = ""
        Me.CounterMachineDay.PLCAddressValue = ""
        Me.CounterMachineDay.PLCAddressVisible = ""
        Me.CounterMachineDay.PollRate = 0
        Me.CounterMachineDay.Size = New System.Drawing.Size(76, 20)
        Me.CounterMachineDay.TabIndex = 47
        Me.CounterMachineDay.Text = "0"
        Me.CounterMachineDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CounterMachineDay.Value = "0"
        Me.CounterMachineDay.ValuePrefix = Nothing
        Me.CounterMachineDay.ValueScaleFactor = 1.0R
        Me.CounterMachineDay.ValueSuffix = Nothing
        '
        'GBSettings
        '
        Me.GBSettings.Controls.Add(Me.Label42)
        Me.GBSettings.Controls.Add(Me.NUoverridewate)
        Me.GBSettings.Controls.Add(Me.Label39)
        Me.GBSettings.Controls.Add(Me.Label40)
        Me.GBSettings.Controls.Add(Me.ButtonSaveTimings)
        Me.GBSettings.Controls.Add(Me.Label19)
        Me.GBSettings.Controls.Add(Me.Label18)
        Me.GBSettings.Controls.Add(Me.Label17)
        Me.GBSettings.Controls.Add(Me.Label16)
        Me.GBSettings.Controls.Add(Me.Label15)
        Me.GBSettings.Controls.Add(Me.Label14)
        Me.GBSettings.Controls.Add(Me.Label13)
        Me.GBSettings.Controls.Add(Me.Label12)
        Me.GBSettings.Controls.Add(Me.Label11)
        Me.GBSettings.Controls.Add(Me.Label10)
        Me.GBSettings.Controls.Add(Me.NUGateCloseDelay)
        Me.GBSettings.Controls.Add(Me.NUhammerdelay)
        Me.GBSettings.Controls.Add(Me.NUknifedelay)
        Me.GBSettings.Controls.Add(Me.NUknifetime)
        Me.GBSettings.Controls.Add(Me.NUlifttime)
        Me.GBSettings.Controls.Add(Me.NUGateOpendelay)
        Me.GBSettings.Controls.Add(Me.CBMachineAutoOverride)
        Me.GBSettings.Location = New System.Drawing.Point(787, 401)
        Me.GBSettings.Name = "GBSettings"
        Me.GBSettings.Size = New System.Drawing.Size(277, 254)
        Me.GBSettings.TabIndex = 36
        Me.GBSettings.TabStop = False
        Me.GBSettings.Text = "Settings"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label39.Location = New System.Drawing.Point(20, 24)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(139, 17)
        Me.Label39.TabIndex = 28
        Me.Label39.Text = "Gate Close Delay:"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label40.Location = New System.Drawing.Point(228, 24)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(28, 17)
        Me.Label40.TabIndex = 27
        Me.Label40.Text = "ms"
        '
        'ButtonSaveTimings
        '
        Me.ButtonSaveTimings.Location = New System.Drawing.Point(79, 224)
        Me.ButtonSaveTimings.Name = "ButtonSaveTimings"
        Me.ButtonSaveTimings.Size = New System.Drawing.Size(104, 23)
        Me.ButtonSaveTimings.TabIndex = 25
        Me.ButtonSaveTimings.Text = "Save Settings"
        Me.ButtonSaveTimings.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(20, 169)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(138, 17)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Gate Open Delay:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label18.Location = New System.Drawing.Point(20, 140)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(76, 17)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Lift Time:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(20, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(90, 17)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Knife Time:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label16.Location = New System.Drawing.Point(20, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 17)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Knife Delay:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label15.Location = New System.Drawing.Point(20, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(118, 17)
        Me.Label15.TabIndex = 15
        Me.Label15.Text = "Hammer Delay:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label14.Location = New System.Drawing.Point(228, 169)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 17)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "ms"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label13.Location = New System.Drawing.Point(228, 140)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 17)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "ms"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label12.Location = New System.Drawing.Point(228, 111)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 17)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "ms"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label11.Location = New System.Drawing.Point(228, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "ms"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(228, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 17)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "ms"
        '
        'NUGateCloseDelay
        '
        Me.NUGateCloseDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NUGateCloseDelay.Location = New System.Drawing.Point(162, 22)
        Me.NUGateCloseDelay.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUGateCloseDelay.Name = "NUGateCloseDelay"
        Me.NUGateCloseDelay.Size = New System.Drawing.Size(60, 23)
        Me.NUGateCloseDelay.TabIndex = 29
        '
        'NUhammerdelay
        '
        Me.NUhammerdelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NUhammerdelay.Location = New System.Drawing.Point(162, 51)
        Me.NUhammerdelay.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUhammerdelay.Name = "NUhammerdelay"
        Me.NUhammerdelay.Size = New System.Drawing.Size(60, 23)
        Me.NUhammerdelay.TabIndex = 20
        '
        'NUknifedelay
        '
        Me.NUknifedelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NUknifedelay.Location = New System.Drawing.Point(162, 80)
        Me.NUknifedelay.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUknifedelay.Name = "NUknifedelay"
        Me.NUknifedelay.Size = New System.Drawing.Size(60, 23)
        Me.NUknifedelay.TabIndex = 21
        '
        'NUknifetime
        '
        Me.NUknifetime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NUknifetime.Location = New System.Drawing.Point(162, 109)
        Me.NUknifetime.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUknifetime.Name = "NUknifetime"
        Me.NUknifetime.Size = New System.Drawing.Size(60, 23)
        Me.NUknifetime.TabIndex = 22
        '
        'NUlifttime
        '
        Me.NUlifttime.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NUlifttime.Location = New System.Drawing.Point(162, 138)
        Me.NUlifttime.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUlifttime.Name = "NUlifttime"
        Me.NUlifttime.Size = New System.Drawing.Size(60, 23)
        Me.NUlifttime.TabIndex = 23
        '
        'NUGateOpendelay
        '
        Me.NUGateOpendelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NUGateOpendelay.Location = New System.Drawing.Point(162, 167)
        Me.NUGateOpendelay.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUGateOpendelay.Name = "NUGateOpendelay"
        Me.NUGateOpendelay.Size = New System.Drawing.Size(60, 23)
        Me.NUGateOpendelay.TabIndex = 24
        '
        'CBMachineAutoOverride
        '
        Me.CBMachineAutoOverride.AutoSize = True
        Me.CBMachineAutoOverride.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.CBMachineAutoOverride.Location = New System.Drawing.Point(23, 197)
        Me.CBMachineAutoOverride.Name = "CBMachineAutoOverride"
        Me.CBMachineAutoOverride.Size = New System.Drawing.Size(129, 21)
        Me.CBMachineAutoOverride.TabIndex = 26
        Me.CBMachineAutoOverride.Text = "Auto-Override"
        Me.CBMachineAutoOverride.UseVisualStyleBackColor = True
        '
        'LabMachine
        '
        Me.LabMachine.AutoSize = True
        Me.LabMachine.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LabMachine.Location = New System.Drawing.Point(703, 3)
        Me.LabMachine.Name = "LabMachine"
        Me.LabMachine.Size = New System.Drawing.Size(147, 31)
        Me.LabMachine.TabIndex = 35
        Me.LabMachine.Text = "Machine #"
        '
        'ButNext
        '
        Me.ButNext.Location = New System.Drawing.Point(1141, 499)
        Me.ButNext.Name = "ButNext"
        Me.ButNext.Size = New System.Drawing.Size(75, 120)
        Me.ButNext.TabIndex = 34
        Me.ButNext.Text = "Next >"
        Me.ButNext.UseVisualStyleBackColor = True
        '
        'ButPrev
        '
        Me.ButPrev.Location = New System.Drawing.Point(229, 499)
        Me.ButPrev.Name = "ButPrev"
        Me.ButPrev.Size = New System.Drawing.Size(75, 120)
        Me.ButPrev.TabIndex = 33
        Me.ButPrev.Text = "< Previous"
        Me.ButPrev.UseVisualStyleBackColor = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 346)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(67, 13)
        Me.Label27.TabIndex = 32
        Me.Label27.Text = "Hold down"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 311)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(25, 13)
        Me.Label26.TabIndex = 31
        Me.Label26.Text = "Lift"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 271)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(36, 13)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "Knife"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 231)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(52, 13)
        Me.Label24.TabIndex = 29
        Me.Label24.Text = "Hammer"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 191)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(31, 13)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "FAD"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 151)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 13)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "Main Trigger"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 111)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 13)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Tail Trigger"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 71)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 13)
        Me.Label20.TabIndex = 25
        Me.Label20.Text = "Tail Gate"
        '
        'TabLog
        '
        Me.TabLog.Controls.Add(Me.LabelWarning)
        Me.TabLog.Controls.Add(Me.DataGridView1)
        Me.TabLog.Controls.Add(Me.DateTimePickerLog)
        Me.TabLog.Location = New System.Drawing.Point(4, 22)
        Me.TabLog.Name = "TabLog"
        Me.TabLog.Size = New System.Drawing.Size(1242, 654)
        Me.TabLog.TabIndex = 2
        Me.TabLog.Text = "Log"
        Me.TabLog.UseVisualStyleBackColor = True
        '
        'LabelWarning
        '
        Me.LabelWarning.AutoSize = True
        Me.LabelWarning.Location = New System.Drawing.Point(566, 24)
        Me.LabelWarning.Name = "LabelWarning"
        Me.LabelWarning.Size = New System.Drawing.Size(0, 13)
        Me.LabelWarning.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(20, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1190, 491)
        Me.DataGridView1.TabIndex = 1
        '
        'DateTimePickerLog
        '
        Me.DateTimePickerLog.Location = New System.Drawing.Point(293, 18)
        Me.DateTimePickerLog.Name = "DateTimePickerLog"
        Me.DateTimePickerLog.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePickerLog.TabIndex = 0
        '
        'TabChart
        '
        Me.TabChart.Controls.Add(Me.ButtonResetEnd)
        Me.TabChart.Controls.Add(Me.ButtonResetStart)
        Me.TabChart.Controls.Add(Me.DateTimePickerEnd)
        Me.TabChart.Controls.Add(Me.DateTimePickerStart)
        Me.TabChart.Controls.Add(Me.DataGridViewChart)
        Me.TabChart.Controls.Add(Me.CheckedListBox1)
        Me.TabChart.Controls.Add(Me.Chart1)
        Me.TabChart.Location = New System.Drawing.Point(4, 22)
        Me.TabChart.Name = "TabChart"
        Me.TabChart.Size = New System.Drawing.Size(1242, 654)
        Me.TabChart.TabIndex = 3
        Me.TabChart.Text = "Chart"
        Me.TabChart.UseVisualStyleBackColor = True
        '
        'ButtonResetEnd
        '
        Me.ButtonResetEnd.Location = New System.Drawing.Point(189, 96)
        Me.ButtonResetEnd.Name = "ButtonResetEnd"
        Me.ButtonResetEnd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonResetEnd.TabIndex = 6
        Me.ButtonResetEnd.Text = "Reset"
        Me.ButtonResetEnd.UseVisualStyleBackColor = True
        '
        'ButtonResetStart
        '
        Me.ButtonResetStart.Location = New System.Drawing.Point(189, 69)
        Me.ButtonResetStart.Name = "ButtonResetStart"
        Me.ButtonResetStart.Size = New System.Drawing.Size(75, 23)
        Me.ButtonResetStart.TabIndex = 5
        Me.ButtonResetStart.Text = "Reset"
        Me.ButtonResetStart.UseVisualStyleBackColor = True
        '
        'DateTimePickerEnd
        '
        Me.DateTimePickerEnd.CustomFormat = "dd/MM/yyy HH:mm"
        Me.DateTimePickerEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerEnd.Location = New System.Drawing.Point(18, 96)
        Me.DateTimePickerEnd.Name = "DateTimePickerEnd"
        Me.DateTimePickerEnd.Size = New System.Drawing.Size(150, 20)
        Me.DateTimePickerEnd.TabIndex = 4
        '
        'DateTimePickerStart
        '
        Me.DateTimePickerStart.CustomFormat = "dd/MM/yyy HH:mm"
        Me.DateTimePickerStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePickerStart.Location = New System.Drawing.Point(18, 69)
        Me.DateTimePickerStart.Name = "DateTimePickerStart"
        Me.DateTimePickerStart.Size = New System.Drawing.Size(150, 20)
        Me.DateTimePickerStart.TabIndex = 3
        Me.DateTimePickerStart.Value = New Date(2013, 11, 14, 17, 26, 0, 0)
        '
        'DataGridViewChart
        '
        Me.DataGridViewChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewChart.Location = New System.Drawing.Point(3, 417)
        Me.DataGridViewChart.Name = "DataGridViewChart"
        Me.DataGridViewChart.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridViewChart.Size = New System.Drawing.Size(396, 234)
        Me.DataGridViewChart.TabIndex = 2
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(18, 164)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(176, 199)
        Me.CheckedListBox1.TabIndex = 1
        '
        'Chart1
        '
        ChartArea1.Name = "Total"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(405, 0)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Size = New System.Drawing.Size(829, 651)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Name = "MainTitle"
        Me.Chart1.Titles.Add(Title1)
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightGray
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.ButtonPrint)
        Me.TabPage1.Controls.Add(Me.ButtonAddVessel)
        Me.TabPage1.Controls.Add(VesselIDLabel)
        Me.TabPage1.Controls.Add(Me.VesselIDComboBox)
        Me.TabPage1.Controls.Add(HarvestIDLabel)
        Me.TabPage1.Controls.Add(Me.HarvestIDTextBox)
        Me.TabPage1.Controls.Add(Me.HarvestTBindingNavigator)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1242, 654)
        Me.TabPage1.TabIndex = 5
        Me.TabPage1.Text = "Report"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ButtonAddSkipper)
        Me.GroupBox2.Controls.Add(Me.ButtonAddPort)
        Me.GroupBox2.Controls.Add(Label34)
        Me.GroupBox2.Controls.Add(Label33)
        Me.GroupBox2.Controls.Add(Label32)
        Me.GroupBox2.Controls.Add(DeliveryDateLabel)
        Me.GroupBox2.Controls.Add(Me.DeliveryDatePicker)
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
        Me.GroupBox2.Controls.Add(Me.EndDateTimeDateTimePicker)
        Me.GroupBox2.Controls.Add(StartTimeLabel)
        Me.GroupBox2.Controls.Add(Me.StartDateTimeDateTimePicker)
        Me.GroupBox2.Controls.Add(ArrivalTimeLabel)
        Me.GroupBox2.Controls.Add(Me.ArrivalTimePicker)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(43, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(885, 341)
        Me.GroupBox2.TabIndex = 102
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Section 2: To be completed by Wellboat Skipper"
        '
        'ButtonAddSkipper
        '
        Me.ButtonAddSkipper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ButtonAddSkipper.Location = New System.Drawing.Point(346, 312)
        Me.ButtonAddSkipper.Name = "ButtonAddSkipper"
        Me.ButtonAddSkipper.Size = New System.Drawing.Size(105, 23)
        Me.ButtonAddSkipper.TabIndex = 107
        Me.ButtonAddSkipper.Text = "Add Skipper"
        Me.ButtonAddSkipper.UseVisualStyleBackColor = True
        '
        'ButtonAddPort
        '
        Me.ButtonAddPort.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ButtonAddPort.Location = New System.Drawing.Point(432, 226)
        Me.ButtonAddPort.Name = "ButtonAddPort"
        Me.ButtonAddPort.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddPort.TabIndex = 106
        Me.ButtonAddPort.Text = "Add Port"
        Me.ButtonAddPort.UseVisualStyleBackColor = True
        '
        'DeliveryDatePicker
        '
        Me.DeliveryDatePicker.CustomFormat = "HH:mm"
        Me.DeliveryDatePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HarvestTBindingSource, "DeliveryDateTime", True))
        Me.DeliveryDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.DeliveryDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DeliveryDatePicker.Location = New System.Drawing.Point(562, 197)
        Me.DeliveryDatePicker.Name = "DeliveryDatePicker"
        Me.DeliveryDatePicker.Size = New System.Drawing.Size(128, 22)
        Me.DeliveryDatePicker.TabIndex = 102
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
        'TBBiomass
        '
        Me.TBBiomass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TBBiomass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TBBiomass.Location = New System.Drawing.Point(217, 56)
        Me.TBBiomass.Name = "TBBiomass"
        Me.TBBiomass.Size = New System.Drawing.Size(151, 22)
        Me.TBBiomass.TabIndex = 97
        '
        'TempSiteTextBox
        '
        Me.TempSiteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TempSiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "TempSite", True))
        Me.TempSiteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TempSiteTextBox.Location = New System.Drawing.Point(518, 115)
        Me.TempSiteTextBox.Name = "TempSiteTextBox"
        Me.TempSiteTextBox.Size = New System.Drawing.Size(59, 22)
        Me.TempSiteTextBox.TabIndex = 84
        '
        'TempWellTextBox
        '
        Me.TempWellTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TempWellTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "TempWell", True))
        Me.TempWellTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.TempWellTextBox.Location = New System.Drawing.Point(217, 115)
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
        Me.ConditionIDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ConditionIDComboBox.FormattingEnabled = True
        Me.ConditionIDComboBox.Location = New System.Drawing.Point(217, 84)
        Me.ConditionIDComboBox.Name = "ConditionIDComboBox"
        Me.ConditionIDComboBox.Size = New System.Drawing.Size(151, 24)
        Me.ConditionIDComboBox.TabIndex = 80
        Me.ConditionIDComboBox.ValueMember = "ConditionID"
        '
        'ConditionTBindingSource
        '
        Me.ConditionTBindingSource.AllowNew = False
        Me.ConditionTBindingSource.DataMember = "ConditionT"
        Me.ConditionTBindingSource.DataSource = Me.ClientDS
        '
        'FishCountTextBox
        '
        Me.FishCountTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FishCountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "FishCount", True))
        Me.FishCountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.FishCountTextBox.Location = New System.Drawing.Point(217, 28)
        Me.FishCountTextBox.Name = "FishCountTextBox"
        Me.FishCountTextBox.Size = New System.Drawing.Size(151, 22)
        Me.FishCountTextBox.TabIndex = 78
        '
        'SkipperIDComboBox
        '
        Me.SkipperIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HarvestTBindingSource, "SkipperID", True))
        Me.SkipperIDComboBox.DataSource = Me.SkipperTBindingSource
        Me.SkipperIDComboBox.DisplayMember = "Skipper"
        Me.SkipperIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SkipperIDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.SkipperIDComboBox.FormattingEnabled = True
        Me.SkipperIDComboBox.Location = New System.Drawing.Point(217, 311)
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
        Me.SkipperCommentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SkipperCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "SkipperComments", True))
        Me.SkipperCommentsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.SkipperCommentsTextBox.Location = New System.Drawing.Point(219, 255)
        Me.SkipperCommentsTextBox.Multiline = True
        Me.SkipperCommentsTextBox.Name = "SkipperCommentsTextBox"
        Me.SkipperCommentsTextBox.Size = New System.Drawing.Size(585, 50)
        Me.SkipperCommentsTextBox.TabIndex = 59
        '
        'PortIDComboBox
        '
        Me.PortIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HarvestTBindingSource, "PortID", True))
        Me.PortIDComboBox.DataSource = Me.PortTBindingSource
        Me.PortIDComboBox.DisplayMember = "Port"
        Me.PortIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.PortIDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
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
        'EndDateTimeDateTimePicker
        '
        Me.EndDateTimeDateTimePicker.CustomFormat = "HH:mm"
        Me.EndDateTimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HarvestTBindingSource, "EndDateTime", True))
        Me.EndDateTimeDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.EndDateTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.EndDateTimeDateTimePicker.Location = New System.Drawing.Point(301, 197)
        Me.EndDateTimeDateTimePicker.Name = "EndDateTimeDateTimePicker"
        Me.EndDateTimeDateTimePicker.Size = New System.Drawing.Size(128, 22)
        Me.EndDateTimeDateTimePicker.TabIndex = 55
        '
        'StartDateTimeDateTimePicker
        '
        Me.StartDateTimeDateTimePicker.CustomFormat = "HH:mm"
        Me.StartDateTimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HarvestTBindingSource, "StartDateTime", True))
        Me.StartDateTimeDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.StartDateTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.StartDateTimeDateTimePicker.Location = New System.Drawing.Point(167, 197)
        Me.StartDateTimeDateTimePicker.Name = "StartDateTimeDateTimePicker"
        Me.StartDateTimeDateTimePicker.Size = New System.Drawing.Size(128, 22)
        Me.StartDateTimeDateTimePicker.TabIndex = 53
        '
        'ArrivalTimePicker
        '
        Me.ArrivalTimePicker.CustomFormat = "HH:mm"
        Me.ArrivalTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HarvestTBindingSource, "ArrivalDateTime", True))
        Me.ArrivalTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ArrivalTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.ArrivalTimePicker.Location = New System.Drawing.Point(33, 197)
        Me.ArrivalTimePicker.Name = "ArrivalTimePicker"
        Me.ArrivalTimePicker.Size = New System.Drawing.Size(128, 22)
        Me.ArrivalTimePicker.TabIndex = 51
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label31)
        Me.GroupBox1.Controls.Add(Label30)
        Me.GroupBox1.Controls.Add(Label29)
        Me.GroupBox1.Controls.Add(RepIDLabel1)
        Me.GroupBox1.Controls.Add(Me.RepIDComboBox1)
        Me.GroupBox1.Controls.Add(Me.ButtonAddRep)
        Me.GroupBox1.Controls.Add(Me.ButtonAddSite)
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
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(43, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(885, 206)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Section 1: To be completed by Site Representative"
        '
        'RepIDComboBox1
        '
        Me.RepIDComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HarvestTBindingSource, "RepID", True))
        Me.RepIDComboBox1.DataSource = Me.RepTBindingSource
        Me.RepIDComboBox1.DisplayMember = "Rep"
        Me.RepIDComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RepIDComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepIDComboBox1.FormattingEnabled = True
        Me.RepIDComboBox1.Location = New System.Drawing.Point(219, 159)
        Me.RepIDComboBox1.Name = "RepIDComboBox1"
        Me.RepIDComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.RepIDComboBox1.TabIndex = 100
        Me.RepIDComboBox1.ValueMember = "RepID"
        '
        'RepTBindingSource
        '
        Me.RepTBindingSource.DataMember = "RepT"
        Me.RepTBindingSource.DataSource = Me.ClientDS
        '
        'ButtonAddRep
        '
        Me.ButtonAddRep.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ButtonAddRep.Location = New System.Drawing.Point(346, 159)
        Me.ButtonAddRep.Name = "ButtonAddRep"
        Me.ButtonAddRep.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddRep.TabIndex = 96
        Me.ButtonAddRep.Text = "Add Rep"
        Me.ButtonAddRep.UseVisualStyleBackColor = True
        '
        'ButtonAddSite
        '
        Me.ButtonAddSite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddSite.Location = New System.Drawing.Point(346, 20)
        Me.ButtonAddSite.Name = "ButtonAddSite"
        Me.ButtonAddSite.Size = New System.Drawing.Size(75, 23)
        Me.ButtonAddSite.TabIndex = 95
        Me.ButtonAddSite.Text = "Add Site"
        Me.ButtonAddSite.UseVisualStyleBackColor = True
        '
        'StarveDateTimeDateTimePicker
        '
        Me.StarveDateTimeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.HarvestTBindingSource, "StarveDateTime", True))
        Me.StarveDateTimeDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StarveDateTimeDateTimePicker.Location = New System.Drawing.Point(663, 23)
        Me.StarveDateTimeDateTimePicker.Name = "StarveDateTimeDateTimePicker"
        Me.StarveDateTimeDateTimePicker.Size = New System.Drawing.Size(141, 22)
        Me.StarveDateTimeDateTimePicker.TabIndex = 90
        '
        'SiteIDComboBox
        '
        Me.SiteIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HarvestTBindingSource, "SiteID", True))
        Me.SiteIDComboBox.DataSource = Me.SiteTBindingSource
        Me.SiteIDComboBox.DisplayMember = "Site"
        Me.SiteIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SiteIDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteIDComboBox.FormattingEnabled = True
        Me.SiteIDComboBox.Location = New System.Drawing.Point(219, 22)
        Me.SiteIDComboBox.Name = "SiteIDComboBox"
        Me.SiteIDComboBox.Size = New System.Drawing.Size(121, 24)
        Me.SiteIDComboBox.TabIndex = 88
        Me.SiteIDComboBox.ValueMember = "SiteID"
        '
        'SiteTBindingSource
        '
        Me.SiteTBindingSource.DataMember = "SiteT"
        Me.SiteTBindingSource.DataSource = Me.ClientDS
        '
        'RepCommentsTextBox
        '
        Me.RepCommentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RepCommentsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "RepComments", True))
        Me.RepCommentsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepCommentsTextBox.Location = New System.Drawing.Point(219, 103)
        Me.RepCommentsTextBox.Multiline = True
        Me.RepCommentsTextBox.Name = "RepCommentsTextBox"
        Me.RepCommentsTextBox.Size = New System.Drawing.Size(585, 50)
        Me.RepCommentsTextBox.TabIndex = 76
        '
        'EndWeightTextBox
        '
        Me.EndWeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EndWeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "EndWeight", True))
        Me.EndWeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.EndWeightTextBox.Location = New System.Drawing.Point(663, 75)
        Me.EndWeightTextBox.Name = "EndWeightTextBox"
        Me.EndWeightTextBox.Size = New System.Drawing.Size(141, 22)
        Me.EndWeightTextBox.TabIndex = 74
        '
        'StartWeightTextBox
        '
        Me.StartWeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.StartWeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "StartWeight", True))
        Me.StartWeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.StartWeightTextBox.Location = New System.Drawing.Point(663, 49)
        Me.StartWeightTextBox.Name = "StartWeightTextBox"
        Me.StartWeightTextBox.Size = New System.Drawing.Size(141, 22)
        Me.StartWeightTextBox.TabIndex = 72
        '
        'AverageWeightTextBox
        '
        Me.AverageWeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AverageWeightTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "AverageWeight", True))
        Me.AverageWeightTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.AverageWeightTextBox.Location = New System.Drawing.Point(219, 75)
        Me.AverageWeightTextBox.Name = "AverageWeightTextBox"
        Me.AverageWeightTextBox.Size = New System.Drawing.Size(121, 22)
        Me.AverageWeightTextBox.TabIndex = 70
        '
        'CageNoTextBox
        '
        Me.CageNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CageNoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "CageNo", True))
        Me.CageNoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.CageNoTextBox.Location = New System.Drawing.Point(219, 49)
        Me.CageNoTextBox.Name = "CageNoTextBox"
        Me.CageNoTextBox.Size = New System.Drawing.Size(121, 22)
        Me.CageNoTextBox.TabIndex = 68
        '
        'ButtonPrint
        '
        Me.ButtonPrint.Location = New System.Drawing.Point(420, 626)
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.Size = New System.Drawing.Size(103, 23)
        Me.ButtonPrint.TabIndex = 99
        Me.ButtonPrint.Text = "Print Report"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ButtonAddVessel
        '
        Me.ButtonAddVessel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddVessel.Location = New System.Drawing.Point(389, 12)
        Me.ButtonAddVessel.Name = "ButtonAddVessel"
        Me.ButtonAddVessel.Size = New System.Drawing.Size(92, 23)
        Me.ButtonAddVessel.TabIndex = 94
        Me.ButtonAddVessel.Text = "Add Vessel"
        Me.ButtonAddVessel.UseVisualStyleBackColor = True
        '
        'VesselIDComboBox
        '
        Me.VesselIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.HarvestTBindingSource, "VesselID", True))
        Me.VesselIDComboBox.DataSource = Me.VesselTBindingSource
        Me.VesselIDComboBox.DisplayMember = "Vessel"
        Me.VesselIDComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.VesselIDComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VesselIDComboBox.FormattingEnabled = True
        Me.VesselIDComboBox.Location = New System.Drawing.Point(262, 9)
        Me.VesselIDComboBox.Name = "VesselIDComboBox"
        Me.VesselIDComboBox.Size = New System.Drawing.Size(121, 24)
        Me.VesselIDComboBox.TabIndex = 86
        Me.VesselIDComboBox.ValueMember = "VesselID"
        '
        'VesselTBindingSource
        '
        Me.VesselTBindingSource.DataMember = "VesselT"
        Me.VesselTBindingSource.DataSource = Me.ClientDS
        '
        'HarvestIDTextBox
        '
        Me.HarvestIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HarvestIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HarvestTBindingSource, "HarvestID", True))
        Me.HarvestIDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HarvestIDTextBox.Location = New System.Drawing.Point(706, 17)
        Me.HarvestIDTextBox.Name = "HarvestIDTextBox"
        Me.HarvestIDTextBox.Size = New System.Drawing.Size(68, 22)
        Me.HarvestIDTextBox.TabIndex = 66
        '
        'HarvestTBindingNavigator
        '
        Me.HarvestTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.HarvestTBindingNavigator.BindingSource = Me.HarvestTBindingSource
        Me.HarvestTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.HarvestTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.HarvestTBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.HarvestTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.HarvestTBindingNavigatorSaveItem})
        Me.HarvestTBindingNavigator.Location = New System.Drawing.Point(3, 626)
        Me.HarvestTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.HarvestTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.HarvestTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.HarvestTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.HarvestTBindingNavigator.Name = "HarvestTBindingNavigator"
        Me.HarvestTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.HarvestTBindingNavigator.Size = New System.Drawing.Size(1236, 25)
        Me.HarvestTBindingNavigator.TabIndex = 49
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
        'TabSettings
        '
        Me.TabSettings.BackColor = System.Drawing.Color.LightGray
        Me.TabSettings.Controls.Add(Me.CBReverseDisplay)
        Me.TabSettings.Controls.Add(Me.GroupBox5)
        Me.TabSettings.Controls.Add(Me.CBSecondScreen)
        Me.TabSettings.Controls.Add(Me.ButtonSaveSettings)
        Me.TabSettings.Controls.Add(Me.Label4)
        Me.TabSettings.Controls.Add(Me.Label3)
        Me.TabSettings.Controls.Add(Me.Label2)
        Me.TabSettings.Controls.Add(Me.TBLogPath)
        Me.TabSettings.Controls.Add(Me.TBNoMachines)
        Me.TabSettings.Controls.Add(Me.TBVessel)
        Me.TabSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabSettings.Name = "TabSettings"
        Me.TabSettings.Size = New System.Drawing.Size(1242, 654)
        Me.TabSettings.TabIndex = 4
        Me.TabSettings.Text = "Settings"
        '
        'CBReverseDisplay
        '
        Me.CBReverseDisplay.AutoSize = True
        Me.CBReverseDisplay.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBReverseDisplay.Checked = Global.MfgControl.AdvancedHMI.My.MySettings.Default.ReverseDisplay
        Me.CBReverseDisplay.Location = New System.Drawing.Point(6, 124)
        Me.CBReverseDisplay.Name = "CBReverseDisplay"
        Me.CBReverseDisplay.Size = New System.Drawing.Size(126, 17)
        Me.CBReverseDisplay.TabIndex = 22
        Me.CBReverseDisplay.Text = "Reverse Display :"
        Me.CBReverseDisplay.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TBoverridewait)
        Me.GroupBox5.Controls.Add(Me.TBHammerDelay)
        Me.GroupBox5.Controls.Add(Me.TBKnifeDelay)
        Me.GroupBox5.Controls.Add(Me.CBSettingsAutooverride)
        Me.GroupBox5.Controls.Add(Me.TBKnifeTime)
        Me.GroupBox5.Controls.Add(Me.Label41)
        Me.GroupBox5.Controls.Add(Me.TBLiftTime)
        Me.GroupBox5.Controls.Add(Me.TBGateCloseDelay)
        Me.GroupBox5.Controls.Add(Me.TBGateOpenDelay)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.Label7)
        Me.GroupBox5.Location = New System.Drawing.Point(734, 18)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(223, 222)
        Me.GroupBox5.TabIndex = 21
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Default Machine Settings"
        '
        'TBoverridewait
        '
        Me.TBoverridewait.Location = New System.Drawing.Point(117, 184)
        Me.TBoverridewait.Name = "TBoverridewait"
        Me.TBoverridewait.Size = New System.Drawing.Size(100, 20)
        Me.TBoverridewait.TabIndex = 20
        '
        'TBHammerDelay
        '
        Me.TBHammerDelay.Location = New System.Drawing.Point(117, 54)
        Me.TBHammerDelay.Name = "TBHammerDelay"
        Me.TBHammerDelay.Size = New System.Drawing.Size(100, 20)
        Me.TBHammerDelay.TabIndex = 3
        '
        'TBKnifeDelay
        '
        Me.TBKnifeDelay.Location = New System.Drawing.Point(117, 80)
        Me.TBKnifeDelay.Name = "TBKnifeDelay"
        Me.TBKnifeDelay.Size = New System.Drawing.Size(100, 20)
        Me.TBKnifeDelay.TabIndex = 4
        '
        'CBSettingsAutooverride
        '
        Me.CBSettingsAutooverride.AutoSize = True
        Me.CBSettingsAutooverride.Checked = Global.MfgControl.AdvancedHMI.My.MySettings.Default.AutoOverride
        Me.CBSettingsAutooverride.Location = New System.Drawing.Point(11, 186)
        Me.CBSettingsAutooverride.Name = "CBSettingsAutooverride"
        Me.CBSettingsAutooverride.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CBSettingsAutooverride.Size = New System.Drawing.Size(104, 17)
        Me.CBSettingsAutooverride.TabIndex = 19
        Me.CBSettingsAutooverride.Text = "Auto Override"
        Me.CBSettingsAutooverride.UseVisualStyleBackColor = True
        '
        'TBKnifeTime
        '
        Me.TBKnifeTime.Location = New System.Drawing.Point(117, 106)
        Me.TBKnifeTime.Name = "TBKnifeTime"
        Me.TBKnifeTime.Size = New System.Drawing.Size(100, 20)
        Me.TBKnifeTime.TabIndex = 5
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(10, 31)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(105, 13)
        Me.Label41.TabIndex = 18
        Me.Label41.Text = "Gate Close Delay"
        '
        'TBLiftTime
        '
        Me.TBLiftTime.Location = New System.Drawing.Point(117, 132)
        Me.TBLiftTime.Name = "TBLiftTime"
        Me.TBLiftTime.Size = New System.Drawing.Size(100, 20)
        Me.TBLiftTime.TabIndex = 6
        '
        'TBGateCloseDelay
        '
        Me.TBGateCloseDelay.Location = New System.Drawing.Point(117, 28)
        Me.TBGateCloseDelay.Name = "TBGateCloseDelay"
        Me.TBGateCloseDelay.Size = New System.Drawing.Size(100, 20)
        Me.TBGateCloseDelay.TabIndex = 17
        '
        'TBGateOpenDelay
        '
        Me.TBGateOpenDelay.Location = New System.Drawing.Point(117, 158)
        Me.TBGateOpenDelay.Name = "TBGateOpenDelay"
        Me.TBGateOpenDelay.Size = New System.Drawing.Size(100, 20)
        Me.TBGateOpenDelay.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Hammer Delay"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Gate Open Delay"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Knife Delay"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Lift Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Knife Time"
        '
        'CBSecondScreen
        '
        Me.CBSecondScreen.AutoSize = True
        Me.CBSecondScreen.Checked = Global.MfgControl.AdvancedHMI.My.MySettings.Default.SecondScreen
        Me.CBSecondScreen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CBSecondScreen.Location = New System.Drawing.Point(6, 101)
        Me.CBSecondScreen.Name = "CBSecondScreen"
        Me.CBSecondScreen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CBSecondScreen.Size = New System.Drawing.Size(145, 17)
        Me.CBSecondScreen.TabIndex = 20
        Me.CBSecondScreen.Text = ":Use Second Monitor"
        Me.CBSecondScreen.UseVisualStyleBackColor = True
        '
        'ButtonSaveSettings
        '
        Me.ButtonSaveSettings.Location = New System.Drawing.Point(261, 217)
        Me.ButtonSaveSettings.Name = "ButtonSaveSettings"
        Me.ButtonSaveSettings.Size = New System.Drawing.Size(113, 23)
        Me.ButtonSaveSettings.TabIndex = 16
        Me.ButtonSaveSettings.Text = "Save Settings"
        Me.ButtonSaveSettings.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Log Path"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Number of Machines"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Vessel Name"
        '
        'TBLogPath
        '
        Me.TBLogPath.Location = New System.Drawing.Point(151, 75)
        Me.TBLogPath.Name = "TBLogPath"
        Me.TBLogPath.Size = New System.Drawing.Size(488, 20)
        Me.TBLogPath.TabIndex = 2
        '
        'TBNoMachines
        '
        Me.TBNoMachines.Location = New System.Drawing.Point(151, 49)
        Me.TBNoMachines.Name = "TBNoMachines"
        Me.TBNoMachines.Size = New System.Drawing.Size(100, 20)
        Me.TBNoMachines.TabIndex = 1
        '
        'TBVessel
        '
        Me.TBVessel.Location = New System.Drawing.Point(151, 23)
        Me.TBVessel.Name = "TBVessel"
        Me.TBVessel.Size = New System.Drawing.Size(100, 20)
        Me.TBVessel.TabIndex = 0
        '
        'TabHelp
        '
        Me.TabHelp.Controls.Add(Me.LbHelpVersion)
        Me.TabHelp.Controls.Add(Me.TextBox1)
        Me.TabHelp.Controls.Add(Me.Label1)
        Me.TabHelp.Location = New System.Drawing.Point(4, 22)
        Me.TabHelp.Name = "TabHelp"
        Me.TabHelp.Size = New System.Drawing.Size(1242, 654)
        Me.TabHelp.TabIndex = 6
        Me.TabHelp.Text = "Help"
        Me.TabHelp.UseVisualStyleBackColor = True
        '
        'LbHelpVersion
        '
        Me.LbHelpVersion.AutoSize = True
        Me.LbHelpVersion.Location = New System.Drawing.Point(736, 26)
        Me.LbHelpVersion.Name = "LbHelpVersion"
        Me.LbHelpVersion.Size = New System.Drawing.Size(97, 13)
        Me.LbHelpVersion.TabIndex = 2
        Me.LbHelpVersion.Text = "Version: 1.0.3.4"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(79, 117)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(499, 104)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Mobile: 0778 626 5680 (Please try this number first)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Office Number: 01957 744 21" & _
    "5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Email: colin@northyell.co.uk"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Colin Dickie contact details:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label36.Location = New System.Drawing.Point(15, 59)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(105, 18)
        Me.Label36.TabIndex = 49
        Me.Label36.Text = "Life Counter:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Label35.Location = New System.Drawing.Point(15, 27)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(107, 18)
        Me.Label35.TabIndex = 48
        Me.Label35.Text = "Day Counter:"
        '
        'TimerLog
        '
        Me.TimerLog.Enabled = True
        Me.TimerLog.Interval = 60000
        '
        'NUoverridewate
        '
        Me.NUoverridewate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.NUoverridewate.Location = New System.Drawing.Point(162, 195)
        Me.NUoverridewate.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NUoverridewate.Name = "NUoverridewate"
        Me.NUoverridewate.Size = New System.Drawing.Size(60, 23)
        Me.NUoverridewate.TabIndex = 30
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label42.Location = New System.Drawing.Point(228, 197)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(28, 17)
        Me.Label42.TabIndex = 31
        Me.Label42.Text = "ms"
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Chocolate
        Me.ClientSize = New System.Drawing.Size(1262, 711)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Johnson Marine - Salmon Harvester"
        Me.TabControl1.ResumeLayout(False)
        Me.TabMain.ResumeLayout(False)
        Me.TabMachine.ResumeLayout(False)
        Me.TabMachine.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GBSettings.ResumeLayout(False)
        Me.GBSettings.PerformLayout()
        CType(Me.NUGateCloseDelay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUhammerdelay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUknifedelay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUknifetime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUlifttime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUGateOpendelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabLog.ResumeLayout(False)
        Me.TabLog.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabChart.ResumeLayout(False)
        CType(Me.DataGridViewChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.HarvestTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConditionTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkipperTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PortTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RepTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiteTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VesselTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HarvestTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.HarvestTBindingNavigator.ResumeLayout(False)
        Me.HarvestTBindingNavigator.PerformLayout()
        Me.TabSettings.ResumeLayout(False)
        Me.TabSettings.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabHelp.ResumeLayout(False)
        Me.TabHelp.PerformLayout()
        CType(Me.NUoverridewate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    'Friend WithEvents Label1 As System.Windows.Forms.Label
    'Friend WithEvents QuickStartLabel As System.Windows.Forms.Label
    'Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    'Friend WithEvents BasicButton1 As MfgControl.AdvancedHMI.BasicButton
    'Friend WithEvents BasicLabel1 As MfgControl.AdvancedHMI.BasicLabel
    'Friend WithEvents BasicLabel2 As MfgControl.AdvancedHMI.BasicLabel
    'Friend WithEvents BasicLabel5 As MfgControl.AdvancedHMI.BasicLabel
    'Friend WithEvents BasicLabel4 As MfgControl.AdvancedHMI.BasicLabel
    'Friend WithEvents BasicLabel3 As MfgControl.AdvancedHMI.BasicLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabMain As System.Windows.Forms.TabPage
    Friend WithEvents TabMachine As System.Windows.Forms.TabPage
    Friend WithEvents TabLog As System.Windows.Forms.TabPage
    Friend WithEvents TabChart As System.Windows.Forms.TabPage
    Friend WithEvents TabSettings As System.Windows.Forms.TabPage
    Friend WithEvents TBLiftTime As System.Windows.Forms.TextBox
    Friend WithEvents TBKnifeTime As System.Windows.Forms.TextBox
    Friend WithEvents TBKnifeDelay As System.Windows.Forms.TextBox
    Friend WithEvents TBHammerDelay As System.Windows.Forms.TextBox
    Friend WithEvents TBLogPath As System.Windows.Forms.TextBox
    Friend WithEvents TBNoMachines As System.Windows.Forms.TextBox
    Friend WithEvents TBVessel As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TBGateOpenDelay As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSaveSettings As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents NUhammerdelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUGateOpendelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUlifttime As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUknifetime As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUknifedelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TimerLog As System.Windows.Forms.Timer
    Friend WithEvents DateTimePickerLog As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LabelWarning As System.Windows.Forms.Label
    Friend WithEvents ButtonResetEnd As System.Windows.Forms.Button
    Friend WithEvents ButtonResetStart As System.Windows.Forms.Button
    Friend WithEvents DateTimePickerEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridViewChart As System.Windows.Forms.DataGridView
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ButNext As System.Windows.Forms.Button
    Friend WithEvents ButPrev As System.Windows.Forms.Button
    Friend WithEvents LabMachine As System.Windows.Forms.Label
    Friend WithEvents LabelTotal As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SkipperIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents PortIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SkipperCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndDateTimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents StartDateTimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ArrivalTimePicker As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents ButtonAddRep As System.Windows.Forms.Button
    Friend WithEvents ButtonAddSite As System.Windows.Forms.Button
    Friend WithEvents ButtonAddVessel As System.Windows.Forms.Button
    Friend WithEvents StarveDateTimeDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SiteIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents VesselIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TempSiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TempWellTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConditionIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents FishCountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RepCommentsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EndWeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StartWeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AverageWeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CageNoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HarvestIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TBBiomass As System.Windows.Forms.TextBox
    Friend WithEvents HarvestTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VesselTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SiteTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConditionTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ButtonPrint As System.Windows.Forms.Button
    Friend WithEvents ClientDS As MfgControl.AdvancedHMI.ClientDS
    Friend WithEvents RepIDComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DeliveryDatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonAddSkipper As System.Windows.Forms.Button
    Friend WithEvents ButtonAddPort As System.Windows.Forms.Button
    Friend WithEvents PortTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SkipperTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents CounterDay As MfgControl.AdvancedHMI.Counter
    Friend WithEvents GBSettings As System.Windows.Forms.GroupBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents CounterLife As MfgControl.AdvancedHMI.Counter
    Friend WithEvents CounterLifeL As MfgControl.AdvancedHMI.Counter
    Friend WithEvents CounterLifeH As MfgControl.AdvancedHMI.Counter
    Friend WithEvents ButtonSaveTimings As System.Windows.Forms.Button
    Friend WithEvents CBMachineAutoOverride As System.Windows.Forms.CheckBox
    Friend WithEvents TabHelp As System.Windows.Forms.TabPage
    Friend WithEvents CounterMachineLifeL As MfgControl.AdvancedHMI.Counter
    Friend WithEvents CounterMachineLifeH As MfgControl.AdvancedHMI.Counter
    Friend WithEvents CounterMachineLife As MfgControl.AdvancedHMI.Counter
    Friend WithEvents CounterMachineDay As MfgControl.AdvancedHMI.Counter
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents LabelRepeat As System.Windows.Forms.Label
    Friend WithEvents NUGateCloseDelay As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents TBGateCloseDelay As System.Windows.Forms.TextBox
    Friend WithEvents CBSettingsAutooverride As System.Windows.Forms.CheckBox
    Friend WithEvents ShBReset As MfgControl.AdvancedHMI.SHButton
    Friend WithEvents ShBResetAll As MfgControl.AdvancedHMI.SHButton
    Friend WithEvents CBSecondScreen As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LbHelpVersion As System.Windows.Forms.Label
    Friend WithEvents CBReverseDisplay As System.Windows.Forms.CheckBox
    Friend WithEvents TBoverridewait As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents NUoverridewate As System.Windows.Forms.NumericUpDown
End Class
