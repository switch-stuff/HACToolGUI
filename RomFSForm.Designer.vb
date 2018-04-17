<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RomFSForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RomFSForm))
        Me.ExtFolderName = New System.Windows.Forms.TextBox()
        Me.OutFolderStr = New System.Windows.Forms.Label()
        Me.ExtStart = New System.Windows.Forms.Button()
        Me.Input = New System.Windows.Forms.Label()
        Me.OpenRomFS = New System.Windows.Forms.Button()
        Me.FileName = New System.Windows.Forms.TextBox()
        Me.SelectRomFS = New System.Windows.Forms.OpenFileDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExtFolderName
        '
        Me.ExtFolderName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ExtFolderName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ExtFolderName.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtFolderName.Location = New System.Drawing.Point(181, 101)
        Me.ExtFolderName.Name = "ExtFolderName"
        Me.ExtFolderName.Size = New System.Drawing.Size(506, 28)
        Me.ExtFolderName.TabIndex = 19
        '
        'OutFolderStr
        '
        Me.OutFolderStr.AutoSize = True
        Me.OutFolderStr.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutFolderStr.ForeColor = System.Drawing.Color.White
        Me.OutFolderStr.Location = New System.Drawing.Point(14, 100)
        Me.OutFolderStr.Name = "OutFolderStr"
        Me.OutFolderStr.Size = New System.Drawing.Size(144, 30)
        Me.OutFolderStr.TabIndex = 18
        Me.OutFolderStr.Text = "Output folder:"
        '
        'ExtStart
        '
        Me.ExtStart.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ExtStart.FlatAppearance.BorderSize = 0
        Me.ExtStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.ExtStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExtStart.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExtStart.ForeColor = System.Drawing.Color.White
        Me.ExtStart.Location = New System.Drawing.Point(697, 93)
        Me.ExtStart.Name = "ExtStart"
        Me.ExtStart.Size = New System.Drawing.Size(135, 42)
        Me.ExtStart.TabIndex = 17
        Me.ExtStart.Text = "Start"
        Me.ExtStart.UseVisualStyleBackColor = False
        '
        'Input
        '
        Me.Input.AutoSize = True
        Me.Input.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Input.ForeColor = System.Drawing.Color.White
        Me.Input.Location = New System.Drawing.Point(14, 13)
        Me.Input.Name = "Input"
        Me.Input.Size = New System.Drawing.Size(101, 30)
        Me.Input.TabIndex = 16
        Me.Input.Text = "Input file:"
        '
        'OpenRomFS
        '
        Me.OpenRomFS.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.OpenRomFS.FlatAppearance.BorderSize = 0
        Me.OpenRomFS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.OpenRomFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenRomFS.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenRomFS.ForeColor = System.Drawing.Color.White
        Me.OpenRomFS.Location = New System.Drawing.Point(19, 43)
        Me.OpenRomFS.Name = "OpenRomFS"
        Me.OpenRomFS.Size = New System.Drawing.Size(102, 44)
        Me.OpenRomFS.TabIndex = 15
        Me.OpenRomFS.Text = "Open"
        Me.OpenRomFS.UseVisualStyleBackColor = False
        '
        'FileName
        '
        Me.FileName.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FileName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FileName.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileName.Location = New System.Drawing.Point(136, 50)
        Me.FileName.Name = "FileName"
        Me.FileName.Size = New System.Drawing.Size(694, 28)
        Me.FileName.TabIndex = 14
        '
        'SelectRomFS
        '
        Me.SelectRomFS.FileName = "Select a file..."
        Me.SelectRomFS.InitialDirectory = "/"
        Me.SelectRomFS.RestoreDirectory = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HACToolGUI.My.Resources.Resources.RomFSDrop
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(851, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'RomFSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(852, 149)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ExtFolderName)
        Me.Controls.Add(Me.OutFolderStr)
        Me.Controls.Add(Me.ExtStart)
        Me.Controls.Add(Me.Input)
        Me.Controls.Add(Me.OpenRomFS)
        Me.Controls.Add(Me.FileName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RomFSForm"
        Me.Text = "Extract RomFS"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExtFolderName As TextBox
    Friend WithEvents OutFolderStr As Label
    Friend WithEvents ExtStart As Button
    Friend WithEvents Input As Label
    Friend WithEvents OpenRomFS As Button
    Friend WithEvents FileName As TextBox
    Friend WithEvents SelectRomFS As OpenFileDialog
    Friend WithEvents PictureBox1 As PictureBox
End Class
