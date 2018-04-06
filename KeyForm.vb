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
        IO.File.WriteAllText("keys.dat", ("master_key_00 = " + MKey00_TextBox.Text + vbNewLine +
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
    End Sub
End Class