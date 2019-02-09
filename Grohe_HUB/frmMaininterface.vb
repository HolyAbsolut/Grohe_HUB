Option Strict On
Imports System.Data.SQLite


Public Class frmMaininterface
    Private daImport As SQLiteDataAdapter

    Private daShipments As SQLiteDataAdapter
    Private daUNLOC As SQLiteDataAdapter
    Private daIncoterm As SQLiteDataAdapter
    Private daPartner As SQLiteDataAdapter
    Private daSettings As SQLiteDataAdapter
    Dim dtShipments As New DataTable("dtShipments")
    Dim dtUNLOC As New DataTable("dtUNLOC")
    Dim dtIncoterm As New DataTable("dtIncoterm")
    Dim dtPartner As New DataTable("dtPartner")
    Dim dtSettings As New DataTable("dtSettings")

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dbLoad()
        xlsTango("C:\Users\HolyAbsolut\Desktop\Grohe_HUB\ex Tango ShipmentsGroheSearch_20180928_133614.xlsx", "Excel Export1")

        'MsgBox(dtUNLOC.Rows.Count)
        'DataGridView1.DataSource = dtUNLOC
        'DataGridView1.Refresh()

    End Sub


    Sub dbLoad()
        Dim dbPath As String = "C:\Users\HolyAbsolut\Desktop\Grohe_HUB\data.sqlite"

        daShipments = New SQLiteDataAdapter("Select * from dsShipments", "Data Source='" & dbPath & "'")
        daShipments.Fill(dtShipments)
        Dim builderdaShipments = New SQLiteCommandBuilder(daShipments)

        daUNLOC = New SQLiteDataAdapter("Select * from dtUNLOC", "Data Source='" & dbPath & "'")
        daUNLOC.Fill(dtUNLOC)
        Dim builderdaUNLOC = New SQLiteCommandBuilder(daUNLOC)

        daIncoterm = New SQLiteDataAdapter("Select * from dtIncoterm", "Data Source='" & dbPath & "'")
        daIncoterm.Fill(dtIncoterm)
        Dim builderdaIncoterm = New SQLiteCommandBuilder(daIncoterm)

        daPartner = New SQLiteDataAdapter("Select * from dsPartner", "Data Source='" & dbPath & "'")
        daPartner.Fill(dtPartner)
        Dim builderdaPartner = New SQLiteCommandBuilder(daPartner)

        daSettings = New SQLiteDataAdapter("Select * from stSettings", "Data Source='" & dbPath & "'")
        daSettings.Fill(dtSettings)
        Dim builderdaSettings = New SQLiteCommandBuilder(daSettings)

    End Sub

    Sub dbSave()
        If daShipments IsNot Nothing Then daShipments.Update(dtShipments)
        If daUNLOC IsNot Nothing Then daUNLOC.Update(dtUNLOC)
        If daIncoterm IsNot Nothing Then daIncoterm.Update(dtIncoterm)
        If daPartner IsNot Nothing Then daPartner.Update(dtPartner)
        If daSettings IsNot Nothing Then daSettings.Update(dtSettings)
    End Sub



    Sub UNloc()

        'dbLoad()
        'Dim ne As DataRow = dtShipments.NewRow
        'ne("Created") = 55
        'dtShipments.Rows.Add(ne)
        'MsgBox(dtShipments.Rows.Count.ToString)
        'dbSave()


    End Sub

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
        'dtSearch.Clear()







        'Dim archresult() As DataRow = dtShipments.Select("Archive_No = '" & Archive_No & "'")

        'dtShipments.Select()
        'If archresult.Count = 1 Then
        '    For Each row As DataRow In archresult
        '        Return Convert.ToInt32((row(0)))
        '    Next
        'End If

        'Dim sttresult() As DataRow = dtShipments.Select("STT_No = '" & STT_No & "'")
        'dtShipments.Select()
        'If sttresult.Count = 1 Then
        '    For Each row As DataRow In sttresult
        '        Return Convert.ToInt32((row(0)))
        '    Next

        'End If

        'Return 0 'Else
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


    Sub xlsTango(ByVal xlsFile As String, ByVal xlsTable As String)
        'im Background
        'mehree Dateien
        'Dateinen ggf Löschen
        'xlsSheet Name ggf aus den Settings auslesen

        'Prüfen ob bereits vorhanden

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
                    'dsNewRow.Item("Shipment_Type") = ImportRow(My.Settings.sttFile2C3).ToString
                    'dsNewRow.Item("Load_Type") = ImportRow("Load Type").ToString
                    dsNewRow.Item("Incoterm") = Incoterm(ImportRow("INCO Terms").ToString)
                    'dsNewRow.Item("Incoterm_Loc") = ImportRow("Location").ToString
                    ''dsNewRow.Item("From") = ImportRow("From").ToString
                    ''dsNewRow.Item("CY_CFS_Origin_Inland") = ImportRow("CY/CFS Origin Inland").ToString
                    'dsNewRow.Item("POL") = ImportRow("Departure").ToString
                    'dsNewRow.Item("POD") = ImportRow("Destination").ToString
                    ''dsNewRow.Item("CY_CFS_Destination_Inland") = ImportRow("CY/CFS Destination Inland").ToString
                    'dsNewRow.Item("To") = ImportRow("To").ToString
                    dsNewRow.Item("STT_No") = ImportRow("STT No#").ToString.ToString
                    dsNewRow.Item("Archive_No") = ImportRow("Archive No#").ToString
                    dsNewRow.Item("Eco_Month") = ImportRow("Eco# Month").ToString
                    'dsNewRow.Item("Carrier") = ImportRow("Carrier").ToString
                    dsNewRow.Item("Vessel") = ImportRow("Vessel/Airline Code/Truck").ToString
                    dsNewRow.Item("dtnETD") = TimeToUnix(Convert.ToDateTime(ImportRow("ETD (Date)")))
                    'dsNewRow.Item("ETD_Time") = ImportRow(My.Settings.sttFile2C26)
                    dsNewRow.Item("dtnETA") = TimeToUnix(Convert.ToDateTime(ImportRow("ETA (Date)")))
                    'dsNewRow.Item("ETA_Time") = ImportRow(My.Settings.sttFile2C28)
                    dsNewRow.Item("Weight") = ImportRow("Gross Weight (weight)").ToString().Replace("KGS ", "").Replace(".", ",")
                    dsNewRow.Item("Volume") = ImportRow("Volume (volume)").ToString().Replace("CBM ", "").Replace(".", ",")
                    'dsNewRow.Item("Principal") = ImportRow("Principal Name").ToString
                    'dsNewRow.Item("Shipper") = ImportRow("Shipper Name").ToString
                    'dsNewRow.Item("Consignee") = ImportRow("Consignee Name").ToString
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

            Dim HBL As String
            If ImportRow("HB/L No#").ToString <> "" Then
                HBL = ImportRow("HB/L No#").ToString
            Else
                HBL = ImportRow("B/L No#").ToString
            End If




        Next


        'TangoTableAdapter.Adapter.Update(GroheDataSet, "Tango")
        'Grohe_AccountingTableAdapter.Adapter.Update(GroheDataSet, "Grohe_Accounting")
        'ImportDtSet.Clear()
        'MsgBox("Done")
        'MsgBox(Me.GroheDataSet.Grohe_Accounting.Count - initCount & " Sendungen importiert.")
        dbSave()
        MsgBox("Done")
    End Sub






End Class
