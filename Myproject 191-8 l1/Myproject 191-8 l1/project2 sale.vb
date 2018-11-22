Public Class Lab2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vista, computer, total, ComVista, ComComputer, ComTotal
        vista = Val(txtVistra.Text)
        computer = Val(txtComputer.Text)

        total = vista + computer
        ComVista = vista * 0.05
        ComComputer = computer * 0.1
        ComTotal = ComVista * ComComputer


        lblTotalVC.Text = total
        lblComV.Text = ComVista
        lblComC.Text = ComComputer
        lblComTotal.Text = ComVista + ComComputer










    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class