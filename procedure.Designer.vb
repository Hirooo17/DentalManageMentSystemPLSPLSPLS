<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class procedure
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
        components = New ComponentModel.Container()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        cbNames = New Guna.UI2.WinForms.Guna2ComboBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        patientlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        timeIn = New Guna.UI2.WinForms.Guna2TextBox()
        timelbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        dateTime = New Guna.UI2.WinForms.Guna2DateTimePicker()
        timetx = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        cmbProcedure = New Guna.UI2.WinForms.Guna2ComboBox()
        Timer1 = New Timer(components)
        Guna2Panel1.SuspendLayout()
        Guna2Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' cbNames
        ' 
        cbNames.BackColor = Color.Transparent
        cbNames.CustomizableEdges = CustomizableEdges11
        cbNames.DrawMode = DrawMode.OwnerDrawFixed
        cbNames.DropDownStyle = ComboBoxStyle.DropDownList
        cbNames.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbNames.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbNames.Font = New Font("Segoe UI", 10F)
        cbNames.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbNames.ItemHeight = 30
        cbNames.Location = New Point(697, 57)
        cbNames.Name = "cbNames"
        cbNames.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        cbNames.Size = New Size(227, 36)
        cbNames.TabIndex = 0
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.Location = New Point(749, 21)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(121, 30)
        Guna2HtmlLabel1.TabIndex = 1
        Guna2HtmlLabel1.Text = "Select Patient"
        ' 
        ' Guna2Panel1
        ' 
        Guna2Panel1.Controls.Add(patientlbl)
        Guna2Panel1.Controls.Add(Guna2HtmlLabel2)
        Guna2Panel1.Controls.Add(cbNames)
        Guna2Panel1.Controls.Add(Guna2HtmlLabel1)
        Guna2Panel1.CustomizableEdges = CustomizableEdges13
        Guna2Panel1.Dock = DockStyle.Top
        Guna2Panel1.FillColor = Color.LightBlue
        Guna2Panel1.Location = New Point(0, 0)
        Guna2Panel1.Name = "Guna2Panel1"
        Guna2Panel1.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        Guna2Panel1.Size = New Size(936, 125)
        Guna2Panel1.TabIndex = 2
        ' 
        ' patientlbl
        ' 
        patientlbl.BackColor = Color.Transparent
        patientlbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        patientlbl.Location = New Point(12, 63)
        patientlbl.Name = "patientlbl"
        patientlbl.Size = New Size(3, 2)
        patientlbl.TabIndex = 3
        patientlbl.Text = Nothing
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.Location = New Point(12, 21)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(134, 30)
        Guna2HtmlLabel2.TabIndex = 2
        Guna2HtmlLabel2.Text = "Current Patient"
        ' 
        ' Guna2Panel2
        ' 
        Guna2Panel2.Controls.Add(Guna2Button1)
        Guna2Panel2.Controls.Add(timeIn)
        Guna2Panel2.Controls.Add(timelbl)
        Guna2Panel2.Controls.Add(dateTime)
        Guna2Panel2.Controls.Add(timetx)
        Guna2Panel2.Controls.Add(Guna2HtmlLabel3)
        Guna2Panel2.Controls.Add(cmbProcedure)
        Guna2Panel2.CustomizableEdges = CustomizableEdges9
        Guna2Panel2.Dock = DockStyle.Fill
        Guna2Panel2.Location = New Point(0, 125)
        Guna2Panel2.Name = "Guna2Panel2"
        Guna2Panel2.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Guna2Panel2.Size = New Size(936, 890)
        Guna2Panel2.TabIndex = 3
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges1
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(699, 797)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(225, 56)
        Guna2Button1.TabIndex = 9
        Guna2Button1.Text = "Done"
        ' 
        ' timeIn
        ' 
        timeIn.Animated = True
        timeIn.BorderRadius = 20
        timeIn.CustomizableEdges = CustomizableEdges3
        timeIn.DefaultText = ""
        timeIn.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        timeIn.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        timeIn.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        timeIn.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        timeIn.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        timeIn.Font = New Font("Segoe UI", 9F)
        timeIn.ForeColor = Color.Black
        timeIn.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        timeIn.Location = New Point(310, 94)
        timeIn.Margin = New Padding(3, 4, 3, 4)
        timeIn.Name = "timeIn"
        timeIn.PasswordChar = ChrW(0)
        timeIn.PlaceholderForeColor = Color.Black
        timeIn.PlaceholderText = ""
        timeIn.ReadOnly = True
        timeIn.SelectedText = ""
        timeIn.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        timeIn.Size = New Size(250, 37)
        timeIn.TabIndex = 8
        ' 
        ' timelbl
        ' 
        timelbl.BackColor = Color.Transparent
        timelbl.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        timelbl.Location = New Point(400, 15)
        timelbl.Name = "timelbl"
        timelbl.Size = New Size(66, 30)
        timelbl.TabIndex = 7
        timelbl.Text = "Time In"
        ' 
        ' dateTime
        ' 
        dateTime.Checked = True
        dateTime.CustomizableEdges = CustomizableEdges5
        dateTime.FillColor = Color.Cyan
        dateTime.Font = New Font("Segoe UI", 9F)
        dateTime.Format = DateTimePickerFormat.Long
        dateTime.Location = New Point(310, 51)
        dateTime.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dateTime.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dateTime.Name = "dateTime"
        dateTime.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        dateTime.Size = New Size(250, 36)
        dateTime.TabIndex = 6
        dateTime.Value = New Date(2024, 6, 21, 18, 16, 36, 182)
        ' 
        ' timetx
        ' 
        timetx.BackColor = Color.Transparent
        timetx.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        timetx.Location = New Point(749, 23)
        timetx.Name = "timetx"
        timetx.Size = New Size(3, 2)
        timetx.TabIndex = 5
        timetx.Text = Nothing
        ' 
        ' Guna2HtmlLabel3
        ' 
        Guna2HtmlLabel3.BackColor = Color.Transparent
        Guna2HtmlLabel3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel3.Location = New Point(50, 15)
        Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Guna2HtmlLabel3.Size = New Size(149, 30)
        Guna2HtmlLabel3.TabIndex = 4
        Guna2HtmlLabel3.Text = "Select Procedure"
        ' 
        ' cmbProcedure
        ' 
        cmbProcedure.BackColor = Color.Transparent
        cmbProcedure.CustomizableEdges = CustomizableEdges7
        cmbProcedure.DrawMode = DrawMode.OwnerDrawFixed
        cmbProcedure.DropDownStyle = ComboBoxStyle.DropDownList
        cmbProcedure.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbProcedure.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cmbProcedure.Font = New Font("Segoe UI", 10F)
        cmbProcedure.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cmbProcedure.ItemHeight = 30
        cmbProcedure.Location = New Point(12, 51)
        cmbProcedure.Name = "cmbProcedure"
        cmbProcedure.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        cmbProcedure.Size = New Size(227, 36)
        cmbProcedure.TabIndex = 0
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' procedure
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(936, 1015)
        Controls.Add(Guna2Panel2)
        Controls.Add(Guna2Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "procedure"
        Text = "procedure"
        Guna2Panel1.ResumeLayout(False)
        Guna2Panel1.PerformLayout()
        Guna2Panel2.ResumeLayout(False)
        Guna2Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents cbNames As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents patientlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cmbProcedure As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents timetx As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timeIn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents timelbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dateTime As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
