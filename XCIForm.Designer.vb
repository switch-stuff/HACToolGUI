<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XCIForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XCIForm))
        Me.OutputDir = New System.Windows.Forms.TextBox()
        Me.OutStr = New System.Windows.Forms.Label()
        Me.Start = New System.Windows.Forms.Button()
        Me.SelectXCI = New System.Windows.Forms.OpenFileDialog()
        Me.InStr = New System.Windows.Forms.Label()
        Me.OpenXCI = New System.Windows.Forms.Button()
        Me.InFile = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OutputDir
        '
        Me.OutputDir.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.OutputDir.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.OutputDir.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutputDir.Location = New System.Drawing.Point(177, 106)
        Me.OutputDir.Name = "OutputDir"
        Me.OutputDir.Size = New System.Drawing.Size(451, 28)
        Me.OutputDir.TabIndex = 27
        '
        'OutStr
        '
        Me.OutStr.AutoSize = True
        Me.OutStr.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OutStr.ForeColor = System.Drawing.Color.White
        Me.OutStr.Location = New System.Drawing.Point(11, 105)
        Me.OutStr.Name = "OutStr"
        Me.OutStr.Size = New System.Drawing.Size(144, 30)
        Me.OutStr.TabIndex = 26
        Me.OutStr.Text = "Output folder:"
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Start.FlatAppearance.BorderSize = 0
        Me.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Start.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Start.ForeColor = System.Drawing.Color.White
        Me.Start.Location = New System.Drawing.Point(634, 98)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(133, 42)
        Me.Start.TabIndex = 25
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = False
        '
        'SelectXCI
        '
        Me.SelectXCI.FileName = "Select a file."
        '
        'InStr
        '
        Me.InStr.AutoSize = True
        Me.InStr.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InStr.ForeColor = System.Drawing.Color.White
        Me.InStr.Location = New System.Drawing.Point(11, 10)
        Me.InStr.Name = "InStr"
        Me.InStr.Size = New System.Drawing.Size(101, 30)
        Me.InStr.TabIndex = 17
        Me.InStr.Text = "Input file:"
        '
        'OpenXCI
        '
        Me.OpenXCI.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.OpenXCI.FlatAppearance.BorderSize = 0
        Me.OpenXCI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.OpenXCI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenXCI.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OpenXCI.ForeColor = System.Drawing.Color.White
        Me.OpenXCI.Location = New System.Drawing.Point(16, 42)
        Me.OpenXCI.Name = "OpenXCI"
        Me.OpenXCI.Size = New System.Drawing.Size(102, 44)
        Me.OpenXCI.TabIndex = 16
        Me.OpenXCI.Text = "Open"
        Me.OpenXCI.UseVisualStyleBackColor = False
        '
        'InFile
        '
        Me.InFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.InFile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.InFile.Font = New System.Drawing.Font("Segoe UI", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InFile.Location = New System.Drawing.Point(130, 49)
        Me.InFile.Name = "InFile"
        Me.InFile.Size = New System.Drawing.Size(637, 28)
        Me.InFile.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.HACToolGUI.My.Resources.Resources.XCIDrop
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(780, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'XCIForm
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(779, 154)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.OutputDir)
        Me.Controls.Add(Me.OutStr)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.InStr)
        Me.Controls.Add(Me.OpenXCI)
        Me.Controls.Add(Me.InFile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "XCIForm"
        Me.Text = "Extract XCI"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OutputDir As TextBox
    Friend WithEvents OutStr As Label
    Friend WithEvents Start As Button
    Friend WithEvents SelectXCI As OpenFileDialog
    Friend WithEvents InStr As Label
    Friend WithEvents OpenXCI As Button
    Friend WithEvents InFile As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
