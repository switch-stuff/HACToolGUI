<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KeyForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(KeyForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MKey00_TextBox = New System.Windows.Forms.TextBox()
        Me.Header_TextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AKEK_TextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AKey_TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Save = New System.Windows.Forms.ToolStripMenuItem()
        Me.KApp_TextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.KOcean_TextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.KSys_TextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MKey01_TextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MKey02_TextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MKey03_TextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.HintButton = New System.Windows.Forms.Button()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TKEKStr = New System.Windows.Forms.Label()
        Me.TKEK = New System.Windows.Forms.TextBox()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(65, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Master Key 00:"
        '
        'MKey00_TextBox
        '
        Me.MKey00_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MKey00_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MKey00_TextBox.Location = New System.Drawing.Point(235, 60)
        Me.MKey00_TextBox.Name = "MKey00_TextBox"
        Me.MKey00_TextBox.Size = New System.Drawing.Size(838, 24)
        Me.MKey00_TextBox.TabIndex = 1
        '
        'Header_TextBox
        '
        Me.Header_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Header_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Header_TextBox.Location = New System.Drawing.Point(235, 276)
        Me.Header_TextBox.Name = "Header_TextBox"
        Me.Header_TextBox.Size = New System.Drawing.Size(838, 24)
        Me.Header_TextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 363)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "AES Key Source:"
        '
        'AKEK_TextBox
        '
        Me.AKEK_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AKEK_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AKEK_TextBox.Location = New System.Drawing.Point(235, 319)
        Me.AKEK_TextBox.Name = "AKEK_TextBox"
        Me.AKEK_TextBox.Size = New System.Drawing.Size(838, 24)
        Me.AKEK_TextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(89, 275)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 30)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Header Key:"
        '
        'AKey_TextBox
        '
        Me.AKey_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.AKey_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AKey_TextBox.Location = New System.Drawing.Point(235, 364)
        Me.AKey_TextBox.Name = "AKey_TextBox"
        Me.AKey_TextBox.Size = New System.Drawing.Size(838, 24)
        Me.AKey_TextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(50, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 30)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "AES KEK Source:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.DimGray
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.Save})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1084, 37)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Save
        '
        Me.Save.Font = New System.Drawing.Font("Candara", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.ForeColor = System.Drawing.Color.White
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(73, 33)
        Me.Save.Text = "Save"
        '
        'KApp_TextBox
        '
        Me.KApp_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KApp_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.KApp_TextBox.Location = New System.Drawing.Point(235, 410)
        Me.KApp_TextBox.Name = "KApp_TextBox"
        Me.KApp_TextBox.Size = New System.Drawing.Size(838, 24)
        Me.KApp_TextBox.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(16, 500)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(196, 30)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "KAK System Source:"
        '
        'KOcean_TextBox
        '
        Me.KOcean_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KOcean_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.KOcean_TextBox.Location = New System.Drawing.Point(235, 456)
        Me.KOcean_TextBox.Name = "KOcean_TextBox"
        Me.KOcean_TextBox.Size = New System.Drawing.Size(838, 24)
        Me.KOcean_TextBox.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(21, 456)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 30)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "KAK Ocean Source:"
        '
        'KSys_TextBox
        '
        Me.KSys_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.KSys_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.KSys_TextBox.Location = New System.Drawing.Point(235, 501)
        Me.KSys_TextBox.Name = "KSys_TextBox"
        Me.KSys_TextBox.Size = New System.Drawing.Size(838, 24)
        Me.KSys_TextBox.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(44, 410)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 30)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "KAK App Source:"
        '
        'MKey01_TextBox
        '
        Me.MKey01_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MKey01_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MKey01_TextBox.Location = New System.Drawing.Point(235, 105)
        Me.MKey01_TextBox.Name = "MKey01_TextBox"
        Me.MKey01_TextBox.Size = New System.Drawing.Size(838, 24)
        Me.MKey01_TextBox.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(65, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 30)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Master Key 01:"
        '
        'MKey02_TextBox
        '
        Me.MKey02_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MKey02_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MKey02_TextBox.Location = New System.Drawing.Point(235, 149)
        Me.MKey02_TextBox.Name = "MKey02_TextBox"
        Me.MKey02_TextBox.Size = New System.Drawing.Size(838, 24)
        Me.MKey02_TextBox.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(65, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(149, 30)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Master Key 02:"
        '
        'MKey03_TextBox
        '
        Me.MKey03_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MKey03_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MKey03_TextBox.Location = New System.Drawing.Point(235, 193)
        Me.MKey03_TextBox.Name = "MKey03_TextBox"
        Me.MKey03_TextBox.Size = New System.Drawing.Size(838, 24)
        Me.MKey03_TextBox.TabIndex = 26
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(65, 193)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 30)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Master Key 03:"
        '
        'HintButton
        '
        Me.HintButton.BackColor = System.Drawing.Color.DarkGray
        Me.HintButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.HintButton.FlatAppearance.BorderSize = 0
        Me.HintButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.HintButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.HintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HintButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HintButton.ForeColor = System.Drawing.Color.Gray
        Me.HintButton.Location = New System.Drawing.Point(1044, 0)
        Me.HintButton.Name = "HintButton"
        Me.HintButton.Size = New System.Drawing.Size(39, 49)
        Me.HintButton.TabIndex = 12
        Me.HintButton.Text = "?"
        Me.HintButton.UseVisualStyleBackColor = False
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.Location = New System.Drawing.Point(235, 234)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(838, 24)
        Me.TextBox11.TabIndex = 28
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(65, 234)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(149, 30)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Master Key 04:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(1, 536)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(1071, 30)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "--------------------------------------------------------------eShop--------------" &
    "-------------------------------------------------"
        '
        'TKEKStr
        '
        Me.TKEKStr.AutoSize = True
        Me.TKEKStr.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TKEKStr.ForeColor = System.Drawing.Color.White
        Me.TKEKStr.Location = New System.Drawing.Point(45, 570)
        Me.TKEKStr.Name = "TKEKStr"
        Me.TKEKStr.Size = New System.Drawing.Size(167, 30)
        Me.TKEKStr.TabIndex = 30
        Me.TKEKStr.Text = "Title KEK Source:"
        '
        'TKEK
        '
        Me.TKEK.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TKEK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TKEK.Location = New System.Drawing.Point(234, 570)
        Me.TKEK.Name = "TKEK"
        Me.TKEK.Size = New System.Drawing.Size(838, 24)
        Me.TKEK.TabIndex = 31
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Font = New System.Drawing.Font("Candara", 9.0!)
        Me.OpenToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(80, 33)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'KeyForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1084, 617)
        Me.Controls.Add(Me.TKEK)
        Me.Controls.Add(Me.TKEKStr)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.MKey03_TextBox)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.MKey02_TextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.MKey01_TextBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.KApp_TextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.KOcean_TextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.KSys_TextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.HintButton)
        Me.Controls.Add(Me.AKey_TextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AKEK_TextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Header_TextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MKey00_TextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "KeyForm"
        Me.Text = "Key Data"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MKey00_TextBox As TextBox
    Friend WithEvents Header_TextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents AKEK_TextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents AKey_TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Save As ToolStripMenuItem
    Friend WithEvents KApp_TextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents KOcean_TextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents KSys_TextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents MKey01_TextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MKey02_TextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents MKey03_TextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents HintButton As Button
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TKEKStr As Label
    Friend WithEvents TKEK As TextBox
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
End Class
