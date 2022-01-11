Public Class Form1


    Private Sub gen_pass_Click(sender As Object, e As EventArgs) Handles gen_pass.Click
        If indificate.Text <> "" Then
            password.Text = ""
            Dim i As Integer = 0
            Dim str1 As String = ""
            Dim mass(Len(indificate.Text) - 1) As Integer
            Dim j As Integer = 0
            While i < Len(indificate.Text)
                str1 = Mid(indificate.Text, i + 1, 1)
                mass(i) += Format(Asc(str1), "0")
                i += 1
            End While
            Dim b1 As String = bX(1, mass, 97)
            Dim b2 As String = bX(2, mass, 97)
            Dim b3 As String = bX(3, mass, 97)
            Dim b4 As String = bX(4, mass, 65)
            Dim b5 As String = bX(5, mass, 65)
            Dim b6 As String = bnum(Len(indificate.Text), 6)
            Dim b7 As String = bnum(Len(indificate.Text), 7)

            password.Text = b1 + b2 + b3 + b4 + b5 + b6 + b7
        End If

    End Sub


    Public Function bX(number As Integer, mass() As Integer, start As Integer) As String
        Dim i As Integer = 0
        Dim b1 As Integer = 0
        Dim M As Integer = 7
        i = number
        While i < Len(indificate.Text)
            b1 += mass(i)
            i += M
        End While
        b1 = b1 Mod 26
        bX = Chr(b1 + start)
    End Function

    Public Function bnum(number As Integer, type As Integer) As String
        Dim b As Integer
        b = (number ^ 4) Mod 100
        If type = 6 Then
            b = b / 10
        ElseIf type = 7 Then
            b = b Mod 10
        End If
        bnum = b.ToString
    End Function

End Class
