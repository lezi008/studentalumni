Public Class Form4
    Private Sub ButtonTVLICT_Click(sender As Object, e As EventArgs) Handles ButtonTVLICT.Click

        If ComboBoxYearBatch.SelectedItem IsNot Nothing AndAlso ComboBoxYearBatch.SelectedItem.ToString() = "2024-2025" Then

            Dim form6 As New Form6()
            form6.Show()
        Else

            MessageBox.Show("Please select the correct Year Batch (2024-2025)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub ButtonABM_Click(sender As Object, e As EventArgs) Handles ButtonABM.Click

        If ComboBoxYearBatch.SelectedItem IsNot Nothing AndAlso ComboBoxYearBatch.SelectedItem.ToString() = "2024-2025" Then

            Dim form7 As New Form7()
            form7.Show()
        Else

            MessageBox.Show("Please select the correct Year Batch (2024-2025)!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class