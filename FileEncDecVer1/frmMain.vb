Imports System.IO

Public Class frmMain
    Dim SecurityLayer As New clsSecurityLayer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnFPBrows_Click(sender As Object, e As EventArgs) Handles btnFPBrows.Click
        With OpenFileDialog
            .Title = "Open a text file"
            .Filter = "Text Files (*.txt)|*.txt|All TEXT Files(*.*)|*.*"
            .ShowDialog()
            txtFP.Text = .FileName
        End With
    End Sub

    Private Sub btnOFBrows_Click(sender As Object, e As EventArgs) Handles btnOFBrows.Click
        With SaveFileDialog
            .Title = "Save the processed file as"
            .Filter = "Text Files (*.txt)|*.txt|All TEXT Files(*.*)|*.*"
            .ShowDialog()
            txtOF.Text = .FileName
        End With
    End Sub

    Private Sub btnEnc_Click(sender As Object, e As EventArgs) Handles btnEnc.Click
        Try
            Dim PText As String = My.Computer.FileSystem.ReadAllText(txtFP.Text)
            Dim CText As String = SecurityLayer.doEncrypt(PText)
            My.Computer.FileSystem.WriteAllText(txtOF.Text, CText, True)
            MsgBox("File has been encrypted successfully.", MsgBoxStyle.Information, Me.Text)
            End
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub

    Private Sub btnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click
        Try
            Dim CText As String = My.Computer.FileSystem.ReadAllText(txtFP.Text)
            Dim PText As String = SecurityLayer.doDecrypt(CText)
            My.Computer.FileSystem.WriteAllText(txtOF.Text, PText, True)
            MsgBox("File has been decrypted successfully.", MsgBoxStyle.Information, Me.Text)
            End
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation, Me.Text)
        End Try
    End Sub
End Class
