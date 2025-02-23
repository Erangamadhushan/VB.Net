<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lbl_last = New System.Windows.Forms.Label()
        Me.lbl_current = New System.Windows.Forms.Label()
        Me.txt_last = New System.Windows.Forms.TextBox()
        Me.txt_current = New System.Windows.Forms.TextBox()
        Me.lbl_unit = New System.Windows.Forms.Label()
        Me.lbl_unit_data = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_total_data = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_last
        '
        Me.lbl_last.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_last.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_last.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_last.Location = New System.Drawing.Point(16, 57)
        Me.lbl_last.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_last.Name = "lbl_last"
        Me.lbl_last.Size = New System.Drawing.Size(304, 44)
        Me.lbl_last.TabIndex = 0
        Me.lbl_last.Text = "Last Reading          :"
        '
        'lbl_current
        '
        Me.lbl_current.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_current.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_current.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_current.Location = New System.Drawing.Point(16, 159)
        Me.lbl_current.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_current.Name = "lbl_current"
        Me.lbl_current.Size = New System.Drawing.Size(304, 42)
        Me.lbl_current.TabIndex = 1
        Me.lbl_current.Text = "Current Reading   :"
        '
        'txt_last
        '
        Me.txt_last.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_last.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_last.Location = New System.Drawing.Point(349, 53)
        Me.txt_last.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_last.Multiline = True
        Me.txt_last.Name = "txt_last"
        Me.txt_last.Size = New System.Drawing.Size(196, 47)
        Me.txt_last.TabIndex = 2
        Me.txt_last.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_current
        '
        Me.txt_current.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_current.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_current.Location = New System.Drawing.Point(349, 159)
        Me.txt_current.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_current.Multiline = True
        Me.txt_current.Name = "txt_current"
        Me.txt_current.Size = New System.Drawing.Size(196, 47)
        Me.txt_current.TabIndex = 3
        Me.txt_current.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbl_unit
        '
        Me.lbl_unit.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unit.ForeColor = System.Drawing.Color.Red
        Me.lbl_unit.Location = New System.Drawing.Point(16, 354)
        Me.lbl_unit.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_unit.Name = "lbl_unit"
        Me.lbl_unit.Size = New System.Drawing.Size(229, 54)
        Me.lbl_unit.TabIndex = 4
        Me.lbl_unit.Text = "Unit"
        '
        'lbl_unit_data
        '
        Me.lbl_unit_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_unit_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_unit_data.ForeColor = System.Drawing.Color.Black
        Me.lbl_unit_data.Location = New System.Drawing.Point(16, 425)
        Me.lbl_unit_data.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_unit_data.Name = "lbl_unit_data"
        Me.lbl_unit_data.Size = New System.Drawing.Size(229, 90)
        Me.lbl_unit_data.TabIndex = 5
        Me.lbl_unit_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_total
        '
        Me.lbl_total.BackColor = System.Drawing.Color.Gainsboro
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Red
        Me.lbl_total.Location = New System.Drawing.Point(303, 354)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(244, 54)
        Me.lbl_total.TabIndex = 6
        Me.lbl_total.Text = "Total Bill Amount"
        '
        'lbl_total_data
        '
        Me.lbl_total_data.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl_total_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_data.ForeColor = System.Drawing.Color.Black
        Me.lbl_total_data.Location = New System.Drawing.Point(303, 425)
        Me.lbl_total_data.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_total_data.Name = "lbl_total_data"
        Me.lbl_total_data.Size = New System.Drawing.Size(244, 90)
        Me.lbl_total_data.TabIndex = 7
        Me.lbl_total_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(792, 556)
        Me.Controls.Add(Me.lbl_total_data)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_unit_data)
        Me.Controls.Add(Me.lbl_unit)
        Me.Controls.Add(Me.txt_current)
        Me.Controls.Add(Me.txt_last)
        Me.Controls.Add(Me.lbl_current)
        Me.Controls.Add(Me.lbl_last)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_last As System.Windows.Forms.Label
    Friend WithEvents lbl_current As System.Windows.Forms.Label
    Friend WithEvents txt_last As System.Windows.Forms.TextBox
    Friend WithEvents txt_current As System.Windows.Forms.TextBox
    Friend WithEvents lbl_unit As System.Windows.Forms.Label
    Friend WithEvents lbl_unit_data As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents lbl_total_data As System.Windows.Forms.Label

End Class
