<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MusikToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PengaturanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KirimMasukanToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TentangBlueskyPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "mp4 wmv mkv m4v avi 3gp mpg flv"
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.Title = "Buka File Video"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        Me.OpenFileDialog2.Multiselect = True
        Me.OpenFileDialog2.Title = "Buka File Musik"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Product Sans", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(65, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Bluesky Player"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(969, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 40)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "X"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(890, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 45)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "-"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PengaturanToolStripMenuItem1, Me.BToolStripMenuItem, Me.KirimMasukanToolStripMenuItem1, Me.TentangBlueskyPlayerToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(197, 136)
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MusikToolStripMenuItem, Me.VideoToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = CType(resources.GetObject("FileToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.FileToolStripMenuItem.Text = "Buka File"
        '
        'MusikToolStripMenuItem
        '
        Me.MusikToolStripMenuItem.Image = CType(resources.GetObject("MusikToolStripMenuItem.Image"), System.Drawing.Image)
        Me.MusikToolStripMenuItem.Name = "MusikToolStripMenuItem"
        Me.MusikToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.MusikToolStripMenuItem.Text = "Musik"
        '
        'VideoToolStripMenuItem
        '
        Me.VideoToolStripMenuItem.Image = CType(resources.GetObject("VideoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VideoToolStripMenuItem.Name = "VideoToolStripMenuItem"
        Me.VideoToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.VideoToolStripMenuItem.Text = "Video"
        '
        'PengaturanToolStripMenuItem1
        '
        Me.PengaturanToolStripMenuItem1.Image = CType(resources.GetObject("PengaturanToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.PengaturanToolStripMenuItem1.Name = "PengaturanToolStripMenuItem1"
        Me.PengaturanToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.PengaturanToolStripMenuItem1.Text = "Pengaturan"
        '
        'BToolStripMenuItem
        '
        Me.BToolStripMenuItem.Image = CType(resources.GetObject("BToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BToolStripMenuItem.Name = "BToolStripMenuItem"
        Me.BToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.BToolStripMenuItem.Text = "Bantuan"
        '
        'KirimMasukanToolStripMenuItem1
        '
        Me.KirimMasukanToolStripMenuItem1.Image = CType(resources.GetObject("KirimMasukanToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.KirimMasukanToolStripMenuItem1.Name = "KirimMasukanToolStripMenuItem1"
        Me.KirimMasukanToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.KirimMasukanToolStripMenuItem1.Text = "Kirim Masukan"
        '
        'TentangBlueskyPlayerToolStripMenuItem
        '
        Me.TentangBlueskyPlayerToolStripMenuItem.Image = CType(resources.GetObject("TentangBlueskyPlayerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TentangBlueskyPlayerToolStripMenuItem.Name = "TentangBlueskyPlayerToolStripMenuItem"
        Me.TentangBlueskyPlayerToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.TentangBlueskyPlayerToolStripMenuItem.Text = "Tentang Bluesky Player"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Image = CType(resources.GetObject("KeluarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'TrackBar1
        '
        Me.TrackBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar1.Location = New System.Drawing.Point(898, 637)
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(106, 45)
        Me.TrackBar1.TabIndex = 21
        Me.TrackBar1.TickStyle = System.Windows.Forms.TickStyle.None
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 8.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(854, 639)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Volume"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(815, 556)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 40)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Bluesky Player Beta" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Version 1.3.51.160921-1810"
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(231, 657)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(45, 45)
        Me.Button5.TabIndex = 20
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Location = New System.Drawing.Point(180, 657)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(45, 45)
        Me.Button4.TabIndex = 19
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(129, 657)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(45, 45)
        Me.Button3.TabIndex = 18
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(78, 657)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(45, 45)
        Me.Button2.TabIndex = 17
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(12, 649)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 60)
        Me.Button1.TabIndex = 16
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 644)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1012, 71)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.bluesky_play.My.Resources.Resources.bigss
        Me.PictureBox2.Location = New System.Drawing.Point(929, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 40)
        Me.PictureBox2.TabIndex = 14
        Me.PictureBox2.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(12, 7)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(47, 45)
        Me.Button6.TabIndex = 24
        Me.Button6.Text = "Menu"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'AxWindowsMediaPlayer1
        '
        Me.AxWindowsMediaPlayer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxWindowsMediaPlayer1.Enabled = True
        Me.AxWindowsMediaPlayer1.Location = New System.Drawing.Point(0, 62)
        Me.AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        Me.AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWindowsMediaPlayer1.Size = New System.Drawing.Size(1012, 611)
        Me.AxWindowsMediaPlayer1.TabIndex = 0
        '
        'Form1
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1012, 716)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AxWindowsMediaPlayer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Bluesky Player"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxWindowsMediaPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MusikToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VideoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PengaturanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents BToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KirimMasukanToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TentangBlueskyPlayerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
