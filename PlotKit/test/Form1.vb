Imports ggplot
Imports Microsoft.VisualBasic.Data.Framework
Imports Microsoft.VisualBasic.Drawing
Imports Microsoft.VisualBasic.Imaging.Driver
Imports Microsoft.VisualBasic.Math
Imports Microsoft.VisualBasic.Math.Distributions
Imports Microsoft.VisualBasic.Math.LinearAlgebra
Imports Microsoft.VisualBasic.Math.VBMath
Imports PlotKit

Public Class Form1

    Dim WithEvents view As New PlotView

    Shared Sub New()
#If NET8_0_OR_GREATER Then
        Call SkiaDriver.Register()
#Else
        Call ImageDriver.Register()
#End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Controls.Add(view)
        view.Dock = DockStyle.Fill

        Dim x As Double() = seq(0, 50, by:=0.05).ToArray
        Dim y1 = Gaussian.Gaussian(x, 12000, 15, 1)
        Dim y2 = Gaussian.Gaussian(x, 300, 27, 2)
        Dim y3 = Gaussian.Gaussian(x, 3600, 35, 4)
        Dim noise = Vector.rand(30, 50, x.Length).ToArray

        Dim test As DataFrame = New DataFrame() _
            .add("x", x) _
            .add("y", SIMD.Add.f64_op_add_f64(SIMD.Add.f64_op_add_f64(SIMD.Add.f64_op_add_f64(y1, y2), y3), noise))
        Dim plot As ggplot.ggplot = ggplotFunction.ggplot(test, mapping:=aes("x", "y"), colorSet:="jet")

        plot += geom_point(size:=12, color:="y")

        view.PlotPadding = "padding: 5% 10% 10% 10%;"
        view.ggplot = plot
        test.rownames = x.Select(Function(xi, i) CStr(i + 1)).ToArray

        '  Call test.WriteCsv("./test_signal.csv")
    End Sub

    Private Sub view_SizeChanged(sender As Object, e As EventArgs) Handles view.SizeChanged
        If view.Debug Then
            Me.Text = view.LastRenderCounter.ToString
        End If
    End Sub
End Class
