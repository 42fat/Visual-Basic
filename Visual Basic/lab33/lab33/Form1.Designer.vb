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
        Me.P_box = New System.Windows.Forms.TextBox()
        Me.V_box = New System.Windows.Forms.TextBox()
        Me.T_box = New System.Windows.Forms.TextBox()
        Me.P = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.S = New System.Windows.Forms.Label()
        Me.A = New System.Windows.Forms.Label()
        Me.L = New System.Windows.Forms.Label()
        Me.gen_pass = New System.Windows.Forms.Button()
        Me.ru_up = New System.Windows.Forms.CheckBox()
        Me.en_up = New System.Windows.Forms.CheckBox()
        Me.en_dw = New System.Windows.Forms.CheckBox()
        Me.ru_dw = New System.Windows.Forms.CheckBox()
        Me.ch = New System.Windows.Forms.CheckBox()
        Me.number = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.res = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'P_box
        '
        Me.P_box.Location = New System.Drawing.Point(278, 47)
        Me.P_box.Name = "P_box"
        Me.P_box.Size = New System.Drawing.Size(181, 22)
        Me.P_box.TabIndex = 0
        '
        'V_box
        '
        Me.V_box.Location = New System.Drawing.Point(278, 100)
        Me.V_box.Name = "V_box"
        Me.V_box.Size = New System.Drawing.Size(181, 22)
        Me.V_box.TabIndex = 1
        '
        'T_box
        '
        Me.T_box.Location = New System.Drawing.Point(278, 148)
        Me.T_box.Name = "T_box"
        Me.T_box.Size = New System.Drawing.Size(181, 22)
        Me.T_box.TabIndex = 2
        '
        'P
        '
        Me.P.AutoSize = True
        Me.P.Location = New System.Drawing.Point(12, 52)
        Me.P.Name = "P"
        Me.P.Size = New System.Drawing.Size(110, 17)
        Me.P.TabIndex = 3
        Me.P.Text = "P(вероятность)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "V(скорость перебора паролей в день)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "T(срок действия в днях)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "S*(нижняя граница паролей)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "А(мощность алфавита)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "L(длина пароля)"
        '
        'S
        '
        Me.S.AutoSize = True
        Me.S.Location = New System.Drawing.Point(233, 217)
        Me.S.Name = "S"
        Me.S.Size = New System.Drawing.Size(16, 17)
        Me.S.TabIndex = 9
        Me.S.Text = "0"
        '
        'A
        '
        Me.A.AutoSize = True
        Me.A.Location = New System.Drawing.Point(233, 259)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(16, 17)
        Me.A.TabIndex = 10
        Me.A.Text = "0"
        '
        'L
        '
        Me.L.AutoSize = True
        Me.L.Location = New System.Drawing.Point(233, 298)
        Me.L.Name = "L"
        Me.L.Size = New System.Drawing.Size(16, 17)
        Me.L.TabIndex = 11
        Me.L.Text = "0"
        '
        'gen_pass
        '
        Me.gen_pass.Location = New System.Drawing.Point(15, 432)
        Me.gen_pass.Name = "gen_pass"
        Me.gen_pass.Size = New System.Drawing.Size(139, 67)
        Me.gen_pass.TabIndex = 12
        Me.gen_pass.Text = "Сформировать пароль"
        Me.gen_pass.UseVisualStyleBackColor = True
        '
        'ru_up
        '
        Me.ru_up.AutoSize = True
        Me.ru_up.Location = New System.Drawing.Point(628, 129)
        Me.ru_up.Name = "ru_up"
        Me.ru_up.Size = New System.Drawing.Size(153, 21)
        Me.ru_up.TabIndex = 13
        Me.ru_up.Text = "Руссикие большие"
        Me.ru_up.UseVisualStyleBackColor = True
        '
        'en_up
        '
        Me.en_up.AutoSize = True
        Me.en_up.Location = New System.Drawing.Point(628, 47)
        Me.en_up.Name = "en_up"
        Me.en_up.Size = New System.Drawing.Size(167, 21)
        Me.en_up.TabIndex = 14
        Me.en_up.Text = "Латинсике большие "
        Me.en_up.UseVisualStyleBackColor = True
        '
        'en_dw
        '
        Me.en_dw.AutoSize = True
        Me.en_dw.Location = New System.Drawing.Point(628, 85)
        Me.en_dw.Name = "en_dw"
        Me.en_dw.Size = New System.Drawing.Size(169, 21)
        Me.en_dw.TabIndex = 15
        Me.en_dw.Text = "Латинсие маленькие"
        Me.en_dw.UseVisualStyleBackColor = True
        '
        'ru_dw
        '
        Me.ru_dw.AutoSize = True
        Me.ru_dw.Location = New System.Drawing.Point(628, 174)
        Me.ru_dw.Name = "ru_dw"
        Me.ru_dw.Size = New System.Drawing.Size(166, 21)
        Me.ru_dw.TabIndex = 16
        Me.ru_dw.Text = "Руссикие маленькие"
        Me.ru_dw.UseVisualStyleBackColor = True
        '
        'ch
        '
        Me.ch.AutoSize = True
        Me.ch.Location = New System.Drawing.Point(628, 217)
        Me.ch.Name = "ch"
        Me.ch.Size = New System.Drawing.Size(89, 21)
        Me.ch.TabIndex = 17
        Me.ch.Text = "Символы"
        Me.ch.UseVisualStyleBackColor = True
        '
        'number
        '
        Me.number.AutoSize = True
        Me.number.Location = New System.Drawing.Point(628, 255)
        Me.number.Name = "number"
        Me.number.Size = New System.Drawing.Size(78, 21)
        Me.number.TabIndex = 18
        Me.number.Text = "Цифры"
        Me.number.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(219, 457)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Пароль :"
        '
        'res
        '
        Me.res.AutoSize = True
        Me.res.Location = New System.Drawing.Point(340, 466)
        Me.res.Name = "res"
        Me.res.Size = New System.Drawing.Size(0, 17)
        Me.res.TabIndex = 20
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 552)
        Me.Controls.Add(Me.res)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.number)
        Me.Controls.Add(Me.ch)
        Me.Controls.Add(Me.ru_dw)
        Me.Controls.Add(Me.en_dw)
        Me.Controls.Add(Me.en_up)
        Me.Controls.Add(Me.ru_up)
        Me.Controls.Add(Me.gen_pass)
        Me.Controls.Add(Me.L)
        Me.Controls.Add(Me.A)
        Me.Controls.Add(Me.S)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.P)
        Me.Controls.Add(Me.T_box)
        Me.Controls.Add(Me.V_box)
        Me.Controls.Add(Me.P_box)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents P_box As TextBox
    Friend WithEvents V_box As TextBox
    Friend WithEvents T_box As TextBox
    Friend WithEvents P As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents S As Label
    Friend WithEvents A As Label
    Friend WithEvents L As Label
    Friend WithEvents gen_pass As Button
    Friend WithEvents ru_up As CheckBox
    Friend WithEvents en_up As CheckBox
    Friend WithEvents en_dw As CheckBox
    Friend WithEvents ru_dw As CheckBox
    Friend WithEvents ch As CheckBox
    Friend WithEvents number As CheckBox
    Friend WithEvents Label6 As Label
    Friend WithEvents res As Label
End Class
