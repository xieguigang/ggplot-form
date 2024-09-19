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
            Dim g As Graphics2D = size.CreateGDIDevice(filled:=ggplot.ggplotTheme.background.TranslateColor)
            Dim region As New GraphicsRegion With {
                .Padding = Me.PlotPadding,
                .Size = size
            }

            Call ggplot.Plot(g, region)
            Call g.Flush()

            PictureBox1.BackgroundImage = g.ImageResource
            g.Dispose()
        End If
    End Sub

    Private Sub PlotView_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Call Rendering()
    End Sub
End Class
