Public Module modual

    Public Function movethat(x As IO.FileInfo, y As IO.FileInfo) As Integer
        Dim done As Integer = 0
        If x.Extension = Nothing Then
            Try
                IO.Directory.Move(x.FullName, y.FullName)
                done = 1
            Catch ex As Exception
                MessageBox.Show("Error occurred: " & ex.Message)
            End Try

        Else
            Try
                IO.File.Move(x.FullName, y.FullName)
                done = 1
            Catch ex As Exception
                MessageBox.Show("Error occurred: " & ex.Message)
            End Try

        End If
        Return done
    End Function



    Public Function creatdirectory(target As String) As Integer
        Dim done As Integer = 0

        Try
            System.IO.Directory.CreateDirectory(target)
            done = 1
        Catch ex As Exception
            MessageBox.Show("Error occurred: " & ex.Message)
        End Try
        Return done

    End Function
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
    Public Function thereIsAnyFileNumber(ByVal FileName As String) As String


        Dim FileNameChars() As Char = FileName.ToCharArray
        Dim chars(5) As Char
        Dim WhatIThinkIsTheFileNumber As New System.Text.StringBuilder

        For Each mychar As Char In FileNameChars


            If chars(0) = Nothing Then
                chars(0) = mychar
            ElseIf chars(1) = Nothing Then
                chars(1) = mychar
            ElseIf chars(2) = Nothing Then
                chars(2) = mychar
            ElseIf chars(3) = Nothing Then
                chars(3) = mychar
            ElseIf chars(4) = Nothing Then
                chars(4) = mychar
            ElseIf chars(5) = Nothing Then
                chars(5) = mychar
            Else

                chars(0) = chars(1)
                chars(1) = chars(2)
                chars(2) = chars(3)
                chars(3) = chars(4)
                chars(4) = chars(5)
                chars(5) = mychar

                If (chars(0).ToString = "s" Or chars(0).ToString = "S") AndAlso _
                    IsNumeric(chars(1).ToString) AndAlso _
                    IsNumeric(chars(2).ToString) AndAlso _
                    (chars(3).ToString = "e" Or chars(3).ToString = "E") AndAlso _
                    IsNumeric(chars(4).ToString) AndAlso _
                    IsNumeric(chars(5).ToString) Then

                    If WhatIThinkIsTheFileNumber.ToString = Nothing Then
                        For Each thechar As Char In chars
                            WhatIThinkIsTheFileNumber.Append(thechar.ToString)
                        Next
                    Else
                        Return "more"
                    End If


                End If
            End If

        Next

        If WhatIThinkIsTheFileNumber.ToString = Nothing Then
            Return Nothing
        Else
            Return WhatIThinkIsTheFileNumber.ToString
        End If

    End Function

End Module
