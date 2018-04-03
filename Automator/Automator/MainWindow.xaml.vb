Imports System.Windows.Forms
Imports ExtraTools

Class MainWindow

    Private Sub btnNewFile_Click(sender As Object, e As RoutedEventArgs)
        If txtCode.Text <> "" Then
            DialogBox.Show("Create a new file?", "All unsaved changes will be lost.", "YES", "NO")
            If DialogBox.Result = DialogBox.ResultEnum.LeftButtonClicked Then
                txtCode.Clear()
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As RoutedEventArgs)
        Dim strOut As String = "#include ""DigiKeyboard.h""" & vbCrLf & vbCrLf
        If tgbLoop.IsChecked = True Then
            strOut = strOut & "void setup() {}" & vbCrLf & vbCrLf
            strOut = strOut & "void loop() {" & vbCrLf & "DigiKeyboard.sendKeyStroke(0);" & vbCrLf & "DigiKeyboard.delay(1000);" & vbCrLf
        Else
            strOut = strOut & "void loop() {}" & vbCrLf & vbCrLf
            strOut = strOut & "void setup() {" & vbCrLf & "DigiKeyboard.sendKeyStroke(0);" & vbCrLf & "DigiKeyboard.delay(1000);" & vbCrLf
        End If
        strOut = strOut & txtCode.Text & vbCrLf & "}"
        Dim sfd As New SaveFileDialog
        With sfd
            .AddExtension = True
            .CheckPathExists = True
            .DefaultExt = "ino"
            .Filter = "Arduino Code File | *.ino"
            .Title = "Save Arduino code to..."
        End With
        If sfd.ShowDialog() = Forms.DialogResult.OK Then
            Dim sw As New IO.StreamWriter(sfd.FileName, False, Text.Encoding.UTF8)
            sw.Write(strOut)
            sw.Close()
            sw.Dispose()
        End If
    End Sub

    Private Sub btnInput_Click(sender As Object, e As RoutedEventArgs)
        If tgbReturn.IsChecked = True Then
            InsertString(vbCrLf & "DigiKeyboard.println("""");")
        Else
            InsertString(vbCrLf & "DigiKeyboard.print("""");")
        End If
    End Sub

    Private Sub btnDelay_Click(sender As Object, e As RoutedEventArgs)
        InsertString(vbCrLf & "DigiKeyboard.delay();")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As RoutedEventArgs)
        If lstKeys.SelectedItems.Count = 0 Or cboKey.Text = "" Then Exit Sub
        Dim strAdd As String = $"DigiKeyboard.sendKeyStroke(KEY_{cboKey.Text}, "
        Dim flgPrimKey As Boolean = False
        If keyCmd.IsSelected = True Then
            strAdd &= "MOD_GUI_LEFT"
            flgPrimKey = True
        End If
        If keyOption.IsSelected = True Then
            If flgPrimKey = True Then
                strAdd &= " | MOD_ALT_LEFT"
            Else
                strAdd &= "MOD_ALT_LEFT"
                flgPrimKey = True
            End If
        End If
        If keyControl.IsSelected = True Then
            If flgPrimKey = True Then
                strAdd &= " | MOD_CONTROL_LEFT"
            Else
                strAdd &= "MOD_CONTROL_LEFT"
                flgPrimKey = True
            End If
        End If
        If keyShift.IsSelected = True Then
            If flgPrimKey = True Then
                strAdd &= " | MOD_SHIFT_LEFT"
            Else
                strAdd &= "MOD_SHIFT_LEFT"
            End If
        End If
        strAdd &= ");"
        InsertString(vbCrLf & strAdd)
    End Sub

    Private Sub btnSendGUI_Click(sender As Object, e As RoutedEventArgs)
        InsertString(vbCrLf & "DigiKeyboard.sendKeyStroke(0, MOD_GUI_LEFT);")
    End Sub

    Private Sub btnSendReturn_Click(sender As Object, e As RoutedEventArgs)
        InsertString(vbCrLf & "DigiKeyboard.sendKeyStroke(KEY_ENTER);")
    End Sub

    Private Sub btnSendSpace_Click(sender As Object, e As RoutedEventArgs)
        InsertString(vbCrLf & "DigiKeyboard.sendKeyStroke(KEY_SPACE);")
    End Sub

    Private Sub btnSendDown_Click(sender As Object, e As RoutedEventArgs)
        InsertString(vbCrLf & "DigiKeyboard.sendKeyStroke(KEY_ARROW_DOWN);")
    End Sub

    Private Sub btnSendUp_Click(sender As Object, e As RoutedEventArgs)
        InsertString(vbCrLf & "DigiKeyboard.sendKeyStroke(KEY_ARROW_UP);")
    End Sub

    Private Sub btnSendLeft_Click(sender As Object, e As RoutedEventArgs)
        InsertString(vbCrLf & "DigiKeyboard.sendKeyStroke(KEY_ARROW_LEFT);")
    End Sub

    Private Sub btnSendRight_Click(sender As Object, e As RoutedEventArgs)
        InsertString(vbCrLf & "DigiKeyboard.sendKeyStroke(KEY_ARROW_RIGHT);")
    End Sub

    Private Sub btnInfo_Click(sender As Object, e As RoutedEventArgs)
        Process.Start("https://github.com/CYRO4S/Automator")
    End Sub

    Private Sub InsertString(ByVal Prompt As String)
        Dim index As Integer = txtCode.SelectionStart
        txtCode.Text = txtCode.Text.Insert(index, Prompt)
        txtCode.SelectionStart = index + Prompt.Length
        txtCode.Focus()
    End Sub
End Class
