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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.lblPapar1 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.lblPapar2 = New System.Windows.Forms.Label()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.lblPapar3 = New System.Windows.Forms.Label()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.lblPapar4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(196, 76)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(94, 29)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Button1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lblPapar1
        '
        Me.lblPapar1.AutoSize = True
        Me.lblPapar1.Location = New System.Drawing.Point(381, 80)
        Me.lblPapar1.Name = "lblPapar1"
        Me.lblPapar1.Size = New System.Drawing.Size(53, 20)
        Me.lblPapar1.TabIndex = 1
        Me.lblPapar1.Text = "Label1"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(12, 168)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(125, 27)
        Me.txt1.TabIndex = 2
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(196, 166)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(94, 29)
        Me.btn2.TabIndex = 3
        Me.btn2.Text = "Button2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'lblPapar2
        '
        Me.lblPapar2.AutoSize = True
        Me.lblPapar2.Location = New System.Drawing.Point(381, 168)
        Me.lblPapar2.Name = "lblPapar2"
        Me.lblPapar2.Size = New System.Drawing.Size(53, 20)
        Me.lblPapar2.TabIndex = 4
        Me.lblPapar2.Text = "Label2"
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(196, 254)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(94, 29)
        Me.btn3.TabIndex = 5
        Me.btn3.Text = "Button3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'lblPapar3
        '
        Me.lblPapar3.AutoSize = True
        Me.lblPapar3.Location = New System.Drawing.Point(381, 254)
        Me.lblPapar3.Name = "lblPapar3"
        Me.lblPapar3.Size = New System.Drawing.Size(53, 20)
        Me.lblPapar3.TabIndex = 6
        Me.lblPapar3.Text = "Label3"
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(12, 336)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(125, 27)
        Me.txt2.TabIndex = 7
        '
        'btn4
        '
        Me.btn4.Location = New System.Drawing.Point(196, 333)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(94, 29)
        Me.btn4.TabIndex = 8
        Me.btn4.Text = "Button4"
        Me.btn4.UseVisualStyleBackColor = True
        '
        'lblPapar4
        '
        Me.lblPapar4.AutoSize = True
        Me.lblPapar4.Location = New System.Drawing.Point(381, 333)
        Me.lblPapar4.Name = "lblPapar4"
        Me.lblPapar4.Size = New System.Drawing.Size(53, 20)
        Me.lblPapar4.TabIndex = 9
        Me.lblPapar4.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblPapar4)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.lblPapar3)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.lblPapar2)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.lblPapar1)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents lblPapar1 As Label
    Friend WithEvents txt1 As TextBox
    Friend WithEvents btn2 As Button
    Friend WithEvents lblPapar2 As Label
    Friend WithEvents btn3 As Button
    Friend WithEvents lblPapar3 As Label
    Friend WithEvents txt2 As TextBox
    Friend WithEvents btn4 As Button
    Friend WithEvents lblPapar4 As Label
End Class
