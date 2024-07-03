<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AppointmentViewerForm
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        dataGridA = New Guna.UI2.WinForms.Guna2DataGridView()
        cbStatus = New Guna.UI2.WinForms.Guna2ComboBox()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        cBId = New Guna.UI2.WinForms.Guna2ComboBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        patientTxt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(dataGridA, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2BorderlessForm1
        ' 
        Guna2BorderlessForm1.ContainerControl = Me
        Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Guna2BorderlessForm1.TransparentWhileDrag = True
        ' 
        ' dataGridA
        ' 
        dataGridA.AllowUserToAddRows = False
        dataGridA.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dataGridA.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dataGridA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dataGridA.ColumnHeadersHeight = 22
        dataGridA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dataGridA.DefaultCellStyle = DataGridViewCellStyle3
        dataGridA.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dataGridA.Location = New Point(51, 51)
        dataGridA.Name = "dataGridA"
        dataGridA.ReadOnly = True
        dataGridA.RowHeadersVisible = False
        dataGridA.RowHeadersWidth = 51
        dataGridA.Size = New Size(807, 458)
        dataGridA.TabIndex = 0
        dataGridA.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dataGridA.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dataGridA.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dataGridA.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dataGridA.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dataGridA.ThemeStyle.BackColor = Color.White
        dataGridA.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dataGridA.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dataGridA.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dataGridA.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
        dataGridA.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dataGridA.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        dataGridA.ThemeStyle.HeaderStyle.Height = 22
        dataGridA.ThemeStyle.ReadOnly = True
        dataGridA.ThemeStyle.RowsStyle.BackColor = Color.White
        dataGridA.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dataGridA.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dataGridA.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dataGridA.ThemeStyle.RowsStyle.Height = 29
        dataGridA.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dataGridA.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' cbStatus
        ' 
        cbStatus.BackColor = Color.Transparent
        cbStatus.CustomizableEdges = CustomizableEdges5
        cbStatus.DrawMode = DrawMode.OwnerDrawFixed
        cbStatus.DropDownStyle = ComboBoxStyle.DropDownList
        cbStatus.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbStatus.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cbStatus.Font = New Font("Segoe UI", 10F)
        cbStatus.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cbStatus.ItemHeight = 30
        cbStatus.Items.AddRange(New Object() {"Cancelled", "Coming Back", "Completed", "No Show"})
        cbStatus.Location = New Point(51, 661)
        cbStatus.Name = "cbStatus"
        cbStatus.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        cbStatus.Size = New Size(297, 36)
        cbStatus.TabIndex = 1
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.Location = New Point(51, 541)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(146, 33)
        Guna2HtmlLabel1.TabIndex = 2
        Guna2HtmlLabel1.Text = "Edit Status for"
        ' 
        ' cBId
        ' 
        cBId.BackColor = Color.Transparent
        cBId.CustomizableEdges = CustomizableEdges3
        cBId.DrawMode = DrawMode.OwnerDrawFixed
        cBId.DropDownStyle = ComboBoxStyle.DropDownList
        cBId.FocusedColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cBId.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        cBId.Font = New Font("Segoe UI", 10F)
        cBId.ForeColor = Color.FromArgb(CByte(68), CByte(88), CByte(112))
        cBId.ItemHeight = 30
        cBId.Location = New Point(51, 580)
        cBId.Name = "cBId"
        cBId.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        cBId.Size = New Size(297, 36)
        cBId.TabIndex = 5
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.Location = New Point(51, 622)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(133, 33)
        Guna2HtmlLabel2.TabIndex = 6
        Guna2HtmlLabel2.Text = "Select Status"
        ' 
        ' Guna2Button2
        ' 
        Guna2Button2.CustomizableEdges = CustomizableEdges1
        Guna2Button2.DisabledState.BorderColor = Color.DarkGray
        Guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray
        Guna2Button2.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Guna2Button2.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Guna2Button2.Font = New Font("Segoe UI", 9F)
        Guna2Button2.ForeColor = Color.White
        Guna2Button2.Location = New Point(51, 703)
        Guna2Button2.Name = "Guna2Button2"
        Guna2Button2.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Guna2Button2.Size = New Size(225, 56)
        Guna2Button2.TabIndex = 7
        Guna2Button2.Text = "Confirm"
        ' 
        ' patientTxt
        ' 
        patientTxt.BackColor = Color.Transparent
        patientTxt.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        patientTxt.Location = New Point(203, 541)
        patientTxt.Name = "patientTxt"
        patientTxt.Size = New Size(3, 2)
        patientTxt.TabIndex = 8
        patientTxt.Text = Nothing
        ' 
        ' AppointmentViewerForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(936, 1015)
        Controls.Add(patientTxt)
        Controls.Add(Guna2Button2)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(cBId)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(cbStatus)
        Controls.Add(dataGridA)
        FormBorderStyle = FormBorderStyle.None
        Name = "AppointmentViewerForm"
        Text = "AppointmentViewerForm"
        CType(dataGridA, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents dataGridA As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents cbStatus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cBId As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents patientTxt As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
