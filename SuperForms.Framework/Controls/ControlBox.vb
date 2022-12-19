

Imports System, System.IO, System.Collections.Generic
Imports System.Drawing, System.Drawing.Drawing2D
Imports System.ComponentModel, System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Imports System.Windows.Forms.TabControl
Imports System.ComponentModel.Design


<ToolboxBitmap(GetType(ControlBox), "ToolboxBitmap.ico")>
Public Class ControlBox
    Inherits ThemeControl154
#Region "Properties"
    Sub New()
        Me.Size = New Point(26, 20)
        Me.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Transparent = True
    End Sub



    Private _GradientColor1 As Color = Color.Transparent
    <Category("Super Forms")>
    Public Property GradientColor1 As Color
        Get
            Return _GradientColor1
        End Get
        Set(ByVal v As Color)
            _GradientColor1 = v
            Invalidate()
        End Set
    End Property


    Private _GradientColor2 As Color = Color.Transparent
    <Category("Super Forms")>
    Public Property GradientColor2 As Color
        Get
            Return _GradientColor2
        End Get
        Set(ByVal v As Color)
            _GradientColor2 = v
            Invalidate()
        End Set
    End Property


    Private _ButtonBackColor As Color = Color.Black
    <Category("Super Forms")>
    Public Property ButtonBackColor As Color
        Get
            Return _ButtonBackColor
        End Get
        Set(ByVal v As Color)
            _ButtonBackColor = v
            BackColor = v
            Invalidate()
        End Set
    End Property

    <Category("Super Forms")>
    Public Overrides Property BackColor As Color
        Get
            Return _ButtonBackColor
        End Get
        Set(ByVal v As Color)
            _ButtonBackColor = v
            Invalidate()
        End Set
    End Property


    Private _ButtonColorDown As Color = Color.Red
    <Category("Super Forms")>
    Public Property ButtonColorDown As Color
        Get
            Return _ButtonColorDown
        End Get
        Set(ByVal v As Color)
            _ButtonColorDown = v
            Invalidate()
        End Set
    End Property


    Private _HeaderHatch As Boolean = False
    <Category("Super Forms")>
    Public Property HeaderHatch As Boolean
        Get
            Return _HeaderHatch
        End Get
        Set(ByVal v As Boolean)
            _HeaderHatch = v
            Invalidate()
        End Set
    End Property

    Private _Shadow As Boolean = False
    <Category("Super Forms")>
    Public Property Shadow As Boolean
        Get
            Return _Shadow
        End Get
        Set(ByVal v As Boolean)
            _Shadow = v
            Invalidate()
        End Set
    End Property

    Private _ShadowButtonMouse As Boolean = False
    <Category("Super Forms")>
    Public Property ShadowButtonMouse As Boolean
        Get
            Return _ShadowButtonMouse
        End Get
        Set(ByVal v As Boolean)
            _ShadowButtonMouse = v
            Invalidate()
        End Set
    End Property

    Private _IconColor As Color = Color.Gainsboro
    <Category("Super Forms")>
    Public Property IconColor As Color
        Get
            Return _IconColor
        End Get
        Set(ByVal v As Color)
            _IconColor = v
            Invalidate()
        End Set
    End Property

    Private _BorderColor As Color = Color.Transparent
    <Category("Super Forms")>
    Public Property BorderColor As Color
        Get
            Return _BorderColor
        End Get
        Set(ByVal v As Color)
            _BorderColor = v
            Invalidate()
        End Set
    End Property


    Private _Border As Boolean = True
    <Category("Super Forms")>
    Public Property Border As Boolean
        Get
            Return _Border
        End Get
        Set(ByVal v As Boolean)
            _Border = v
            Invalidate()
        End Set
    End Property

    Private _StateMinimize As Boolean = False
    <Category("Super Forms")>
    Public Property StateMinimize() As Boolean
        Get
            Return _StateMinimize
        End Get
        Set(ByVal v As Boolean)
            _StateMinimize = v
            Invalidate()
        End Set
    End Property

    Private _StateClose As Boolean = False
    <Category("Super Forms")>
    Public Property StateClose() As Boolean
        Get
            Return _StateClose
        End Get
        Set(ByVal v As Boolean)
            _StateClose = v
            Invalidate()
        End Set
    End Property

    Private _StateMaximize As Boolean = False
    <Category("Super Forms")>
    Public Property StateMaximize() As Boolean
        Get
            Return _StateMaximize
        End Get
        Set(ByVal v As Boolean)
            _StateMaximize = v
            Invalidate()
        End Set
    End Property

    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        MyBase.OnResize(e)
        Me.Size = New Point(26, 20)
    End Sub
    Protected Overrides Sub OnMouseClick(ByVal e As System.Windows.Forms.MouseEventArgs)
        MyBase.OnMouseClick(e)
        If _StateMinimize = True Then
            FindForm.WindowState = FormWindowState.Minimized ' true
            ' Else
            _StateClose = False ' false
            _StateMaximize = False
        End If
        If _StateClose = True Then
            FindForm.Close()
            'Else
            _StateMinimize = False
            _StateMaximize = False
        End If
        If _StateMaximize = True Then
            If FindForm.WindowState <> FormWindowState.Maximized Then FindForm.WindowState = FormWindowState.Maximized Else FindForm.WindowState = FormWindowState.Normal
            _StateClose = False ' false
            _StateMinimize = False
        End If

    End Sub
    Protected Overrides Sub ColorHook()

    End Sub
