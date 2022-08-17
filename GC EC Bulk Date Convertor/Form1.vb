Imports System.IO
Imports System.Windows.Forms

Public Class Form1
    Dim path As String = ""
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Dim sfd As New SaveFileDialog
            sfd.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv|All files (*.*)|*.*"
            sfd.FilterIndex = 1
            sfd.RestoreDirectory = True
            'Prompt the user for a file name to save to.
            If sfd.ShowDialog() = DialogResult.OK Then
                'Create the file to save to.
                Dim output As New IO.StreamWriter(sfd.FileName)

                'Write lines of text to the file.
                For Each item As Object In lstDest.Items
                    output.WriteLine(lstDest.GetItemText(item))
                Next item
                MsgBox("Saved Successfully!", MsgBoxStyle.Information)
                'Close the file.
                output.Close()
            End If
        Catch x As Exception
            MsgBox("There is something wrong with the saving!" + x.StackTrace, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Try
            lstStart.Items.Clear()
            txtFilePath.Enabled = True
            Dim od As OpenFileDialog = New OpenFileDialog()
            od.Filter = "Text File (*.txt;*.csv)|*.txt;*.csv"
            od.FilterIndex = 0
            Dim result As DialogResult = od.ShowDialog()
            ' Test result.
            If result = System.Windows.Forms.DialogResult.OK Then

                ' Get the file name.
                path = od.FileName
                txtFilePath.Text = path
                Dim txt As String
                Dim objReader As New System.IO.StreamReader(path)
                Do While objReader.Peek() <> -1
                    txt = objReader.ReadLine() & vbNewLine
                    lstStart.Items.Add(txt)
                Loop

            End If
        Catch x As Exception
            MsgBox("There is something wrong with reading the file!" + x.StackTrace, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub txtText_MouseEnter(sender As Object, e As EventArgs) Handles txtText.MouseEnter
        txtText.Enabled = True
        If Not String.IsNullOrEmpty(txtFilePath.Text) Then
            txtFilePath.Enabled = False
        End If
    End Sub

    Private Sub txtFilePath_TextChanged(sender As Object, e As EventArgs) Handles txtFilePath.TextChanged
        If Not String.IsNullOrEmpty(txtText.Text) Then
            txtText.Enabled = False
        End If
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        Try
            lstDest.Items.Clear()
            Dim hdp As HabeshaDateTimePicker.EthiopianDateControl = New HabeshaDateTimePicker.EthiopianDateControl
            'Dim dt As Date = #8/17/2022#
            Dim dt As Date
            'Console.WriteLine("DDDD" + hdp.ConvertGregorianToEthiopianDate(d, True))
            If cmbChange.SelectedIndex.Equals(0) Then
                For Each i As String In lstStart.Items
                    lstDest.Items.Add(hdp.ConvertGregorianToEthiopianDate(i, True))
                Next
            ElseIf cmbChange.SelectedIndex.Equals(1) Then
                For Each i As String In lstStart.Items
                    lstDest.Items.Add(hdp.ConvertEthiopianDateToGregorianDate(i, True))
                Next
            End If
        Catch x As Exception
            MsgBox("Error: Check date is the correct format MM/dd/yyyy!" + x.StackTrace, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbChange.SelectedIndex = 0
    End Sub

    Private Sub txtText_TextChanged(sender As Object, e As EventArgs) Handles txtText.TextChanged
        btnAdd.Enabled = True
        txtFilePath.Enabled = False
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs)

    End Sub
End Class
