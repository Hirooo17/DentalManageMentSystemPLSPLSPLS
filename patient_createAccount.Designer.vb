<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class patient_createAccount
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Guna2PictureBox3 = New Guna.UI2.WinForms.Guna2PictureBox()
        pword = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        patient = New Guna.UI2.WinForms.Guna2TextBox()
        CType(Guna2PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.Animated = True
        Guna2Button2.CustomizableEdges = CustomizableEdges1
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.FillColor = Color.White
        Guna2Button2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2Button2.ForeColor = Color.Black
        Guna2Button2.Image = My.Resources.Resources.login
        Guna2Button2.Location = New Point(288, 439)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button2.Size = New Size(262, 56)
        Guna2Button2.TabIndex = 15
        Guna2Button2.Text = "Create Account"
        ' 
        ' Guna2PictureBox3
        ' 
        Guna2PictureBox3.CustomizableEdges = CustomizableEdges3
        Guna2PictureBox3.Image = My.Resources.Resources.password
        Guna2PictureBox3.ImageRotate = 0F
        Guna2PictureBox3.Location = New Point(133, 352)
        Guna2PictureBox3.Name = "Guna2PictureBox3"
        Guna2PictureBox3.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        Guna2PictureBox3.Size = New Size(69, 59)
        Guna2PictureBox3.TabIndex = 13
        Guna2PictureBox3.TabStop = False
        ' 
        ' pword
        ' 
        pword.Animated = True
        pword.BorderColor = Color.Black
        pword.BorderRadius = 25
        pword.BorderThickness = 2
        pword.CustomizableEdges = CustomizableEdges5
        pword.DefaultText = ""
        pword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        pword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        pword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        pword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        pword.FillColor = Color.WhiteSmoke
        pword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        pword.Font = New Font("Segoe UI", 9F)
        pword.HoverState.BorderColor = Color.Blue
        pword.Location = New Point(208, 352)
        pword.Margin = New Padding(3, 4, 3, 4)
        pword.Name = "pword"
        pword.PasswordChar = "*"c
        pword.PlaceholderText = ""
        pword.SelectedText = ""
        pword.ShadowDecoration.BorderRadius = 50
        pword.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        pword.Size = New Size(425, 60)
        pword.TabIndex = 12
        ' 
        ' Guna2PictureBox2
        ' 
        Guna2PictureBox2.CustomizableEdges = CustomizableEdges7
        Guna2PictureBox2.Image = My.Resources.Resources.dentist__1_
        Guna2PictureBox2.ImageRotate = 0F
        Guna2PictureBox2.Location = New Point(133, 249)
        Guna2PictureBox2.Name = "Guna2PictureBox2"
        Guna2PictureBox2.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        Guna2PictureBox2.Size = New Size(69, 59)
        Guna2PictureBox2.TabIndex = 11
        Guna2PictureBox2.TabStop = False
        ' 
        ' patient
        ' 
        patient.Animated = True
        patient.BorderColor = Color.Black
        patient.BorderRadius = 25
        patient.BorderThickness = 2
        patient.CustomizableEdges = CustomizableEdges9
        patient.DefaultText = ""
        patient.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        patient.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        patient.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        patient.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        patient.FillColor = Color.WhiteSmoke
        patient.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        patient.Font = New Font("Segoe UI", 9F)
        patient.HoverState.BorderColor = Color.Blue
        patient.Location = New Point(208, 249)
        patient.Margin = New Padding(3, 4, 3, 4)
        patient.Name = "patient"
        patient.PasswordChar = ChrW(0)
        patient.PlaceholderText = ""
        patient.SelectedText = ""
        patient.ShadowDecoration.BorderRadius = 50
        patient.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        patient.Size = New Size(425, 60)
        patient.TabIndex = 10
        ' 
        ' patient_createAccount
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(849, 705)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2PictureBox3)
        Controls.Add(pword)
        Controls.Add(Guna2PictureBox2)
        Controls.Add(patient)
        FormBorderStyle = FormBorderStyle.None
        Name = "patient_createAccount"
        StartPosition = FormStartPosition.CenterParent
        Text = "patient_createAccount"
        CType(Guna2PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(Guna2PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2PictureBox3 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents pword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents patient As Guna.UI2.WinForms.Guna2TextBox
End Class
