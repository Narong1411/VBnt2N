<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lab2
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
        Me.lblVista = New System.Windows.Forms.Label()
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.lblAll = New System.Windows.Forms.Label()
        Me.lblComittionVistra = New System.Windows.Forms.Label()
        Me.lblCommittonComputer = New System.Windows.Forms.Label()
        Me.lblCommittionTotal = New System.Windows.Forms.Label()
        Me.txtVistra = New System.Windows.Forms.TextBox()
        Me.txtComputer = New System.Windows.Forms.TextBox()
        Me.lblTotalVC = New System.Windows.Forms.Label()
        Me.lblComV = New System.Windows.Forms.Label()
        Me.lblComC = New System.Windows.Forms.Label()
        Me.lblComTotal = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblLab2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblVista
        '
        Me.lblVista.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblVista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVista.Location = New System.Drawing.Point(43, 64)
        Me.lblVista.Name = "lblVista"
        Me.lblVista.Size = New System.Drawing.Size(215, 26)
        Me.lblVista.TabIndex = 0
        Me.lblVista.Text = "ยอดขาย(Vistra Gluta )"
        '
        'lblComputer
        '
        Me.lblComputer.BackColor = System.Drawing.Color.PaleTurquoise
        Me.lblComputer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputer.Location = New System.Drawing.Point(43, 123)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(215, 23)
        Me.lblComputer.TabIndex = 0
        Me.lblComputer.Text = "ยอดขาย(Computer Toshiba Extra520x)"
        '
        'lblAll
        '
        Me.lblAll.BackColor = System.Drawing.Color.MintCream
        Me.lblAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAll.Location = New System.Drawing.Point(43, 177)
        Me.lblAll.Name = "lblAll"
        Me.lblAll.Size = New System.Drawing.Size(215, 23)
        Me.lblAll.TabIndex = 0
        Me.lblAll.Text = "ยอดขายรวม"
        '
        'lblComittionVistra
        '
        Me.lblComittionVistra.BackColor = System.Drawing.Color.MintCream
        Me.lblComittionVistra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblComittionVistra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComittionVistra.Location = New System.Drawing.Point(43, 241)
        Me.lblComittionVistra.Name = "lblComittionVistra"
        Me.lblComittionVistra.Size = New System.Drawing.Size(215, 23)
        Me.lblComittionVistra.TabIndex = 0
        Me.lblComittionVistra.Text = "คอมมิชชั่น(Vistra Gluta )"
        '
        'lblCommittonComputer
        '
        Me.lblCommittonComputer.BackColor = System.Drawing.Color.MintCream
        Me.lblCommittonComputer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommittonComputer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommittonComputer.Location = New System.Drawing.Point(43, 299)
        Me.lblCommittonComputer.Name = "lblCommittonComputer"
        Me.lblCommittonComputer.Size = New System.Drawing.Size(215, 23)
        Me.lblCommittonComputer.TabIndex = 0
        Me.lblCommittonComputer.Text = "คอมมิชชั่น(Computer Toshiba) "
        '
        'lblCommittionTotal
        '
        Me.lblCommittionTotal.BackColor = System.Drawing.Color.MintCream
        Me.lblCommittionTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCommittionTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCommittionTotal.Location = New System.Drawing.Point(43, 353)
        Me.lblCommittionTotal.Name = "lblCommittionTotal"
        Me.lblCommittionTotal.Size = New System.Drawing.Size(215, 23)
        Me.lblCommittionTotal.TabIndex = 0
        Me.lblCommittionTotal.Text = "คอมมิชชั่นรวม"
        '
        'txtVistra
        '
        Me.txtVistra.Location = New System.Drawing.Point(342, 64)
        Me.txtVistra.Name = "txtVistra"
        Me.txtVistra.Size = New System.Drawing.Size(182, 20)
        Me.txtVistra.TabIndex = 1
        '
        'txtComputer
        '
        Me.txtComputer.Location = New System.Drawing.Point(342, 123)
        Me.txtComputer.Name = "txtComputer"
        Me.txtComputer.Size = New System.Drawing.Size(182, 20)
        Me.txtComputer.TabIndex = 1
        '
        'lblTotalVC
        '
        Me.lblTotalVC.AutoSize = True
        Me.lblTotalVC.Location = New System.Drawing.Point(339, 180)
        Me.lblTotalVC.Name = "lblTotalVC"
        Me.lblTotalVC.Size = New System.Drawing.Size(46, 13)
        Me.lblTotalVC.TabIndex = 2
        Me.lblTotalVC.Text = "............."
        '
        'lblComV
        '
        Me.lblComV.AutoSize = True
        Me.lblComV.Location = New System.Drawing.Point(339, 244)
        Me.lblComV.Name = "lblComV"
        Me.lblComV.Size = New System.Drawing.Size(37, 13)
        Me.lblComV.TabIndex = 2
        Me.lblComV.Text = ".........."
        '
        'lblComC
        '
        Me.lblComC.AutoSize = True
        Me.lblComC.Location = New System.Drawing.Point(339, 299)
        Me.lblComC.Name = "lblComC"
        Me.lblComC.Size = New System.Drawing.Size(31, 13)
        Me.lblComC.TabIndex = 2
        Me.lblComC.Text = "........"
        '
        'lblComTotal
        '
        Me.lblComTotal.AutoSize = True
        Me.lblComTotal.Location = New System.Drawing.Point(339, 356)
        Me.lblComTotal.Name = "lblComTotal"
        Me.lblComTotal.Size = New System.Drawing.Size(37, 13)
        Me.lblComTotal.TabIndex = 2
        Me.lblComTotal.Text = ".........."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(189, 404)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "คำนวณ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(342, 404)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "ปิด"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'lblLab2
        '
        Me.lblLab2.AutoSize = True
        Me.lblLab2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLab2.Location = New System.Drawing.Point(247, 9)
        Me.lblLab2.Name = "lblLab2"
        Me.lblLab2.Size = New System.Drawing.Size(64, 25)
        Me.lblLab2.TabIndex = 4
        Me.lblLab2.Text = "Lab2"
        '
        'Lab2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(571, 475)
        Me.Controls.Add(Me.lblLab2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblComTotal)
        Me.Controls.Add(Me.lblComC)
        Me.Controls.Add(Me.lblComV)
        Me.Controls.Add(Me.lblTotalVC)
        Me.Controls.Add(Me.txtComputer)
        Me.Controls.Add(Me.txtVistra)
        Me.Controls.Add(Me.lblCommittionTotal)
        Me.Controls.Add(Me.lblCommittonComputer)
        Me.Controls.Add(Me.lblComittionVistra)
        Me.Controls.Add(Me.lblAll)
        Me.Controls.Add(Me.lblComputer)
        Me.Controls.Add(Me.lblVista)
        Me.Name = "Lab2"
        Me.Text = "Lab2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVista As Label
    Friend WithEvents lblComputer As Label
    Friend WithEvents lblAll As Label
    Friend WithEvents lblComittionVistra As Label
    Friend WithEvents lblCommittonComputer As Label
    Friend WithEvents lblCommittionTotal As Label
    Friend WithEvents txtVistra As TextBox
    Friend WithEvents txtComputer As TextBox
    Friend WithEvents lblTotalVC As Label
    Friend WithEvents lblComV As Label
    Friend WithEvents lblComC As Label
    Friend WithEvents lblComTotal As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblLab2 As Label
End Class
