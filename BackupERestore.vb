Imports System.Data.SqlClient

'"Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

Public Class BackupERestore




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Try



            'dados
            Dim sqlConnectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"
            Dim conn As New SqlConnection(sqlConnectionString)
            'abre conexao
            conn.Open()

            'comando para salvar
            Dim cmd As New SqlCommand With {
                .CommandType = CommandType.Text,
                .CommandText = "BACKUP DATABASE PrinceDB TO DISK='D:\PrinceDB.BAK'",
                .Connection = conn
            }
            cmd.ExecuteNonQuery()

            'abrir a barra de progresso
            '  Timer1.Enabled = True
            ' ProgressBar1.Visible = True

            'fecha conexao
            conn.Close()


            'todo certinho
            'cmd.CommandText = "BACKUP DATABASE PrinceDB TO DISK='C:\Users\Betel User\Documents\Rogerio\PRINCEDB\PrinceDB.BAK'"

        Catch ex As Exception

            MsgBox("Erro ao fazer cópia de segurança.Tente novamente, se o erro persistir reinicie o sistema.", MsgBoxStyle.Information, "Erro")

        Finally



            If MsgBox(" Sucesso! Salvo na Unidade D:/ 
Deseja abrir o local salvo?", MsgBoxStyle.YesNo, "Backup Completo!") = MsgBoxResult.Yes Then
                System.Diagnostics.Process.Start("D:/")
            End If

        End Try

    End Sub





    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class