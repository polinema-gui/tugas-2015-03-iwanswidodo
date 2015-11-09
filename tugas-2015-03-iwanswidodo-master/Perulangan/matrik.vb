Public Class DERET

    Dim cekKolom As Boolean = True


    Private Sub generate_btn_Click(sender As Object, e As EventArgs) Handles generate_btn.Click
        Try
            Dim LineMatriks1 As Integer = Tb_matrik1.Lines.Count
            Dim RowMatriks1 As Integer = Tb_matrik1.Lines.ElementAt(0).Split(" ").Length
            Dim LineMatriks2 As Integer = Tb_matrik1.Lines.Count
            Dim kotakMatriks2 As Integer = Tb_matrik1.Lines.ElementAt(0).Split(" ").Length
            Dim PrintMatriks1(LineMatriks1, RowMatriks1) As Integer
            Dim PrintMatriks2(LineMatriks2, kotakMatriks2) As Integer
            ngecek(LineMatriks1, LineMatriks2, RowMatriks1, kotakMatriks2)
            copyToArray(LineMatriks1, LineMatriks2, RowMatriks1, kotakMatriks2, PrintMatriks1, PrintMatriks2)
            operasinya(PrintMatriks1, PrintMatriks2, LineMatriks1, kotakMatriks2)
        Catch ex As Exception
            MsgBox("Inputan Bukan Angka")
        End Try
    End Sub

    Private Sub copyToArray(ByVal Linenya1 As Integer, Linenya2 As Integer, kolom1 As Integer, kolom2 As Integer, ByRef nilai1(,) As Integer, ByRef nilai2(,) As Integer)
        If (Me.cekKolom) Then
            For Linenya As Integer = 0 To Linenya1 - 1
                For kolom As Integer = 0 To kolom1 - 1
                    nilai1(Linenya, kolom) = Tb_matrik1.Lines.ElementAt(Linenya).Split(" ").ElementAt(kolom)
                    nilai2(Linenya, kolom) = Tb_matrik2.Lines.ElementAt(Linenya).Split(" ").ElementAt(kolom)
                Next
            Next
        End If
    End Sub

    Private Sub ngecek(ByVal Linenya1 As Integer, Linenya2 As Integer, kolom1 As Integer, kolom2 As Integer)
        Dim temp As Boolean = True
        For Linenya = 0 To Linenya1 - 2
            If (Tb_matrik1.Lines.ElementAt(Linenya).Split(" ").Length <> Tb_matrik1.Lines.ElementAt(Linenya + 1).Split(" ").Length) Then
                temp = False
            End If
        Next
        For Linenya = 0 To Linenya2 - 2
            If (Tb_matrik2.Lines.ElementAt(Linenya).Split(" ").Length <> Tb_matrik2.Lines.ElementAt(Linenya + 1).Split(" ").Length) Then
                temp = False
            End If
        Next
        If (temp = False) Then
            Me.cekKolom = False
            Convert.ToInt32(Tb_matrik1.Text)
            Convert.ToInt32(Tb_matrik2.Text)

        ElseIf (Linenya1 = Linenya2 And kolom1 = kolom2) Then
            Me.cekKolom = True
        Else
            Me.cekKolom = False
        End If
    End Sub

    Private Sub operasinya(ByVal matriks1(,) As Integer, matriks2(,) As Integer, batasLinenya As Integer, batasKolom As Integer)
        Dim smdg As String = ""
        If (Me.cekKolom) Then
            Select Case cb_aritmatika.Text
                Case "Tambah"
                    For Linenya As Integer = 0 To batasLinenya - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            smdg &= (matriks1(Linenya, kolom) + matriks2(Linenya, kolom)).ToString & vbTab
                        Next
                        smdg &= vbNewLine
                    Next
                Case "Kurang"
                    For Linenya As Integer = 0 To batasLinenya - 1
                        For kolom As Integer = 0 To batasKolom - 1
                            smdg &= (matriks1(Linenya, kolom) - matriks2(Linenya, kolom)).ToString & vbTab
                        Next
                        smdg &= vbNewLine
                    Next
                Case Else
                    MsgBox("sampean dereng milih operasinipun")
            End Select
            Txb_hasil.Text = smdg
        End If
    End Sub

    Private Sub DERET_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class