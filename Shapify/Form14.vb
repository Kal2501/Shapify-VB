Public Class Balok

    
    Private Sub txtLebar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLebar.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtLebar.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtLebar2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLebar2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtLebar2.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPanjang_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPanjang.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtPanjang.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPanjang2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPanjang2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtPanjang2.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTinggi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTinggi.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtTinggi.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTinggi2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTinggi2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtTinggi2.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtPanjang.Text.Trim() = "" Or txtLebar.Text.Trim() = "" Or txtTinggi.Text.Trim() = "" Then
                MessageBox.Show("Masukkan panjang, lebar, dan tinggi terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim panjang As Double = Convert.ToDouble(txtPanjang.Text)
            Dim lebar As Double = Convert.ToDouble(txtLebar.Text)
            Dim tinggi As Double = Convert.ToDouble(txtTinggi.Text)

            Dim luas As Double = 2 * ((panjang * lebar) + (panjang * tinggi) + (lebar * tinggi))

            lbLuas.Text = "Hasil : " & Math.Round(luas, 2) & " satuan²"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPanjang.Clear()
            txtLebar.Clear()
            txtTinggi.Clear()
            txtPanjang.Focus()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtPanjang2.Text.Trim() = "" Or txtLebar2.Text.Trim() = "" Or txtTinggi2.Text.Trim() = "" Then
                MessageBox.Show("Masukkan panjang, lebar, dan tinggi terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim panjang As Double = Convert.ToDouble(txtPanjang2.Text)
            Dim lebar As Double = Convert.ToDouble(txtLebar2.Text)
            Dim tinggi As Double = Convert.ToDouble(txtTinggi2.Text)

            Dim volume As Double = panjang * lebar * tinggi

            lbVolume.Text = "Hasil : " & Math.Round(volume, 2) & " satuan³"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtPanjang2.Clear()
            txtLebar2.Clear()
            txtTinggi2.Clear()
            txtPanjang2.Focus()
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BangunRuang.Show()
        Me.Close()
    End Sub
End Class