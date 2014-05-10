<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSite
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
        Dim SiteIDLabel As System.Windows.Forms.Label
        Dim SiteLabel As System.Windows.Forms.Label
        Dim ClientIDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewSite))
        Me.SiteTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientDS = New MfgControl.AdvancedHMI.ClientDS()
        Me.SiteTBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.SiteTBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.SiteIDTextBox = New System.Windows.Forms.TextBox()
        Me.SiteTextBox = New System.Windows.Forms.TextBox()
        Me.ClientTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientIDComboBox = New System.Windows.Forms.ComboBox()
        Me.ClientTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        SiteIDLabel = New System.Windows.Forms.Label()
        SiteLabel = New System.Windows.Forms.Label()
        ClientIDLabel = New System.Windows.Forms.Label()
        CType(Me.SiteTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiteTBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SiteTBindingNavigator.SuspendLayout()
        CType(Me.ClientTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SiteIDLabel
        '
        SiteIDLabel.AutoSize = True
        SiteIDLabel.Location = New System.Drawing.Point(62, 17)
        SiteIDLabel.Name = "SiteIDLabel"
        SiteIDLabel.Size = New System.Drawing.Size(42, 13)
        SiteIDLabel.TabIndex = 1
        SiteIDLabel.Text = "Site ID:"
        '
        'SiteLabel
        '
        SiteLabel.AutoSize = True
        SiteLabel.Location = New System.Drawing.Point(76, 43)
        SiteLabel.Name = "SiteLabel"
        SiteLabel.Size = New System.Drawing.Size(28, 13)
        SiteLabel.TabIndex = 3
        SiteLabel.Text = "Site:"
        '
        'ClientIDLabel
        '
        ClientIDLabel.AutoSize = True
        ClientIDLabel.Location = New System.Drawing.Point(54, 69)
        ClientIDLabel.Name = "ClientIDLabel"
        ClientIDLabel.Size = New System.Drawing.Size(50, 13)
        ClientIDLabel.TabIndex = 5
        ClientIDLabel.Text = "Client ID:"
        '
        'SiteTBindingSource
        '
        Me.SiteTBindingSource.DataMember = "SiteT"
        Me.SiteTBindingSource.DataSource = Me.ClientDS
        '
        'ClientDS
        '
        Me.ClientDS.DataSetName = "ClientDS"
        Me.ClientDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SiteTBindingNavigator
        '
        Me.SiteTBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SiteTBindingNavigator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SiteTBindingNavigator.BindingSource = Me.SiteTBindingSource
        Me.SiteTBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SiteTBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SiteTBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.SiteTBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SiteTBindingNavigatorSaveItem})
        Me.SiteTBindingNavigator.Location = New System.Drawing.Point(9, 121)
        Me.SiteTBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SiteTBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SiteTBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SiteTBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SiteTBindingNavigator.Name = "SiteTBindingNavigator"
        Me.SiteTBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SiteTBindingNavigator.Size = New System.Drawing.Size(278, 25)
        Me.SiteTBindingNavigator.TabIndex = 0
        Me.SiteTBindingNavigator.Text = "BindingNavigator1"
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
        'SiteTBindingNavigatorSaveItem
        '
        Me.SiteTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SiteTBindingNavigatorSaveItem.Image = CType(resources.GetObject("SiteTBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SiteTBindingNavigatorSaveItem.Name = "SiteTBindingNavigatorSaveItem"
        Me.SiteTBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SiteTBindingNavigatorSaveItem.Text = "Save Data"
        '
        'SiteIDTextBox
        '
        Me.SiteIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiteTBindingSource, "SiteID", True))
        Me.SiteIDTextBox.Enabled = False
        Me.SiteIDTextBox.Location = New System.Drawing.Point(110, 14)
        Me.SiteIDTextBox.Name = "SiteIDTextBox"
        Me.SiteIDTextBox.Size = New System.Drawing.Size(130, 20)
        Me.SiteIDTextBox.TabIndex = 2
        '
        'SiteTextBox
        '
        Me.SiteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SiteTBindingSource, "Site", True))
        Me.SiteTextBox.Location = New System.Drawing.Point(110, 40)
        Me.SiteTextBox.Name = "SiteTextBox"
        Me.SiteTextBox.Size = New System.Drawing.Size(130, 20)
        Me.SiteTextBox.TabIndex = 4
        '
        'ClientTBindingSource
        '
        Me.ClientTBindingSource.DataMember = "FK_SiteT_ClientT"
        Me.ClientTBindingSource.DataSource = Me.SiteTBindingSource
        '
        'ClientIDComboBox
        '
        Me.ClientIDComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.SiteTBindingSource, "ClientID", True))
        Me.ClientIDComboBox.DataSource = Me.ClientTBindingSource1
        Me.ClientIDComboBox.DisplayMember = "Client"
        Me.ClientIDComboBox.FormattingEnabled = True
        Me.ClientIDComboBox.Location = New System.Drawing.Point(110, 69)
        Me.ClientIDComboBox.Name = "ClientIDComboBox"
        Me.ClientIDComboBox.Size = New System.Drawing.Size(130, 21)
        Me.ClientIDComboBox.TabIndex = 6
        Me.ClientIDComboBox.ValueMember = "ClientID"
        '
        'ClientTBindingSource1
        '
        Me.ClientTBindingSource1.DataMember = "ClientT"
        Me.ClientTBindingSource1.DataSource = Me.ClientDS
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(256, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Add Client"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ViewSite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(364, 155)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ClientIDLabel)
        Me.Controls.Add(Me.ClientIDComboBox)
        Me.Controls.Add(SiteLabel)
        Me.Controls.Add(Me.SiteTextBox)
        Me.Controls.Add(SiteIDLabel)
        Me.Controls.Add(Me.SiteIDTextBox)
        Me.Controls.Add(Me.SiteTBindingNavigator)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewSite"
        Me.Text = "View/Add Sites"
        CType(Me.SiteTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiteTBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SiteTBindingNavigator.ResumeLayout(False)
        Me.SiteTBindingNavigator.PerformLayout()
        CType(Me.ClientTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClientDS As ClientDS
    Friend WithEvents SiteTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SiteTBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents SiteTBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SiteIDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SiteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClientTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientIDComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ClientTBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
