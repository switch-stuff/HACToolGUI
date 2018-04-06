Imports System.IO
Imports System.Net
Public Class MainForm
    Dim keyorder() As Object = {System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Up,
System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.Down,
System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right,
System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.Right,
System.Windows.Forms.Keys.B, System.Windows.Forms.Keys.A}
    Dim index As Integer = 0
    Dim sequence() As Boolean = {False, False, False, False, False, False, False, False, False, False}
    Dim UpdateCheck As String = "http://simolabs.com.au/hactoolgui/currentversion.txt"
    Dim Notify As String = "http://simolabs.com.au/hactoolgui/news.txt"
    Dim Web As WebClient = New WebClient()
    Dim Rd As StreamReader = New StreamReader(Web.OpenRead(UpdateCheck))
    Dim GBATemp As String = "https://gbatemp.net/threads/release-hactoolgui-v0-1-a-very-simple-gui-for-hactool.499526/"
    Dim LatestVersion As String = Rd.ReadToEnd
    Dim CurrentVersion As String = "0.2c"
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub
    Private Sub CalculatorAboutForm_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If index < 9 And sequence(index) = False And e.KeyCode = keyorder(index) Then
            sequence(index) = True
            index += 1
        ElseIf index = 9 And e.KeyCode = keyorder(index) Then
            MsgBox("You found the first easter egg!" + vbNewLine + "Now look for the others...")
        Else
            index = 0
            For i As Integer = 0 To sequence.Length - 1
                sequence(i) = False
            Next
        End If
    End Sub
    Private Sub LaunchNCA_Click(sender As Object, e As EventArgs) Handles LaunchNCA.Click
        NCAForm.Show()
    End Sub

    Private Sub LaunchXCI_Click(sender As Object, e As EventArgs) Handles LaunchXCI.Click
        XCIForm.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("hactool.exe") Then
        Else
            MsgBox("You must put hactool.exe and its dependencies in this directory.")
            Close()
        End If
        If IO.File.Exists("easter.egg") Then
            MsgBox("You found the second easter egg!" + vbNewLine + "Gotta catch 'em all!")
        Else
        End If
        If LatestVersion = CurrentVersion Then
            Label1.Text = "HACToolGUI is up to date."
        Else
            Label1.Text = "Version " + LatestVersion + " is available."
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        RomFSForm.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        PFS0Form.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        HFS0Form.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        NPDMForm.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        PK11Form.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        PK21Form.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        INI1Form.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        KIP1Form.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        If Label1.Text = "HACToolGUI is up to date." Then
        Else
            Process.Start(GBATemp)
        End If
    End Sub
End Class