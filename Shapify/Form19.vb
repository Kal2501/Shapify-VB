Public Class LimasSegiEmpat

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

    Private Sub txtTinggiLimas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTinggiLimas.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtTinggiLimas.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTinggiSalahSatuSisiTegak_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTSST.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtTSST.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtSisi.Text.Trim() = "" Or txtTSST.Text.Trim() = "" Then
                MessageBox.Show("Masukkan sisi dan tinggi salah satu sisi tegak terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim sisi As Double = Convert.ToDouble(txtSisi.Text)
            Dim tinggiSisiTegak As Double = Convert.ToDouble(txtTSST.Text)

            ' Luas alas
            Dim luasAlas As Double = Math.Pow(sisi, 2)

            ' Luas sisi tegak
            Dim luasSisiTegak As Double = 4 * (0.5 * sisi * tinggiSisiTegak)

            ' Total luas permukaan
            Dim luasTotal As Double = luasAlas + luasSisiTegak

            lbLuas.Text = "Hasil : " & Math.Round(luasTotal, 2) & " satuan²"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSisi.Clear()
            txtTSST.Clear()
            txtSisi.Focus()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtSisi2.Text.Trim() = "" Or txtTinggiLimas.Text.Trim() = "" Then
                MessageBox.Show("Masukkan sisi dan tinggi limas terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim sisi As Double = Convert.ToDouble(txtSisi2.Text)
            Dim tinggiLimas As Double = Convert.ToDouble(txtTinggiLimas.Text)

            ' Volume limas
            Dim volume As Double = (1.0 / 3.0) * Math.Pow(sisi, 2) * tinggiLimas

            lbVolume.Text = "Hasil : " & Math.Round(volume, 2) & " satuan³"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSisi2.Clear()
            txtTinggiLimas.Clear()
            txtSisi2.Focus()
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BangunRuang.Show()
        Me.Close()
    End Sub
End Class