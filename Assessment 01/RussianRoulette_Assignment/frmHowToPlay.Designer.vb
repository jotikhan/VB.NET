<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHowToPlay
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
        Me.rtb1 = New System.Windows.Forms.RichTextBox()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'rtb1
        '
        Me.rtb1.Location = New System.Drawing.Point(13, 36)
        Me.rtb1.Name = "rtb1"
        Me.rtb1.Size = New System.Drawing.Size(588, 327)
        Me.rtb1.TabIndex = 0
        Me.rtb1.Text = ""
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(544, 376)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMainMenu.TabIndex = 1
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'frmHowToPlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 411)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.rtb1)
        Me.Name = "frmHowToPlay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "How to play"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rtb1 As System.Windows.Forms.RichTextBox
    Friend WithEvents btnMainMenu As System.Windows.Forms.Button
End Class
