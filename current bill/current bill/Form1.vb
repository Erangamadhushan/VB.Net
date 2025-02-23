Public Class Form1
    Dim unit, lr, cr As Single
    Dim total As String
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

 

    Private Sub lbl_unit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_unit.Click
        lr = Val(txt_last.Text)
        cr = Val(txt_current.Text)
        unit = cr - lr
        If unit <= 0 Then
            lbl_unit_data.Text = " Enter Is Wrong"
        Else
            lbl_unit_data.Text = unit
        End If
    End Sub

    Private Sub lbl_total_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_total.Click
        lr = Val(txt_last.Text)
        cr = Val(txt_current.Text)
        unit = cr - lr
        If unit <= 0 Then
            total = " Enter Is Wrong"
        ElseIf unit <= 30 Then
            total = 120 + (8 * unit)
        ElseIf unit <= 60 Then
            total = 240 + (8 * 30) + (10 * (unit - 30))
        ElseIf unit <= 90 Then
            total = 360 + (16 * unit)
        ElseIf unit <= 180 Then
            total = 960 + (16 * 90) + (50 * (unit - 90))
        Else
            total = 1500 + (16 * 90) + (90 * 50) + (75 * (unit - 180))
        End If
        lbl_total_data.Text = total
    End Sub
End Class
