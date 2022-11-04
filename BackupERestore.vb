Imports System.Data.SqlClient

'"Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

Public Class BackupERestore




    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Try
            Dim sqlConnectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

            'perguntar se deseja fazer backup
            'depois perguntar o local no windows para salvar antes savedialog e o nome
            'depois fazer o backup
            Dim sqlConnection As New SqlConnection(SqlConnectionString)
            'escolher o local usando savedialog
            Dim saveFileDialog1 As New SaveFileDialog With {
                .Filter = "Backup Files|*.bak",
                .Title = "Salvar o Arquivo de Backup"
            }
            saveFileDialog1.ShowDialog()
            'verificar se o usuario escolheu um local
            If saveFileDialog1.FileName <> "" Then
                'fazer o backup
                Dim sqlQuery As String = "BACKUP DATABASE PrinceDB TO DISK='" & saveFileDialog1.FileName & "'"
                Dim sqlCommand As New SqlCommand(sqlQuery, sqlConnection)
                sqlConnection.Open()
                sqlCommand.ExecuteNonQuery()
                sqlConnection.Close()
            Else
                'finalizar sub
                Exit Sub
            End If

        Catch ex As Exception

            MsgBox("Erro ao fazer cópia de segurança.Tente novamente salvar em outro local, se o erro persistir contate o administrador do sistema!", MsgBoxStyle.Information, "Erro")

        Finally
            MessageBox.Show("Backup do banco de dados do sistema foi realizado com sucesso!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)


        End Try

    End Sub





    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class