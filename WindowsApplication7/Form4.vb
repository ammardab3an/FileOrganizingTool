Public Class Form4
    Dim sourcefile As IO.FileInfo
    Dim destfile As IO.FileInfo
    Dim themovedfile(,) As IO.FileInfo
    Dim yy As Integer
    Private Sub DialogSkin1_DragDrop(sender As Object, e As DragEventArgs) Handles DialogSkin1.DragDrop
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        Dim files As String() = e.Data.GetData(DataFormats.FileDrop)
        Dim movedfile(9999, 1) As IO.FileInfo
        Dim x As Integer = -1


        For Each path In files
            x += 1
            Dim MyFile = New IO.FileInfo(path)
            Dim FileName As String = MyFile.Name


            Dim FileNumber As String
            Dim season As String
            Dim a As String
            Dim b As String
            a = "S0"
            b = InStr(MyFile.Name, a)
            TextBox1.Text = MyFile.Name
            If b Then

                TextBox1.Focus()
                TextBox1.SelectionStart = b - 1
                TextBox1.SelectionLength = 6
                FileNumber = TextBox1.SelectedText

                TextBox1.Focus()
                TextBox1.SelectionStart = b - 1
                TextBox1.SelectionLength = 3
                season = TextBox1.SelectedText



                Dim _target As String = MyFile.Directory.ToString & "\" & MdTextBox1.Text & " " & season
                Dim target As String = _target & "\" & FileNumber
                destfile = New IO.FileInfo(target & "\" & MyFile.Name)

                movedfile(x, 0) = (MyFile)
                movedfile(x, 1) = (destfile)
                creatdirectory(_target)
                creatdirectory(target)
                movethat(MyFile, destfile)

                If CreatDirectorfDone = 1 AndAlso MoveThatDone = 1 Then
                    ListBox1.Items.Add("\" & MyFile.Name)
                    ListBox2.Items.Add("\" & MdTextBox1.Text & " " & season & "\" & FileNumber & "\" & MyFile.Name)
                    ListBox3.Items.Add(FileNumber)
                End If
                If MoveThatDone = 0 Then
                    Try
                        System.IO.Directory.Delete(target)
                    Catch exc As Exception
                        MessageBox.Show("Error occurred: " & exc.Message)
                    End Try
                End If

            Else
                MsgBox("The file: " & MyFile.Name & vbNewLine & "doesn't have a number like (S01E01)")
            End If

        Next

        themovedfile = movedfile
        yy = x

    End Sub


    Private Sub DialogSkin1_DragEnter(sender As Object, e As DragEventArgs) Handles DialogSkin1.DragEnter
        Dim file As String = e.Data.GetData(DataFormats.FileDrop)(0)
        Dim MyFile = New IO.FileInfo(file)
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub



    Private Sub MdButton2_Click(sender As Object, e As EventArgs) Handles MdButton2.Click
        Application.Exit()
    End Sub

    Private Sub MdButton1_Click(sender As Object, e As EventArgs) Handles MdButton1.Click
        Form2.Show()
        Form2.Focus()
        Me.Hide()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListBox1.HorizontalScrollbar = True
        ListBox2.HorizontalScrollbar = True

    End Sub

    Private Sub MdButton3_Click(sender As Object, e As EventArgs) Handles MdButton3.Click
        Dim undo0 As IO.FileInfo
        Dim undo1 As IO.FileInfo
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        For i = 0 To yy

            undo1 = themovedfile(i, 1)
            undo0 = themovedfile(i, 0)
            themovedfile(i, 0) = undo1
            themovedfile(i, 1) = undo0

            Try
                movethat(themovedfile(i, 0), themovedfile(i, 1))
                ListBox1.Items.Add(themovedfile(i, 0))
                ListBox2.Items.Add(themovedfile(i, 1))


            Catch ex As Exception

            End Try

        Next
    End Sub

    Private Sub MdButton5_Click(sender As Object, e As EventArgs) Handles MdButton5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class