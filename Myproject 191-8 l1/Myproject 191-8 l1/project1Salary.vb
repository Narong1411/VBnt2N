Public Class Lab1
    Private Sub Lab1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSalary.TextChanged

    End Sub

    Private Sub btnCaculate_Click(sender As Object, e As EventArgs) Handles btnCaculate.Click
        Dim salay, total As Integer
        Dim tax As Double
        salay = Val(txtSalary.Text)

        total = salay * 12
        txtTotal.Text = total

        tax = total * 0.05
        txtTax.Text = total - tax



    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class