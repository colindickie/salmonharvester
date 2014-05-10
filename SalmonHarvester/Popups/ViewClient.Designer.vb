<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewClient
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
        Dim ClientIDLabel As System.Windows.Forms.Label
        Dim ClientLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewClient))
        Me.ClientDS = New MfgControl.AdvancedHMI.ClientDS()
        Me.ClientTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ClientTBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ClientIDTextBox = New System.Windows.Forms.TextBox()
        Me.ClientTextBox = New System.Windows.Forms.TextBox()
        ClientIDLabel = New System.Windows.Forms.Label()
        ClientLabel = New System.Windows.Forms.Label()
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientTBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClientIDLabel
        '
        ClientIDLabel.AutoSize = True
        ClientIDLabel.Location = New System.Drawing.Point(65, 15)
        ClientIDLabel.Name = "ClientIDLabel"
        ClientIDLabel.Size = New System.Drawing.Size(50, 13)
        ClientIDLabel.TabIndex = 1
        ClientIDLabel.Text = "Client ID:"
        '
        'ClientLabel
        '
        ClientLabel.AutoSize = True
        ClientLabel.Location = New System.Drawing.Point(79, 41)
        ClientLabel.Name = "ClientLabel"
        ClientLabel.Size = New System.Drawing.Size(36, 13)
        ClientLabel.TabIndex = 3
        ClientLabel.Text = "Client:"
        '
        'ClientDS
        '
        Me.ClientDS.DataSetName = "ClientDS"
        Me.ClientDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientTBindingSource
        '
        Me.ClientTBindingSource.DataMember = "ClientT"
        Me.ClientTBindingSource.DataSource = Me.ClientDS
        '
        'ClientTBindingNavigator
        '
        Me.ClientTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ClientTBindingNavigator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClientTBindingNavigator.BindingSource = Me.ClientTBindingSource
        Me.ClientTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ClientTBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ClientTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ClientTBindingNavigatorSaveItem})
        Me.ClientTBindingNavigator.Location = New System.Drawing.Point(9, 70)
        Me.ClientTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientTBindingNavigator.Name = "ClientTBindingNavigator"
        Me.ClientTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientTBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.ClientTBindingNavigator.TabIndex = 0
        Me.ClientTBindingNavigator.Text = "BindingNavigator1"
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
        'ClientTBindingNavigatorSaveItem
        '
        Me.ClientTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClientTBindingNavigatorSaveItem.Image = CType(resources.GetObject("ClientTBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ClientTBindingNavigatorSaveItem.Name = "ClientTBindingNavigatorSaveItem"
        Me.ClientTBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ClientTBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ClientIDTextBox
        '
        Me.ClientIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientTBindingSource, "ClientID", True))
        Me.ClientIDTextBox.Enabled = False
        Me.ClientIDTextBox.Location = New System.Drawing.Point(121, 12)
        Me.ClientIDTextBox.Name = "ClientIDTextBox"
        Me.ClientIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClientIDTextBox.TabIndex = 2
        '
        'ClientTextBox
        '
        Me.ClientTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientTBindingSource, "Client", True))
        Me.ClientTextBox.Location = New System.Drawing.Point(121, 38)
        Me.ClientTextBox.Name = "ClientTextBox"
        Me.ClientTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ClientTextBox.TabIndex = 4
        '
        'ViewClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 95)
        Me.Controls.Add(ClientLabel)
        Me.Controls.Add(Me.ClientTextBox)
        Me.Controls.Add(ClientIDLabel)
        Me.Controls.Add(Me.ClientIDTextBox)
        Me.Controls.Add(Me.ClientTBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewClient"
        Me.Text = "View/Add Clients"
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientTBindingNavigator.ResumeLayout(False)
        Me.ClientTBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClientDS As ClientDS
    Friend WithEvents ClientTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientTBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents ClientTBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClientIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClientTextBox As System.Windows.Forms.TextBox
End Class
