Imports System.IO
Imports System.Runtime.CompilerServices
Imports Microsoft.VisualBasic.Imaging
Imports Microsoft.VisualBasic.Imaging.Driver

Module Interop

    <Extension>
    Public Function GetGdiPlusRasterImageResource(canvas As GdiRasterGraphics) As System.Drawing.Image
        Using ms As New MemoryStream
            Call canvas.ImageResource.Save(ms, ImageFormats.Png)
            Call ms.Flush()
            Call ms.Seek(Scan0, SeekOrigin.Begin)

            Return System.Drawing.Image.FromStream(ms)
        End Using
    End Function
End Module