#End Region
#Region "Color Of Control"
    Protected Overrides Sub PaintHook()
        G.Clear(_ButtonBackColor)
        G.SmoothingMode = SmoothingMode.HighQuality

        If _ShadowButtonMouse Then
            Dim Header As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), _GradientColor1, _GradientColor2, 270S)
            G.FillRectangle(Header, New Rectangle(0, 0, Width - 1, Height - 1))
        End If

        If _HeaderHatch Then
            Dim HeaderHatch As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
            G.FillRectangle(HeaderHatch, New Rectangle(0, 0, Width - 1, Height - 1))
        End If

        If _Shadow Then
            G.FillRectangle(New SolidBrush(Color.FromArgb(8, Color.White)), 0, 0, Width - 1, 10)
            G.DrawLine(New Pen(Color.FromArgb(33, 33, 33)), 0, 9, Width - 1, 10)
        End If


        Select Case State
            Case MouseState.Over
                If _ShadowButtonMouse Then
                    Dim Header1 As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), Color.FromArgb(25, 25, 25), Color.FromArgb(40, 40, 40), 270S)
                    G.FillRectangle(Header1, New Rectangle(0, 0, Width - 1, Height - 1))
                End If

                If _HeaderHatch Then
                    Dim HeaderHatch1 As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
                    G.FillRectangle(HeaderHatch1, New Rectangle(0, 0, Width - 1, Height - 1))
                End If

                If _Shadow Then
                    G.FillRectangle(New SolidBrush(Color.FromArgb(10, Color.White)), 0, 0, Width - 1, 10)
                    G.DrawLine(New Pen(Color.FromArgb(38, 38, 38)), 0, 9, Width - 1, 10)
                End If

            Case MouseState.Down
                Dim Header1 As New LinearGradientBrush(New Rectangle(0, 0, Width - 1, Height - 1), _ButtonColorDown, _ButtonColorDown, 270S)
                G.FillRectangle(Header1, New Rectangle(0, 0, Width - 1, Height - 1))

                If _HeaderHatch Then
                    Dim HeaderHatch1 As New HatchBrush(HatchStyle.Trellis, Color.FromArgb(35, Color.Black), Color.Transparent)
                    G.FillRectangle(HeaderHatch1, New Rectangle(0, 0, Width - 1, Height - 1))
                End If

                If _Shadow Then
                    G.FillRectangle(New SolidBrush(Color.FromArgb(8, Color.White)), 0, 0, Width - 1, 10)
                    G.DrawLine(New Pen(Color.FromArgb(35, 35, 35)), 0, 9, Width - 1, 10)
                End If
        End Select


        If _StateMinimize = True Then
            G.DrawString("0", New Font("Marlett", 8), New SolidBrush(_IconColor), New Point(6, 4))
            _StateClose = False
            _StateMaximize = False
        End If

        If _StateClose = True Then
            G.DrawString("r", New Font("Marlett", 8), New SolidBrush(_IconColor), New Point(6, 4))
            _StateMinimize = False
            _StateMaximize = False
        End If

        If _StateMaximize = True Then
            If FindForm.WindowState <> FormWindowState.Maximized Then G.DrawString("1", New Font("Marlett", 8), New SolidBrush(_IconColor), New Point(6, 4)) Else G.DrawString("2", New Font("Marlett", 8), New SolidBrush(_IconColor), New Point(6, 4))
            _StateClose = False
            _StateMinimize = False
        End If

        If _Border Then DrawBorders(New Pen(_BorderColor))

    End Sub
#End Region
End Class
