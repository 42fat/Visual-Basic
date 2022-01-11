Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        KSumma.Text = KSummX(a.Text)
        KSummb.Text = KSummX(b.Text)
        KSummc.Text = KSummX(c.Text)
        KSummd.Text = KSummX(d.Text)
        guma.Text = SummKodBukvOtkrX(a.Text)
        gumb.Text = SummKodBukvOtkrX(b.Text)
        gumc.Text = SummKodBukvOtkrX(c.Text)
        gumd.Text = SummKodBukvOtkrX(d.Text)
    End Sub

    Function KSummX(str As String) As String
        Dim MaxVal As Integer = 255
        Dim K As Integer = 0
        Dim i As Integer = 0
        Dim tmp_str As String = ""
        While i < str.Length
            tmp_str = Mid(str, i + 1, 1)
            K += Asc(tmp_str)
            i += 1
        End While

        If K > MaxVal Then
            K = K Mod (MaxVal + 1)
        End If
        KSummX = K
    End Function

    Function SummKodBukvOtkrX(str As String) As String
        Dim MaxVal As Integer = 255
        Dim K As Integer = 0
        Dim tmp As Integer = 0
        Dim i As Integer = 0
        Dim tmp_str As String = ""
        Dim a As Integer = 17
        Dim b As Integer = 11
        Dim c As Integer = MaxVal + 1
        Dim prevt As Integer = 172
        While i < str.Length
            tmp_str = Mid(str, i + 1, 1)
            tmp = Int(tmp_str)
            prevt = (a * prevt + b) Mod c
            K += tmp Xor prevt
            i += 1
        End While

        If K > MaxVal Then
            K = K Mod (MaxVal + 1)
        End If

        SummKodBukvOtkrX = K
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles a.Click

    End Sub
End Class
