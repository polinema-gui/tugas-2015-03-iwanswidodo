<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DERET
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
        Me.generate_btn = New System.Windows.Forms.Button()
        Me.Lbl_hasil = New System.Windows.Forms.Label()
        Me.Txb_hasil = New System.Windows.Forms.TextBox()
        Me.Tb_matrik2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cb_aritmatika = New System.Windows.Forms.ComboBox()
        Me.Lbl_operasi = New System.Windows.Forms.Label()
        Me.Tb_matrik1 = New System.Windows.Forms.TextBox()
        Me.Lbl_matrik1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'generate_btn
        '
        Me.generate_btn.Location = New System.Drawing.Point(307, 355)
        Me.generate_btn.Name = "generate_btn"
        Me.generate_btn.Size = New System.Drawing.Size(122, 23)
        Me.generate_btn.TabIndex = 17
        Me.generate_btn.Text = "Proses"
        Me.generate_btn.UseVisualStyleBackColor = True
        '
        'Lbl_hasil
        '
        Me.Lbl_hasil.AutoSize = True
        Me.Lbl_hasil.Location = New System.Drawing.Point(12, 267)
        Me.Lbl_hasil.Name = "Lbl_hasil"
        Me.Lbl_hasil.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_hasil.TabIndex = 16
        Me.Lbl_hasil.Text = "Hasil"
        '
        'Txb_hasil
        '
        Me.Txb_hasil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txb_hasil.Location = New System.Drawing.Point(61, 264)
        Me.Txb_hasil.Multiline = True
        Me.Txb_hasil.Name = "Txb_hasil"
        Me.Txb_hasil.Size = New System.Drawing.Size(368, 76)
        Me.Txb_hasil.TabIndex = 15
        '
        'Tb_matrik2
        '
        Me.Tb_matrik2.Location = New System.Drawing.Point(63, 169)
        Me.Tb_matrik2.Multiline = True
        Me.Tb_matrik2.Name = "Tb_matrik2"
        Me.Tb_matrik2.Size = New System.Drawing.Size(368, 76)
        Me.Tb_matrik2.TabIndex = 14
        Me.Tb_matrik2.Text = "masukkan angka kedua"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Matrik 2"
        '
        'cb_aritmatika
        '
        Me.cb_aritmatika.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_aritmatika.FormattingEnabled = True
        Me.cb_aritmatika.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.cb_aritmatika.Location = New System.Drawing.Point(61, 122)
        Me.cb_aritmatika.Name = "cb_aritmatika"
        Me.cb_aritmatika.Size = New System.Drawing.Size(368, 21)
        Me.cb_aritmatika.TabIndex = 12
        '
        'Lbl_operasi
        '
        Me.Lbl_operasi.AutoSize = True
        Me.Lbl_operasi.Location = New System.Drawing.Point(12, 125)
        Me.Lbl_operasi.Name = "Lbl_operasi"
        Me.Lbl_operasi.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_operasi.TabIndex = 11
        Me.Lbl_operasi.Text = "Operasi"
        '
        'Tb_matrik1
        '
        Me.Tb_matrik1.Location = New System.Drawing.Point(61, 24)
        Me.Tb_matrik1.Multiline = True
        Me.Tb_matrik1.Name = "Tb_matrik1"
        Me.Tb_matrik1.Size = New System.Drawing.Size(368, 76)
        Me.Tb_matrik1.TabIndex = 10
        Me.Tb_matrik1.Text = "masukkan angkanya"
        '
        'Lbl_matrik1
        '
        Me.Lbl_matrik1.AutoSize = True
        Me.Lbl_matrik1.Location = New System.Drawing.Point(13, 27)
        Me.Lbl_matrik1.Name = "Lbl_matrik1"
        Me.Lbl_matrik1.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_matrik1.TabIndex = 9
        Me.Lbl_matrik1.Text = "Matrik1"
        '
        'DERET
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.generate_btn)
        Me.Controls.Add(Me.Lbl_hasil)
        Me.Controls.Add(Me.Txb_hasil)
        Me.Controls.Add(Me.Tb_matrik2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cb_aritmatika)
        Me.Controls.Add(Me.Lbl_operasi)
        Me.Controls.Add(Me.Tb_matrik1)
        Me.Controls.Add(Me.Lbl_matrik1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "DERET"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents generate_btn As System.Windows.Forms.Button
    Friend WithEvents Lbl_hasil As System.Windows.Forms.Label
    Friend WithEvents Txb_hasil As System.Windows.Forms.TextBox
    Friend WithEvents Tb_matrik2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cb_aritmatika As System.Windows.Forms.ComboBox
    Friend WithEvents Lbl_operasi As System.Windows.Forms.Label
    Friend WithEvents Tb_matrik1 As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_matrik1 As System.Windows.Forms.Label
End Class
