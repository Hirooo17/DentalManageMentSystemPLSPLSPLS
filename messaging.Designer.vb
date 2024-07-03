<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class messaging
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        usert = New TextBox()
        Label2 = New Label()
        Button3 = New Button()
        message2 = New TextBox()
        Panel4 = New Panel()
        Panel3 = New Panel()
        Button1 = New Button()
        Label1 = New Label()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveCaption
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(12, 13)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(590, 333)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SkyBlue
        Panel2.Controls.Add(usert)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(message2)
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(19, 23)
        Panel2.Margin = New Padding(3, 4, 3, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(502, 261)
        Panel2.TabIndex = 0
        ' 
        ' usert
        ' 
        usert.Location = New Point(217, 103)
        usert.Margin = New Padding(3, 4, 3, 4)
        usert.Multiline = True
        usert.Name = "usert"
        usert.Size = New Size(255, 43)
        usert.TabIndex = 10
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(7, 103)
        Label2.Name = "Label2"
        Label2.Size = New Size(211, 37)
        Label2.TabIndex = 2
        Label2.Text = "Enter your name"
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.SkyBlue
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.Location = New Point(377, 201)
        Button3.Margin = New Padding(3, 4, 3, 4)
        Button3.Name = "Button3"
        Button3.Size = New Size(46, 43)
        Button3.TabIndex = 4
        Button3.UseVisualStyleBackColor = False
        ' 
        ' message2
        ' 
        message2.Location = New Point(71, 201)
        message2.Margin = New Padding(3, 4, 3, 4)
        message2.Multiline = True
        message2.Name = "message2"
        message2.Size = New Size(255, 43)
        message2.TabIndex = 8
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.LightSkyBlue
        Panel4.Location = New Point(7, 776)
        Panel4.Margin = New Padding(3, 4, 3, 4)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(463, 53)
        Panel4.TabIndex = 9
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Azure
        Panel3.Controls.Add(Button1)
        Panel3.Controls.Add(Label1)
        Panel3.Location = New Point(3, 4)
        Panel3.Margin = New Padding(3, 4, 3, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(466, 85)
        Panel3.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(3, 7)
        Button1.Margin = New Padding(3, 4, 3, 4)
        Button1.Name = "Button1"
        Button1.Size = New Size(46, 31)
        Button1.TabIndex = 1
        Button1.Text = "<"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(68, 17)
        Label1.Name = "Label1"
        Label1.Size = New Size(352, 74)
        Label1.TabIndex = 0
        Label1.Text = "Send an Email to the Dentist" & vbCrLf & vbCrLf
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' messaging
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(545, 352)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "messaging"
        Text = "messaging"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents message2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents usert As TextBox
    Friend WithEvents Label2 As Label
End Class
