﻿Public Class Form2

    Dim sourcefile As IO.FileInfo
    Dim destfile As IO.FileInfo
    Dim themovedfile(,) As IO.FileInfo
    Dim yy As Integer




    Private Sub DialogSkin1_DragDrop(sender As Object, e As DragEventArgs) Handles DialogSkin1.DragDrop

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim files As String() = e.Data.GetData(DataFormats.FileDrop)
        Dim movedfile(9999, 1) As IO.FileInfo
        Dim x As Integer = -1

        For Each path In files

            x += 1
            Dim MyFile = New IO.FileInfo(path)
            Dim target As String = MyFile.Directory.ToString & "\" & TextBox3.Text
            destfile = New IO.FileInfo(target & "\" & MyFile.Name)
            movedfile(x, 0) = (MyFile)
            movedfile(x, 1) = (destfile)
            creatdirectory(target)
            movethat(MyFile, destfile)

            If CreatDirectorfDone = 1 AndAlso MoveThatDone = 1 Then


                ListBox1.Items.Add("\" & MyFile.Name)
                ListBox2.Items.Add("\" & TextBox3.Text & "\" & MyFile.Name)
               
            End If
            If MoveThatDone = 0 Then
                Try
                    System.IO.Directory.Delete(target)
                Catch exc As Exception
                    MessageBox.Show("Error occurred: " & exc.Message)
                End Try
            End If

        Next


        If CheckBox1.Checked = False Then
            RefreshTheFolderName()
        End If
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

    Private Sub MdButton1_Click(sender As Object, e As EventArgs) Handles MdButton1.Click
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

    Private Sub NumericUpDown1_Click(sender As Object, e As EventArgs) Handles NumericUpDown1.Click
        RefreshTheFolderNameWithout()
    End Sub

    Private Sub NumericUpDown1_DoubleClick(sender As Object, e As EventArgs) Handles NumericUpDown1.DoubleClick
        RefreshTheFolderNameWithout()
    End Sub



    Private Sub MdButton2_Click(sender As Object, e As EventArgs) Handles MdButton2.Click
        Application.Exit()
    End Sub


    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        RefreshTheFolderNameWithout()
    End Sub

    Private Sub MdToggle1_CheckedChanged(sender As Object) Handles MdToggle1.CheckedChanged
        RefreshTheFolderNameWithout()
    End Sub

    Private Sub MdNumeric1_Click(sender As Object, e As EventArgs) Handles MdNumeric1.Click
        RefreshTheFolderNameWithout()
    End Sub

    Private Sub MdNumeric1_DoubleClick(sender As Object, e As EventArgs) Handles MdNumeric1.DoubleClick
        RefreshTheFolderNameWithout()
    End Sub

  
    Private Sub MdButton3_Click(sender As Object, e As EventArgs) Handles MdButton3.Click
        Form3.Show()
        Form3.Focus()
    End Sub

    Private Sub MdButton4_Click(sender As Object, e As EventArgs) Handles MdButton4.Click
        Form4.Show()
        Form4.Focus()
        Me.Hide()
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles Me.Load
        ListBox1.HorizontalScrollbar = True
        ListBox2.HorizontalScrollbar = True
    End Sub
End Class