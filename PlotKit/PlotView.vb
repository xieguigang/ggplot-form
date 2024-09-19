Imports Microsoft.VisualBasic.Imaging
Imports Microsoft.VisualBasic.Imaging.Drawing2D
Imports PlotPadding = Microsoft.VisualBasic.MIME.Html.CSS.Padding

Public Class PlotView

    Dim m_ggplot As ggplot.ggplot

    Public Property ggplot As ggplot.ggplot
        Get
            Return m_ggplot
        End Get
        Set
            m_ggplot = Value
            Rendering()
        End Set
    End Property

    Public Property PlotPadding As PlotPadding = g.DefaultPadding

    Public Property ScaleFactor As Single = 2

    Private Sub Rendering()
        If Not ggplot Is Nothing Then
            Dim size As New Size(Width * ScaleFactor, Height * ScaleFactor)
            Dim g As Graphics = Me.CreateGraphics
            Dim canvas As New Graphics2D(g, size)
            Dim region As New GraphicsRegion With {
                .Padding = Me.PlotPadding,
                .Size = size
            }

            Call ggplot.Plot(canvas, region)
        End If
    End Sub

    Private Sub PlotView_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Call Rendering()
    End Sub
End Class
