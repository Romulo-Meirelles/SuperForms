<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ControlBox1 = New SuperForms.ControlBox()
        Me.ControlBox2 = New SuperForms.ControlBox()
        Me.ControlBox3 = New SuperForms.ControlBox()
        Me.Adobe1 = New SuperForms.Adobe()
        Me.Adobe1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ControlBox1
        '
        Me.ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBox1.Border = True
        Me.ControlBox1.BorderColor = System.Drawing.Color.Transparent
        Me.ControlBox1.ButtonBackColor = System.Drawing.Color.Transparent
        Me.ControlBox1.ButtonColorDown = System.Drawing.Color.Red
        Me.ControlBox1.Colors = New SuperForms.Bloom(-1) {}
        Me.ControlBox1.Customization = ""
        Me.ControlBox1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ControlBox1.GradientColor1 = System.Drawing.Color.Transparent
        Me.ControlBox1.GradientColor2 = System.Drawing.Color.Transparent
        Me.ControlBox1.HeaderHatch = False
        Me.ControlBox1.IconColor = System.Drawing.Color.Gainsboro
        Me.ControlBox1.Image = Nothing
        Me.ControlBox1.Location = New System.Drawing.Point(353, 12)
        Me.ControlBox1.Name = "ControlBox1"
        Me.ControlBox1.NoRounding = False
        Me.ControlBox1.Shadow = False
        Me.ControlBox1.ShadowButtonMouse = False
        Me.ControlBox1.Size = New System.Drawing.Size(26, 20)
        Me.ControlBox1.StateClose = True
        Me.ControlBox1.StateMaximize = False
        Me.ControlBox1.StateMinimize = False
        Me.ControlBox1.TabIndex = 0
        Me.ControlBox1.Text = "ControlBox1"
        Me.ControlBox1.Transparent = True
        '
        'ControlBox2
        '
        Me.ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBox2.Border = True
        Me.ControlBox2.BorderColor = System.Drawing.Color.Transparent
        Me.ControlBox2.ButtonBackColor = System.Drawing.Color.Transparent
        Me.ControlBox2.ButtonColorDown = System.Drawing.Color.Red
        Me.ControlBox2.Colors = New SuperForms.Bloom(-1) {}
        Me.ControlBox2.Customization = ""
        Me.ControlBox2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ControlBox2.GradientColor1 = System.Drawing.Color.Transparent
        Me.ControlBox2.GradientColor2 = System.Drawing.Color.Transparent
        Me.ControlBox2.HeaderHatch = False
        Me.ControlBox2.IconColor = System.Drawing.Color.Gainsboro
        Me.ControlBox2.Image = Nothing
        Me.ControlBox2.Location = New System.Drawing.Point(328, 12)
        Me.ControlBox2.Name = "ControlBox2"
        Me.ControlBox2.NoRounding = False
        Me.ControlBox2.Shadow = False
        Me.ControlBox2.ShadowButtonMouse = False
        Me.ControlBox2.Size = New System.Drawing.Size(26, 20)
        Me.ControlBox2.StateClose = False
        Me.ControlBox2.StateMaximize = True
        Me.ControlBox2.StateMinimize = False
        Me.ControlBox2.TabIndex = 1
        Me.ControlBox2.Text = "ControlBox2"
        Me.ControlBox2.Transparent = True
        '
        'ControlBox3
        '
        Me.ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ControlBox3.Border = True
        Me.ControlBox3.BorderColor = System.Drawing.Color.Transparent
        Me.ControlBox3.ButtonBackColor = System.Drawing.Color.Transparent
        Me.ControlBox3.ButtonColorDown = System.Drawing.Color.Red
        Me.ControlBox3.Colors = New SuperForms.Bloom(-1) {}
        Me.ControlBox3.Customization = ""
        Me.ControlBox3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.ControlBox3.GradientColor1 = System.Drawing.Color.Transparent
        Me.ControlBox3.GradientColor2 = System.Drawing.Color.Transparent
        Me.ControlBox3.HeaderHatch = False
        Me.ControlBox3.IconColor = System.Drawing.Color.Gainsboro
        Me.ControlBox3.Image = Nothing
        Me.ControlBox3.Location = New System.Drawing.Point(303, 12)
        Me.ControlBox3.Name = "ControlBox3"
        Me.ControlBox3.NoRounding = False
        Me.ControlBox3.Shadow = False
        Me.ControlBox3.ShadowButtonMouse = False
        Me.ControlBox3.Size = New System.Drawing.Size(26, 20)
        Me.ControlBox3.StateClose = False
        Me.ControlBox3.StateMaximize = False
        Me.ControlBox3.StateMinimize = True
        Me.ControlBox3.TabIndex = 2
        Me.ControlBox3.Text = "ControlBox3"
        Me.ControlBox3.Transparent = True
        '
        'Adobe1
        '
        Me.Adobe1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Adobe1.Controls.Add(Me.ControlBox3)
        Me.Adobe1.Controls.Add(Me.ControlBox2)
        Me.Adobe1.Controls.Add(Me.ControlBox1)
        Me.Adobe1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Adobe1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Adobe1.Icon = CType(resources.GetObject("Adobe1.Icon"), System.Drawing.Icon)
        Me.Adobe1.Image = Nothing
        Me.Adobe1.Location = New System.Drawing.Point(0, 0)
        Me.Adobe1.MoveHeight = 19
        Me.Adobe1.Name = "Adobe1"
        Me.Adobe1.Resizable = False
        Me.Adobe1.ShowIcon = True
        Me.Adobe1.Size = New System.Drawing.Size(386, 260)
        Me.Adobe1.StateClose = False
        Me.Adobe1.StateMaximize = False
        Me.Adobe1.StateMinimize = False
        Me.Adobe1.TabIndex = 0
        Me.Adobe1.Text = "Adobe1"
        Me.Adobe1.TextAlignment = SuperForms.Adobe.TextAlign.Left
        Me.Adobe1.TransparencyKey = System.Drawing.Color.Fuchsia
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 260)
        Me.Controls.Add(Me.Adobe1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(305, 150)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.Adobe1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ControlBox1 As SuperForms.ControlBox
    Friend WithEvents ControlBox2 As SuperForms.ControlBox
    Friend WithEvents ControlBox3 As SuperForms.ControlBox
    Friend WithEvents Adobe1 As SuperForms.Adobe
End Class
