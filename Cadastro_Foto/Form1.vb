Imports System.Data.SqlClient
Imports System.IO


Public Class Form1


    Private ImageAUsar As Image

    Private Sub btnEscolher_Click(sender As Object, e As EventArgs) Handles btnEscolher.Click
        Using OFD As New OpenFileDialog With {.Filter = "Image File(*.jpg;*.bmp;*.gif)|*.jpg;*.bmp;*.gif"}
            If OFD.ShowDialog = DialogResult.OK Then
                ImageAUsar = Image.FromFile(OFD.FileName)
                picImagem.Image = ImageAUsar
            End If
        End Using
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click

        Try
            'String de Conexão do banco de dados, deve ser alterado de acordo com a localização do seu servidor, usuario e senha
            Using conex As New SqlConnection("Data Source=(LOCAL);Initial Catalog=Aula_01;User Id=sa;Password=$1206JFOOD1751A")
                Using com As New SqlCommand("Insert into impressoes(Imagem) values (@Imagem)", conex)
                    Using ms As New IO.MemoryStream
                        ImageAUsar.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                        Dim byteArray = ms.ToArray
                        com.Parameters.AddWithValue("@Imagem", byteArray)
                        conex.Open()
                        com.ExecuteNonQuery()
                        MsgBox("Imagem gravada com sucesso!", MsgBoxStyle.Information, "Sucesso")


                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(" Erro ao gravar imagem no banco de dados! " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click
        Dim cod_imagem As Integer = txtCodigo.Text

        Try
            'String de Conexão do banco de dados, deve ser alterado de acordo com a localização do seu servidor, usuario e senha
            Using conex As New SqlConnection("Data Source=(LOCAL);Initial Catalog=Aula_01;User Id=sa;Password=$1206JFOOD1751A")

                Using com As New SqlCommand("Select Imagem from impressoes where ID=@ID", conex)
                    com.Parameters.AddWithValue("@ID", Convert.ToInt32(cod_imagem))
                    conex.Open()
                    Dim tempImagem As Byte() = DirectCast(com.ExecuteScalar(), Byte())
                    If tempImagem Is Nothing Then
                        MessageBox.Show("Imagem não localizada", "Erro")
                        Exit Sub
                    Else
                        Dim strArquivo As String = Convert.ToString(DateTime.Now.ToFileTime())
                        Dim fs As New FileStream(strArquivo, FileMode.CreateNew, FileAccess.Write)
                        fs.Write(tempImagem, 0, tempImagem.Length)
                        fs.Flush()
                        fs.Close()
                        picImagem.Image = Image.FromFile(strArquivo)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(" Erro ao recuperar a imagem no banco de dados! " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        Dim ID As Integer = txtCodigo.Text
        Try
            'String de Conexão do banco de dados, deve ser alterado de acordo com a localização do seu servidor, usuario e senha
            Using conex As New SqlConnection("Data Source=(LOCAL);Initial Catalog=Aula_01;User Id=sa;Password=$1206JFOOD1751A")

                Using com As New SqlCommand("Update impressoes set Imagem=@Imagem where ID=" & ID & "", conex)
                    Using ms As New IO.MemoryStream
                        ImageAUsar.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                        Dim byteArray = ms.ToArray
                        com.Parameters.AddWithValue("@Imagem", byteArray)
                        conex.Open()
                        com.ExecuteNonQuery()
                        MsgBox("Imagem alterada com sucesso!", MsgBoxStyle.Information, "Sucesso")


                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(" Erro ao gravar imagem no banco de dados! " & ex.Message, MsgBoxStyle.Critical, "ERRO")
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
