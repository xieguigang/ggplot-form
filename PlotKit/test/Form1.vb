Imports ggplot
Imports Microsoft.VisualBasic.Math.DataFrame
Imports PlotKit

Public Class Form1

    Dim WithEvents view As New PlotView

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Controls.Add(view)
        view.Dock = DockStyle.Fill

        Dim test As DataFrame = New DataFrame().add("x", New Double() {1, 2, 3, 4, 5}).add("y", New Double() {2, 4, 6, 8, 10})
        Dim plot As ggplot.ggplot = ggplotFunction.ggplot(test, mapping:=aes("x", "y"))

        plot += geom_point()

        view.ggplot = plot
    End Sub
End Class
