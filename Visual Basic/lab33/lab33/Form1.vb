Public Class Form1
    Private Sub gen_pass_Click(sender As Object, e As EventArgs) Handles gen_pass.Click
        Dim check As Integer = 1
        If V_box.Text Like "*[A-Za-z]*" Then check = 0
        If V_box.Text Like "*[А-Яа-я,Ё,ё]*" Then check = 0
        If T_box.Text Like "*[A-Za-z]*" Then check = 0
        If T_box.Text Like "*[А-Яа-я,Ё,ё]*" Then check = 0
        If P_box.Text Like "*[A-Za-z]*" Then check = 0
        If P_box.Text Like "*[А-Яа-я,Ё,ё]*" Then check = 0
        If Val(P_box.Text) > 1.0 Then check = 0


        If check = 1 Then
            S.Text = Int((Val(V_box.Text) * Val(T_box.Text)) / Val(P_box.Text))
        Else
            S.Text = 0
            MessageBox.Show("Нужно вводить только числа , без букв или символов     (P>1, такого быть не может)", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        End If
        Dim a_arr As String = ""
        A.Text = 0
        If en_up.Checked <> False Then
            Dim en_up_arr As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
            a_arr = a_arr + en_up_arr
            A.Text += 26
        End If

        If en_dw.Checked <> False Then
            Dim en_dw_arr As String = "abcdefghijklmnopqrstuvwxyz"
            a_arr = a_arr + en_dw_arr
            A.Text += 26
        End If

        If ru_up.Checked <> False Then
            Dim ru_up_arr As String = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ"
            a_arr = a_arr + ru_up_arr
            A.Text += 33
        End If

        If ru_dw.Checked <> False Then
            Dim ru_dw_arr As String = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя"
            a_arr = a_arr + ru_dw_arr
            A.Text += 33
        End If

        If ch.Checked <> False Then
            Dim ch_arr As String = "!""#$%&'()*"
            a_arr = a_arr + ch_arr
            A.Text += 10
        End If

        If number.Checked <> False Then
            Dim number_arr As String = "0123456789"
            a_arr = a_arr + number_arr
            A.Text += 10
        End If

        If A.Text = 0 Then
            MessageBox.Show("Нужно выбрать используемый алфавит ", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        End If

        L.Text = Math.Log(Val(S.Text)) / Math.Log(Val(A.Text))

        Dim check2 As Double = Math.Round(Val(L.Text))

        If L.Text > check2 Then
            L.Text = check2 + 1
        Else
            L.Text = check2
        End If


        Dim i As Integer = 0
        Dim str_password As String = ""
        While i < Val(L.Text)
            str_password += Mid(a_arr, Int(Val(A.Text) * Rnd() + 1), 1)
            i += 1
        End While


        res.Text = str_password

    End Sub

    Private Sub T_box_TextChanged(sender As Object, e As EventArgs) Handles T_box.TextChanged

    End Sub
End Class
