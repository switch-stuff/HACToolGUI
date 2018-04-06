<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NCAForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NCAForm))
        Me.FileName = New System.Windows.Forms.TextBox()
        Me.OpenNCA = New System.Windows.Forms.Button()
        Me.Input = New System.Windows.Forms.Label()
        Me.SelectNCA = New System.Windows.Forms.OpenFileDialog()
        Me.PlainOpt = New System.Windows.Forms.RadioButton()
        Me.ExtractOpt = New System.Windows.Forms.RadioButton()
        Me.Output = New System.Windows.Forms.Label()
        Me.PlainStart = New System.Windows.Forms.Button()
        Me.PlainStr = New System.Windows.Forms.Label()
        Me.PlainName = New System.Windows.Forms.TextBox()
        Me.PlainExtStr = New System.Windows.Forms.Label()
        Me.ExtFolderName = New System.Windows.Forms.TextBox()
        Me.OutFolderStr = New System.Windows.Forms.Label()
        Me.ExtStart = New System.Windows.Forms.Button()
        Me.KeyManLaunch = New System.Windows.Forms.Button()
        Me.RomFSName = New System.Windows.Forms.TextBox()
        Me.RomFSStr = New System.Windows.Forms.Label()
        Me.RomFSStart = New System.Windows.Forms.Button()
        Me.RomFSOpt = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileName
        '
        Me.FileName.AllowDrop = True
        Me.FileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FileName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FileName.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileName.Location = New System.Drawing.Point(130, 97)
        Me.FileName.Name = "FileName"
        Me.FileName.Size = New System.Drawing.Size(694, 28)
        Me.FileName.TabIndex = 1
        '
        'OpenNCA
        '
        Me.OpenNCA.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.OpenNCA.FlatAppearance.BorderSize = 0
        Me.OpenNCA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.OpenNCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenNCA.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenNCA.ForeColor = System.Drawing.Color.White
        Me.OpenNCA.Location = New System.Drawing.Point(11, 88)
        Me.OpenNCA.Name = "OpenNCA"
        Me.OpenNCA.Size = New System.Drawing.Size(102, 44)
        Me.OpenNCA.TabIndex = 2
        Me.OpenNCA.Text = "Open"
        Me.OpenNCA.UseVisualStyleBackColor = False
        '
        'Input
        '
        Me.Input.AutoSize = True
        Me.Input.BackColor = System.Drawing.Color.Gray
        Me.Input.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input.ForeColor = System.Drawing.Color.White
        Me.Input.Location = New System.Drawing.Point(6, 58)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(101, 30)
        Me.Input.TabIndex = 3
        Me.Input.Text = "Input file:"
        '
        'SelectNCA
        '
        Me.SelectNCA.FileName = "Select a file."
        '
        'PlainOpt
        '
        Me.PlainOpt.AutoSize = True
        Me.PlainOpt.BackColor = System.Drawing.Color.Gray
        Me.PlainOpt.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlainOpt.ForeColor = System.Drawing.Color.White
        Me.PlainOpt.Location = New System.Drawing.Point(11, 166)
        Me.PlainOpt.Name = "PlainOpt"
        Me.PlainOpt.Size = New System.Drawing.Size(173, 34)
        Me.PlainOpt.TabIndex = 4
        Me.PlainOpt.Text = "Plaintext NCA"
        Me.PlainOpt.UseVisualStyleBackColor = False
        '
        'ExtractOpt
        '
        Me.ExtractOpt.AutoSize = True
        Me.ExtractOpt.BackColor = System.Drawing.Color.Gray
        Me.ExtractOpt.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtractOpt.ForeColor = System.Drawing.Color.White
        Me.ExtractOpt.Location = New System.Drawing.Point(193, 166)
        Me.ExtractOpt.Name = "ExtractOpt"
        Me.ExtractOpt.Size = New System.Drawing.Size(235, 34)
        Me.ExtractOpt.TabIndex = 5
        Me.ExtractOpt.Text = "Extract files to folder"
        Me.ExtractOpt.UseVisualStyleBackColor = False
        '
        'Output
        '
        Me.Output.AutoSize = True
        Me.Output.BackColor = System.Drawing.Color.Gray
        Me.Output.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Output.ForeColor = System.Drawing.Color.White
        Me.Output.Location = New System.Drawing.Point(6, 135)
        Me.Output.Name = "Output"
        Me.Output.Size = New System.Drawing.Size(84, 30)
        Me.Output.TabIndex = 6
        Me.Output.Text = "Output:"
        '
        'PlainStart
        '
        Me.PlainStart.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.PlainStart.Enabled = False
        Me.PlainStart.FlatAppearance.BorderSize = 0
        Me.PlainStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.PlainStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PlainStart.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlainStart.ForeColor = System.Drawing.Color.White
        Me.PlainStart.Location = New System.Drawing.Point(636, 207)
        Me.PlainStart.Name = "PlainStart"
        Me.PlainStart.Size = New System.Drawing.Size(188, 41)
        Me.PlainStart.TabIndex = 7
        Me.PlainStart.Text = "Start"
        Me.PlainStart.UseVisualStyleBackColor = False
        '
        'PlainStr
        '
        Me.PlainStr.AutoSize = True
        Me.PlainStr.BackColor = System.Drawing.Color.Gray
        Me.PlainStr.Enabled = False
        Me.PlainStr.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlainStr.ForeColor = System.Drawing.Color.White
        Me.PlainStr.Location = New System.Drawing.Point(6, 215)
        Me.PlainStr.Name = "PlainStr"
        Me.PlainStr.Size = New System.Drawing.Size(170, 30)
        Me.PlainStr.TabIndex = 8
        Me.PlainStr.Text = "Output filename:"
        '
        'PlainName
        '
        Me.PlainName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PlainName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PlainName.Enabled = False
        Me.PlainName.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlainName.Location = New System.Drawing.Point(209, 215)
        Me.PlainName.Name = "PlainName"
        Me.PlainName.Size = New System.Drawing.Size(364, 28)
        Me.PlainName.TabIndex = 9
        '
        'PlainExtStr
        '
        Me.PlainExtStr.AutoSize = True
        Me.PlainExtStr.BackColor = System.Drawing.Color.Gray
        Me.PlainExtStr.Enabled = False
        Me.PlainExtStr.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlainExtStr.ForeColor = System.Drawing.Color.White
        Me.PlainExtStr.Location = New System.Drawing.Point(577, 217)
        Me.PlainExtStr.Name = "PlainExtStr"
        Me.PlainExtStr.Size = New System.Drawing.Size(51, 30)
        Me.PlainExtStr.TabIndex = 10
        Me.PlainExtStr.Text = ".nca"
        '
        'ExtFolderName
        '
        Me.ExtFolderName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ExtFolderName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ExtFolderName.Enabled = False
        Me.ExtFolderName.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtFolderName.Location = New System.Drawing.Point(177, 260)
        Me.ExtFolderName.Name = "ExtFolderName"
        Me.ExtFolderName.Size = New System.Drawing.Size(506, 28)
        Me.ExtFolderName.TabIndex = 13
        '
        'OutFolderStr
        '
        Me.OutFolderStr.AutoSize = True
        Me.OutFolderStr.BackColor = System.Drawing.Color.Gray
        Me.OutFolderStr.Enabled = False
        Me.OutFolderStr.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutFolderStr.ForeColor = System.Drawing.Color.White
        Me.OutFolderStr.Location = New System.Drawing.Point(6, 261)
        Me.OutFolderStr.Name = "OutFolderStr"
        Me.OutFolderStr.Size = New System.Drawing.Size(144, 30)
        Me.OutFolderStr.TabIndex = 12
        Me.OutFolderStr.Text = "Output folder:"
        '
        'ExtStart
        '
        Me.ExtStart.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExtStart.Enabled = False
        Me.ExtStart.FlatAppearance.BorderSize = 0
        Me.ExtStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.ExtStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExtStart.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtStart.ForeColor = System.Drawing.Color.White
        Me.ExtStart.Location = New System.Drawing.Point(689, 253)
        Me.ExtStart.Name = "ExtStart"
        Me.ExtStart.Size = New System.Drawing.Size(135, 42)
        Me.ExtStart.TabIndex = 11
        Me.ExtStart.Text = "Start"
        Me.ExtStart.UseVisualStyleBackColor = False
        '
        'KeyManLaunch
        '
        Me.KeyManLaunch.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.KeyManLaunch.FlatAppearance.BorderSize = 0
        Me.KeyManLaunch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.KeyManLaunch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.KeyManLaunch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyManLaunch.ForeColor = System.Drawing.Color.White
        Me.KeyManLaunch.Location = New System.Drawing.Point(12, 4)
        Me.KeyManLaunch.Name = "KeyManLaunch"
        Me.KeyManLaunch.Size = New System.Drawing.Size(812, 56)
        Me.KeyManLaunch.TabIndex = 14
        Me.KeyManLaunch.Text = "Open Key Manager"
        Me.KeyManLaunch.UseVisualStyleBackColor = False
        '
        'RomFSName
        '
        Me.RomFSName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.RomFSName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RomFSName.Enabled = False
        Me.RomFSName.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RomFSName.Location = New System.Drawing.Point(349, 304)
        Me.RomFSName.Name = "RomFSName"
        Me.RomFSName.Size = New System.Drawing.Size(334, 28)
        Me.RomFSName.TabIndex = 17
        '
        'RomFSStr
        '
        Me.RomFSStr.AutoSize = True
        Me.RomFSStr.BackColor = System.Drawing.Color.Gray
        Me.RomFSStr.Enabled = False
        Me.RomFSStr.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RomFSStr.ForeColor = System.Drawing.Color.White
        Me.RomFSStr.Location = New System.Drawing.Point(254, 304)
        Me.RomFSStr.Name = "RomFSStr"
        Me.RomFSStr.Size = New System.Drawing.Size(75, 30)
        Me.RomFSStr.TabIndex = 16
        Me.RomFSStr.Text = "Folder:"
        '
        'RomFSStart
        '
        Me.RomFSStart.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RomFSStart.Enabled = False
        Me.RomFSStart.FlatAppearance.BorderSize = 0
        Me.RomFSStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.RomFSStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RomFSStart.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RomFSStart.ForeColor = System.Drawing.Color.White
        Me.RomFSStart.Location = New System.Drawing.Point(689, 299)
        Me.RomFSStart.Name = "RomFSStart"
        Me.RomFSStart.Size = New System.Drawing.Size(135, 41)
        Me.RomFSStart.TabIndex = 15
        Me.RomFSStart.Text = "Start"
        Me.RomFSStart.UseVisualStyleBackColor = False
        '
        'RomFSOpt
        '
        Me.RomFSOpt.AutoSize = True
        Me.RomFSOpt.BackColor = System.Drawing.Color.Gray
        Me.RomFSOpt.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RomFSOpt.ForeColor = System.Drawing.Color.White
        Me.RomFSOpt.Location = New System.Drawing.Point(460, 167)
        Me.RomFSOpt.Name = "RomFSOpt"
        Me.RomFSOpt.Size = New System.Drawing.Size(336, 34)
        Me.RomFSOpt.TabIndex = 19
        Me.RomFSOpt.Text = "Generate emulator-ready folder"
        Me.RomFSOpt.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.HACToolGUI.My.Resources.Resources.NCADrop
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(836, 348)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Enabled = False
        Me.RadioButton1.Font = New System.Drawing.Font("Segoe UI", 7.875!)
        Me.RadioButton1.Location = New System.Drawing.Point(11, 300)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 34)
        Me.RadioButton1.TabIndex = 21
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Yuzu"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Enabled = False
        Me.RadioButton2.Font = New System.Drawing.Font("Segoe UI", 7.875!)
        Me.RadioButton2.Location = New System.Drawing.Point(119, 300)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(117, 34)
        Me.RadioButton2.TabIndex = 22
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RyujiNX"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'NCAForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(835, 347)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.RomFSOpt)
        Me.Controls.Add(Me.RomFSName)
        Me.Controls.Add(Me.RomFSStr)
        Me.Controls.Add(Me.RomFSStart)
        Me.Controls.Add(Me.KeyManLaunch)
        Me.Controls.Add(Me.ExtFolderName)
        Me.Controls.Add(Me.OutFolderStr)
        Me.Controls.Add(Me.ExtStart)
        Me.Controls.Add(Me.PlainExtStr)
        Me.Controls.Add(Me.PlainName)
        Me.Controls.Add(Me.PlainStr)
        Me.Controls.Add(Me.PlainStart)
        Me.Controls.Add(Me.Output)
        Me.Controls.Add(Me.ExtractOpt)
        Me.Controls.Add(Me.PlainOpt)
        Me.Controls.Add(Me.Input)
        Me.Controls.Add(Me.OpenNCA)
        Me.Controls.Add(Me.FileName)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "NCAForm"
        Me.Text = "Extract NCA"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FileName As TextBox
    Friend WithEvents OpenNCA As Button
    Friend WithEvents Input As Label
    Friend WithEvents SelectNCA As OpenFileDialog
    Friend WithEvents PlainOpt As RadioButton
    Friend WithEvents ExtractOpt As RadioButton
    Friend WithEvents Output As Label
    Friend WithEvents PlainStart As Button
    Friend WithEvents PlainStr As Label
    Friend WithEvents PlainName As TextBox
    Friend WithEvents PlainExtStr As Label
    Friend WithEvents ExtFolderName As TextBox
    Friend WithEvents OutFolderStr As Label
    Friend WithEvents ExtStart As Button
    Friend WithEvents KeyManLaunch As Button
    Friend WithEvents RomFSName As TextBox
    Friend WithEvents RomFSStr As Label
    Friend WithEvents RomFSStart As Button
    Friend WithEvents RomFSOpt As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
End Class
