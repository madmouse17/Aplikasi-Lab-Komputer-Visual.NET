Public Class Main_menu

    Private Sub DataDosenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataDosenToolStripMenuItem.Click
        Form1.Show()
    End Sub

    Private Sub JadwalLABToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JadwalLABToolStripMenuItem.Click
        Jadwal.Show()
    End Sub

    Private Sub LAPORANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LAPORANToolStripMenuItem.Click
        Laporan.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub SignUpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SignUpToolStripMenuItem.Click
        sign_up.Show()
    End Sub
End Class