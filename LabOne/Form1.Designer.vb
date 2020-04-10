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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(150, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(325, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Experiment with These Controls!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "You selected:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(465, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "You selected:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 372)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "You selected:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(272, 372)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Move the Scroll Bar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(292, 425)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Cat", "Dog", "Elephant"})
        Me.ComboBox1.Location = New System.Drawing.Point(15, 26)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "Choose a Pet"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ComboBox"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(229, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CheckBox"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(15, 29)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(170, 17)
        Me.CheckBox1.TabIndex = 5
        Me.CheckBox1.Text = "The Check Box is un-checked"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(455, 74)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ListBox"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Beans", "Broccoli", "Carrots", "Lettuce", "Margaritas"})
        Me.ListBox1.Location = New System.Drawing.Point(6, 26)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(76, 56)
        Me.ListBox1.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton3)
        Me.GroupBox4.Controls.Add(Me.RadioButton2)
        Me.GroupBox4.Controls.Add(Me.RadioButton1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 255)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "RadioButtons"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(15, 76)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton3.TabIndex = 12
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Option 3"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(15, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton2.TabIndex = 11
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Option 2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 28)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton1.TabIndex = 10
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Option 1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.HScrollBar1)
        Me.GroupBox5.Location = New System.Drawing.Point(229, 255)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox5.TabIndex = 14
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "HScrollBar"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(7, 28)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(80, 17)
        Me.HScrollBar1.TabIndex = 15
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.VScrollBar1)
        Me.GroupBox6.Location = New System.Drawing.Point(455, 255)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "VScrollBar"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(74, 16)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(17, 80)
        Me.VScrollBar1.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(496, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Move the Scroll Bar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(672, 463)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Controls Demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents Label6 As Label
End Class
