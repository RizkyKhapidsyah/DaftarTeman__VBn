<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTeman
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
        Me.listTeman = New System.Windows.Forms.ListBox()
        Me.tombolMasukkanNama = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'listTeman
        '
        Me.listTeman.FormattingEnabled = True
        Me.listTeman.Location = New System.Drawing.Point(13, 13)
        Me.listTeman.Name = "listTeman"
        Me.listTeman.Size = New System.Drawing.Size(204, 134)
        Me.listTeman.TabIndex = 0
        '
        'tombolMasukkanNama
        '
        Me.tombolMasukkanNama.Location = New System.Drawing.Point(12, 159)
        Me.tombolMasukkanNama.Name = "tombolMasukkanNama"
        Me.tombolMasukkanNama.Size = New System.Drawing.Size(94, 40)
        Me.tombolMasukkanNama.TabIndex = 1
        Me.tombolMasukkanNama.Text = "Masukkan Nama"
        Me.tombolMasukkanNama.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(123, 159)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(94, 40)
        Me.tombolKeluar.TabIndex = 2
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 212)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolMasukkanNama)
        Me.Controls.Add(Me.listTeman)
        Me.Name = "Form1"
        Me.Text = "Daftar Teman"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents listTeman As System.Windows.Forms.ListBox
    Friend WithEvents tombolMasukkanNama As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
