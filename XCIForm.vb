Public Class XCIForm
    Private Sub OpenXCI_Click(sender As Object, e As EventArgs) Handles OpenXCI.Click
        SelectXCI.ShowDialog()
        InFile.Text = SelectXCI.FileName
        If InFile.Text = "Select a file." Then
            InFile.Text = ""
        End If
    End Sub

    Private Sub Start_Click(sender As Object, e As EventArgs) Handles Start.Click
        If OutputDir.Text IsNot "" Then
            Process.Start("cmd", "/c hactool -t xci " + "--outdir=" + OutputDir.Text + " " + """" + InFile.Text + """")
        Else
            MsgBox("You must type a folder name!")
        End If
    End Sub

    Private Sub XCIForm_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim DraggedFile() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each File In DraggedFile
            InFile.Text = File
        Next
        PictureBox1.Visible = False
    End Sub

    Private Sub XCIForm_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
        PictureBox1.Visible = True
    End Sub

    Private Sub XCIForm_DragLeave(sender As Object, e As EventArgs) Handles MyBase.DragLeave
        PictureBox1.Visible = False

    End Sub

    Private Sub InFile_DragDrop(sender As Object, e As DragEventArgs) Handles InFile.DragDrop
        Dim DraggedFile() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each File In DraggedFile
            InFile.Text = File
        Next
        PictureBox1.Visible = False
    End Sub

    Private Sub InFile_DragEnter(sender As Object, e As DragEventArgs) Handles InFile.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
        PictureBox1.Visible = True
    End Sub

    Private Sub InFile_DragLeave(sender As Object, e As EventArgs) Handles InFile.DragLeave
        PictureBox1.Visible = False

    End Sub

    Private Sub OutputDir_DragDrop(sender As Object, e As DragEventArgs) Handles OutputDir.DragDrop
        Dim DraggedFile() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each File In DraggedFile
            InFile.Text = File
        Next
        PictureBox1.Visible = False
    End Sub

    Private Sub OutputDir_DragEnter(sender As Object, e As DragEventArgs) Handles OutputDir.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
        PictureBox1.Visible = True
    End Sub

    Private Sub OutputDir_DragLeave(sender As Object, e As EventArgs) Handles OutputDir.DragLeave
        PictureBox1.Visible = False
    End Sub
End Class