Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles lblTotal.Click, lblTax.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate1.Click
        lblTotal.Text = Val(txtHours.Text) * Val(txtPayrate.Text)
        lblTax.Text = Val(lblTotal.Text) * 3 / 100


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnCalculate2.Click
        Dim houre As Integer
        Dim payRate, total, tax As Double
        houre = Val(txtHours.Text)
        payRate = Val(txtPayrate.Text)


        total = houre * payRate
        tax = total * 0.03

        lblTotal.Text = total
        lblTax.Text = tax

    End Sub
End Class
