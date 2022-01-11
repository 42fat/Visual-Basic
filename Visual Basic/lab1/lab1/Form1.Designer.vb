<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gen_pass = New System.Windows.Forms.Button()
        Me.indificate = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(100, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Индефикатор"
        '
        'gen_pass
        '
        Me.gen_pass.Location = New System.Drawing.Point(105, 304)
        Me.gen_pass.Name = "gen_pass"
        Me.gen_pass.Size = New System.Drawing.Size(167, 32)
        Me.gen_pass.TabIndex = 1
        Me.gen_pass.Text = "Сформировать пароль"
        Me.gen_pass.UseVisualStyleBackColor = True
        '
        'indificate
        '
        Me.indificate.Location = New System.Drawing.Point(311, 109)
        Me.indificate.Multiline = True
        Me.indificate.Name = "indificate"
        Me.indificate.Size = New System.Drawing.Size(319, 29)
        Me.indificate.TabIndex = 2
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(301, 304)
        Me.password.Multiline = True
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(329, 32)
        Me.password.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.indificate)
        Me.Controls.Add(Me.gen_pass)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gen_pass As Button
    Friend WithEvents indificate As TextBox
    Friend WithEvents password As TextBox
End Class
