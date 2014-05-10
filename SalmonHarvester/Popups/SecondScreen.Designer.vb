<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SecondScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SecondScreen))
        Me.LabelSecondTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LabelSecondTotal
        '
        Me.LabelSecondTotal.Font = New System.Drawing.Font("Let's go Digital", 240.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSecondTotal.ForeColor = System.Drawing.Color.Red
        Me.LabelSecondTotal.Location = New System.Drawing.Point(0, 350)
        Me.LabelSecondTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.LabelSecondTotal.MinimumSize = New System.Drawing.Size(1006, 316)
        Me.LabelSecondTotal.Name = "LabelSecondTotal"
        Me.LabelSecondTotal.Size = New System.Drawing.Size(1006, 316)
        Me.LabelSecondTotal.TabIndex = 1
        Me.LabelSecondTotal.Text = "99,000"
        Me.LabelSecondTotal.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SecondScreen_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1584, 798)
        Me.Controls.Add(Me.LabelSecondTotal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SecondScreen_new"
        Me.Text = "SecondScreen"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelSecondTotal As System.Windows.Forms.Label
End Class
