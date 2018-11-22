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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.lblPayrate = New System.Windows.Forms.Label()
        Me.lblS = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnCalculate1 = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtHours = New System.Windows.Forms.TextBox()
        Me.txtPayrate = New System.Windows.Forms.TextBox()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.btnCalculate2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(95, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรเเกรมตัวอย่างการคิดค่าเเรง"
        '
        'lblHours
        '
        Me.lblHours.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblHours.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHours.ForeColor = System.Drawing.Color.Blue
        Me.lblHours.Location = New System.Drawing.Point(100, 118)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(137, 23)
        Me.lblHours.TabIndex = 1
        Me.lblHours.Text = "ชั่วโมงการทำงาน"
        '
        'lblPayrate
        '
        Me.lblPayrate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPayrate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPayrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayrate.ForeColor = System.Drawing.Color.Blue
        Me.lblPayrate.Location = New System.Drawing.Point(100, 174)
        Me.lblPayrate.Name = "lblPayrate"
        Me.lblPayrate.Size = New System.Drawing.Size(137, 23)
        Me.lblPayrate.TabIndex = 1
        Me.lblPayrate.Text = "อัตราค่าจ้างต่อชั่วโมง"
        '
        'lblS
        '
        Me.lblS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblS.ForeColor = System.Drawing.Color.Blue
        Me.lblS.Location = New System.Drawing.Point(100, 230)
        Me.lblS.Name = "lblS"
        Me.lblS.Size = New System.Drawing.Size(137, 23)
        Me.lblS.TabIndex = 1
        Me.lblS.Text = "คิดเป็นเงิน"
        '
        'lblA
        '
        Me.lblA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.ForeColor = System.Drawing.Color.Blue
        Me.lblA.Location = New System.Drawing.Point(100, 282)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(137, 23)
        Me.lblA.TabIndex = 1
        Me.lblA.Text = "หักภาษี ณ ที่จ่าย"
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Blue
        Me.lblTotal.Location = New System.Drawing.Point(291, 230)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 2
        '
        'btnCalculate1
        '
        Me.btnCalculate1.BackColor = System.Drawing.Color.MediumPurple
        Me.btnCalculate1.Location = New System.Drawing.Point(113, 372)
        Me.btnCalculate1.Name = "btnCalculate1"
        Me.btnCalculate1.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate1.TabIndex = 4
        Me.btnCalculate1.Text = "คำนวณ"
        Me.btnCalculate1.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(304, 372)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "ปิด"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'txtHours
        '
        Me.txtHours.Location = New System.Drawing.Point(291, 118)
        Me.txtHours.Name = "txtHours"
        Me.txtHours.Size = New System.Drawing.Size(100, 20)
        Me.txtHours.TabIndex = 0
        '
        'txtPayrate
        '
        Me.txtPayrate.Location = New System.Drawing.Point(291, 174)
        Me.txtPayrate.Name = "txtPayrate"
        Me.txtPayrate.Size = New System.Drawing.Size(100, 20)
        Me.txtPayrate.TabIndex = 1
        '
        'lblTax
        '
        Me.lblTax.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.ForeColor = System.Drawing.Color.Blue
        Me.lblTax.Location = New System.Drawing.Point(291, 282)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 3
        '
        'btnCalculate2
        '
        Me.btnCalculate2.BackColor = System.Drawing.Color.MediumPurple
        Me.btnCalculate2.Location = New System.Drawing.Point(209, 372)
        Me.btnCalculate2.Name = "btnCalculate2"
        Me.btnCalculate2.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate2.TabIndex = 4
        Me.btnCalculate2.Text = "คำนวณ2"
        Me.btnCalculate2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 450)
        Me.Controls.Add(Me.txtPayrate)
        Me.Controls.Add(Me.txtHours)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCalculate2)
        Me.Controls.Add(Me.btnCalculate1)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblS)
        Me.Controls.Add(Me.lblPayrate)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblHours)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblHours As Label
    Friend WithEvents lblPayrate As Label
    Friend WithEvents lblS As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnCalculate1 As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtHours As TextBox
    Friend WithEvents txtPayrate As TextBox
    Friend WithEvents lblTax As Label
    Friend WithEvents btnCalculate2 As Button
End Class
