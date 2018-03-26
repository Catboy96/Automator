Class MainWindow

    Private Sub btnNewFile_Click(sender As Object, e As RoutedEventArgs)
        If txtCode.Text <> "" Then
            If MessageBox.Show("Create a new file? All unsaved changes will be lost.", "", MessageBoxButton.YesNo, MessageBoxImage.Question) = MessageBoxResult.Yes Then
                txtCode.Clear()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As RoutedEventArgs)

    End Sub

    Private Sub btnInput_Click(sender As Object, e As RoutedEventArgs)
        If tgbReturn.IsChecked = True Then
            txtCode.AppendText("DigiKeyboard.println("""");")
        Else
            txtCode.AppendText("DigiKeyboard.print("""");")
        End If
    End Sub

    Private Sub btnDelay_Click(sender As Object, e As RoutedEventArgs)
        txtCode.AppendText("DigiKeyboard.delay();")
    End Sub
End Class
