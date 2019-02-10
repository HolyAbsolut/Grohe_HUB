<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaininterface
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtSTT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtArchive = New System.Windows.Forms.TextBox()
        Me.txtMBL = New System.Windows.Forms.TextBox()
        Me.txtHBL = New System.Windows.Forms.TextBox()
        Me.cmbService = New System.Windows.Forms.ComboBox()
        Me.cmbIncoterm = New System.Windows.Forms.ComboBox()
        Me.txtIncotermLoc = New System.Windows.Forms.TextBox()
        Me.txtShipper = New System.Windows.Forms.TextBox()
        Me.txtCarrier = New System.Windows.Forms.TextBox()
        Me.txtConsignee = New System.Windows.Forms.TextBox()
        Me.txtPOD = New System.Windows.Forms.TextBox()
        Me.txtPOL = New System.Windows.Forms.TextBox()
        Me.num20DC = New System.Windows.Forms.TextBox()
        Me.numTEU = New System.Windows.Forms.TextBox()
        Me.numWeight = New System.Windows.Forms.TextBox()
        Me.numVolume = New System.Windows.Forms.TextBox()
        Me.num40HQ = New System.Windows.Forms.TextBox()
        Me.num40DC = New System.Windows.Forms.TextBox()
        Me.dtnETA = New System.Windows.Forms.TextBox()
        Me.dtnETD = New System.Windows.Forms.TextBox()
        Me.dtnPickUp = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.numOanda = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New Grohe_HUB.Watermark()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "C:\Users\HolyAbsolut\Desktop\Grohe_HUB\data.sqlite"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(33, 89)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtSTT
        '
        Me.txtSTT.Location = New System.Drawing.Point(355, 51)
        Me.txtSTT.Name = "txtSTT"
        Me.txtSTT.Size = New System.Drawing.Size(100, 20)
        Me.txtSTT.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "STT No.:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Archive No.:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(494, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "HBL No.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Incoterm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Service"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(494, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "MBL No.:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(612, 148)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Consignee"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(612, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Shipper"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(188, 199)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Incoterm Location"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(188, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "POL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(195, 251)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "POD"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(623, 177)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Carrier"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(973, 419)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(29, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "TEU"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(450, 450)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Weight"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(252, 451)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "Volume"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(703, 421)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "40HQ"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(481, 410)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 13)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "40DC"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(243, 419)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 13)
        Me.Label19.TabIndex = 21
        Me.Label19.Text = "20DC"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(229, 358)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(28, 13)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "ETA"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(224, 332)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "ETD"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(224, 301)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 13)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Pick up"
        '
        'txtArchive
        '
        Me.txtArchive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtArchive.Location = New System.Drawing.Point(355, 77)
        Me.txtArchive.Name = "txtArchive"
        Me.txtArchive.Size = New System.Drawing.Size(100, 20)
        Me.txtArchive.TabIndex = 27
        '
        'txtMBL
        '
        Me.txtMBL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMBL.Location = New System.Drawing.Point(615, 73)
        Me.txtMBL.Name = "txtMBL"
        Me.txtMBL.Size = New System.Drawing.Size(100, 20)
        Me.txtMBL.TabIndex = 29
        '
        'txtHBL
        '
        Me.txtHBL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtHBL.Location = New System.Drawing.Point(615, 47)
        Me.txtHBL.Name = "txtHBL"
        Me.txtHBL.Size = New System.Drawing.Size(100, 20)
        Me.txtHBL.TabIndex = 28
        '
        'cmbService
        '
        Me.cmbService.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbService.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbService.FormattingEnabled = True
        Me.cmbService.Items.AddRange(New Object() {"LCL", "FCL"})
        Me.cmbService.Location = New System.Drawing.Point(334, 127)
        Me.cmbService.Name = "cmbService"
        Me.cmbService.Size = New System.Drawing.Size(121, 21)
        Me.cmbService.TabIndex = 30
        '
        'cmbIncoterm
        '
        Me.cmbIncoterm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbIncoterm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbIncoterm.FormattingEnabled = True
        Me.cmbIncoterm.Items.AddRange(New Object() {"CFR", "CIF", "CIP", "CPT", "DAP", "DAT", "DDP", "DDU", "EXW", "FAS", "FCA", "FOB", "ZZZ"})
        Me.cmbIncoterm.Location = New System.Drawing.Point(340, 154)
        Me.cmbIncoterm.Name = "cmbIncoterm"
        Me.cmbIncoterm.Size = New System.Drawing.Size(121, 21)
        Me.cmbIncoterm.TabIndex = 31
        '
        'txtIncotermLoc
        '
        Me.txtIncotermLoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIncotermLoc.Location = New System.Drawing.Point(340, 192)
        Me.txtIncotermLoc.MaxLength = 5
        Me.txtIncotermLoc.Name = "txtIncotermLoc"
        Me.txtIncotermLoc.Size = New System.Drawing.Size(100, 20)
        Me.txtIncotermLoc.TabIndex = 32
        '
        'txtShipper
        '
        Me.txtShipper.Location = New System.Drawing.Point(785, 128)
        Me.txtShipper.Name = "txtShipper"
        Me.txtShipper.Size = New System.Drawing.Size(100, 20)
        Me.txtShipper.TabIndex = 33
        '
        'txtCarrier
        '
        Me.txtCarrier.Location = New System.Drawing.Point(791, 180)
        Me.txtCarrier.Name = "txtCarrier"
        Me.txtCarrier.Size = New System.Drawing.Size(100, 20)
        Me.txtCarrier.TabIndex = 35
        '
        'txtConsignee
        '
        Me.txtConsignee.Location = New System.Drawing.Point(785, 154)
        Me.txtConsignee.Name = "txtConsignee"
        Me.txtConsignee.Size = New System.Drawing.Size(100, 20)
        Me.txtConsignee.TabIndex = 34
        '
        'txtPOD
        '
        Me.txtPOD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPOD.Location = New System.Drawing.Point(355, 248)
        Me.txtPOD.MaxLength = 5
        Me.txtPOD.Name = "txtPOD"
        Me.txtPOD.Size = New System.Drawing.Size(100, 20)
        Me.txtPOD.TabIndex = 37
        '
        'txtPOL
        '
        Me.txtPOL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPOL.Location = New System.Drawing.Point(355, 218)
        Me.txtPOL.MaxLength = 5
        Me.txtPOL.Name = "txtPOL"
        Me.txtPOL.Size = New System.Drawing.Size(100, 20)
        Me.txtPOL.TabIndex = 36
        '
        'num20DC
        '
        Me.num20DC.Location = New System.Drawing.Point(315, 418)
        Me.num20DC.Name = "num20DC"
        Me.num20DC.Size = New System.Drawing.Size(36, 20)
        Me.num20DC.TabIndex = 39
        '
        'numTEU
        '
        Me.numTEU.Location = New System.Drawing.Point(1061, 416)
        Me.numTEU.Name = "numTEU"
        Me.numTEU.Size = New System.Drawing.Size(36, 20)
        Me.numTEU.TabIndex = 38
        '
        'numWeight
        '
        Me.numWeight.Location = New System.Drawing.Point(513, 448)
        Me.numWeight.Name = "numWeight"
        Me.numWeight.Size = New System.Drawing.Size(100, 20)
        Me.numWeight.TabIndex = 41
        '
        'numVolume
        '
        Me.numVolume.Location = New System.Drawing.Point(315, 455)
        Me.numVolume.Name = "numVolume"
        Me.numVolume.Size = New System.Drawing.Size(100, 20)
        Me.numVolume.TabIndex = 40
        '
        'num40HQ
        '
        Me.num40HQ.Location = New System.Drawing.Point(799, 418)
        Me.num40HQ.Name = "num40HQ"
        Me.num40HQ.Size = New System.Drawing.Size(36, 20)
        Me.num40HQ.TabIndex = 43
        '
        'num40DC
        '
        Me.num40DC.Location = New System.Drawing.Point(577, 419)
        Me.num40DC.Name = "num40DC"
        Me.num40DC.Size = New System.Drawing.Size(36, 20)
        Me.num40DC.TabIndex = 42
        '
        'dtnETA
        '
        Me.dtnETA.Location = New System.Drawing.Point(315, 358)
        Me.dtnETA.Name = "dtnETA"
        Me.dtnETA.Size = New System.Drawing.Size(100, 20)
        Me.dtnETA.TabIndex = 45
        '
        'dtnETD
        '
        Me.dtnETD.Location = New System.Drawing.Point(315, 332)
        Me.dtnETD.Name = "dtnETD"
        Me.dtnETD.Size = New System.Drawing.Size(100, 20)
        Me.dtnETD.TabIndex = 44
        '
        'dtnPickUp
        '
        Me.dtnPickUp.Location = New System.Drawing.Point(315, 302)
        Me.dtnPickUp.Name = "dtnPickUp"
        Me.dtnPickUp.Size = New System.Drawing.Size(100, 20)
        Me.dtnPickUp.TabIndex = 46
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(219, 527)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 13)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Oanda"
        '
        'numOanda
        '
        Me.numOanda.Location = New System.Drawing.Point(287, 520)
        Me.numOanda.Name = "numOanda"
        Me.numOanda.Size = New System.Drawing.Size(100, 20)
        Me.numOanda.TabIndex = 47
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(427, 8)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 49
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(185, 8)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(211, 20)
        Me.txtSearch.TabIndex = 50
        Me.txtSearch.WatermarkColor = System.Drawing.Color.Gray
        Me.txtSearch.WatermarkText = "Search..."
        '
        'frmMaininterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 616)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.numOanda)
        Me.Controls.Add(Me.dtnPickUp)
        Me.Controls.Add(Me.dtnETA)
        Me.Controls.Add(Me.dtnETD)
        Me.Controls.Add(Me.num40HQ)
        Me.Controls.Add(Me.num40DC)
        Me.Controls.Add(Me.numWeight)
        Me.Controls.Add(Me.numVolume)
        Me.Controls.Add(Me.num20DC)
        Me.Controls.Add(Me.numTEU)
        Me.Controls.Add(Me.txtPOD)
        Me.Controls.Add(Me.txtPOL)
        Me.Controls.Add(Me.txtCarrier)
        Me.Controls.Add(Me.txtConsignee)
        Me.Controls.Add(Me.txtShipper)
        Me.Controls.Add(Me.txtIncotermLoc)
        Me.Controls.Add(Me.cmbIncoterm)
        Me.Controls.Add(Me.cmbService)
        Me.Controls.Add(Me.txtMBL)
        Me.Controls.Add(Me.txtHBL)
        Me.Controls.Add(Me.txtArchive)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSTT)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "frmMaininterface"
        Me.Text = "Grohe HUB"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtSTT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents txtArchive As TextBox
    Friend WithEvents txtMBL As TextBox
    Friend WithEvents txtHBL As TextBox
    Friend WithEvents cmbService As ComboBox
    Friend WithEvents cmbIncoterm As ComboBox
    Friend WithEvents txtIncotermLoc As TextBox
    Friend WithEvents txtShipper As TextBox
    Friend WithEvents txtCarrier As TextBox
    Friend WithEvents txtConsignee As TextBox
    Friend WithEvents txtPOD As TextBox
    Friend WithEvents txtPOL As TextBox
    Friend WithEvents num20DC As TextBox
    Friend WithEvents numTEU As TextBox
    Friend WithEvents numWeight As TextBox
    Friend WithEvents numVolume As TextBox
    Friend WithEvents num40HQ As TextBox
    Friend WithEvents num40DC As TextBox
    Friend WithEvents dtnETA As TextBox
    Friend WithEvents dtnETD As TextBox
    Friend WithEvents dtnPickUp As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents numOanda As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As Watermark
End Class
