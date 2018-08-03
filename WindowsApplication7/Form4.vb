Public Class Form4
    Dim sourcefile As IO.FileInfo
    Dim destfile As IO.FileInfo
    Dim themovedfile(,) As IO.FileInfo

    Private Sub DialogSkin1_DragDrop(sender As Object, e As DragEventArgs) Handles DialogSkin1.DragDrop
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        Dim files As String() = e.Data.GetData(DataFormats.FileDrop)
        Dim movedfile(files.Length - 1, 1) As IO.FileInfo


        For i = 0 To files.Length - 1

            Dim MyFile = New IO.FileInfo(files(i))
            Dim FileNumber As String = thereIsAnyFileNumber(MyFile.Name)

            If FileNumber = Nothing Then
                MsgBox("The file: " & MyFile.Name & vbNewLine & "doesn't have a (file number) like (S01E01)")
            ElseIf FileNumber = "more" Then
                MsgBox("The file: " & MyFile.Name & vbNewLine & "has more than one (file number)")
            Else


                Dim season As String
                Dim episode As String

                season = "S" & FileNumber.Chars(1) & FileNumber.Chars(2)
                episode = "E" & FileNumber.Chars(4) & FileNumber.Chars(5)

                Dim target As String

                If MdTextBox1.Text = "" Then
                    target = MyFile.Directory.ToString & "\" & season & "\" & season & episode
                Else
                    target = MyFile.Directory.ToString & "\" & MdTextBox1.Text & " " & season & "\" & season & episode
                End If

                destfile = New IO.FileInfo(target & "\" & MyFile.Name)



                Dim CreatDirectorfDone As Integer = creatdirectory(target)
                Dim MoveThatDone As Integer = movethat(MyFile, destfile)


                If CreatDirectorfDone = 1 AndAlso MoveThatDone = 1 Then

                    ListBox3.Items.Add(FileNumber)
                    ListBox1.Items.Add("\" & MyFile.Name)

                    If MdTextBox1.Text = "" Then
                        ListBox2.Items.Add("\" & season & "\" & season & episode & "\" & MyFile.Name)
                    Else
                        ListBox2.Items.Add("\" & MdTextBox1.Text & " " & season & "\" & season & episode & "\" & MyFile.Name)
                    End If


                    movedfile(i, 0) = (MyFile)
                    movedfile(i, 1) = (destfile)


                End If
                If MoveThatDone = 0 Then
                    Try
                        System.IO.Directory.Delete(target)
                    Catch exc As Exception
                        MessageBox.Show("Error occurred: " & exc.Message)
                    End Try
                End If

            End If


        Next

        themovedfile = movedfile


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

        If themovedfile Is Nothing Then
            MsgBox("move some files first")
        Else
            Dim undo0 As IO.FileInfo
            Dim undo1 As IO.FileInfo
            ListBox1.Items.Clear()
            ListBox2.Items.Clear()

            For i = 0 To themovedfile.GetLength(0) - 1

                undo0 = themovedfile(i, 0)
                undo1 = themovedfile(i, 1)
                themovedfile(i, 0) = undo1
                themovedfile(i, 1) = undo0


                Dim MoveThatDone As Integer = movethat(themovedfile(i, 0), themovedfile(i, 1))

                If MoveThatDone = 1 Then
                    ListBox1.Items.Add(themovedfile(i, 0))
                    ListBox2.Items.Add(themovedfile(i, 1))
                End If

            Next
        End If
    End Sub

    Private Sub MdButton5_Click(sender As Object, e As EventArgs) Handles MdButton5.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub


End Class