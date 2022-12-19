Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Enum MouseState As Byte
    None = 0
    Over = 1
    Down = 2
    Block = 3
End Enum
Public Structure Bloom

    Private _Name As String
    Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal value As String)
            _Name = value
        End Set
    End Property

    Private _Value As Color
    Property Value() As Color
        Get
            Return _Value
        End Get
        Set(ByVal value As Color)
            _Value = value
        End Set
    End Property

    Sub New(ByVal name As String, ByVal value As Color)
        _Name = name
        _Value = value
    End Sub
End Structure
Public Class Palette
    Public ColHighest As Color
    Public ColHigh As Color
    Public ColMed As Color
    Public ColDim As Color
    Public ColDark As Color
End Class
Public Enum GradientAlignment As Byte
    Vertical = 0
    Horizontal = 1
End Enum
Public Class DrawUtils
    Public Sub FillDualGradPath(ByVal g As Graphics, ByVal Col1 As Color, ByVal Col2 As Color, ByVal rect As Rectangle, ByVal gp As GraphicsPath, ByVal align As GradientAlignment)
        Dim stored As SmoothingMode = g.SmoothingMode
        Dim Blend As New ColorBlend
        g.SmoothingMode = SmoothingMode.HighQuality
        Select Case align
            Case GradientAlignment.Vertical
                Dim PathGradient As New LinearGradientBrush(New Point(rect.X, rect.Y), New Point(rect.X + rect.Width - 1, rect.Y), Color.Black, Color.Black)
                Blend.Positions = {0, 1 / 2, 1}
                Blend.Colors = {Col1, Col2, Col1}
                PathGradient.InterpolationColors = Blend
                g.FillPath(PathGradient, gp)
            Case GradientAlignment.Horizontal
                Dim PathGradient As New LinearGradientBrush(New Point(rect.X, rect.Y), New Point(rect.X, rect.Y + rect.Height), Color.Black, Color.Black)
                Blend.Positions = {0, 1 / 2, 1}
                Blend.Colors = {Col1, Col2, Col1}
                PathGradient.InterpolationColors = Blend
                PathGradient.RotateTransform(0)
                g.FillPath(PathGradient, gp)
        End Select
        g.SmoothingMode = stored
    End Sub
    Public Sub DrawShadowPath(ByVal G As Graphics, ByVal ColBlend As ColorBlend, ByVal Path As GraphicsPath)
        Using ShadowBrush As PathGradientBrush = New PathGradientBrush(Path)
            ShadowBrush.InterpolationColors = ColBlend
            G.FillPath(ShadowBrush, Path)
        End Using
    End Sub
    Public Sub DrawShadowEllipse(ByVal G As Graphics, ByVal col As Color, ByVal Path As Rectangle)
        Dim GPath As New GraphicsPath()
        GPath.AddEllipse(Path)
        Dim PathGradBrush As New PathGradientBrush(GPath)
        With PathGradBrush
            .CenterPoint = New PointF(Path.X + Path.Width / 2, Path.Y + Path.Height / 2)
            .CenterColor = col
            .SurroundColors = New Color() {Color.Transparent}
            .SetBlendTriangularShape(0.1F, 1.0F)
            .FocusScales = New PointF(0.0F, 0.0F)
        End With
        G.FillPath(PathGradBrush, GPath)
    End Sub
    Public Sub DrawTextWithShadow(ByVal G As Graphics, ByVal ContRect As Rectangle, ByVal Text As String, ByVal TFont As Font, ByVal TAlign As HorizontalAlignment, ByVal TColor As Color, ByVal BColor As Color)
        DrawText(G, New Rectangle(ContRect.X + 1, ContRect.Y + 2, ContRect.Width + 1, ContRect.Height + 2), Text, TFont, TAlign, BColor)
        DrawText(G, ContRect, Text, TFont, TAlign, TColor)
    End Sub
    Public Sub DrawText(ByVal G As Graphics, ByVal ContRect As Rectangle, ByVal Text As String, ByVal TFont As Font, ByVal TAlign As HorizontalAlignment, ByVal TColor As Color)
        If String.IsNullOrEmpty(Text) Then Return
        Dim TextSize As Size = G.MeasureString(Text, TFont).ToSize
        Dim CenteredY As Integer = ContRect.Height \ 2 - TextSize.Height \ 2
        Select Case TAlign
            Case HorizontalAlignment.Left
                G.DrawString(Text, TFont, New SolidBrush(TColor), ContRect.X, CenteredY)
            Case HorizontalAlignment.Right
                G.DrawString(Text, TFont, New SolidBrush(TColor), ContRect.X + ContRect.Width - TextSize.Width - 5, CenteredY)
            Case HorizontalAlignment.Center
                G.DrawString(Text, TFont, New SolidBrush(TColor), ContRect.X + 4 + ContRect.Width \ 2 - TextSize.Width \ 2, CenteredY)
        End Select
    End Sub
    Public Function RoundRect(ByVal Rectangle As Rectangle, ByVal Curve As Integer) As GraphicsPath
        Dim Path As New GraphicsPath
        Dim ArcRectangleWidth As Integer = Curve * 2
        With Path
            .AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
            .AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
            .AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 0, 90)
            .AddArc(New Rectangle(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), 90, 90)
            .AddLine(New Point(Rectangle.X, Rectangle.Height - ArcRectangleWidth + Rectangle.Y), New Point(Rectangle.X, Curve + Rectangle.Y))
        End With
        Return Path
    End Function
    Public Function RoundedTopRect(ByVal Rectangle As Rectangle, ByVal Curve As Integer) As GraphicsPath
        Dim Path As GraphicsPath = New GraphicsPath()
        Dim ArcRectangleWidth As Integer = Curve * 2
        With Path
            .AddArc(New Rectangle(Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -180, 90)
            .AddArc(New Rectangle(Rectangle.Width - ArcRectangleWidth + Rectangle.X, Rectangle.Y, ArcRectangleWidth, ArcRectangleWidth), -90, 90)
            .AddLine(New Point(Rectangle.X + Rectangle.Width, Rectangle.Y + ArcRectangleWidth), New Point(Rectangle.X + Rectangle.Width, Rectangle.Y + Rectangle.Height))
            .AddLine(New Point(Rectangle.X, Rectangle.Height + Rectangle.Y), New Point(Rectangle.X, Rectangle.Y + Curve))
        End With
        Return Path
    End Function
End Class
