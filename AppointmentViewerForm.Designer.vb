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
        Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(components)
        dataGridA = New Guna.UI2.WinForms.Guna2DataGridView()
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
        dataGridA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.White
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        dataGridA.DefaultCellStyle = DataGridViewCellStyle3
        dataGridA.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dataGridA.Location = New Point(144, 60)
        dataGridA.Name = "dataGridA"
        dataGridA.ReadOnly = True
        dataGridA.RowHeadersVisible = False
        dataGridA.RowHeadersWidth = 51
        dataGridA.Size = New Size(661, 458)
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
        dataGridA.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
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
        ' AppointmentViewerForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(936, 1015)
        Controls.Add(dataGridA)
        FormBorderStyle = FormBorderStyle.None
        Name = "AppointmentViewerForm"
        Text = "AppointmentViewerForm"
        CType(dataGridA, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents dataGridA As Guna.UI2.WinForms.Guna2DataGridView
End Class
