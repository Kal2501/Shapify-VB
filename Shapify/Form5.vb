Public Class Lingkaran

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BangunDatar.Show()
        Me.Close()
    End Sub

    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Try
            If txtJariJari.Text.Trim() = "" Then
                MessageBox.Show("Masukkan nilai jari-jari terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtJariJari.Focus()
                Exit Sub
            End If

            Dim jariJari As Double = Convert.ToDouble(txtJariJari.Text)

            Dim luas As Double = Math.PI * Math.Pow(jariJari, 2)

            lbHasil.Text = "Hasil : " & Math.Round(luas, 2).ToString() & " satuan²"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka yang benar (contoh: 12.5)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtJariJari.Clear()
            txtJariJari.Focus()
        End Try
    End Sub

    Private Sub txtJariJari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJariJari.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtJariJari.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    
    Private Sub txtDiameter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDiameter.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtJariJari.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnHitung2_Click(sender As Object, e As EventArgs) Handles btnHitung2.Click
        Try
            If txtJariJari.Text.Trim() = "" Then
                MessageBox.Show("Masukkan nilai jari-jari terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtJariJari.Focus()
                Exit Sub
            End If

            Dim jariJari As Double = Convert.ToDouble(txtJariJari.Text)

            Dim diameter As Double = 2 * jariJari

            lbHasil2.Text = "Hasil : " & Math.Round(diameter, 2).ToString()

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtJariJari.Clear()
            txtJariJari.Focus()
        End Try
    End Sub

    Private Sub Lingkaran_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class