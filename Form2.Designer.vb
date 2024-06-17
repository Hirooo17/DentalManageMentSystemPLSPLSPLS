<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        GunaLineDataset1 = New Guna.Charts.WinForms.GunaLineDataset()
        SuspendLayout()
        ' 
        ' GunaLineDataset1
        ' 
        GunaLineDataset1.BorderColor = Color.Empty
        GunaLineDataset1.FillColor = Color.Empty
        GunaLineDataset1.Label = "Line1"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
    End Sub
    Friend WithEvents GunaLineDataset1 As Guna.Charts.WinForms.GunaLineDataset
End Class
