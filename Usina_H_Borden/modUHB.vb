Imports System.Data.SqlClient
Imports System.Security.Principal.WindowsIdentity

Module modUHB

    Public strCampos, strTabela, strFiltro, strOrdem, strTitulo, strOperacao, strOperacaoPlanejamento As String 'para utilizar em instruções sql
    Public intOds As Integer
    Public Campos, Tabela, Condicao, Ordem, strFiltroAdicional As String

    Function TrataDatas(ByVal Data As String)

        TrataDatas = Mid(Data, 4, 2) & "/" & Mid(Data, 1, 2) & "/" & Mid(Data, 7, 4)

    End Function

End Module
