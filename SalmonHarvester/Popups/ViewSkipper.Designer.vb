<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSkipper
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
        Dim SkipperLabel As System.Windows.Forms.Label
        Dim SkipperIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSkipper))
        Me.SkipperTextBox = New System.Windows.Forms.TextBox()
        Me.SkipperTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientDS = New MfgControl.AdvancedHMI.ClientDS()
        Me.SkipperIDTextBox = New System.Windows.Forms.TextBox()
        Me.SkipperTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        SkipperLabel = New System.Windows.Forms.Label()
        SkipperIDLabel = New System.Windows.Forms.Label()
        CType(Me.SkipperTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SkipperTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SkipperTBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'SkipperLabel
        '
        SkipperLabel.AutoSize = True
        SkipperLabel.Location = New System.Drawing.Point(74, 56)
        SkipperLabel.Name = "SkipperLabel"
        SkipperLabel.Size = New System.Drawing.Size(46, 13)
        SkipperLabel.TabIndex = 8
        SkipperLabel.Text = "Skipper:"
        '
        'SkipperIDLabel
        '
        SkipperIDLabel.AutoSize = True
        SkipperIDLabel.Location = New System.Drawing.Point(74, 25)
        SkipperIDLabel.Name = "SkipperIDLabel"
        SkipperIDLabel.Size = New System.Drawing.Size(60, 13)
        SkipperIDLabel.TabIndex = 6
        SkipperIDLabel.Text = "Skipper ID:"
        '
        'SkipperTextBox
        '
        Me.SkipperTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkipperTBindingSource, "Skipper", True))
        Me.SkipperTextBox.Location = New System.Drawing.Point(140, 53)
        Me.SkipperTextBox.Name = "SkipperTextBox"
        Me.SkipperTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SkipperTextBox.TabIndex = 9
        '
        'SkipperTBindingSource
        '
        Me.SkipperTBindingSource.DataMember = "SkipperT"
        Me.SkipperTBindingSource.DataSource = Me.ClientDS
        '
        'ClientDS
        '
        Me.ClientDS.DataSetName = "ClientDS"
        Me.ClientDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SkipperIDTextBox
        '
        Me.SkipperIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SkipperTBindingSource, "SkipperID", True))
        Me.SkipperIDTextBox.Enabled = False
        Me.SkipperIDTextBox.Location = New System.Drawing.Point(140, 22)
        Me.SkipperIDTextBox.Name = "SkipperIDTextBox"
        Me.SkipperIDTextBox.ReadOnly = True
        Me.SkipperIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SkipperIDTextBox.TabIndex = 7
        '
        'SkipperTBindingNavigator
        '
        Me.SkipperTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SkipperTBindingNavigator.BindingSource = Me.SkipperTBindingSource
        Me.SkipperTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SkipperTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SkipperTBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SkipperTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSaveItem})
        Me.SkipperTBindingNavigator.Location = New System.Drawing.Point(0, 93)
        Me.SkipperTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SkipperTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SkipperTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SkipperTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SkipperTBindingNavigator.Name = "SkipperTBindingNavigator"
        Me.SkipperTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SkipperTBindingNavigator.Size = New System.Drawing.Size(313, 25)
        Me.SkipperTBindingNavigator.TabIndex = 5
        Me.SkipperTBindingNavigator.Text = "SkipperTBindingNavigator"
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
        'ViewSkipper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 118)
        Me.Controls.Add(SkipperLabel)
        Me.Controls.Add(Me.SkipperTextBox)
        Me.Controls.Add(SkipperIDLabel)
        Me.Controls.Add(Me.SkipperIDTextBox)
        Me.Controls.Add(Me.SkipperTBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewSkipper"
        Me.Text = "View/Add Skippers"
        CType(Me.SkipperTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SkipperTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SkipperTBindingNavigator.ResumeLayout(False)
        Me.SkipperTBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SkipperTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SkipperIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SkipperTBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SkipperTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientDS As MfgControl.AdvancedHMI.ClientDS
End Class
