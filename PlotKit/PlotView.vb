Imports System.Drawing
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.Data.ChartPlots.Graphic
Imports Microsoft.VisualBasic.Imaging
Imports Microsoft.VisualBasic.Imaging.Drawing2D
Imports PlotPadding = Microsoft.VisualBasic.MIME.Markup.HTML.CSS.Padding

Public Class PlotView : Inherits Control

    Public Property Chart As Plot
    Public Property PlotPadding As PlotPadding

    Private Sub PlotView_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Not Chart Is Nothing Then
            Dim g As Graphics = Me.CreateGraphics
            Dim canvas As New Graphics2D(g, Me.Size)
            Dim region As New GraphicsRegion With {
                .Padding = Me.PlotPadding,
                .Size = Me.Size
            }

            Call Chart.Plot(canvas, region)
        End If
    End Sub
End Class
