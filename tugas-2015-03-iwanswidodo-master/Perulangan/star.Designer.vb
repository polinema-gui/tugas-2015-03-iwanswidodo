<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STARS
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
        Me.Cb_gambar = New System.Windows.Forms.ComboBox()
        Me.tb_correct = New System.Windows.Forms.TextBox()
        Me.generate = New System.Windows.Forms.Button()
        Me.Tb_urut = New System.Windows.Forms.TextBox()
        Me.Lbl_baris = New System.Windows.Forms.Label()
        Me.Lbl_pola = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cb_gambar
        '
        Me.Cb_gambar.FormattingEnabled = True
        Me.Cb_gambar.Items.AddRange(New Object() {"Segitiga", "Segitiga_Bolong", "Segitiga_Kebalik", "Segitiga_Kebalik_Bolong"})
        Me.Cb_gambar.Location = New System.Drawing.Point(59, 11)
        Me.Cb_gambar.Name = "Cb_gambar"
        Me.Cb_gambar.Size = New System.Drawing.Size(386, 21)
        Me.Cb_gambar.TabIndex = 7
        Me.Cb_gambar.Text = "pilih dulu polanya....."
        '
        'tb_correct
        '
        Me.tb_correct.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_correct.Location = New System.Drawing.Point(22, 108)
        Me.tb_correct.Multiline = True
        Me.tb_correct.Name = "tb_correct"
        Me.tb_correct.ReadOnly = True
        Me.tb_correct.Size = New System.Drawing.Size(423, 305)
        Me.tb_correct.TabIndex = 11
        '
        'generate
        '
        Me.generate.Location = New System.Drawing.Point(331, 60)
        Me.generate.Name = "generate"
        Me.generate.Size = New System.Drawing.Size(114, 23)
        Me.generate.TabIndex = 10
        Me.generate.Text = "Proses"
        Me.generate.UseVisualStyleBackColor = True
        '
        'Tb_urut
        '
        Me.Tb_urut.CausesValidation = False
        Me.Tb_urut.Location = New System.Drawing.Point(59, 62)
        Me.Tb_urut.Name = "Tb_urut"
        Me.Tb_urut.Size = New System.Drawing.Size(266, 20)
        Me.Tb_urut.TabIndex = 9
        Me.Tb_urut.Text = "masukkin angka ya...."
        '
        'Lbl_baris
        '
        Me.Lbl_baris.AutoSize = True
        Me.Lbl_baris.Location = New System.Drawing.Point(19, 65)
        Me.Lbl_baris.Name = "Lbl_baris"
        Me.Lbl_baris.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_baris.TabIndex = 8
        Me.Lbl_baris.Text = "Baris :"
        '
        'Lbl_pola
        '
        Me.Lbl_pola.AutoSize = True
        Me.Lbl_pola.Location = New System.Drawing.Point(19, 19)
        Me.Lbl_pola.Name = "Lbl_pola"
        Me.Lbl_pola.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_pola.TabIndex = 6
        Me.Lbl_pola.Text = "Pola :"
        '
        'STARS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.Cb_gambar)
        Me.Controls.Add(Me.tb_correct)
        Me.Controls.Add(Me.generate)
        Me.Controls.Add(Me.Tb_urut)
        Me.Controls.Add(Me.Lbl_baris)
        Me.Controls.Add(Me.Lbl_pola)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "STARS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cb_gambar As System.Windows.Forms.ComboBox
    Friend WithEvents tb_correct As System.Windows.Forms.TextBox
    Friend WithEvents generate As System.Windows.Forms.Button
    Friend WithEvents Tb_urut As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_baris As System.Windows.Forms.Label
    Friend WithEvents Lbl_pola As System.Windows.Forms.Label
End Class
