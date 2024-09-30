Imports Microsoft.VisualBasic.Imaging
Imports Microsoft.VisualBasic.Imaging.Drawing2D
Imports Microsoft.VisualBasic.Imaging.Driver
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
        If Width <= 0 OrElse Height <= 0 Then
            Return
        End If

        If Not ggplot Is Nothing Then
            Dim size As New Size(Width * ScaleFactor, Height * ScaleFactor)
            Dim g As IGraphics = DriverLoad.CreateGraphicsDevice(size, ggplot.ggplotTheme.background.TranslateColor, driver:=Drivers.GDI)
            Dim region As New GraphicsRegion With {
                .Padding = Me.PlotPadding,
                .Size = size
            }

            Call ggplot.Plot(g, region)
            Call g.Flush()

            ' PictureBox1.BackgroundImage = DirectCast(g, GdiRasterGraphics).ImageResource
            g.Dispose()
        End If
    End Sub

    Private Sub PlotView_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        Call Rendering()
    End Sub
End Class
