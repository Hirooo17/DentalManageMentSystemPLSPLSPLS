<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class goBack
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        dateTime = New Guna.UI2.WinForms.Guna2DateTimePicker()
        cbNames = New Guna.UI2.WinForms.Guna2ComboBox()
        emailtxt = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Location = New Point(101, 29)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(235, 22)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "When will the patient will go back?"
        ' 
        ' dateTime
        ' 
        dateTime.Checked = True
        dateTime.CustomizableEdges = CustomizableEdges9
        dateTime.Font = New Font("Segoe UI", 9F)
        dateTime.Format = DateTimePickerFormat.Long
        dateTime.Location = New Point(86, 73)
        dateTime.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dateTime.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dateTime.Name = "dateTime"
        dateTime.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        dateTime.Size = New Size(250, 45)
        dateTime.TabIndex = 1
        dateTime.Value = New Date(2024, 6, 21, 19, 35, 20, 486)
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
        cbNames.Location = New Point(562, 29)
        cbNames.Name = "cbNames"
        cbNames.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        cbNames.Size = New Size(304, 36)
        cbNames.TabIndex = 2
        ' 
        ' emailtxt
        ' 
        emailtxt.CustomizableEdges = CustomizableEdges13
        emailtxt.DefaultText = ""
        emailtxt.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        emailtxt.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        emailtxt.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        emailtxt.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        emailtxt.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        emailtxt.Font = New Font("Segoe UI", 9F)
        emailtxt.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        emailtxt.Location = New Point(67, 135)
        emailtxt.Margin = New Padding(3, 4, 3, 4)
        emailtxt.Name = "emailtxt"
        emailtxt.PasswordChar = ChrW(0)
        emailtxt.PlaceholderText = ""
        emailtxt.SelectedText = ""
        emailtxt.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        emailtxt.Size = New Size(286, 60)
        emailtxt.TabIndex = 3
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Location = New Point(623, 73)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(194, 22)
        Guna2HtmlLabel2.TabIndex = 4
        Guna2HtmlLabel2.Text = "if walk-in patient enter email"
        ' 
        ' Guna2Button1
        ' 
        Guna2Button1.CustomizableEdges = CustomizableEdges15
        Guna2Button1.DisabledState.BorderColor = Color.DarkGray
        Guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button1.Font = New Font("Segoe UI", 9F)
        Guna2Button1.ForeColor = Color.White
        Guna2Button1.Location = New Point(612, 135)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        Guna2Button1.Size = New Size(225, 60)
        Guna2Button1.TabIndex = 5
        Guna2Button1.Text = "Confirm"
        ' 
        ' goBack
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(909, 271)
        Controls.Add(Guna2Button1)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(emailtxt)
        Controls.Add(cbNames)
        Controls.Add(dateTime)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "goBack"
        StartPosition = FormStartPosition.CenterParent
        Text = "goBack"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents cbNames As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents dateTime As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents emailtxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
