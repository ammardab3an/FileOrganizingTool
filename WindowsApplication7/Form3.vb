Public Class Form3

    Private Sub MdButton2_Click(sender As Object, e As EventArgs) Handles MdButton2.Click
        Me.Close()
        Form2.Focus()
    End Sub

    Private Sub MdButton1_Click(sender As Object, e As EventArgs) Handles MdButton1.Click
        Try
            Process.Start("https://github.com/ammardab3an/FileOrganizingTool/raw/master/WindowsApplication7/bin/Release/FilesOrganizingTool.exe")

        Catch ex As Exception
            MessageBox.Show("Error occurred: " & ex.Message)
        End Try
    End Sub
End Class