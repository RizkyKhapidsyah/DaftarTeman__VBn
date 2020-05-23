Public Class FormTeman

    Private Sub tombolMasukkanNama_Click(sender As Object, e As EventArgs) Handles tombolMasukkanNama.Click
        Const intSUBSKRIPT_MAKS As Integer = 4    'subskript maks
        Dim strNama(intSUBSKRIPT_MAKS) As String 'array menampung nama-nama
        Dim intHitung As Integer ' Loop counter

        'memberitahu user apa yang harus dilakukan
        MessageBox.Show("Saya meminta Anda untuk memasukkan nama " &
        "dari lima teman.")

        'membaca nama dan menyimpannya ke dalam array
        For intHitung = 0 To intSUBSKRIPT_MAKS
            strNama(intHitung) = InputBox("Masukkan nama teman.")
        Next

        'membersihkan kotak list
        listTeman.Items.Clear()

        'menampilkan isi array pada kotak list
        For intHitung = 0 To intSUBSKRIPT_MAKS
            listTeman.Items.Add(strNama(intHitung))
        Next
    End Sub

    Private Sub tombolKeluar_Click(sender As Object, e As EventArgs) Handles tombolKeluar.Click
        'menutup
        Me.Close()
    End Sub
End Class
