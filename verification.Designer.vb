<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class verification
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
        verify = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' verify
        ' 
        verify.CustomizableEdges = CustomizableEdges3
        verify.DefaultText = ""
        verify.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        verify.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        verify.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        verify.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        verify.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        verify.Font = New Font("Segoe UI", 9F)
        verify.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        verify.Location = New Point(210, 91)
        verify.Margin = New Padding(3, 4, 3, 4)
        verify.Name = "verify"
        verify.PasswordChar = ChrW(0)
        verify.PlaceholderText = ""
        verify.SelectedText = ""
        verify.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        verify.Size = New Size(444, 95)
        verify.TabIndex = 0
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
        Guna2Button1.Location = New Point(233, 220)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(404, 84)
        Guna2Button1.TabIndex = 1
        Guna2Button1.Text = "verify"
        ' 
        ' verification
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(887, 428)
        Controls.Add(Guna2Button1)
        Controls.Add(verify)
        FormBorderStyle = FormBorderStyle.None
        Name = "verification"
        Text = "verification"
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents verify As Guna.UI2.WinForms.Guna2TextBox
End Class
