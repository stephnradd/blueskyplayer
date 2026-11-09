<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.Location = New System.Drawing.Point(6, 24)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(256, 21)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Dukung file .3gp dan .m4a (Belum Aktif)"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(470, 431)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 37)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(330, 432)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(134, 36)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Kembali Ke Semula"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.Location = New System.Drawing.Point(6, 51)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(399, 21)
        Me.CheckBox4.TabIndex = 7
        Me.CheckBox4.Text = "Gunakan Codec untuk memutar file *.FLV dan *.3GP (Belum Aktif)"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.AutoSize = True
        Me.CheckBox7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox7.Location = New System.Drawing.Point(6, 24)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(171, 21)
        Me.CheckBox7.TabIndex = 11
        Me.CheckBox7.Text = "Putar Ulang (Belum Aktif)"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.AutoSize = True
        Me.CheckBox8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox8.Location = New System.Drawing.Point(6, 51)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(159, 21)
        Me.CheckBox8.TabIndex = 12
        Me.CheckBox8.Text = "Acak lagu (Belum Aktif)"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Pengaturan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(531, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 40)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "X"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 142)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Utama"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox7)
        Me.GroupBox2.Controls.Add(Me.CheckBox8)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 205)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(553, 84)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pemutaran"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(577, 480)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form8"
        Me.ShowInTaskbar = False
        Me.Text = "Pengaturan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
