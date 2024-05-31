<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        datepicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        nametext = New Guna.UI2.WinForms.Guna2HtmlLabel()
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
        Guna2HtmlLabel1.Location = New Point(133, 57)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(147, 22)
        Guna2HtmlLabel1.TabIndex = 0
        Guna2HtmlLabel1.Text = "BOOK APPOINTMENT"
        ' 
        ' datepicker
        ' 
        datepicker.Checked = True
        datepicker.CustomizableEdges = CustomizableEdges3
        datepicker.Font = New Font("Segoe UI", 9F)
        datepicker.Format = DateTimePickerFormat.Long
        datepicker.Location = New Point(133, 154)
        datepicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        datepicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        datepicker.Name = "datepicker"
        datepicker.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        datepicker.Size = New Size(472, 73)
        datepicker.TabIndex = 1
        datepicker.Value = New Date(2024, 5, 30, 6, 34, 14, 469)
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Location = New Point(133, 85)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(92, 22)
        Guna2HtmlLabel2.TabIndex = 2
        Guna2HtmlLabel2.Text = "SELECT DATE"
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
        Guna2Button1.Location = New Point(250, 265)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(225, 56)
        Guna2Button1.TabIndex = 3
        Guna2Button1.Text = "CONFIRM BOOKING"
        ' 
        ' nametext
        ' 
        nametext.BackColor = Color.Transparent
        nametext.Location = New Point(332, 126)
        nametext.Name = "nametext"
        nametext.Size = New Size(32, 22)
        nametext.TabIndex = 4
        nametext.Text = "nam"
        ' 
        ' Appointment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1047, 423)
        Controls.Add(nametext)
        Controls.Add(Guna2Button1)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(datepicker)
        Controls.Add(Guna2HtmlLabel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Appointment"
        Text = "Appointment"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents datepicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents nametext As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
