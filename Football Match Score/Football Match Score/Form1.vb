Public Class Form1

    Dim N, a1, a2 As Single
    Dim a, b As Object
    Dim mom As String





    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btn_add_goals.Enabled = False
        btn_s1r.Enabled = False
        btn_fr.Enabled = False
        btn_clear.Enabled = False


    End Sub

    Private Sub btn_enter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_enter.Click

        a = InputBox("Enter Teams Name;", "Teams  1 Name")
        b = InputBox("Enter Teams Name;", "Teams  2 Name")
        If a = "" Then
            MsgBox("Please Enter Your Team 1 Name")
        Else
            lbl_ft.Text = a
            If b = "" Then
                MsgBox("Please Enter Your Team 2 Name")

            Else
                lbl_st.Text = b
                btn_add_goals.Enabled = True
                btn_s1r.Enabled = True
                btn_enter.Enabled = False
            End If
        End If
        lbl_s1t1r.Text = lbl_ft.Text
        lbl_ft1r.Text = lbl_ft.Text
        lbl_s1t2r.Text = lbl_st.Text
        lbl_ft2r.Text = lbl_st.Text

        btn_clear.Enabled = True

    End Sub

    Private Sub btn_add_goals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add_goals.Click
        N = InputBox("Enter Team Number;", "Your Number")
        If N = 1 Then
            lbl_t1.Text = Val(lbl_t1.Text) + 1

        ElseIf N = 2 Then
            lbl_t2.Text = Val(lbl_t2.Text) + 1
        Else
            MsgBox("Enter is Wrong")
        End If

    End Sub

    Private Sub btn_s1r_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_s1r.Click
        lbl_s1t1rd.Text = Val(lbl_t1.Text)
        lbl_s1t2rd.Text = Val(lbl_t2.Text)
        btn_s1r.Enabled = False
        btn_fr.Enabled = True
    End Sub

    Private Sub lbl_t2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_t2.Click

    End Sub

    Private Sub btn_fr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fr.Click
        lbl_ft1rd.Text = Val(lbl_t1.Text)
        lbl_ft2rd.Text = Val(lbl_t2.Text)
        btn_fr.Enabled = False

        a1 = lbl_ft1rd.Text
        a2 = lbl_ft2rd.Text
        If a1 > a2 Then
            lbl_winnerd.Text = lbl_ft.Text
            mom = InputBox("Who is a Player of the Match;", " Man of the Match")
            lbl_momd.Text = mom
            MsgBox("Congradulation {lbl_f1.text}")

        ElseIf a2 > a1 Then
            lbl_winnerd.Text = lbl_st.Text
            mom = InputBox("Who is a Player of the Match;", "Man of the Match")
            lbl_momd.Text = mom
            MsgBox("Congradulation India")
        Else
            lbl_winnerd.Text = "Match draw"
            lbl_momd.Text = "No One"
        End If
        btn_add_goals.Enabled = False
        

    End Sub

    Private Sub lbl_ft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_ft.Click

    End Sub

    Private Sub btn_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_clear.Click
        lbl_winnerd.Text = ""
        lbl_momd.Text = ""
        lbl_ft1rd.Text = ""
        lbl_ft2rd.Text = ""
        lbl_s1t1rd.Text = ""
        lbl_s1t2rd.Text = ""
        lbl_t1.Text = ""
        lbl_t2.Text = ""
        lbl_ft.Text = ""
        lbl_st.Text = ""
        btn_enter.Enabled = True

    End Sub
End Class
