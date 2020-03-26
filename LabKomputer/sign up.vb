Imports System.Data.Odbc
Public Class sign_up
    Dim con As OdbcConnection
    Dim dr As OdbcDataReader
    Dim da As OdbcDataAdapter
    Dim ds As DataSet
    Dim dt As DataTable
    Dim cmd As OdbcCommand
    Dim sql As String
    Sub koneksi()
        con = New OdbcConnection
        con.ConnectionString = "dsn=lab"
        con.Open()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub sign_up_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Login.TextBox1.Text = "admin" Then
            If TextBox2.Text = TextBox3.Text Then
            Else
                MsgBox("Password Salah", vbCritical, "PERINGATAN")
                Stop
            End If
            koneksi()
            Dim sql As String = "insert into tblogin values('" & TextBox1.Text & "','" & TextBox2.Text & "')"
            cmd = New OdbcCommand(sql, con)
            cmd.ExecuteNonQuery()
            Try
                MsgBox("Sign UP BERHASIL", vbInformation, "INFORMASI")
            Catch ex As Exception
                MsgBox("Sign Up GAGAL", vbInformation, "PERINGATAN")
            End Try
        Else
            MsgBox("Maaf anda Bukan admin", vbInformation, "PERINGATAN")
        End If
    End Sub


    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox2.PasswordChar = ""
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox3.PasswordChar = ""
    End Sub
End Class