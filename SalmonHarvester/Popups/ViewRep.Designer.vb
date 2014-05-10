<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewRep
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
        Dim RepIDLabel As System.Windows.Forms.Label
        Dim RepLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewRep))
        Me.ClientDS = New MfgControl.AdvancedHMI.ClientDS()
        Me.RepTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RepTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RepTBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RepIDTextBox = New System.Windows.Forms.TextBox()
        Me.RepTextBox = New System.Windows.Forms.TextBox()
        RepIDLabel = New System.Windows.Forms.Label()
        RepLabel = New System.Windows.Forms.Label()
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RepTBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepIDLabel
        '
        RepIDLabel.AutoSize = True
        RepIDLabel.Location = New System.Drawing.Point(76, 19)
        RepIDLabel.Name = "RepIDLabel"
        RepIDLabel.Size = New System.Drawing.Size(44, 13)
        RepIDLabel.TabIndex = 1
        RepIDLabel.Text = "Rep ID:"
        '
        'RepLabel
        '
        RepLabel.AutoSize = True
        RepLabel.Location = New System.Drawing.Point(76, 50)
        RepLabel.Name = "RepLabel"
        RepLabel.Size = New System.Drawing.Size(30, 13)
        RepLabel.TabIndex = 3
        RepLabel.Text = "Rep:"
        '
        'ClientDS
        '
        Me.ClientDS.DataSetName = "ClientDS"
        Me.ClientDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RepTBindingSource
        '
        Me.RepTBindingSource.DataMember = "RepT"
        Me.RepTBindingSource.DataSource = Me.ClientDS
        '
        'RepTBindingNavigator
        '
        Me.RepTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RepTBindingNavigator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RepTBindingNavigator.BindingSource = Me.RepTBindingSource
        Me.RepTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RepTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RepTBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.RepTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RepTBindingNavigatorSaveItem})
        Me.RepTBindingNavigator.Location = New System.Drawing.Point(9, 88)
        Me.RepTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RepTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RepTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RepTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RepTBindingNavigator.Name = "RepTBindingNavigator"
        Me.RepTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RepTBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.RepTBindingNavigator.TabIndex = 0
        Me.RepTBindingNavigator.Text = "BindingNavigator1"
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
        'RepTBindingNavigatorSaveItem
        '
        Me.RepTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RepTBindingNavigatorSaveItem.Image = CType(resources.GetObject("RepTBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RepTBindingNavigatorSaveItem.Name = "RepTBindingNavigatorSaveItem"
        Me.RepTBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RepTBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RepIDTextBox
        '
        Me.RepIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RepTBindingSource, "RepID", True))
        Me.RepIDTextBox.Enabled = False
        Me.RepIDTextBox.Location = New System.Drawing.Point(126, 16)
        Me.RepIDTextBox.Name = "RepIDTextBox"
        Me.RepIDTextBox.ReadOnly = True
        Me.RepIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RepIDTextBox.TabIndex = 2
        '
        'RepTextBox
        '
        Me.RepTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.RepTBindingSource, "Rep", True))
        Me.RepTextBox.Location = New System.Drawing.Point(126, 47)
        Me.RepTextBox.Name = "RepTextBox"
        Me.RepTextBox.Size = New System.Drawing.Size(100, 20)
        Me.RepTextBox.TabIndex = 4
        '
        'ViewRep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 122)
        Me.Controls.Add(RepLabel)
        Me.Controls.Add(Me.RepTextBox)
        Me.Controls.Add(RepIDLabel)
        Me.Controls.Add(Me.RepIDTextBox)
        Me.Controls.Add(Me.RepTBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewRep"
        Me.Text = "View/Add Reps"
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RepTBindingNavigator.ResumeLayout(False)
        Me.RepTBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClientDS As ClientDS
    Friend WithEvents RepTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepTBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RepTBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RepIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RepTextBox As System.Windows.Forms.TextBox
End Class
