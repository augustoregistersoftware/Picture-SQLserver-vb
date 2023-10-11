<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.picImagem = New System.Windows.Forms.PictureBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnEscolher = New System.Windows.Forms.Button()
        Me.btnRecuperar = New System.Windows.Forms.Button()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picImagem
        '
        Me.picImagem.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.picImagem.Location = New System.Drawing.Point(84, 12)
        Me.picImagem.Name = "picImagem"
        Me.picImagem.Size = New System.Drawing.Size(399, 323)
        Me.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImagem.TabIndex = 0
        Me.picImagem.TabStop = False
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(84, 341)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(90, 23)
        Me.btnSalvar.TabIndex = 1
        Me.btnSalvar.Text = "Salvar Imagem"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(180, 341)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(86, 23)
        Me.btnAlterar.TabIndex = 2
        Me.btnAlterar.Text = "Alterar Imagem"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnEscolher
        '
        Me.btnEscolher.Location = New System.Drawing.Point(272, 341)
        Me.btnEscolher.Name = "btnEscolher"
        Me.btnEscolher.Size = New System.Drawing.Size(98, 23)
        Me.btnEscolher.TabIndex = 3
        Me.btnEscolher.Text = "Escolher Imagem"
        Me.btnEscolher.UseVisualStyleBackColor = True
        '
        'btnRecuperar
        '
        Me.btnRecuperar.Location = New System.Drawing.Point(376, 341)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(107, 23)
        Me.btnRecuperar.TabIndex = 4
        Me.btnRecuperar.Text = "Recuperar Imagem"
        Me.btnRecuperar.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(84, 399)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(78, 20)
        Me.txtCodigo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 380)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Código:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 463)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.btnRecuperar)
        Me.Controls.Add(Me.btnEscolher)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.picImagem)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picImagem As System.Windows.Forms.PictureBox
    Friend WithEvents btnSalvar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnEscolher As System.Windows.Forms.Button
    Friend WithEvents btnRecuperar As System.Windows.Forms.Button
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
