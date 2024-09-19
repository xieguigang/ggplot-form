Imports Microsoft.VisualBasic.Data.ChartPlots.Graphic
Imports Microsoft.VisualBasic.Imaging
Imports Microsoft.VisualBasic.Imaging.Drawing2D
Imports PlotPadding = Microsoft.VisualBasic.MIME.Html.CSS.Padding

Public Class PlotView

    'Dim _chart As Plot

    'Public Property Chart As Plot
    '    Get
    '        Return _chart
    '    End Get
    '    Set(value As Plot)
    '        _chart = value
    '        Rendering()
    '    End Set
    'End Property

    'Public Property PlotPadding As PlotPadding = g.DefaultPadding

    'Private Sub Rendering()
    '    If Not Chart Is Nothing Then
    '        Dim g As Graphics = Me.CreateGraphics
    '        Dim canvas As New Graphics2D(g, Me.Size)
    '        Dim region As New GraphicsRegion With {
    '            .Padding = Me.PlotPadding,
    '            .Size = Me.Size
    '        }

    '        Call Chart.Plot(canvas, region)
    '    End If
    'End Sub

    'Private Sub PlotView_Resize(sender As Object, e As EventArgs) Handles Me.Resize
    '    Call Rendering()
    'End Sub
End Class
