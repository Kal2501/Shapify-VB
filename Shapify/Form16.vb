Public Class PrismaSegitiga

    
    Private Sub txtAlas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlas.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtAlas.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtAlas2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAlas2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtAlas2.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrisma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTinggiPrisma.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtTinggiPrisma.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTinggiAlas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTinggiAlas.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtTinggiAlas.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTinggiAlas2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTinggiAlas2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtTinggiAlas2.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTinggiPrisma2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTinggiPrisma2.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso txtTinggiPrisma2.Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If txtAlas.Text.Trim() = "" Or txtTinggiAlas.Text.Trim() = "" Or txtTinggiPrisma.Text.Trim() = "" Then
                MessageBox.Show("Masukkan semua nilai terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim alas As Double = Convert.ToDouble(txtAlas.Text)
            Dim tinggiAlas As Double = Convert.ToDouble(txtTinggiAlas.Text)
            Dim tinggiPrisma As Double = Convert.ToDouble(txtTinggiPrisma.Text)

            Dim luasAlas As Double = 0.5 * alas * tinggiAlas
            Dim kelilingAlas As Double = 3 * alas ' Asumsi segitiga sama sisi
            Dim luasPermukaan As Double = (2 * luasAlas) + (kelilingAlas * tinggiPrisma)

            lbLuas.Text = "Hasil : " & Math.Round(luasPermukaan, 2) & " satuan²"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAlas.Clear()
            txtTinggiAlas.Clear()
            txtTinggiPrisma.Clear()
            txtAlas.Focus()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            If txtAlas2.Text.Trim() = "" Or txtTinggiAlas2.Text.Trim() = "" Or txtTinggiPrisma2.Text.Trim() = "" Then
                MessageBox.Show("Masukkan semua nilai terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            Dim alas As Double = Convert.ToDouble(txtAlas2.Text)
            Dim tinggiAlas As Double = Convert.ToDouble(txtTinggiAlas2.Text)
            Dim tinggiPrisma As Double = Convert.ToDouble(txtTinggiPrisma2.Text)

            Dim volume As Double = 0.5 * alas * tinggiAlas * tinggiPrisma

            lbVolume.Text = "Hasil : " & Math.Round(volume, 2) & " satuan³"

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Masukkan angka yang benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAlas2.Clear()
            txtTinggiAlas2.Clear()
            txtTinggiPrisma2.Clear()
            txtAlas2.Focus()
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BangunRuang.Show()
        Me.Close()
    End Sub
End Class