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
        Dim ChartFont1 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim ChartFont2 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim ChartFont3 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim ChartFont4 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Grid1 As Guna.Charts.WinForms.Grid = New Guna.Charts.WinForms.Grid()
        Dim Tick1 As Guna.Charts.WinForms.Tick = New Guna.Charts.WinForms.Tick()
        Dim ChartFont5 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Grid2 As Guna.Charts.WinForms.Grid = New Guna.Charts.WinForms.Grid()
        Dim Tick2 As Guna.Charts.WinForms.Tick = New Guna.Charts.WinForms.Tick()
        Dim ChartFont6 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Grid3 As Guna.Charts.WinForms.Grid = New Guna.Charts.WinForms.Grid()
        Dim PointLabel1 As Guna.Charts.WinForms.PointLabel = New Guna.Charts.WinForms.PointLabel()
        Dim ChartFont7 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        Dim Tick3 As Guna.Charts.WinForms.Tick = New Guna.Charts.WinForms.Tick()
        Dim ChartFont8 As Guna.Charts.WinForms.ChartFont = New Guna.Charts.WinForms.ChartFont()
        GunaChart1 = New Guna.Charts.WinForms.GunaChart()
        GunaLineDataset1 = New Guna.Charts.WinForms.GunaLineDataset()
        SuspendLayout()
        ' 
        ' GunaChart1
        ' 
        GunaChart1.Datasets.AddRange(New Guna.Charts.Interfaces.IGunaDataset() {GunaLineDataset1})
        ChartFont1.FontName = "Arial"
        GunaChart1.Legend.LabelFont = ChartFont1
        GunaChart1.Location = New Point(150, 36)
        GunaChart1.Name = "GunaChart1"
        GunaChart1.Size = New Size(524, 325)
        GunaChart1.TabIndex = 0
        ChartFont2.FontName = "Arial"
        ChartFont2.Size = 12
        ChartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold
        GunaChart1.Title.Font = ChartFont2
        ChartFont3.FontName = "Arial"
        GunaChart1.Tooltips.BodyFont = ChartFont3
        ChartFont4.FontName = "Arial"
        ChartFont4.Size = 9
        ChartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold
        GunaChart1.Tooltips.TitleFont = ChartFont4
        GunaChart1.XAxes.GridLines = Grid1
        ChartFont5.FontName = "Arial"
        Tick1.Font = ChartFont5
        GunaChart1.XAxes.Ticks = Tick1
        GunaChart1.YAxes.GridLines = Grid2
        ChartFont6.FontName = "Arial"
        Tick2.Font = ChartFont6
        GunaChart1.YAxes.Ticks = Tick2
        GunaChart1.ZAxes.GridLines = Grid3
        ChartFont7.FontName = "Arial"
        PointLabel1.Font = ChartFont7
        GunaChart1.ZAxes.PointLabels = PointLabel1
        ChartFont8.FontName = "Arial"
        Tick3.Font = ChartFont8
        GunaChart1.ZAxes.Ticks = Tick3
        ' 
        ' GunaLineDataset1
        ' 
        GunaLineDataset1.BorderColor = Color.Empty
        GunaLineDataset1.FillColor = Color.Empty
        GunaLineDataset1.Label = "Line1"
        GunaLineDataset1.TargetChart = GunaChart1
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GunaChart1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
    End Sub

    Friend WithEvents GunaChart1 As Guna.Charts.WinForms.GunaChart
    Friend WithEvents GunaLineDataset1 As Guna.Charts.WinForms.GunaLineDataset
End Class
