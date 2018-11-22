<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lab1
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
        Me.lblSalary = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.btnCaculate = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSalary
        '
        Me.lblSalary.Location = New System.Drawing.Point(60, 97)
        Me.lblSalary.Name = "lblSalary"
        Me.lblSalary.Size = New System.Drawing.Size(100, 23)
        Me.lblSalary.TabIndex = 0
        Me.lblSalary.Text = "เงินเดือน"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(60, 160)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "รายได้ทั้งปี"
        '
        'lblTax
        '
        Me.lblTax.Location = New System.Drawing.Point(60, 245)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 0
        Me.lblTax.Text = "รายได้หลังหักภาษี"
        '
        'txtSalary
        '
        Me.txtSalary.Location = New System.Drawing.Point(236, 94)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 20)
        Me.txtSalary.TabIndex = 1
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(236, 172)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 2
        '
        'txtTax
        '
        Me.txtTax.Location = New System.Drawing.Point(236, 248)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(100, 20)
        Me.txtTax.TabIndex = 2
        '
        'btnCaculate
        '
        Me.btnCaculate.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnCaculate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCaculate.Location = New System.Drawing.Point(63, 362)
        Me.btnCaculate.Name = "btnCaculate"
        Me.btnCaculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCaculate.TabIndex = 3
        Me.btnCaculate.Text = "คำนวณ"
        Me.btnCaculate.UseVisualStyleBackColor = False
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnClose.Location = New System.Drawing.Point(261, 362)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "ปิด"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Lab1"
        '
        'Lab1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCaculate)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblSalary)
        Me.Name = "Lab1"
        Me.Text = "รายได้รวม"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSalary As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents btnCaculate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents Label1 As Label
End Class
