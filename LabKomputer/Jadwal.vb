Imports System.Data.Odbc
Public Class Jadwal
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand
    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=lab"
        con.Open()
    End Sub
    Sub simpan()
        koneksi()
        Dim sql As String = "insert into tbjadwal values('" & TextBox1.Text & "','" & ComboBox3.Text & "','" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox2.Text & "','" & DateTimePicker1.Text & "','" & DateTimePicker2.Text & "','" & DateTimePicker3.Text & "')"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub
    Sub tampil()
        DataGridView1.Rows.Clear()
        Try
            koneksi()
            da = New OdbcDataAdapter("select *from tbjadwal order by idjd asc", con)
            dt = New DataTable
            da.Fill(dt)
            For Each row In dt.Rows
                DataGridView1.Rows.Add(row(0), row(1), row(2), row(3), row(4), row(5), row(6), row(7), row(8), row(9))
            Next
            dt.Rows.Clear()
        Catch ex As Exception
            MsgBox("Menampilkan data GAGAL")
        End Try
    End Sub
    Sub dosen()
        cmd = New OdbcCommand("select id from tbdosen", con)
        dr = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        Do While dr.Read
            ComboBox1.Items.Add(dr.Item("id"))
        Loop
    End Sub
    Sub edit()
        koneksi()
        Dim sql As String = "update tbjadwal set idjd='" & TextBox1.Text & "',ruang='" & ComboBox3.Text & "',id='" & ComboBox1.Text & "',dosen='" & TextBox2.Text & "',makul='" & TextBox3.Text & "',kelas='" & TextBox4.Text & "',fakultas='" & ComboBox2.Text & "',tgl='" & DateTimePicker1.Text & "',jawal='" & DateTimePicker2.Text & "',jakir='" & DateTimePicker3.Text & "'where idjd='" & TextBox1.Text & "'"
        cmd = New OdbcCommand(sql, con)
        cmd.ExecuteNonQuery()
        Try
            MsgBox("Menyimpan data BERHASIL", vbInformation, "INFORMASI")
        Catch ex As Exception
            MsgBox("Menyimpan data GAGAL", vbInformation, "PERINGATAN")
        End Try
    End Sub

    Private Sub Jadwal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
        dosen()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        cmd = New OdbcCommand("select * from tbdosen where id='" & ComboBox1.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            TextBox2.Text = dr.Item("nama")
            TextBox3.Text = dr.Item("makul")
        Else
            MsgBox("ID Dosen tidak ada")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        simpan()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        tampil()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ComboBox1.Text = "--pilih--"
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox3.Text = "--pilih--"
        ComboBox2.Text = "--pilih--"
        ComboBox1.Focus()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim a As String = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value
        If a = "" Then
            MsgBox("Data Jadwal yang dihapus belum DIPILIH")
        Else
            If (MessageBox.Show("Anda yakin menghapus data dengan idjadwal=" & a & "...?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK) Then
                koneksi()
                cmd = New OdbcCommand("delete from tbjadwal where idjd='" & a & "'", con)
                cmd.ExecuteNonQuery()
                MsgBox("Menghapus data nilai BERHASIL", vbInformation, "INFORMASI")
                con.Close()
                tampil()
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim index As Integer
        index = e.RowIndex

        Dim selectedrow As DataGridViewRow

        selectedrow = DataGridView1.Rows(index)
        TextBox1.Text = selectedrow.Cells(0).Value.ToString()
        ComboBox3.Text = selectedrow.Cells(1).Value.ToString()
        ComboBox1.Text = selectedrow.Cells(2).Value.ToString()
        TextBox2.Text = selectedrow.Cells(3).Value.ToString()
        TextBox3.Text = selectedrow.Cells(4).Value.ToString()
        TextBox4.Text = selectedrow.Cells(5).Value.ToString()
        ComboBox2.Text = selectedrow.Cells(6).Value.ToString()
        DateTimePicker1.Text = selectedrow.Cells(7).Value.ToString()
        DateTimePicker2.Text = selectedrow.Cells(8).Value.ToString()
        DateTimePicker3.Text = selectedrow.Cells(9).Value.ToString()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        edit()
        tampil()
    End Sub
End Class