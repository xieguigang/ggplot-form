Imports PlotKit

Public Class Form1

    Dim WithEvents view As New PlotView

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Controls.Add(view)
        view.Dock = DockStyle.Fill
    End Sub
End Class
