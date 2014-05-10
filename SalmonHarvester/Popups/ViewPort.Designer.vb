<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewPort
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
        Dim PortLabel As System.Windows.Forms.Label
        Dim PortIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewPort))
        Me.PortTextBox = New System.Windows.Forms.TextBox()
        Me.PortTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientDS = New MfgControl.AdvancedHMI.ClientDS()
        Me.PortIDTextBox = New System.Windows.Forms.TextBox()
        Me.PortTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        PortLabel = New System.Windows.Forms.Label()
        PortIDLabel = New System.Windows.Forms.Label()
        CType(Me.PortTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PortTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PortTBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PortLabel
        '
        PortLabel.AutoSize = True
        PortLabel.Location = New System.Drawing.Point(74, 45)
        PortLabel.Name = "PortLabel"
        PortLabel.Size = New System.Drawing.Size(29, 13)
        PortLabel.TabIndex = 13
        PortLabel.Text = "Port:"
        '
        'PortIDLabel
        '
        PortIDLabel.AutoSize = True
        PortIDLabel.Location = New System.Drawing.Point(74, 14)
        PortIDLabel.Name = "PortIDLabel"
        PortIDLabel.Size = New System.Drawing.Size(43, 13)
        PortIDLabel.TabIndex = 11
        PortIDLabel.Text = "Port ID:"
        '
        'PortTextBox
        '
        Me.PortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PortTBindingSource, "Port", True))
        Me.PortTextBox.Location = New System.Drawing.Point(140, 42)
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PortTextBox.TabIndex = 14
        '
        'PortTBindingSource
        '
        Me.PortTBindingSource.DataMember = "PortT"
        Me.PortTBindingSource.DataSource = Me.ClientDS
        '
        'ClientDS
        '
        Me.ClientDS.DataSetName = "ClientDS"
        Me.ClientDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PortIDTextBox
        '
        Me.PortIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PortTBindingSource, "PortID", True))
        Me.PortIDTextBox.Enabled = False
        Me.PortIDTextBox.Location = New System.Drawing.Point(140, 11)
        Me.PortIDTextBox.Name = "PortIDTextBox"
        Me.PortIDTextBox.ReadOnly = True
        Me.PortIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PortIDTextBox.TabIndex = 12
        '
        'PortTBindingNavigator
        '
        Me.PortTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PortTBindingNavigator.BindingSource = Me.PortTBindingSource
        Me.PortTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PortTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PortTBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PortTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSaveItem})
        Me.PortTBindingNavigator.Location = New System.Drawing.Point(0, 89)
        Me.PortTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PortTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PortTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PortTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PortTBindingNavigator.Name = "PortTBindingNavigator"
        Me.PortTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PortTBindingNavigator.Size = New System.Drawing.Size(343, 25)
        Me.PortTBindingNavigator.TabIndex = 10
        Me.PortTBindingNavigator.Text = "PortTBindingNavigator"
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
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorSaveItem.Image = CType(resources.GetObject("BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorSaveItem.Text = "Save Data"
        '
        'ViewPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(343, 114)
        Me.Controls.Add(PortLabel)
        Me.Controls.Add(Me.PortTextBox)
        Me.Controls.Add(PortIDLabel)
        Me.Controls.Add(Me.PortIDTextBox)
        Me.Controls.Add(Me.PortTBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewPort"
        Me.Text = "View/Add Ports"
        CType(Me.PortTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PortTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PortTBindingNavigator.ResumeLayout(False)
        Me.PortTBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PortTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PortTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientDS As MfgControl.AdvancedHMI.ClientDS
    Friend WithEvents PortIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PortTBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
End Class
