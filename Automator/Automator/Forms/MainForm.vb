Public Class MainForm

#Region "Menu"

    'New File
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If MessageBox.Show(My.Resources.UI_NEW_FILE_WARNING, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            txt.Clear()
        End If
    End Sub

    'Generate Arduino Project
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        If Not sfdMain.ShowDialog = DialogResult.OK Then Exit Sub
        Dim sw As New IO.StreamWriter(sfdMain.FileName, False, System.Text.Encoding.UTF8)
        If radOnce.Checked = True Then
            sw.WriteLine("#include ""DigiKeyboard.h""")
            sw.WriteLine("")
            sw.WriteLine("void setup() {")
            sw.WriteLine("DigiKeyboard.sendKeyStroke(0);")
            sw.Write(txt.Text)
            sw.WriteLine("")
            sw.WriteLine("}")
            sw.WriteLine("")
            sw.WriteLine("void loop() {")
            sw.WriteLine("}")
            sw.Close()
            sw.Dispose()
        ElseIf radLoop.Checked = True Then
            sw.WriteLine("#include ""DigiKeyboard.h""")
            sw.WriteLine("")
            sw.WriteLine("void setup() {")
            sw.WriteLine("}")
            sw.WriteLine("")
            sw.WriteLine("void loop() {")
            sw.WriteLine("DigiKeyboard.sendKeyStroke(0);")
            sw.Write(txt.Text)
            sw.WriteLine("}")
            sw.Close()
            sw.Dispose()
        End If
    End Sub

    'Info
    Private Sub btnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
        Process.Start("https://github.com/CYRO4S/Automator")
    End Sub

#End Region

#Region "Editing"

    'Init Delay
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt.AppendText($"DigiKeyboard.delay({txtInitDelay.Value});" & vbCrLf)
    End Sub

    'Print
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txt.AppendText($"DigiKeyboard.print(""{txtPrint.Text}"");" & vbCrLf)
    End Sub

    'Println
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        txt.AppendText($"DigiKeyboard.println(""{txtPrintln.Text}"");" & vbCrLf)
    End Sub

    'Delay
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txt.AppendText($"DigiKeyboard.delay({txtDelay.Value});" & vbCrLf)
    End Sub

    'Delay 50ms
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        txt.AppendText("DigiKeyboard.delay(50);" & vbCrLf)
    End Sub

    'Delay 100ms
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        txt.AppendText("DigiKeyboard.delay(100);" & vbCrLf)
    End Sub

    'Delay 500ms
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        txt.AppendText("DigiKeyboard.delay(500);" & vbCrLf)
    End Sub

    'Delay 1000ms
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        txt.AppendText("DigiKeyboard.delay(1000);" & vbCrLf)
    End Sub

    'Remark
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        txt.AppendText($"//{txtRemark.Text}" & vbCrLf)
    End Sub

    'Send Single Key
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Select Case cboSingle.SelectedIndex
            Case 0
                txt.AppendText("DigiKeyboard.sendKeyStroke(0, MOD_GUI_LEFT);" & vbCrLf)
            Case 1
                txt.AppendText("DigiKeyboard.sendKeyStroke(0, MOD_GUI_RIGHT);" & vbCrLf)
            Case 2
                txt.AppendText("DigiKeyboard.sendKeyStroke(KEY_ENTER);" & vbCrLf)
            Case 3
                txt.AppendText("DigiKeyboard.sendKeyStroke(KEY_SPACE);" & vbCrLf)
            Case 4
                txt.AppendText("DigiKeyboard.sendKeyStroke(KEY_ARROW_LEFT);" & vbCrLf)
        End Select
    End Sub

    'Send Key Stroke
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim strPK, strFAK, strSAK As String

        'Primary Key
        Select Case cboPK.SelectedIndex
            Case 0
                strPK = "KEY_ENTER"
            Case 1
                strPK = "KEY_SPACE"
            Case Else
                strPK = $"KEY_{cboPK.SelectedItem}"
        End Select

        'First Assist Key
        Select Case cboFAK.SelectedIndex
            Case 0
                strFAK = "MOD_CONTROL_LEFT"
            Case 1
                strFAK = "MOD_SHIFT_LEFT"
            Case 2
                strFAK = "MOD_ALT_LEFT"
            Case 3
                strFAK = "MOD_CONTROL_RIGHT"
            Case 4
                strFAK = "MOD_SHIFT_RIGHT"
            Case 5
                strFAK = "MOD_ALT_RIGHT"
            Case 6
                strFAK = "MOD_GUI_LEFT"
            Case 7
                strFAK = "MOD_GUI_RIGHT"
        End Select

        'Secondary Assist Key
        Select Case cboSAK.SelectedIndex
            Case 0
                txt.AppendText($"DigiKeyboard.sendKeyStroke({strPK}, {strFAK});" & vbCrLf)
            Case 1
                strSAK = "MOD_CONTROL_LEFT"
                txt.AppendText($"DigiKeyboard.sendKeyStroke({strPK}, {strFAK} | {strSAK});" & vbCrLf)
            Case 2
                strSAK = "MOD_SHIFT_LEFT"
                txt.AppendText($"DigiKeyboard.sendKeyStroke({strPK}, {strFAK} | {strSAK});" & vbCrLf)
            Case 3
                strSAK = "MOD_ALT_LEFT"
                txt.AppendText($"DigiKeyboard.sendKeyStroke({strPK}, {strFAK} | {strSAK});" & vbCrLf)
            Case 4
                strSAK = "MOD_CONTROL_RIGHT"
                txt.AppendText($"DigiKeyboard.sendKeyStroke({strPK}, {strFAK} | {strSAK});" & vbCrLf)
            Case 5
                strSAK = "MOD_SHIFT_RIGHT"
                txt.AppendText($"DigiKeyboard.sendKeyStroke({strPK}, {strFAK} | {strSAK});" & vbCrLf)
            Case 6
                strSAK = "MOD_ALT_RIGHT"
                txt.AppendText($"DigiKeyboard.sendKeyStroke({strPK}, {strFAK} | {strSAK});" & vbCrLf)
            Case 7
                strSAK = "MOD_GUI_LEFT"
                txt.AppendText($"DigiKeyboard.sendKeyStroke({strPK}, {strFAK} | {strSAK});" & vbCrLf)
            Case 8
                strSAK = "MOD_GUI_RIGHT"
                txt.AppendText($"DigiKeyboard.sendKeyStroke({strPK}, {strFAK} | {strSAK});" & vbCrLf)
        End Select
    End Sub





#End Region

End Class
