Imports System.Data.SqlClient

Public Class BackupERestore

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        Try
            ' String de conexão
            Dim sqlConnectionString As String = "Data Source=ROGERIO\PRINCE;Initial Catalog=PrinceDB;Persist Security Info=True;User ID=sa;Password=rs755"

            ' Confirmar backup
            Dim result = MessageBox.Show("Deseja realmente realizar o backup do banco de dados?", "Confirmação de Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.No Then
                Exit Sub
            End If

            ' Criar diálogo para salvar o arquivo de backup
            Dim saveFileDialog1 As New SaveFileDialog With {
                .Filter = "Backup Files|*.bak",
                .Title = "Salvar o Arquivo de Backup"
            }

            ' Mostrar o diálogo de salvar
            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                If Not String.IsNullOrEmpty(saveFileDialog1.FileName) Then
                    ' Realizar o backup usando `Using` para garantir o fechamento correto da conexão
                    Using sqlConnection As New SqlConnection(sqlConnectionString)
                        Dim sqlQuery As String = "BACKUP DATABASE PrinceDB TO DISK = @filePath"
                        Using sqlCommand As New SqlCommand(sqlQuery, sqlConnection)
                            sqlCommand.Parameters.AddWithValue("@filePath", saveFileDialog1.FileName)
                            sqlConnection.Open()
                            sqlCommand.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Informar sucesso
                    MessageBox.Show("Backup do banco de dados do sistema foi realizado com sucesso!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    ' Se o caminho estiver vazio
                    MessageBox.Show("Nenhum local foi escolhido para salvar o backup.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                ' Caso o diálogo seja cancelado
                MessageBox.Show("Backup cancelado pelo usuário.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As SqlException
            MessageBox.Show("Erro SQL: " & ex.Message, "Erro SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Erro ao realizar o backup: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

End Class
