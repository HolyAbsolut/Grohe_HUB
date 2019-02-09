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




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UNloc()



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

    Sub UNloc()

        dbLoad()
        Dim ne As DataRow = dtShipments.NewRow
        ne("Created") = 55
        dtShipments.Rows.Add(ne)
        MsgBox(dtShipments.Rows.Count.ToString)
        dbSave()


    End Sub


    Sub dsShipmentww()
        Dim dtShipments As New DataTable("dsShipments")
        Dim cnn As New SQLiteConnection("Data Source='" & TextBox1.Text & "'")
        cnn.Open()
        Dim mycommand As New SQLiteCommand(cnn)
        mycommand.CommandText = "Select * from dsShipments"
        Dim reader As SQLiteDataReader = mycommand.ExecuteReader()
        dtShipments.Load(reader)
        reader.Close()
        cnn.Close()
        MsgBox(dtShipments.Rows.Count.ToString)
        'Return dtShipments
    End Sub



End Class
