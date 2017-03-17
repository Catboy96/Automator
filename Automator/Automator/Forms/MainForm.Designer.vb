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
        Me.mnuMain = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.btnInfo = New System.Windows.Forms.ToolStripButton()
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
        Me.sfdMain = New System.Windows.Forms.SaveFileDialog()
        Me.mnuMain.SuspendLayout()
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
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.btnInfo})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1000, 31)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Automator.My.Resources.Resources.NewRequest_8796
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(67, 28)
        Me.ToolStripButton1.Text = "新建"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.Automator.My.Resources.Resources.CubePreview
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(67, 28)
        Me.ToolStripButton2.Text = "生成"
        '
        'btnInfo
        '
        Me.btnInfo.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnInfo.Image = Global.Automator.My.Resources.Resources.StatusAnnotations_Information_16xLG_color
        Me.btnInfo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(28, 28)
        Me.btnInfo.Text = "&Info"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 31)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1000, 639)
        Me.SplitContainer1.SplitterDistance = 610
        Me.SplitContainer1.TabIndex = 1
        '
        'txt
        '
        Me.txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.Location = New System.Drawing.Point(0, 0)
        Me.txt.Multiline = True
        Me.txt.Name = "txt"
        Me.txt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt.Size = New System.Drawing.Size(610, 639)
        Me.txt.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabGeneral)
        Me.TabControl1.Controls.Add(Me.tabType)
        Me.TabControl1.Controls.Add(Me.tabSend)
        Me.TabControl1.Controls.Add(Me.tabDelay)
        Me.TabControl1.Controls.Add(Me.tabRemark)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(386, 639)
        Me.TabControl1.TabIndex = 0
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
        Me.tabGeneral.Location = New System.Drawing.Point(4, 29)
        Me.tabGeneral.Name = "tabGeneral"
        Me.tabGeneral.Padding = New System.Windows.Forms.Padding(3)
        Me.tabGeneral.Size = New System.Drawing.Size(378, 606)
        Me.tabGeneral.TabIndex = 0
        Me.tabGeneral.Text = "通用"
        Me.tabGeneral.UseVisualStyleBackColor = True
        '
        'radLoop
        '
        Me.radLoop.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radLoop.AutoSize = True
        Me.radLoop.Location = New System.Drawing.Point(31, 342)
        Me.radLoop.Name = "radLoop"
        Me.radLoop.Size = New System.Drawing.Size(60, 24)
        Me.radLoop.TabIndex = 3
        Me.radLoop.Text = "循环"
        Me.radLoop.UseVisualStyleBackColor = True
        '
        'radOnce
        '
        Me.radOnce.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.radOnce.AutoSize = True
        Me.radOnce.Checked = True
        Me.radOnce.Location = New System.Drawing.Point(31, 308)
        Me.radOnce.Name = "radOnce"
        Me.radOnce.Size = New System.Drawing.Size(60, 24)
        Me.radOnce.TabIndex = 3
        Me.radOnce.TabStop = True
        Me.radOnce.Text = "单次"
        Me.radOnce.UseVisualStyleBackColor = True
        '
        'txtInitDelay
        '
        Me.txtInitDelay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtInitDelay.Location = New System.Drawing.Point(31, 99)
        Me.txtInitDelay.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.txtInitDelay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtInitDelay.Name = "txtInitDelay"
        Me.txtInitDelay.Size = New System.Drawing.Size(312, 27)
        Me.txtInitDelay.TabIndex = 2
        Me.txtInitDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtInitDelay.Value = New Decimal(New Integer() {1000, 0, 0, 0})
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Location = New System.Drawing.Point(30, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(312, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "添加"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Location = New System.Drawing.Point(31, 140)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(312, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "添加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.Label4.Location = New System.Drawing.Point(26, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(218, 40)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "程序是只执行一次，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "还是重复执行直至拔出USB设备？"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(25, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 25)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "执行方式"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.Label2.Location = New System.Drawing.Point(26, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(204, 40)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "程序开始前的等待时间，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "通常用于计算机识别USB设备。"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "初始延时"
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
        Me.tabType.Location = New System.Drawing.Point(4, 25)
        Me.tabType.Name = "tabType"
        Me.tabType.Padding = New System.Windows.Forms.Padding(3)
        Me.tabType.Size = New System.Drawing.Size(378, 610)
        Me.tabType.TabIndex = 1
        Me.tabType.Text = "键入"
        Me.tabType.UseVisualStyleBackColor = True
        '
        'txtPrintln
        '
        Me.txtPrintln.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrintln.Location = New System.Drawing.Point(31, 291)
        Me.txtPrintln.Name = "txtPrintln"
        Me.txtPrintln.Size = New System.Drawing.Size(313, 27)
        Me.txtPrintln.TabIndex = 7
        Me.txtPrintln.Text = "Hello Digispark!"
        '
        'txtPrint
        '
        Me.txtPrint.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPrint.Location = New System.Drawing.Point(30, 83)
        Me.txtPrint.Name = "txtPrint"
        Me.txtPrint.Size = New System.Drawing.Size(313, 27)
        Me.txtPrint.TabIndex = 7
        Me.txtPrint.Text = "Hello Digispark!"
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.Location = New System.Drawing.Point(31, 326)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(312, 50)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "添加"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.Label8.Location = New System.Drawing.Point(28, 241)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(261, 40)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "将模拟键盘一字一字地输入下面的内容，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "最后会插入一个换行符。"
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.Location = New System.Drawing.Point(30, 118)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(312, 50)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "添加"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(26, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(145, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "键入字符并换行"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.Label5.Location = New System.Drawing.Point(27, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "将模拟键盘一字一字地输入下面的内容"
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(25, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 25)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "键入字符"
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
        Me.tabSend.Location = New System.Drawing.Point(4, 25)
        Me.tabSend.Name = "tabSend"
        Me.tabSend.Size = New System.Drawing.Size(378, 610)
        Me.tabSend.TabIndex = 2
        Me.tabSend.Text = "发送"
        Me.tabSend.UseVisualStyleBackColor = True
        '
        'cboSAK
        '
        Me.cboSAK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboSAK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSAK.FormattingEnabled = True
        Me.cboSAK.Items.AddRange(New Object() {"无", "左Control", "左Shift", "左Alter / Option", "右Control", "右Shift", "右Alter / Option", "左GUI", "右GUI"})
        Me.cboSAK.Location = New System.Drawing.Point(30, 364)
        Me.cboSAK.Name = "cboSAK"
        Me.cboSAK.Size = New System.Drawing.Size(312, 28)
        Me.cboSAK.TabIndex = 14
        '
        'cboPK
        '
        Me.cboPK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboPK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPK.FormattingEnabled = True
        Me.cboPK.Items.AddRange(New Object() {"回车", "空格", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"})
        Me.cboPK.Location = New System.Drawing.Point(30, 423)
        Me.cboPK.Name = "cboPK"
        Me.cboPK.Size = New System.Drawing.Size(312, 28)
        Me.cboPK.TabIndex = 14
        '
        'cboFAK
        '
        Me.cboFAK.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboFAK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFAK.FormattingEnabled = True
        Me.cboFAK.Items.AddRange(New Object() {"左Control", "左Shift", "左Alter / Option", "右Control", "右Shift", "右Alter / Option", "左GUI", "右GUI"})
        Me.cboFAK.Location = New System.Drawing.Point(30, 305)
        Me.cboFAK.Name = "cboFAK"
        Me.cboFAK.Size = New System.Drawing.Size(312, 28)
        Me.cboFAK.TabIndex = 14
        '
        'cboSingle
        '
        Me.cboSingle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cboSingle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSingle.FormattingEnabled = True
        Me.cboSingle.Items.AddRange(New Object() {"左GUI", "右GUI", "回车", "空格", "左箭头"})
        Me.cboSingle.Location = New System.Drawing.Point(30, 80)
        Me.cboSingle.Name = "cboSingle"
        Me.cboSingle.Size = New System.Drawing.Size(312, 28)
        Me.cboSingle.TabIndex = 14
        '
        'Button12
        '
        Me.Button12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button12.Location = New System.Drawing.Point(30, 118)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(312, 50)
        Me.Button12.TabIndex = 13
        Me.Button12.Text = "添加"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.Label19.Location = New System.Drawing.Point(26, 340)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 20)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "+ 第二辅助键"
        '
        'Button11
        '
        Me.Button11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button11.Location = New System.Drawing.Point(30, 461)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(312, 50)
        Me.Button11.TabIndex = 13
        Me.Button11.Text = "添加"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.Label18.Location = New System.Drawing.Point(26, 399)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(51, 20)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "+ 主键"
        '
        'Label17
        '
        Me.Label17.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.Label17.Location = New System.Drawing.Point(26, 256)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(163, 40)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "向计算机发送键位组合。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "第一辅助键"
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Label16.Location = New System.Drawing.Point(25, 226)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(126, 25)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "发送键位组合"
        '
        'Label14
        '
        Me.Label14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.Label14.Location = New System.Drawing.Point(26, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(163, 20)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "模拟键盘按下特殊按键。"
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Label15.Location = New System.Drawing.Point(25, 25)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 25)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "发送按键"
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
        Me.tabDelay.Location = New System.Drawing.Point(4, 25)
        Me.tabDelay.Name = "tabDelay"
        Me.tabDelay.Size = New System.Drawing.Size(378, 610)
        Me.tabDelay.TabIndex = 3
        Me.tabDelay.Text = "延时"
        Me.tabDelay.UseVisualStyleBackColor = True
        '
        'txtDelay
        '
        Me.txtDelay.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDelay.Location = New System.Drawing.Point(31, 127)
        Me.txtDelay.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
        Me.txtDelay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtDelay.Name = "txtDelay"
        Me.txtDelay.Size = New System.Drawing.Size(312, 27)
        Me.txtDelay.TabIndex = 7
        Me.txtDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDelay.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button9.Location = New System.Drawing.Point(30, 416)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(312, 50)
        Me.Button9.TabIndex = 5
        Me.Button9.Text = "延时 半秒"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button8.Location = New System.Drawing.Point(30, 472)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(312, 50)
        Me.Button8.TabIndex = 5
        Me.Button8.Text = "延时 一秒"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.Location = New System.Drawing.Point(30, 360)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(312, 50)
        Me.Button7.TabIndex = 5
        Me.Button7.Text = "延时 100毫秒"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.Location = New System.Drawing.Point(30, 304)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(312, 50)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "延时 50毫秒"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.Location = New System.Drawing.Point(30, 168)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(312, 50)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "添加"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.Label9.Location = New System.Drawing.Point(26, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(191, 60)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "执行下一语句前的等待时间，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "通常用在两个键盘操作之间，" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "等待操作系统完成上一步骤。"
        '
        'Label11
        '
        Me.Label11.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Label11.Location = New System.Drawing.Point(25, 268)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 25)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "快捷插入"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(25, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 25)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "延时"
        '
        'tabRemark
        '
        Me.tabRemark.Controls.Add(Me.txtRemark)
        Me.tabRemark.Controls.Add(Me.Button10)
        Me.tabRemark.Controls.Add(Me.Label12)
        Me.tabRemark.Controls.Add(Me.Label13)
        Me.tabRemark.Location = New System.Drawing.Point(4, 25)
        Me.tabRemark.Name = "tabRemark"
        Me.tabRemark.Size = New System.Drawing.Size(378, 610)
        Me.tabRemark.TabIndex = 4
        Me.tabRemark.Text = "注释"
        Me.tabRemark.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRemark.Location = New System.Drawing.Point(29, 82)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(313, 27)
        Me.txtRemark.TabIndex = 11
        Me.txtRemark.Text = "Automator by CYRO4S"
        '
        'Button10
        '
        Me.Button10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button10.Location = New System.Drawing.Point(29, 117)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(312, 50)
        Me.Button10.TabIndex = 10
        Me.Button10.Text = "添加"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("微软雅黑", 8.0!)
        Me.Label12.Location = New System.Drawing.Point(26, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 20)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "在代码中插入注释"
        '
        'Label13
        '
        Me.Label13.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("微软雅黑", 11.0!)
        Me.Label13.Location = New System.Drawing.Point(25, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(50, 25)
        Me.Label13.TabIndex = 9
        Me.Label13.Text = "注释"
        '
        'sfdMain
        '
        Me.sfdMain.DefaultExt = "ino"
        Me.sfdMain.FileName = "我的USB键盘"
        Me.sfdMain.Filter = "Arduino 项目文件|*.ino"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 670)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.mnuMain)
        Me.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automator"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
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
