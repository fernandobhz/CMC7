Public Class Form1

    Private Sub Capture1_Captured(CMC7 As CMC7.CMC7Data)
        MsgBox(String.Format("Banco: {0}, Agencia: {1}, Conta: {2}, Cheque: {3}, Camara: {4}", CMC7.Banco, CMC7.Agencia, CMC7.Conta, CMC7.Cheque, CMC7.CamaraCompensacao))
    End Sub

    Private Sub Capture1_Bulding(s As String)
        Me.Text = s
    End Sub

End Class

