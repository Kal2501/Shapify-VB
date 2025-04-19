Public Class Kerucut

    
    Private Sub txtJariJari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJariJari.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtJariJari.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub


    Private Sub txtJariJari2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtJariJari2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtJariJari2.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtSelimut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSelimut.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtSelimut.Text.Contains(".") Then
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
            If txtJariJari.Text.Trim() = "" Or txtSelimut.Text.Trim() = "" Then
                MessageBox.Show("Masukkan jari-jari dan selimut terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim jariJari As Double = Convert.ToDouble(txtJariJari.Text)
            Dim selimut As Double = Convert.ToDouble(txtSelimut.Text)
            Dim phi As Double = Math.PI
            Dim luasPermukaan As Double = phi * jariJari * (jariJari + selimut)

            lbLuas.Text = "Hasil : " & Math.Round(luasPermukaan, 2) & " satuan²"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtJariJari.Clear()
            txtSelimut.Clear()
            txtJariJari.Focus()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtJariJari2.Text.Trim() = "" Or txtTinggi.Text.Trim() = "" Then
                MessageBox.Show("Masukkan jari-jari dan tinggi terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim jariJari As Double = Convert.ToDouble(txtJariJari2.Text)
            Dim tinggi As Double = Convert.ToDouble(txtTinggi.Text)
            Dim phi As Double = Math.PI
            Dim volume As Double = (1.0 / 3.0) * phi * Math.Pow(jariJari, 2) * tinggi

            lbVolume.Text = "Hasil : " & Math.Round(volume, 2) & " satuan³"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtJariJari2.Clear()
            txtTinggi.Clear()
            txtJariJari2.Focus()
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BangunRuang.Show()
        Me.Close()
    End Sub
End Class