<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewVessel
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
        Dim VesselIDLabel As System.Windows.Forms.Label
        Dim VesselLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewVessel))
        Me.ClientDS = New MfgControl.AdvancedHMI.ClientDS()
        Me.VesselTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VesselTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VesselTBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VesselIDTextBox = New System.Windows.Forms.TextBox()
        Me.VesselTextBox = New System.Windows.Forms.TextBox()
        VesselIDLabel = New System.Windows.Forms.Label()
        VesselLabel = New System.Windows.Forms.Label()
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VesselTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VesselTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VesselTBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'VesselIDLabel
        '
        VesselIDLabel.AutoSize = True
        VesselIDLabel.Location = New System.Drawing.Point(65, 16)
        VesselIDLabel.Name = "VesselIDLabel"
        VesselIDLabel.Size = New System.Drawing.Size(55, 13)
        VesselIDLabel.TabIndex = 1
        VesselIDLabel.Text = "Vessel ID:"
        '
        'VesselLabel
        '
        VesselLabel.AutoSize = True
        VesselLabel.Location = New System.Drawing.Point(79, 47)
        VesselLabel.Name = "VesselLabel"
        VesselLabel.Size = New System.Drawing.Size(41, 13)
        VesselLabel.TabIndex = 3
        VesselLabel.Text = "Vessel:"
        '
        'ClientDS
        '
        Me.ClientDS.DataSetName = "ClientDS"
        Me.ClientDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VesselTBindingSource
        '
        Me.VesselTBindingSource.DataMember = "VesselT"
        Me.VesselTBindingSource.DataSource = Me.ClientDS
        '
        'VesselTBindingNavigator
        '
        Me.VesselTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VesselTBindingNavigator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.VesselTBindingNavigator.BindingSource = Me.VesselTBindingSource
        Me.VesselTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VesselTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VesselTBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.VesselTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VesselTBindingNavigatorSaveItem})
        Me.VesselTBindingNavigator.Location = New System.Drawing.Point(9, 78)
        Me.VesselTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VesselTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VesselTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VesselTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VesselTBindingNavigator.Name = "VesselTBindingNavigator"
        Me.VesselTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VesselTBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.VesselTBindingNavigator.TabIndex = 0
        Me.VesselTBindingNavigator.Text = "BindingNavigator1"
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
        'VesselTBindingNavigatorSaveItem
        '
        Me.VesselTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VesselTBindingNavigatorSaveItem.Image = CType(resources.GetObject("VesselTBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VesselTBindingNavigatorSaveItem.Name = "VesselTBindingNavigatorSaveItem"
        Me.VesselTBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VesselTBindingNavigatorSaveItem.Text = "Save Data"
        '
        'VesselIDTextBox
        '
        Me.VesselIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VesselTBindingSource, "VesselID", True))
        Me.VesselIDTextBox.Enabled = False
        Me.VesselIDTextBox.Location = New System.Drawing.Point(126, 13)
        Me.VesselIDTextBox.Name = "VesselIDTextBox"
        Me.VesselIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VesselIDTextBox.TabIndex = 2
        '
        'VesselTextBox
        '
        Me.VesselTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VesselTBindingSource, "Vessel", True))
        Me.VesselTextBox.Location = New System.Drawing.Point(126, 44)
        Me.VesselTextBox.Name = "VesselTextBox"
        Me.VesselTextBox.Size = New System.Drawing.Size(100, 20)
        Me.VesselTextBox.TabIndex = 4
        '
        'ViewVessel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 103)
        Me.Controls.Add(VesselLabel)
        Me.Controls.Add(Me.VesselTextBox)
        Me.Controls.Add(VesselIDLabel)
        Me.Controls.Add(Me.VesselIDTextBox)
        Me.Controls.Add(Me.VesselTBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewVessel"
        Me.Text = "View/Add Vessels"
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VesselTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VesselTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VesselTBindingNavigator.ResumeLayout(False)
        Me.VesselTBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClientDS As ClientDS
    Friend WithEvents VesselTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VesselTBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents VesselTBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents VesselIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VesselTextBox As System.Windows.Forms.TextBox
End Class
