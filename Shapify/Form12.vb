Public Class Trapesium


    Private Sub txtAB_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAB.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtAB.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAD.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtAD.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAtas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAtas.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtAtas.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBawah_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBawah.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtBawah.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtBC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBC.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtBC.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCD_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCD.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtCD.Text.Contains(".") Then
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtAtas.Text.Trim() = "" Or txtBawah.Text.Trim() = "" Or txtTinggi.Text.Trim() = "" Then
                MessageBox.Show("Masukkan nilai atas, bawah, dan tinggi terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim atas As Double = Convert.ToDouble(txtAtas.Text)
            Dim bawah As Double = Convert.ToDouble(txtBawah.Text)
            Dim tinggi As Double = Convert.ToDouble(txtTinggi.Text)

            Dim luas As Double = 0.5 * (atas + bawah) * tinggi

            lbLuas.Text = "Hasil : " & Math.Round(luas, 2) & " satuan²"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAtas.Clear()
            txtBawah.Clear()
            txtTinggi.Clear()
            txtAtas.Focus()
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BangunDatar.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtAB.Text.Trim() = "" Or txtBC.Text.Trim() = "" Or txtCD.Text.Trim() = "" Or txtAD.Text.Trim() = "" Then
                MessageBox.Show("Masukkan semua panjang sisi trapesium (AB, BC, CD, AD).", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim AB As Double = Convert.ToDouble(txtAB.Text)
            Dim BC As Double = Convert.ToDouble(txtBC.Text)
            Dim CD As Double = Convert.ToDouble(txtCD.Text)
            Dim AD As Double = Convert.ToDouble(txtAD.Text)

            Dim keliling As Double = AB + BC + CD + AD

            lbKeliling.Text = "Hasil : " & Math.Round(keliling, 2) & " satuan"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAB.Clear()
            txtBC.Clear()
            txtCD.Clear()
            txtAD.Clear()
            txtAB.Focus()
        End Try
    End Sub
End Class