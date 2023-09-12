Imports System.Data.SqlClient

Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Imports System.Text
Imports System.Runtime.InteropServices
Public Class Config_Class
    ReadOnly Servidor As String = "ns1036.hostgator.com.br"
    ReadOnly Database As String = "quenti94_sys"
    ReadOnly UserID As String = "quenti94_us "
    ReadOnly Senha As String = "N78951753ais%$"
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand
    ReadOnly ds As New DataSet
    Dim adpt As New MySqlDataAdapter
    Public strCon As String = $"server = {Servidor}; database ={Database}; user id = {UserID};  password= {Senha}; port = 3306"

    Public Function Listar(ByVal sql As String)
        con = New MySqlConnection(strCon)
        con.Open()
        adpt = New MySqlDataAdapter(sql, con)
        ds.Clear()
        adpt.Fill(ds)
        con.Close()
        Return ds
    End Function
    Public Sub Operar(ByVal sql As String)
        con = New MySqlConnection(strCon)
        con.Open()
        cmd = New MySqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Function TxtAleatorio(ByVal inttamanho As Integer) As String
        Static rand As New Random
        Dim senha As New System.Text.StringBuilder(inttamanho)
        ' Dim senha As New Text.stringbuilder(inttamanho)
        For I As Integer = 1 To inttamanho
            Dim Index As Integer
            Do
                Index = rand.Next(48, 123)
            Loop Until (Index >= 65 AndAlso Index <= 90) OrElse (Index >= 48 AndAlso Index <= 57)
            ' Loop Until (Index >= 48 AndAlso Index <= 57) OrElse (Index >= 48 AndAlso Index <= 90) OrElse (Index >= 97 AndAlso Index <= 122)
            senha.Append(Convert.ToChar(Index))
        Next
        Return senha.ToString
    End Function 'GERAR SENHA

End Class