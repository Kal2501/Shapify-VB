Public Class Welcome
    Const WM_NCHITTEST As Integer = &H84
    Const HTCLIENT As Integer = &H1
    Const HTCAPTION As Integer = &H2
    Dim first As Boolean = False


    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Select Case m.Msg
            Case WM_NCHITTEST
                MyBase.WndProc(m)
                If m.Result = HTCLIENT Then m.Result = HTCAPTION
            Case Else
                MyBase.WndProc(m)
        End Select
    End Sub
    '------------------------------------------------------------------------'

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity <= 1.0 Then
            Me.Opacity = Me.Opacity - 0.1
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Me.Opacity <= 0.2 Then
            End
        End If
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If Me.Opacity < 1.0 Then
            Me.Opacity = Me.Opacity + 0.1
        End If
    End Sub
    Private Sub FORM1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 0.0
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Start()
        Timer_loading.Start()
    End Sub
    Private Sub Timer_loading_Tick(sender As Object, e As EventArgs) Handles Timer_loading.Tick
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        If first = False Then
            Home.Show()
            first = True
        End If
        Me.Hide()
    End Sub

End Class
