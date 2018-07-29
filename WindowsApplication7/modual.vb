Public Module modual
    Public MoveThatDone As Integer = 0
    Public Sub movethat(x As IO.FileInfo, y As IO.FileInfo)
        MoveThatDone = 0
        If x.Extension = Nothing Then
            Try
                IO.Directory.Move(x.FullName, y.FullName)
                MoveThatDone = 1
            Catch ex As Exception
                MessageBox.Show("Error occurred: " & ex.Message)
            End Try

        Else
            Try
                IO.File.Move(x.FullName, y.FullName)
                MoveThatDone = 1
            Catch ex As Exception
                MessageBox.Show("Error occurred: " & ex.Message)
            End Try

        End If
    End Sub
    Public CreatDirectorfDone As Integer = 0
    Public Sub creatdirectory(target As String)
        CreatDirectorfDone = 0
        Try
            System.IO.Directory.CreateDirectory(target)
            CreatDirectorfDone = 1
        Catch ex As Exception
            MessageBox.Show("Error occurred: " & ex.Message)
        End Try

    End Sub
    Public Sub RefreshTheFolderName()
        Dim aa As String
        Dim bb As String
        Form2.NumericUpDown1.Value += 1
        If Form2.NumericUpDown1.Value < 10 Then
            aa = "0" + Form2.NumericUpDown1.Value.ToString
        Else
            aa = Form2.NumericUpDown1.Value.ToString
        End If

        If Form2.MdToggle1.Checked = True Then

            If Form2.MdNumeric1.Value < 10 Then
                bb = "S0" + Form2.MdNumeric1.Value.ToString + "E"
            Else
                bb = "S" + Form2.MdNumeric1.Value.ToString + "E"
            End If
            Form2.TextBox3.Text = Form2.TextBox4.Text + bb + aa
        Else
            Form2.TextBox3.Text = Form2.TextBox4.Text + aa
        End If
      


    End Sub
    Public Sub RefreshTheFolderNameWithout()

        Dim aa As String

        Dim bb As String

        If Form2.NumericUpDown1.Value < 10 Then
            aa = "0" + Form2.NumericUpDown1.Value.ToString
        Else
            aa = Form2.NumericUpDown1.Value.ToString
        End If

        If Form2.MdToggle1.Checked = True Then

            If Form2.MdNumeric1.Value < 10 Then
                bb = "S0" + Form2.MdNumeric1.Value.ToString + "E"
            Else
                bb = "S" + Form2.MdNumeric1.Value.ToString + "E"
            End If
            Form2.TextBox3.Text = Form2.TextBox4.Text + bb + aa
        Else
            Form2.TextBox3.Text = Form2.TextBox4.Text + aa
        End If




    End Sub
End Module
