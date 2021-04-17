<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PlotView1 = New PlotKit.PlotView()
        Me.SuspendLayout()
        '
        'PlotView1
        '
        Me.PlotView1.Chart = Nothing
        Me.PlotView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlotView1.Location = New System.Drawing.Point(0, 0)
        Me.PlotView1.Name = "PlotView1"
        Me.PlotView1.Size = New System.Drawing.Size(851, 443)
        Me.PlotView1.TabIndex = 0
        Me.PlotView1.Text = "PlotView1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 443)
        Me.Controls.Add(Me.PlotView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PlotView1 As PlotKit.PlotView
End Class
