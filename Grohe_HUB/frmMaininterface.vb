Option Strict On
Imports System.Data.SQLite


Public Class frmMaininterface
    Private daImport As SQLiteDataAdapter

    Private daShipments As SQLiteDataAdapter
    Private daUNLOC As SQLiteDataAdapter
    Private daIncoterm As SQLiteDataAdapter
    Private daPartner As SQLiteDataAdapter
    Private daSettings As SQLiteDataAdapter
    Private daLocTranslate As SQLiteDataAdapter
    Dim dtShipments As New DataTable("dtShipments")
    Dim dtUNLOC As New DataTable("dtUNLOC")
    Dim dtIncoterm As New DataTable("dtIncoterm")
    Dim dtPartner As New DataTable("dtPartner")
    Dim dtSettings As New DataTable("dtSettings")
    Dim dtLocTranslate As New DataTable("dtSettings")

    Sub direct()
        Dim sqlite_cmd As SQLiteCommand
        Dim sqlite_datareader As SQLiteDataReader
        Dim connectString As SQLiteConnectionStringBuilder
        connectString = New SQLiteConnectionStringBuilder()

        connectString.DataSource = TextBox1.Text
        connectString.ForeignKeys = True
        connectString.JournalMode = SQLiteJournalModeEnum.Wal

        System.Console.WriteLine(connectString.ToString())

        Dim sqlite_conn As SQLiteConnection
        sqlite_conn = New SQLiteConnection(connectString.ToString())

        ' open the connection:
        sqlite_conn.Open()

        sqlite_cmd = sqlite_conn.CreateCommand()

        sqlite_cmd.CommandText = "SELECT * FROM dtUNLOC"
        sqlite_datareader = sqlite_cmd.ExecuteReader()

        ' The SQLiteDataReader allows us to run through each row per loop
        While (sqlite_datareader.Read()) ' Read() returns true if there is still a result line to read
            'Begin
            ' Print out the content of the text field:
            ' Console.WriteLine("DEBUG Output: '" + sqlite_datareader["text"] + "'")

            Dim idReader As Object
            Dim textReader As String

            idReader = sqlite_datareader.GetValue(0)
            textReader = sqlite_datareader.GetString(0)

            MsgBox(textReader)
        End While
    End Sub


    'Load
    Private Sub frmMaininterface_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbLoad("All")
    End Sub

    Sub dbLoad(ByVal table As String)
        Dim dbPath As String = "C:\Users\HolyAbsolut\Desktop\Grohe_HUB\data.sqlite"

        Select Case table
            Case "dtShipments"
                daShipments = New SQLiteDataAdapter("Select * from dsShipments", "Data Source='" & dbPath & "'")
                daShipments.Fill(dtShipments)
                Dim builderdaShipments = New SQLiteCommandBuilder(daShipments)
                dtShipments.PrimaryKey = New DataColumn() {dtShipments.Columns(0)}
            Case "dtUNLOC"
                daUNLOC = New SQLiteDataAdapter("Select * from dtUNLOC", "Data Source='" & dbPath & "'")
                daUNLOC.Fill(dtUNLOC)
                Dim builderdaUNLOC = New SQLiteCommandBuilder(daUNLOC)
            Case "dtIncoterm"
                daIncoterm = New SQLiteDataAdapter("Select * from dtIncoterm", "Data Source='" & dbPath & "'")
                daIncoterm.Fill(dtIncoterm)
                Dim builderdaIncoterm = New SQLiteCommandBuilder(daIncoterm)
            Case "dtPartner"
                daPartner = New SQLiteDataAdapter("Select * from dsPartner", "Data Source='" & dbPath & "'")
                daPartner.Fill(dtPartner)
                Dim builderdaPartner = New SQLiteCommandBuilder(daPartner)
                dtPartner.PrimaryKey = New DataColumn() {dtPartner.Columns(0)}
            Case "dtSettings"
                daSettings = New SQLiteDataAdapter("Select * from stSettings", "Data Source='" & dbPath & "'")
                daSettings.Fill(dtSettings)
                Dim builderdaSettings = New SQLiteCommandBuilder(daSettings)
            Case "dsLocTranslate"
                daLocTranslate = New SQLiteDataAdapter("Select * from dsLocTranslate", "Data Source='" & dbPath & "'")
                daLocTranslate.Fill(dtLocTranslate)
                Dim builderdaLocTranslate = New SQLiteCommandBuilder(daLocTranslate)
            Case Else
                daShipments = New SQLiteDataAdapter("Select * from dsShipments", "Data Source='" & dbPath & "'")
                daShipments.Fill(dtShipments)
                Dim builderdaShipments = New SQLiteCommandBuilder(daShipments)
                dtShipments.PrimaryKey = New DataColumn() {dtShipments.Columns(0)}

                daUNLOC = New SQLiteDataAdapter("Select * from dtUNLOC", "Data Source='" & dbPath & "'")
                daUNLOC.Fill(dtUNLOC)
                Dim builderdaUNLOC = New SQLiteCommandBuilder(daUNLOC)

                daIncoterm = New SQLiteDataAdapter("Select * from dtIncoterm", "Data Source='" & dbPath & "'")
                daIncoterm.Fill(dtIncoterm)
                Dim builderdaIncoterm = New SQLiteCommandBuilder(daIncoterm)

                daPartner = New SQLiteDataAdapter("Select * from dsPartner", "Data Source='" & dbPath & "'")
                daPartner.Fill(dtPartner)
                Dim builderdaPartner = New SQLiteCommandBuilder(daPartner)
                dtPartner.PrimaryKey = New DataColumn() {dtPartner.Columns(0)}

                daSettings = New SQLiteDataAdapter("Select * from stSettings", "Data Source='" & dbPath & "'")
                daSettings.Fill(dtSettings)
                Dim builderdaSettings = New SQLiteCommandBuilder(daSettings)

                daLocTranslate = New SQLiteDataAdapter("Select * from dsLocTranslate", "Data Source='" & dbPath & "'")
                daLocTranslate.Fill(dtLocTranslate)
                Dim builderdaLocTranslate = New SQLiteCommandBuilder(daLocTranslate)
        End Select

    End Sub

    Sub dbSave(ByVal table As String)
        Select Case table
            Case "dtShipments"
                If daShipments IsNot Nothing Then daShipments.Update(dtShipments)
            Case "dtUNLOC"
                If daUNLOC IsNot Nothing Then daUNLOC.Update(dtUNLOC)
            Case "dtIncoterm"
                If daIncoterm IsNot Nothing Then daIncoterm.Update(dtIncoterm)
            Case "dtPartner"
                If daPartner IsNot Nothing Then daPartner.Update(dtPartner)
            Case "dtSettings"
                If daSettings IsNot Nothing Then daSettings.Update(dtSettings)
            Case "dtLocTranslate"
                If daLocTranslate IsNot Nothing Then daLocTranslate.Update(dtLocTranslate)
            Case Else
                If daShipments IsNot Nothing Then daShipments.Update(dtShipments)
                If daUNLOC IsNot Nothing Then daUNLOC.Update(dtUNLOC)
                If daIncoterm IsNot Nothing Then daIncoterm.Update(dtIncoterm)
                If daPartner IsNot Nothing Then daPartner.Update(dtPartner)
                If daSettings IsNot Nothing Then daSettings.Update(dtSettings)
                If daLocTranslate IsNot Nothing Then daLocTranslate.Update(dtLocTranslate)
        End Select
    End Sub


    'Functions
    Public Function UnixToTime(ByVal strUnixTime As String) As Date
        UnixToTime = DateAdd(DateInterval.Second, Val(strUnixTime), #1/1/1970#)
        If UnixToTime.IsDaylightSavingTime = True Then
            UnixToTime = DateAdd(DateInterval.Hour, 1, UnixToTime)
        End If
    End Function

    Public Function TimeToUnix(ByVal dteDate As Date) As String
        If dteDate.IsDaylightSavingTime = True Then
            dteDate = DateAdd(DateInterval.Hour, -1, dteDate)
        End If
        TimeToUnix = DateDiff(DateInterval.Second, #1/1/1970#, dteDate).ToString
    End Function

    Function chkShipment(ByVal STT_No As String, ByVal Archive_No As String) As Integer
        Dim SQlSearch As String = "Archive_No = '" & STT_No & "' OR STT_No = '" & Archive_No & "'"
        Dim dtSearch As DataTable = dtShipments
        'Abfrage
        dtSearch.DefaultView.RowFilter = SQlSearch ' Suche
        If dtSearch.DefaultView.Count = 0 Then
            chkShipment = 0
        Else
            chkShipment = 1
        End If
        dtSearch.DefaultView.RowFilter = String.Empty
    End Function

    Function Incoterm(ByVal TangoIncoterm As String) As String
        Incoterm = ""
        Select Case TangoIncoterm
            Case Is = "Cost and Freight"
                Incoterm = "CFR"
            Case Is = "Cost, Insurance and Freight"
                Incoterm = "CIF"
            Case Is = "Carriage and Insurance Paid to"
                Incoterm = "CIP"
            Case Is = "Carriage Paid to"
                Incoterm = "CPT"
            Case Is = "Delivered at Frontier"
                Incoterm = "DAF"
            Case Is = "Delivered at Place"
                Incoterm = "DAP"
            Case Is = "Delivered at Terminal"
                Incoterm = "DAT"
            Case Is = "Delivered Duty Paid"
                Incoterm = "DDP"
            Case Is = "Delivered Duty Unpaid"
                Incoterm = "DDU"
            Case Is = "Delivered Ex Quay"
                Incoterm = "DEQ"
            Case Is = "Delivered Ex Ship"
                Incoterm = "DES"
            Case Is = "Ex Works"
                Incoterm = "EXW"
            Case Is = "Free Alongside Ship"
                Incoterm = "FAS"
            Case Is = "Free Carrier"
                Incoterm = "FCA"
            Case Is = "Free on Board"
                Incoterm = "FOB"
            Case Is = ""
                Incoterm = "FOB"
            Case Else
                MsgBox("WTF...unbekanntes Incoterm")
        End Select
    End Function

    Function getPartnerID(ByVal PartnerName As String) As Integer

        Dim idPartner As Integer = 0
        Dim dtSearch As DataTable = dtPartner
        Dim SQlSearch As String = "PartnerName = '" & PartnerName & "'"
        dtSearch.DefaultView.RowFilter = SQlSearch ' Suche

        If dtSearch.DefaultView.Count = 1 Then
            idPartner = Convert.ToInt32(dtSearch.DefaultView.Item(0).Row("Partner_ID").ToString)
        ElseIf dtSearch.DefaultView.Count = 0 Then
            Dim dsNewRow As DataRow
            dsNewRow = dtPartner.NewRow
            dsNewRow.Item("Created") = TimeToUnix(Date.Now)
            dsNewRow.Item("PartnerName") = PartnerName
            dtPartner.Rows.Add(dsNewRow)
            dbSave("dtPartner")
            dtPartner.Clear()
            dbLoad("dtPartner")
            dtSearch = dtPartner
            dtSearch.DefaultView.RowFilter = SQlSearch ' Suche
            idPartner = Convert.ToInt32(dtSearch.DefaultView.Item(0).Row("Partner_ID").ToString)
        End If
        'dtSearch.DefaultView.RowFilter = String.Empty
        'dtSearch.Clear()
        Return idPartner
    End Function

    Function getUNLOC(ByVal locName As String) As String
        'Erst in UNLOC suchen
        'Dann in locTranslation suchen
        'TODO neue locTranslation anlegen

        Dim dtSearch As DataTable = dtUNLOC
        Dim SQlSearch As String = "Name = '" & locName & "'"
        dtSearch.DefaultView.RowFilter = SQlSearch ' Suche

        If dtSearch.DefaultView.Count = 1 Then
            Return dtSearch.DefaultView.Item(0).Row("UNLOC").ToString
        Else
            dtSearch = dtLocTranslate
            SQlSearch = "Location = '" & locName & "'"
            dtSearch.DefaultView.RowFilter = SQlSearch ' Suche
            If dtSearch.DefaultView.Count = 1 Then
                Return dtSearch.DefaultView.Item(0).Row("UNLOC").ToString
            Else
                Return "ZZZZZ"
            End If
        End If
    End Function

    Function getPartnerName(ByVal PartnerID As Integer) As String
        Dim SQlSearch As String = "Partner_ID = '" & PartnerID & "'"
        dtPartner.DefaultView.RowFilter = SQlSearch ' Suche
        If dtPartner.DefaultView.Count = 1 Then
            Return dtPartner.Rows.Find(PartnerID).Item("PartnerName").ToString
        Else
            Return ""
        End If
    End Function

    'SUBs
    Sub chkUNLOC(ByVal UNLOC As String)
        Dim dtSearch As DataTable = dtUNLOC
        Dim SQlSearch As String = "UNLOC = '" & UNLOC & "'"
        dtSearch.DefaultView.RowFilter = SQlSearch ' Suche
        If dtSearch.DefaultView.Count = 0 Then
            'MsgBox("Ich lege an" & UNLOC)
            Dim dsNewRow As DataRow
            dsNewRow = dtUNLOC.NewRow
            dsNewRow.Item("UNLOC") = UNLOC
            dsNewRow.Item("Country") = UNLOC.Substring(0, 2)
            dsNewRow.Item("Location") = UNLOC.Substring(2, 3)
            dsNewRow.Item("Remarks") = "Added by chkUNLOC"
            dtUNLOC.Rows.Add(dsNewRow)
            dbSave("dtUNLOC")
            dbLoad("dtUNLOC")
        End If
    End Sub

    Sub xlsTango(ByVal xlsFile As String, ByVal xlsTable As String)
        'im Background
        'mehree Dateien
        'Dateinen ggf Löschen
        'xlsSheet Name ggf aus den Settings auslesen

        Dim MyConnection As System.Data.OleDb.OleDbConnection
        Dim ImportDtSet As System.Data.DataSet
        Dim MyCommand As System.Data.OleDb.OleDbDataAdapter
        Try 'Tango xls in DS einspielen
            MyConnection = New System.Data.OleDb.OleDbConnection _
            ("provider=Microsoft.ACE.OLEDB.12.0;" &
            " Data Source='" & xlsFile & "'; " &
             "Extended Properties=Excel 12.0;")
            MyCommand = New System.Data.OleDb.OleDbDataAdapter _
                ("Select * from [" & xlsTable & "$]", MyConnection)
            MyCommand.TableMappings.Add("Table", "TangoImport")
            ImportDtSet = New System.Data.DataSet
            MyCommand.Fill(ImportDtSet)
            MyConnection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        For Each ImportRow As DataRow In ImportDtSet.Tables("TangoImport").Rows
            If chkShipment(ImportRow("STT No#").ToString, ImportRow("Archive No#").ToString) = 0 Then
                Try
                    Dim dsNewRow As DataRow
                    dsNewRow = dtShipments.NewRow ' Ursprünglich Table (2)
                    dsNewRow.Item("Created") = TimeToUnix(Date.Now)
                    dsNewRow.Item("Shipment_Type") = ImportRow("Shipment Type").ToString
                    dsNewRow.Item("Service") = ImportRow("Load Type").ToString
                    dsNewRow.Item("Incoterm") = Incoterm(ImportRow("INCO Terms").ToString)
                    dsNewRow.Item("Incoterm_Loc") = getUNLOC(ImportRow("Location").ToString)
                    ''dsNewRow.Item("From") = ImportRow("From").ToString
                    ''dsNewRow.Item("CY_CFS_Origin_Inland") = ImportRow("CY/CFS Origin Inland").ToString
                    chkUNLOC(ImportRow("Departure").ToString)
                    chkUNLOC(ImportRow("Destination").ToString)
                    dsNewRow.Item("POL") = ImportRow("Departure").ToString
                    dsNewRow.Item("POD") = ImportRow("Destination").ToString
                    ''dsNewRow.Item("CY_CFS_Destination_Inland") = ImportRow("CY/CFS Destination Inland").ToString
                    'dsNewRow.Item("To") = ImportRow("To").ToString
                    dsNewRow.Item("STT_No") = ImportRow("STT No#").ToString.ToString
                    dsNewRow.Item("Archive_No") = ImportRow("Archive No#").ToString
                    dsNewRow.Item("Eco_Month") = ImportRow("Eco# Month").ToString
                    dsNewRow.Item("Carrier") = getPartnerID(ImportRow("Carrier").ToString)
                    dsNewRow.Item("Vessel") = ImportRow("Vessel/Airline Code/Truck").ToString
                    dsNewRow.Item("dtnETD") = TimeToUnix(Convert.ToDateTime(ImportRow("ETD (Date)")))
                    dsNewRow.Item("dtnETA") = TimeToUnix(Convert.ToDateTime(ImportRow("ETA (Date)")))
                    dsNewRow.Item("Weight") = ImportRow("Gross Weight (weight)").ToString().Replace("KGS ", "").Replace(".", ",")
                    dsNewRow.Item("Volume") = ImportRow("Volume (volume)").ToString().Replace("CBM ", "").Replace(".", ",")
                    dsNewRow.Item("Shipper") = getPartnerID(ImportRow("Shipper Name").ToString)
                    dsNewRow.Item("Consignee") = getPartnerID(ImportRow("Consignee Name").ToString)
                    If ImportRow("HB/L No#").ToString <> "" Then
                        dsNewRow.Item("HBL_No") = ImportRow("HB/L No#").ToString
                    Else
                        dsNewRow.Item("HBL_No") = ImportRow("B/L No#").ToString
                    End If
                    dsNewRow.Item("MBL_No") = ImportRow("B/L No#").ToString
                    'dsNewRow.Item("Container_No") = ImportRow("Container No#").ToString
                    dtShipments.Rows.Add(dsNewRow) ' Ursprünglich Table (2)
                Catch EXC As Exception
                    MsgBox(EXC.Message)
                End Try
            End If
        Next
        dbSave("dtShipments")
        MsgBox("Done")
    End Sub

    Sub UNloc()

        'dbLoad()
        'Dim ne As DataRow = dtShipments.NewRow
        'ne("Created") = 55
        'dtShipments.Rows.Add(ne)
        'MsgBox(dtShipments.Rows.Count.ToString)
        'dbSave()


    End Sub

    'Buttons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        xlsTango("C:\Users\HolyAbsolut\Desktop\Grohe_HUB\ex Tango ShipmentsGroheSearch_20180928_133614.xlsx", "Excel Export1")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim str As String = "CNSHA"
        MsgBox(str.Substring(2, 3))
    End Sub

    Function getShipmentID(ByVal refSearch As String) As Integer
        Dim dtSearch As DataTable = dtShipments
        Dim SQlSearch As String = "STT_No = '" & refSearch & "' OR ARCHIVE_NO ='" & refSearch & "'OR HBL_No ='" & refSearch & "'OR MBL_No ='" & refSearch & "'"
        dtSearch.DefaultView.RowFilter = SQlSearch ' Suche

        If dtSearch.DefaultView.Count = 1 Then
            Return Convert.ToInt32(dtSearch.DefaultView.Item(0).Row("Shipment_ID").ToString)
        Else
            Return 0
        End If
    End Function


    Function getDate(ByVal dtnString As String) As Date
        Try
            Select Case dtnString.Length
                Case 0
                    getDate = Nothing
                Case 6
                    getDate = DateTime.ParseExact(dtnString, "ddMMyy", Globalization.CultureInfo.InvariantCulture)
                Case 8
                    If dtnString.Contains("."c) Then getDate = DateTime.ParseExact(dtnString, "dd.MM.yy", Globalization.CultureInfo.InvariantCulture)
                    If dtnString.Contains("/"c) Then getDate = DateTime.ParseExact(dtnString, "dd/MM/yy", Globalization.CultureInfo.InvariantCulture)
                    If getDate.ToString = "" Then
                        getDate = DateTime.ParseExact(dtnString, "ddMMyyyy", Globalization.CultureInfo.InvariantCulture)
                    Else
                        getDate = Nothing
                    End If
                Case 10
                    getDate = DateTime.ParseExact(dtnString, "dd.MM.yyyy", Globalization.CultureInfo.InvariantCulture)
                Case 19
                    getDate = DateTime.ParseExact(dtnString, "dd.MM.yyyy hh:mm:ss", Globalization.CultureInfo.InvariantCulture)
                Case Else
                    getDate = Nothing
                    MsgBox("Format unkown")
            End Select
        Catch ex As Exception
            getDate = Nothing
            MsgBox("Format unkown")
        End Try
    End Function

    Sub PopulateForm(ByVal ShipmentId As Integer)

        'Suche
        Dim SQlSearch As String = "Shipment_ID = '" & ShipmentId & "'"
        'Abfrage
        dtShipments.DefaultView.RowFilter = SQlSearch ' Suche
        If dtShipments.DefaultView.Count <> 1 Then Exit Sub

        txtSTT.Text = dtShipments.Rows.Find(ShipmentId).Item("STT_No").ToString
        txtArchive.Text = dtShipments.Rows.Find(ShipmentId).Item("Archive_No").ToString
        txtHBL.Text = dtShipments.Rows.Find(ShipmentId).Item("HBL_No").ToString
        txtMBL.Text = dtShipments.Rows.Find(ShipmentId).Item("MBL_No").ToString

        cmbService.Text = dtShipments.Rows.Find(ShipmentId).Item("Service").ToString
        cmbIncoterm.Text = dtShipments.Rows.Find(ShipmentId).Item("Incoterm").ToString
        txtIncotermLoc.Text = dtShipments.Rows.Find(ShipmentId).Item("Incoterm_Loc").ToString
        txtPOL.Text = dtShipments.Rows.Find(ShipmentId).Item("POL").ToString
        txtPOD.Text = dtShipments.Rows.Find(ShipmentId).Item("POD").ToString
        dtnPickUp.Text = UnixToTime(dtShipments.Rows.Find(ShipmentId).Item("dtnPick_Up").ToString).ToShortDateString
        dtnETD.Text = UnixToTime(dtShipments.Rows.Find(ShipmentId).Item("dtnETD").ToString).ToShortDateString
        dtnETA.Text = UnixToTime(dtShipments.Rows.Find(ShipmentId).Item("dtnETA").ToString).ToShortDateString

        txtShipper.Text = getPartnerName(Convert.ToInt32(dtShipments.Rows.Find(ShipmentId).Item("Shipper").ToString))
        txtConsignee.Text = getPartnerName(Convert.ToInt32(dtShipments.Rows.Find(ShipmentId).Item("Consignee").ToString))
        txtCarrier.Text = getPartnerName(Convert.ToInt32(dtShipments.Rows.Find(ShipmentId).Item("Carrier").ToString))

        num20DC.Text = dtShipments.Rows.Find(ShipmentId).Item("Cont20DC").ToString
        num40DC.Text = dtShipments.Rows.Find(ShipmentId).Item("Cont40DC").ToString
        num40HQ.Text = dtShipments.Rows.Find(ShipmentId).Item("Cont40HQ").ToString
        'numTEU.Text 

        numVolume.Text = dtShipments.Rows.Find(ShipmentId).Item("Volume").ToString
        numWeight.Text = dtShipments.Rows.Find(ShipmentId).Item("Weight").ToString

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        txtSearch.Text = "87620033077772"
        PopulateForm(getShipmentID(txtSearch.Text))


        'MsgBox(dtSearch.DefaultView.Count)
    End Sub


    Private Sub OnlyNumeric(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles num20DC.KeyPress, num40DC.KeyPress, num40HQ.KeyPress, numTEU.KeyPress, txtSTT.KeyPress, numWeight.KeyPress, numVolume.KeyPress, numOanda.KeyPress, dtnETD.KeyPress, dtnETA.KeyPress, dtnPickUp.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 44
                ' Zahlen, Backspace und Komma zulassen
            Case Else
                ' alle anderen Eingaben unterdrücken
                e.Handled = True
        End Select

    End Sub

    Private Sub dtnConvert(ctlButton As Object, e As EventArgs) Handles dtnPickUp.Leave, dtnETD.Leave, dtnETA.Leave
        'dtnPickUp.Text = getDate(dtnPickUp.Text).ToShortDateString
        Dim sender As Control = CType(ctlButton, Control)
        If sender.Text = "" Then
            'DsDemag_HUB.dsShipments.Rows.Find(Shipment_IDTextBox.Text).Item(sender.Name) = System.DBNull.Value
        Else
            sender.Text = getDate(sender.Text).ToShortDateString
        End If
    End Sub
End Class
