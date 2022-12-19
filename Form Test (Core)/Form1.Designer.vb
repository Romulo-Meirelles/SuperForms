<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Avatar1 = New SuperForms.Core.Avatar()
        Me.SuspendLayout()
        '
        'Avatar1
        '
        Me.Avatar1.BackColor = System.Drawing.Color.Black
        Me.Avatar1.BackColor_ = System.Drawing.Color.DeepSkyBlue
        Me.Avatar1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Avatar1.Customization = "/78A//8A//8="
        Me.Avatar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Avatar1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Avatar1.Icon = CType(resources.GetObject("Avatar1.Icon"), System.Drawing.Icon)
        Me.Avatar1.Image = Nothing
        Me.Avatar1.Location = New System.Drawing.Point(0, 0)
        Me.Avatar1.Movable = True
        Me.Avatar1.Name = "Avatar1"
        Me.Avatar1.NoRounding = False
        Me.Avatar1.ShowIcon = True
        Me.Avatar1.Sizable = True
        Me.Avatar1.Size = New System.Drawing.Size(284, 262)
        Me.Avatar1.SmartBounds = True
        Me.Avatar1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.Avatar1.TabIndex = 0
        Me.Avatar1.Text = "Avatar1"
        Me.Avatar1.TextColor = System.Drawing.Color.DeepSkyBlue
        Me.Avatar1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Avatar1.Transparent = False
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Avatar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Adobe1 As SuperForms.Core.Adobe
    Friend WithEvents ControlBox1 As SuperForms.Core.ControlBox
    Friend WithEvents Advantium1 As SuperForms.Core.Advantium
    Friend WithEvents Aryan1 As SuperForms.Core.Aryan
    Friend WithEvents Avatar1 As SuperForms.Core.Avatar
End Class
