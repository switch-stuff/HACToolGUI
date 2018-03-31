Public Class RomFSForm
    Private Sub OpenRomFS_Click(sender As Object, e As EventArgs) Handles OpenRomFS.Click
        SelectRomFS.ShowDialog()
        FileName.Text = SelectRomFS.FileName
        If FileName.Text = "Select a file." Then
            FileName.Text = ""
        End If
    End Sub

    Private Sub ExtStart_Click(sender As Object, e As EventArgs) Handles ExtStart.Click
        If ExtFolderName.Text IsNot "" Then
            IO.Directory.CreateDirectory(ExtFolderName.Text)
            Process.Start("cmd", "/c hactool -x --intype=romfs " + "--outdir=" + ExtFolderName.Text + " " + """" + FileName.Text + """")
        Else
            MsgBox("You must type a folder name!")
        End If
    End Sub
    Private Sub RomFSForm_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim DraggedFile() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each File In DraggedFile
            FileName.Text = File
        Next
        PictureBox1.Visible = False
    End Sub

    Private Sub RomFSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
    End Sub

    Private Sub RomFSForm_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
        PictureBox1.Visible = True
    End Sub

    Private Sub FileName_DragDrop(sender As Object, e As DragEventArgs) Handles FileName.DragDrop
        Dim DraggedFile() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each File In DraggedFile
            FileName.Text = File
        Next
        PictureBox1.Visible = False
    End Sub

    Private Sub FileName_DragEnter(sender As Object, e As DragEventArgs) Handles FileName.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
        PictureBox1.Visible = True
    End Sub

    Private Sub RomFSForm_DragLeave(sender As Object, e As EventArgs) Handles MyBase.DragLeave
        PictureBox1.Visible = False
    End Sub

    Private Sub FileName_DragLeave(sender As Object, e As EventArgs) Handles FileName.DragLeave
        PictureBox1.Visible = False
    End Sub
    Private Sub ExtFolderName_DragDrop(sender As Object, e As DragEventArgs) Handles ExtFolderName.DragDrop
        Dim DraggedFile() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each File In DraggedFile
            FileName.Text = File
        Next
        PictureBox1.Visible = False
    End Sub

    Private Sub ExtFolderName_DragEnter(sender As Object, e As DragEventArgs) Handles ExtFolderName.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
        PictureBox1.Visible = True
    End Sub
    Private Sub ExtFolderName_DragLeave(sender As Object, e As EventArgs) Handles ExtFolderName.DragLeave
        PictureBox1.Visible = False
    End Sub
End Class