Public Class LayangLayang

    Private Sub txtDiagonal1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiagonal1.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtDiagonal1.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtDiagonal2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiagonal2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtDiagonal2.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSisi1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSisi1.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtSisi1.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSisi2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSisi2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtSisi2.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtDiagonal1.Text.Trim() = "" Or txtDiagonal2.Text.Trim() = "" Then
                MessageBox.Show("Masukkan nilai diagonal1 dan diagonal2 terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim diagonal1 As Double = Convert.ToDouble(txtDiagonal1.Text)
            Dim diagonal2 As Double = Convert.ToDouble(txtDiagonal2.Text)

            Dim luas As Double = 0.5 * diagonal1 * diagonal2

            lbLuas.Text = "Hasil : " & Math.Round(luas, 2) & " satuan²"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtDiagonal1.Clear()
            txtDiagonal2.Clear()
            txtDiagonal1.Focus()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtSisi1.Text.Trim() = "" Or txtSisi2.Text.Trim() = "" Then
                MessageBox.Show("Masukkan nilai sisi1 dan sisi2 terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim sisi1 As Double = Convert.ToDouble(txtSisi1.Text)
            Dim sisi2 As Double = Convert.ToDouble(txtSisi2.Text)

            Dim keliling As Double = 2 * (sisi1 + sisi2)

            lbKeliling.Text = "Hasil : " & Math.Round(keliling, 2) & " satuan"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSisi1.Clear()
            txtSisi2.Clear()
            txtSisi1.Focus()
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BangunDatar.Show()
        Me.Close()
    End Sub
End Class