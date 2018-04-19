Imports System.IO.File
Imports System.IO.Directory
Public Class NCAForm
    Private Sub OpenNCA_Click(sender As Object, e As EventArgs) Handles OpenNCA.Click
        SelectNCA.ShowDialog()
        FileName.Text = SelectNCA.FileName
        If FileName.Text = "Select a file." Then
            FileName.Text = ""
        End If
    End Sub
    Private Sub PlainOpt_CheckedChanged(sender As Object, e As EventArgs) Handles PlainOpt.CheckedChanged
        WriteAllText("prefs.dat", "0")
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RomFSStr.Enabled = False
        RomFSName.Enabled = False
        RomFSStart.Enabled = False
        OutFolderStr.Enabled = False
        ExtFolderName.Enabled = False
        ExtStart.Enabled = False
        PlainStr.Enabled = True
        PlainName.Enabled = True
        PlainStart.Enabled = True
        PlainExtStr.Enabled = True
    End Sub
    Private Sub ExtractOpt_CheckedChanged(sender As Object, e As EventArgs) Handles ExtractOpt.CheckedChanged
        WriteAllText("prefs.dat", "1")
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        RomFSStr.Enabled = False
        RomFSName.Enabled = False
        RomFSStart.Enabled = False
        PlainStr.Enabled = False
        PlainName.Enabled = False
        PlainStart.Enabled = False
        PlainExtStr.Enabled = False
        OutFolderStr.Enabled = True
        ExtFolderName.Enabled = True
        ExtStart.Enabled = True
    End Sub
    Private Sub PlainStart_Click(sender As Object, e As EventArgs) Handles PlainStart.Click
        If IO.File.Exists("keys.dat") Then
            If PlainName.Text IsNot "" Then
                Process.Start("cmd", "/c hactool -k keys.dat " + "--plaintext=" + PlainName.Text + ".nca" + " " + """" + FileName.Text + """")
            Else
                MsgBox("You must type a filename!")
            End If
        Else
            MsgBox("You must add keys first.")
            KeyForm.Show()
        End If
    End Sub
    Private Sub ExtStart_Click(sender As Object, e As EventArgs) Handles ExtStart.Click
        If IO.File.Exists("keys.dat") Then
            If ExtFolderName.Text IsNot "" Then
                CreateDirectory(ExtFolderName.Text)
                Process.Start("cmd", "/c hactool -k keys.dat " + "--romfsdir=" + ExtFolderName.Text + " " + """" + FileName.Text + """")
            Else
                MsgBox("You must type a folder name!")
            End If
        Else
            MsgBox("You must add keys first.")
            KeyForm.Show()
        End If
    End Sub

    Private Sub KeyManLaunch_Click(sender As Object, e As EventArgs) Handles KeyManLaunch.Click
        KeyForm.Show()
    End Sub

    Private Sub RomFSOpt_CheckedChanged(sender As Object, e As EventArgs) Handles RomFSOpt.CheckedChanged
        WriteAllText("prefs.dat", "2")
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        RomFSStr.Enabled = True
        RomFSName.Enabled = True
        RomFSStart.Enabled = True
        PlainStr.Enabled = False
        PlainName.Enabled = False
        PlainStart.Enabled = False
        PlainExtStr.Enabled = False
        OutFolderStr.Enabled = False
        ExtFolderName.Enabled = False
        ExtStart.Enabled = False
    End Sub

    Private Sub RomFSStart_Click(sender As Object, e As EventArgs) Handles RomFSStart.Click
        If IO.File.Exists("keys.dat") Then
            If RomFSName.Text IsNot "" Then
                CreateDirectory(RomFSName.Text)
                If RadioButton1.Checked = True Then
                    WriteAllText("prefs.dat", "A")
                    Process.Start("cmd", "/c hactool -k keys.dat " + "--romfs=" + RomFSName.Text + "/RomFS.romfs" + " --section0dir=" + RomFSName.Text + " " + """" + FileName.Text + """")
                Else
                    WriteAllText("prefs.dat", "B")
                    Process.Start("cmd", "/c hactool -k keys.dat " + "--romfs=" + RomFSName.Text + "/game.istorage" + " --section0dir=" + RomFSName.Text + " " + """" + FileName.Text + """")
                End If
            Else
                MsgBox("You must type a filename!")
            End If
        Else
            MsgBox("You must add keys first.")
            KeyForm.Show()
        End If
    End Sub
    Private Sub NCAForm_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim DraggedFile() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each File In DraggedFile
            FileName.Text = File
        Next
        PictureBox1.Visible = False
    End Sub

    Private Sub NCAForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
        If IO.File.Exists("prefs.dat") = False Then
            IO.File.Create("prefs.dat").Close()
        End If
        If ReadAllText("prefs.dat") = "0" Then
            PlainOpt.Checked = True
        ElseIf ReadAllText("prefs.dat") = "1" Then
            ExtractOpt.Checked = True
        ElseIf ReadAllText("prefs.dat") = "2" Then
            RomFSOpt.Checked = True
        ElseIf ReadAllText("prefs.dat") = "A" Then
            RadioButton1.Checked = True
        ElseIf ReadAllText("prefs.dat") = "B" Then
            RadioButton2.Checked = True
        ElseIf ReadAllText("prefs.dat") = "" Then

        End If

    End Sub

    Private Sub NCAForm_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
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

    Private Sub NCAForm_DragLeave(sender As Object, e As EventArgs) Handles MyBase.DragLeave
        PictureBox1.Visible = False
    End Sub

    Private Sub FileName_DragLeave(sender As Object, e As EventArgs) Handles FileName.DragLeave
        PictureBox1.Visible = False
    End Sub
End Class
