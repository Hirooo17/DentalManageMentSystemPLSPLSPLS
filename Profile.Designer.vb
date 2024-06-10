<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Profile
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
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Timer1 = New Timer(components)
        picbox = New Guna.UI2.WinForms.Guna2PictureBox()
        btnBrowse = New Guna.UI2.WinForms.Guna2Button()
        OpenFileDialog1 = New OpenFileDialog()
        Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(picbox, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' picbox
        ' 
        picbox.CustomizableEdges = CustomizableEdges5
        picbox.ImageRotate = 0F
        picbox.Location = New Point(235, 106)
        picbox.Name = "picbox"
        picbox.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        picbox.Size = New Size(460, 371)
        picbox.SizeMode = PictureBoxSizeMode.Zoom
        picbox.TabIndex = 0
        picbox.TabStop = False
        ' 
        ' btnBrowse
        ' 
        btnBrowse.CustomizableEdges = CustomizableEdges3
        btnBrowse.DisabledState.BorderColor = Color.DarkGray
        btnBrowse.DisabledState.CustomBorderColor = Color.DarkGray
        btnBrowse.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnBrowse.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnBrowse.Font = New Font("Segoe UI", 9F)
        btnBrowse.ForeColor = Color.White
        btnBrowse.Location = New Point(54, 526)
        btnBrowse.Name = "btnBrowse"
        btnBrowse.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnBrowse.Size = New Size(351, 75)
        btnBrowse.TabIndex = 1
        btnBrowse.Text = "Guna2Button1"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
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
        Guna2Button1.Location = New Point(518, 526)
        Guna2Button1.Name = "Guna2Button1"
        Guna2Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button1.Size = New Size(351, 75)
        Guna2Button1.TabIndex = 2
        Guna2Button1.Text = "savee"
        ' 
        ' Profile
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(942, 711)
        Controls.Add(Guna2Button1)
        Controls.Add(btnBrowse)
        Controls.Add(picbox)
        FormBorderStyle = FormBorderStyle.None
        Name = "Profile"
        Text = "Profile"
        CType(picbox, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Timer1 As Timer
    Friend WithEvents picbox As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents btnBrowse As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
