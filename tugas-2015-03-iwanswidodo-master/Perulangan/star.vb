Public Class STARS

    Dim hasil As String = ""

    Private Sub btn_proses_Click(sender As Object, e As EventArgs) Handles generate.Click
        Try
            Select Case Cb_gambar.Text
                Case "Segitiga"
                    Segitiga(Convert.ToInt32(Tb_urut.Text))
                Case "Segitiga_Bolong"
                    Segitiga_Bolong(Convert.ToInt32(Tb_urut.Text))
                Case "Segitiga_Kebalik"
                    Segitiga_Kebalik(Convert.ToInt32(Tb_urut.Text))
                Case "Segitiga_Kebalik_Bolong"
                    Segitiga_Kebalik_Bolong(Convert.ToInt32(Tb_urut.Text))
                Case Else
                    tb_correct.Text = "Polanya belum bro"
            End Select
        Catch ex As Exception
            tb_correct.Text = " Itu Bukan Angka bro"
        End Try
    End Sub

    Private Sub Segitiga(batas As Integer)
        Dim batasK1 As Integer = batas
        Dim batasK2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom < batasK1 Or kolom > batasK2) Then
                    Me.hasil &= "  "
                Else
                    Me.hasil &= "*"
                End If
            Next
            batasK1 -= 1
            batasK2 += 1
            Me.hasil &= vbCrLf
        Next
        tb_correct.Text = hasil
        hasil = ""
    End Sub

    Private Sub Segitiga_Bolong(batas As Integer)
        Dim batasK1 As Integer = batas
        Dim batasK2 As Integer = batas
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris < batas) Then
                    If (kolom = batasK1 Or kolom = batasK2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                Else
                    Me.hasil &= "*"
                End If
            Next
            batasK1 -= 1
            batasK2 += 1
            Me.hasil &= vbCrLf
        Next
        tb_correct.Text = hasil
        hasil = ""
    End Sub

    Private Sub Segitiga_Kebalik(batas As Integer)
        Dim batasK1 As Integer = 0
        Dim batasK2 As Integer = batas * 2
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (kolom > batasK1 And kolom < batasK2) Then
                    Me.hasil &= "*"
                Else
                    Me.hasil &= "  "
                End If
            Next
            Me.hasil &= vbCrLf
            batasK1 += 1
            batasK2 -= 1
        Next
        tb_correct.Text = hasil
        Me.hasil = ""
    End Sub

    Private Sub Segitiga_Kebalik_Bolong(batas As Integer)
        Dim batasK1 As Integer = 1
        Dim batasK2 As Integer = batas * 2 - 1
        For baris As Integer = 1 To batas
            For kolom As Integer = 1 To batas * 2 - 1
                If (baris = 1) Then
                    Me.hasil &= "*"
                Else
                    If (kolom = batasK1 Or kolom = batasK2) Then
                        Me.hasil &= "*"
                    Else
                        Me.hasil &= "  "
                    End If
                End If
            Next
            batasK1 += 1
            batasK2 -= 1
            Me.hasil &= vbCrLf
        Next
        tb_correct.Text = hasil
        Me.hasil = ""
    End Sub
    Private Sub STARS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Tb_urut_TextChanged(sender As Object, e As EventArgs) Handles Tb_urut.TextChanged

    End Sub
End Class