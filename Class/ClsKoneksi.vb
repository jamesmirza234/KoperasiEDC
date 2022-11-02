
Imports System.IO
Imports System.Data.SqlClient
Public Class ClsKoneksi
    Protected con As New SqlConnection
    Public Function OpenConn() As Boolean
        On Error Resume Next
        Dim txtPath As String = Application.StartupPath & "\koneksi.txt"
        Dim server, database, user, password As String
        server = (ReadALine(txtPath, GetNumberOfLines(txtPath), 0)) 'mengambil baris pertama
        database = (ReadALine(txtPath, GetNumberOfLines(txtPath), 1)) 'baris kedua
        user = (ReadALine(txtPath, GetNumberOfLines(txtPath), 2)) 'baris ketiga
        password = (ReadALine(txtPath, GetNumberOfLines(txtPath), 3)) 'baris keempat
        con = New SqlConnection("Data Source = " & server & "; Database=" & database & ";user id=" & user & ";password=" & password & "")
        con.Open()
        If con.State <> ConnectionState.Open Then
            Return False
        Else
            MsgBox("koneksi terbuka")
        End If
    End Function
    Public Sub closeCon()
        If Not IsNothing(con) Then
            con.Close()
            con = Nothing
        End If
    End Sub
    Public Function GetNumberOfLines(ByVal file_path As String) As Integer
        Dim sr As New StreamReader(file_path)
        Dim NumberOfLines As Integer
        Do While sr.Peek >= 0
            sr.ReadLine()
            NumberOfLines += 1
        Loop
        Return NumberOfLines
        sr.Close()
        sr.Dispose()
    End Function
    Public Function ReadALine(ByVal File_Path As String, ByVal TotalLine As Integer, ByVal Line2Read As Integer) As String
        Dim Buffer As Array
        Dim Line As String
        If TotalLine <= Line2Read Then
            Return "No Such Line"
        End If
        Buffer = File.ReadAllLines(File_Path)
        Line = Buffer(Line2Read)
        Return Line
    End Function

End Class
