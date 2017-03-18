<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.txt = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabGeneral = New System.Windows.Forms.TabPage()
        Me.radLoop = New System.Windows.Forms.RadioButton()
        Me.radOnce = New System.Windows.Forms.RadioButton()
        Me.txtInitDelay = New System.Windows.Forms.NumericUpDown()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabType = New System.Windows.Forms.TabPage()
        Me.txtPrintln = New System.Windows.Forms.TextBox()
        Me.txtPrint = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabSend = New System.Windows.Forms.TabPage()
        Me.cboSAK = New System.Windows.Forms.ComboBox()
        Me.cboPK = New System.Windows.Forms.ComboBox()
        Me.cboFAK = New System.Windows.Forms.ComboBox()
        Me.cboSingle = New System.Windows.Forms.ComboBox()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tabDelay = New System.Windows.Forms.TabPage()
        Me.txtDelay = New System.Windows.Forms.NumericUpDown()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tabRemark = New System.Windows.Forms.TabPage()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mnuMain = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.btnInfo = New System.Windows.Forms.ToolStripButton()
        Me.sfdMain = New System.Windows.Forms.SaveFileDialog()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabGeneral.SuspendLayout()
        CType(Me.txtInitDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabType.SuspendLayout()
        Me.tabSend.SuspendLayout()
        Me.tabDelay.SuspendLayout()
        CType(Me.txtDelay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRemark.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        resources.ApplyResources(Me.SplitContainer1, "SplitContainer1")
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        '
        'txt
        '
        resources.ApplyResources(Me.txt, "txt")
        Me.txt.Name = "txt"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabGeneral)
        Me.TabControl1.Controls.Add(Me.tabType)
        Me.TabControl1.Controls.Add(Me.tabSend)
        Me.TabControl1.Controls.Add(Me.tabDelay)
        Me.TabControl1.Controls.Add(Me.tabRemark)
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        '
        'tabGeneral
        '
        Me.tabGeneral.Controls.Add(Me.radLoop)
        Me.tabGeneral.Controls.Add(Me.radOnce)
        Me.tabGeneral.Controls.Add(Me.txtInitDelay)
        Me.tabGeneral.Controls.Add(Me.Button2)
        Me.tabGeneral.Controls.Add(Me.Button1)
        Me.tabGeneral.Controls.Add(Me.Label4)
        Me.tabGeneral.Controls.Add(Me.Label3)
        Me.tabGeneral.Controls.Add(Me.Label2)
        Me.tabGeneral.Controls.Add(Me.Label1)
        resources.ApplyResources(Me.tabGeneral, "tabGeneral")
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'radLoop
        '
        resources.ApplyResources(Me.radLoop, "radLoop")
        Me.radLoop.Name = "radLoop"
        Me.radLoop.UseVisualStyleBackColor = True
        '
        'radOnce
        '
        resources.ApplyResources(Me.radOnce, "radOnce")
        Me.radOnce.Checked = True
        Me.radOnce.Name = "radOnce"
        Me.radOnce.TabStop = True
        Me.radOnce.UseVisualStyleBackColor = True
        '
        'txtInitDelay
        '
        resources.ApplyResources(Me.txtInitDelay, "txtInitDelay")
        Me.txtInitDelay.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.txtInitDelay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtInitDelay.Name = "txtInitDelay"
        Me.txtInitDelay.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Button2
        '
        resources.ApplyResources(Me.Button2, "Button2")
        Me.Button2.Name = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'tabType
        '
        Me.tabType.Controls.Add(Me.txtPrintln)
        Me.tabType.Controls.Add(Me.txtPrint)
        Me.tabType.Controls.Add(Me.Button4)
        Me.tabType.Controls.Add(Me.Label8)
        Me.tabType.Controls.Add(Me.Button3)
        Me.tabType.Controls.Add(Me.Label7)
        Me.tabType.Controls.Add(Me.Label5)
        Me.tabType.Controls.Add(Me.Label6)
        resources.ApplyResources(Me.tabType, "tabType")
        Me.tabType.Name = "tabType"
        Me.tabType.UseVisualStyleBackColor = True
        '
        'txtPrintln
        '
        resources.ApplyResources(Me.txtPrintln, "txtPrintln")
        Me.txtPrintln.Name = "txtPrintln"
        '
        'txtPrint
        '
        resources.ApplyResources(Me.txtPrint, "txtPrint")
        Me.txtPrint.Name = "txtPrint"
        '
        'Button4
        '
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'Button3
        '
        resources.ApplyResources(Me.Button3, "Button3")
        Me.Button3.Name = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'tabSend
        '
        Me.tabSend.Controls.Add(Me.cboSAK)
        Me.tabSend.Controls.Add(Me.cboPK)
        Me.tabSend.Controls.Add(Me.cboFAK)
        Me.tabSend.Controls.Add(Me.cboSingle)
        Me.tabSend.Controls.Add(Me.Button12)
        Me.tabSend.Controls.Add(Me.Label19)
        Me.tabSend.Controls.Add(Me.Button11)
        Me.tabSend.Controls.Add(Me.Label18)
        Me.tabSend.Controls.Add(Me.Label17)
        Me.tabSend.Controls.Add(Me.Label16)
        Me.tabSend.Controls.Add(Me.Label14)
        Me.tabSend.Controls.Add(Me.Label15)
        resources.ApplyResources(Me.tabSend, "tabSend")
        Me.tabSend.Name = "tabSend"
        Me.tabSend.UseVisualStyleBackColor = True
        '
        'cboSAK
        '
        resources.ApplyResources(Me.cboSAK, "cboSAK")
        Me.cboSAK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSAK.FormattingEnabled = True
        Me.cboSAK.Items.AddRange(New Object() {resources.GetString("cboSAK.Items"), resources.GetString("cboSAK.Items1"), resources.GetString("cboSAK.Items2"), resources.GetString("cboSAK.Items3"), resources.GetString("cboSAK.Items4"), resources.GetString("cboSAK.Items5"), resources.GetString("cboSAK.Items6"), resources.GetString("cboSAK.Items7"), resources.GetString("cboSAK.Items8")})
        Me.cboSAK.Name = "cboSAK"
        '
        'cboPK
        '
        resources.ApplyResources(Me.cboPK, "cboPK")
        Me.cboPK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPK.FormattingEnabled = True
        Me.cboPK.Items.AddRange(New Object() {resources.GetString("cboPK.Items"), resources.GetString("cboPK.Items1"), resources.GetString("cboPK.Items2"), resources.GetString("cboPK.Items3"), resources.GetString("cboPK.Items4"), resources.GetString("cboPK.Items5"), resources.GetString("cboPK.Items6"), resources.GetString("cboPK.Items7"), resources.GetString("cboPK.Items8"), resources.GetString("cboPK.Items9"), resources.GetString("cboPK.Items10"), resources.GetString("cboPK.Items11"), resources.GetString("cboPK.Items12"), resources.GetString("cboPK.Items13"), resources.GetString("cboPK.Items14"), resources.GetString("cboPK.Items15"), resources.GetString("cboPK.Items16"), resources.GetString("cboPK.Items17"), resources.GetString("cboPK.Items18"), resources.GetString("cboPK.Items19"), resources.GetString("cboPK.Items20"), resources.GetString("cboPK.Items21"), resources.GetString("cboPK.Items22"), resources.GetString("cboPK.Items23"), resources.GetString("cboPK.Items24"), resources.GetString("cboPK.Items25"), resources.GetString("cboPK.Items26"), resources.GetString("cboPK.Items27"), resources.GetString("cboPK.Items28"), resources.GetString("cboPK.Items29"), resources.GetString("cboPK.Items30"), resources.GetString("cboPK.Items31"), resources.GetString("cboPK.Items32"), resources.GetString("cboPK.Items33"), resources.GetString("cboPK.Items34"), resources.GetString("cboPK.Items35"), resources.GetString("cboPK.Items36"), resources.GetString("cboPK.Items37"), resources.GetString("cboPK.Items38"), resources.GetString("cboPK.Items39"), resources.GetString("cboPK.Items40"), resources.GetString("cboPK.Items41"), resources.GetString("cboPK.Items42"), resources.GetString("cboPK.Items43"), resources.GetString("cboPK.Items44"), resources.GetString("cboPK.Items45"), resources.GetString("cboPK.Items46"), resources.GetString("cboPK.Items47"), resources.GetString("cboPK.Items48"), resources.GetString("cboPK.Items49")})
        Me.cboPK.Name = "cboPK"
        '
        'cboFAK
        '
        resources.ApplyResources(Me.cboFAK, "cboFAK")
        Me.cboFAK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFAK.FormattingEnabled = True
        Me.cboFAK.Items.AddRange(New Object() {resources.GetString("cboFAK.Items"), resources.GetString("cboFAK.Items1"), resources.GetString("cboFAK.Items2"), resources.GetString("cboFAK.Items3"), resources.GetString("cboFAK.Items4"), resources.GetString("cboFAK.Items5"), resources.GetString("cboFAK.Items6"), resources.GetString("cboFAK.Items7")})
        Me.cboFAK.Name = "cboFAK"
        '
        'cboSingle
        '
        resources.ApplyResources(Me.cboSingle, "cboSingle")
        Me.cboSingle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSingle.FormattingEnabled = True
        Me.cboSingle.Items.AddRange(New Object() {resources.GetString("cboSingle.Items"), resources.GetString("cboSingle.Items1"), resources.GetString("cboSingle.Items2"), resources.GetString("cboSingle.Items3"), resources.GetString("cboSingle.Items4")})
        Me.cboSingle.Name = "cboSingle"
        '
        'Button12
        '
        resources.ApplyResources(Me.Button12, "Button12")
        Me.Button12.Name = "Button12"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'Button11
        '
        resources.ApplyResources(Me.Button11, "Button11")
        Me.Button11.Name = "Button11"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'tabDelay
        '
        Me.tabDelay.Controls.Add(Me.txtDelay)
        Me.tabDelay.Controls.Add(Me.Button9)
        Me.tabDelay.Controls.Add(Me.Button8)
        Me.tabDelay.Controls.Add(Me.Button7)
        Me.tabDelay.Controls.Add(Me.Button6)
        Me.tabDelay.Controls.Add(Me.Button5)
        Me.tabDelay.Controls.Add(Me.Label9)
        Me.tabDelay.Controls.Add(Me.Label11)
        Me.tabDelay.Controls.Add(Me.Label10)
        resources.ApplyResources(Me.tabDelay, "tabDelay")
        Me.tabDelay.Name = "tabDelay"
        Me.tabDelay.UseVisualStyleBackColor = True
        '
        'txtDelay
        '
        resources.ApplyResources(Me.txtDelay, "txtDelay")
        Me.txtDelay.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.txtDelay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Button9
        '
        resources.ApplyResources(Me.Button9, "Button9")
        Me.Button9.Name = "Button9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        resources.ApplyResources(Me.Button8, "Button8")
        Me.Button8.Name = "Button8"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        resources.ApplyResources(Me.Button7, "Button7")
        Me.Button7.Name = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'tabRemark
        '
        Me.tabRemark.Controls.Add(Me.txtRemark)
        Me.tabRemark.Controls.Add(Me.Button10)
        Me.tabRemark.Controls.Add(Me.Label12)
        Me.tabRemark.Controls.Add(Me.Label13)
        resources.ApplyResources(Me.tabRemark, "tabRemark")
        Me.tabRemark.Name = "tabRemark"
        Me.tabRemark.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        resources.ApplyResources(Me.txtRemark, "txtRemark")
        Me.txtRemark.Name = "txtRemark"
        '
        'Button10
        '
        resources.ApplyResources(Me.Button10, "Button10")
        Me.Button10.Name = "Button10"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'mnuMain
        '
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.btnInfo})
        resources.ApplyResources(Me.mnuMain, "mnuMain")
        Me.mnuMain.Name = "mnuMain"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Automator.My.Resources.Resources.NewRequest_8796
        resources.ApplyResources(Me.ToolStripButton1, "ToolStripButton1")
        Me.ToolStripButton1.Name = "ToolStripButton1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Automator.My.Resources.Resources.CubePreview
        resources.ApplyResources(Me.ToolStripButton2, "ToolStripButton2")
        Me.ToolStripButton2.Name = "ToolStripButton2"
        '
        'btnInfo
        '
        Me.btnInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnInfo.Image = Global.Automator.My.Resources.Resources.StatusAnnotations_Information_16xLG_color
        resources.ApplyResources(Me.btnInfo, "btnInfo")
        Me.btnInfo.Name = "btnInfo"
        '
        'sfdMain
        '
        Me.sfdMain.DefaultExt = "ino"
        Me.sfdMain.FileName = "我的USB键盘"
        resources.ApplyResources(Me.sfdMain, "sfdMain")
        '
        'MainForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.mnuMain)
        Me.Name = "MainForm"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tabGeneral.ResumeLayout(False)
        Me.tabGeneral.PerformLayout()
        CType(Me.txtInitDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabType.ResumeLayout(False)
        Me.tabType.PerformLayout()
        Me.tabSend.ResumeLayout(False)
        Me.tabSend.PerformLayout()
        Me.tabDelay.ResumeLayout(False)
        Me.tabDelay.PerformLayout()
        CType(Me.txtDelay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRemark.ResumeLayout(False)
        Me.tabRemark.PerformLayout()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents btnInfo As ToolStripButton
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents txt As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabGeneral As TabPage
    Friend WithEvents tabType As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tabSend As TabPage
    Friend WithEvents tabDelay As TabPage
    Friend WithEvents tabRemark As TabPage
    Friend WithEvents txtInitDelay As NumericUpDown
    Friend WithEvents radLoop As RadioButton
    Friend WithEvents radOnce As RadioButton
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrint As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrintln As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDelay As NumericUpDown
    Friend WithEvents Button9 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents Button10 As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cboPK As ComboBox
    Friend WithEvents cboFAK As ComboBox
    Friend WithEvents cboSingle As ComboBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents cboSAK As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents sfdMain As SaveFileDialog
End Class
