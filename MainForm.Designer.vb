<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.QuestionStr = New System.Windows.Forms.Label()
        Me.LaunchNCA = New System.Windows.Forms.Button()
        Me.LaunchXCI = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'QuestionStr
        '
        Me.QuestionStr.AutoSize = True
        Me.QuestionStr.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuestionStr.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.QuestionStr.Location = New System.Drawing.Point(20, 20)
        Me.QuestionStr.Name = "QuestionStr"
        Me.QuestionStr.Size = New System.Drawing.Size(535, 51)
        Me.QuestionStr.TabIndex = 0
        Me.QuestionStr.Text = "What would you like to do?"
        '
        'LaunchNCA
        '
        Me.LaunchNCA.BackColor = System.Drawing.Color.DimGray
        Me.LaunchNCA.FlatAppearance.BorderSize = 0
        Me.LaunchNCA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.LaunchNCA.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LaunchNCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaunchNCA.ForeColor = System.Drawing.Color.White
        Me.LaunchNCA.Location = New System.Drawing.Point(12, 85)
        Me.LaunchNCA.Name = "LaunchNCA"
        Me.LaunchNCA.Size = New System.Drawing.Size(274, 137)
        Me.LaunchNCA.TabIndex = 1
        Me.LaunchNCA.Text = "Extract NCA"
        Me.LaunchNCA.UseVisualStyleBackColor = False
        '
        'LaunchXCI
        '
        Me.LaunchXCI.BackColor = System.Drawing.Color.DimGray
        Me.LaunchXCI.FlatAppearance.BorderSize = 0
        Me.LaunchXCI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.LaunchXCI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LaunchXCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LaunchXCI.ForeColor = System.Drawing.Color.White
        Me.LaunchXCI.Location = New System.Drawing.Point(292, 85)
        Me.LaunchXCI.Name = "LaunchXCI"
        Me.LaunchXCI.Size = New System.Drawing.Size(270, 137)
        Me.LaunchXCI.TabIndex = 2
        Me.LaunchXCI.Text = "Extract XCI"
        Me.LaunchXCI.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DimGray
        Me.Button3.Enabled = False
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(292, 371)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(270, 137)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Extract NPDM"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.DimGray
        Me.Button4.Enabled = False
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(12, 371)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(274, 137)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Extract HFS0"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.DimGray
        Me.Button5.Enabled = False
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(292, 228)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(270, 137)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Extract PFS0"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DimGray
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(12, 228)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(274, 137)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Extract RomFS"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.DimGray
        Me.Button7.Enabled = False
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(292, 514)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(270, 137)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Extract Package2"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.DimGray
        Me.Button8.Enabled = False
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(12, 514)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(274, 137)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Extract Package1"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.DimGray
        Me.Button9.Enabled = False
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(292, 657)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(270, 137)
        Me.Button9.TabIndex = 10
        Me.Button9.Text = "Extract KIP1"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.DimGray
        Me.Button10.Enabled = False
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(12, 657)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(274, 137)
        Me.Button10.TabIndex = 9
        Me.Button10.Text = "Extract INI1"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(524, 33)
        Me.ToolStripStatusLabel1.Text = "Checked for updates, HACToolGUI is up to date."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 803)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(465, 51)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Checking for updates..."
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(192.0!, 192.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(574, 869)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.LaunchXCI)
        Me.Controls.Add(Me.LaunchNCA)
        Me.Controls.Add(Me.QuestionStr)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.Text = "HACToolGUI Interface"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuestionStr As Label
    Friend WithEvents LaunchNCA As Button
    Friend WithEvents LaunchXCI As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
End Class
