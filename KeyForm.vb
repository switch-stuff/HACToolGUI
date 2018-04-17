Imports System.IO.File
Public Class KeyForm
    Private Sub HintButton_Click(sender As Object, e As EventArgs) Handles HintButton.Click
        MKey00_TextBox.Text = "C2CA"
        MKey01_TextBox.Text = "54E1"
        MKey02_TextBox.Text = "4F6B"
        MKey03_TextBox.Text = "84E0"
        Header_TextBox.Text = "AEAA"
        AKEK_TextBox.Text = "4D87"
        AKey_TextBox.Text = "8961"
        KApp_TextBox.Text = "7F59"
        KOcean_TextBox.Text = "327D"
        KSys_TextBox.Text = "8745"
        TKEK.Text = "1EDC"
    End Sub
    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click
        WriteAllText("keys.dat", ("master_key_00 = " + MKey00_TextBox.Text + vbNewLine +
                             "master_key_01 = " + MKey01_TextBox.Text + vbNewLine +
                             "master_key_02 = " + MKey02_TextBox.Text + vbNewLine +
                             "master_key_03 = " + MKey03_TextBox.Text + vbNewLine +
                             "header_key = " + Header_TextBox.Text + vbNewLine +
                             "aes_kek_generation_source = " + AKEK_TextBox.Text + vbNewLine +
                             "aes_key_generation_source = " + AKey_TextBox.Text + vbNewLine +
                             "key_area_key_application_source = " + KApp_TextBox.Text + vbNewLine +
                             "key_area_key_ocean_source = " + KOcean_TextBox.Text + vbNewLine +
                             "key_area_key_system_source = " + KSys_TextBox.Text + vbNewLine +
                             "titlekek_source = " + TKEK.Text))
        If Exists("keys.dat") Then
            MsgBox("Keys saved successfully!")
        Else MsgBox("Keys were not saved successfully." + vbNewLine + "Simon is an idiot, spam him on Discord and make sure to tell him how bad of a programmer he is.")
        End If
        MainForm.LaunchNCA.Enabled = True
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        If Exists("keys.dat") Then
            Dim Line = ReadLines("keys.dat")
            MKey00_TextBox.Text = Line(0).Substring(16)
            MKey01_TextBox.Text = Line(1).Substring(16)
            MKey02_TextBox.Text = Line(2).Substring(16)
            MKey03_TextBox.Text = Line(3).Substring(16)
            Header_TextBox.Text = Line(4).Substring(13)
            AKEK_TextBox.Text = Line(5).Substring(28)
            AKey_TextBox.Text = Line(6).Substring(28)
            KApp_TextBox.Text = Line(7).Substring(34)
            KOcean_TextBox.Text = Line(8).Substring(28)
            KSys_TextBox.Text = Line(9).Substring(29)
            TKEK.Text = Line(10).Substring(18)
        Else
            MsgBox("Make a keyfile first! I can't just GIVE you the keys...")
        End If
    End Sub

    Private Sub KeyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            If Exists("keys.dat") Then
                Dim Line = ReadLines("keys.dat")
                MKey00_TextBox.Text = Line(0).Substring(16)
                MKey01_TextBox.Text = Line(1).Substring(16)
                MKey02_TextBox.Text = Line(2).Substring(16)
                MKey03_TextBox.Text = Line(3).Substring(16)
                Header_TextBox.Text = Line(4).Substring(13)
                AKEK_TextBox.Text = Line(5).Substring(28)
                AKey_TextBox.Text = Line(6).Substring(28)
                KApp_TextBox.Text = Line(7).Substring(34)
                KOcean_TextBox.Text = Line(8).Substring(28)
                KSys_TextBox.Text = Line(9).Substring(29)
                TKEK.Text = Line(10).Substring(18)
            Else
            End If
        Catch ex As NullReferenceException
            MsgBox("You have a corrupted keyfile, OK to delete?")
            Delete("keys.dat")
            MKey00_TextBox.Clear()
            MKey01_TextBox.Clear()
            MKey02_TextBox.Clear()
            MKey03_TextBox.Clear()
            Header_TextBox.Clear()
            AKEK_TextBox.Clear()
            AKey_TextBox.Clear()
            KApp_TextBox.Clear()
            KOcean_TextBox.Clear()
            KSys_TextBox.Clear()
            TKEK.Clear()
        End Try
    End Sub
End Class