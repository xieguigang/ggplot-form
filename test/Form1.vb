Imports Microsoft.VisualBasic.Data.ChartPlots
Imports Microsoft.VisualBasic.Data.ChartPlots.Graphic.Canvas
Imports Microsoft.VisualBasic.Data.ChartPlots.Plots

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim scatter As New SerialData With {.color = Color.Red, .pts = SeqRandom(5).Select(Function(i) New PointData With {.pt = New PointF(Rnd, Rnd)}).ToArray, .pointSize = 5}
        Dim theme As New Theme With {
            .drawLegend = True,
            .XaxisTickFormat = "F4",
            .YaxisTickFormat = "F4",
            .drawGrid = True,
            .background = "white"
        }

        PlotView1.Chart = New Scatter2D(
            data:={scatter},
            theme:=theme,
            scatterReorder:=False,
            fillPie:=False,
            ablines:=Nothing,
            hullConvexList:=Nothing
        ) With {
            .xlabel = "X",
            .ylabel = "Y"
        }
    End Sub
End Class
