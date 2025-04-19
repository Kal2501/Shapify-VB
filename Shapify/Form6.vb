Public Class Persegi

    
    Private Sub txtSisi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSisi.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtSisi.Text.Contains(".") Then
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
            If txtSisi.Text.Trim() = "" Then
                MessageBox.Show("Masukkan panjang sisi persegi terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSisi.Focus()
                Exit Sub
            End If

            Dim sisi As Double = Convert.ToDouble(txtSisi.Text)

            Dim luas As Double = sisi * sisi

            lbLuas.Text = "Hasil : " & Math.Round(luas, 2).ToString() & " satuan²"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka saja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSisi.Clear()
            txtSisi.Focus()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtSisi.Text.Trim() = "" Then
                MessageBox.Show("Masukkan panjang sisi persegi terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtSisi.Focus()
                Exit Sub
            End If

            Dim sisi As Double = Convert.ToDouble(txtSisi.Text)

            Dim keliling As Double = 4 * sisi

            lbKeliling.Text = "Keliling Persegi: " & Math.Round(keliling, 2).ToString() & " satuan"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka saja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSisi.Clear()
            txtSisi.Focus()
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BangunDatar.Show()
        Me.Close()
    End Sub
End Class