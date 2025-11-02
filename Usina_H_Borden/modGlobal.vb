Imports System.Data.SqlClient
Imports System.Security
Imports System.Security.Principal.WindowsIdentity
Imports Microsoft.Reporting.WinForms

Module modGlobal

    'Banco de dados na rede
    Public cnn As New SqlConnection(
        "Data Source=172.16.4.90;Initial Catalog=CEM;Persist Security Info=True;User ID=cem_eng_sgcs;Password=sgcs_cem")

    Public cnnMackGeral As New SqlConnection(
        "Data Source=172.17.4.95\ELIPSEDATA;Initial Catalog=dbGeral;Persist Security Info=True;User ID=emae@elipse;Password=emae@2022")

    Public cnnDados_UE As New SqlConnection(
        "Data Source=172.17.4.95\ELIPSEDATA;Initial Catalog=Dados_UE;Persist Security Info=True;User ID=emae@elipse;Password=emae@2022")

    Public cnnDados_US As New SqlConnection(
        "Data Source=172.17.4.95\ELIPSEDATA;Initial Catalog=Dados_US;Persist Security Info=True;User ID=emae@elipse;Password=emae@2022")

    Public cnnDados_CV As New SqlConnection(
        "Data Source=172.17.4.95\ELIPSEDATA;Initial Catalog=Dados_CV;Persist Security Info=True;User ID=emae@elipse;Password=emae@2022")

    Public cnnDados_E88 As New SqlConnection(
        "Data Source=172.17.4.95\ELIPSEDATA;Initial Catalog=Dados_E88;Persist Security Info=True;User ID=emae@elipse;Password=emae@2022")

    Public cnnBDUsinaSubterranea As New SqlConnection(
        "Data Source=172.17.4.95\ELIPSEDATA;Initial Catalog=BDUsinaSubterranea;Persist Security Info=True;User ID=emae@elipse;Password=emae@2022")


    'BDUsinaSubterranea
    Public intOds As Integer
    Public strOperacao As String = ""
    Public strOperacaoPlanejamento As String
    Public StrCanceladas As Boolean
    Public comando As New SqlClient.SqlCommand
    Public reg As Short

    Public StrOperacaoLTB As String
    Public intLTB As Integer

    'Dados do usuário
    Public intRegUsuario As Integer
    Public strNomeUsuario As String
    Public btNivelUsuario As Byte
    Public strGrupoUsuario As String
    Public strLocalUsuario As String

    Public intUnidade As Integer

    Public limite As String = TrataDatas(DateAdd("d", -1460, Today))

    Function UsuarioWindows() As Integer

        Dim UW As String = GetCurrent.Name
        UsuarioWindows = Val(Mid(UW, Len(UW) - 4, 5))

    End Function

    Function CalcTempo(DataIni As Date, DataTerm As Date, HorIni As Date, HorTerm As Date)
        Dim intMinutos As Integer
        Dim intHoras As Integer
        Dim intDias As Integer
        Dim booErro As Boolean

        booErro = False

        intMinutos = DateDiff("n", HorIni, HorTerm)
        intHoras = intMinutos \ 60
        intMinutos = intMinutos Mod 60
        intDias = DateDiff("d", DataIni, DataTerm)

        If DataIni = DataTerm Then
            'se a data for igual
            'verifica erro
            If intMinutos < 0 Or intHoras < 0 Then
                'booErro = True
                MsgBox("A hora de inicio não pode ser maior que a hora de termino.", , " LTB ")
                Exit Function
            End If

            If intMinutos = 0 Then
                CalcTempo = intHoras & " Hora(s)"
            Else
                If intHoras = 0 Then
                    CalcTempo = intMinutos & " minuto(s)"
                Else
                    CalcTempo = intHoras & " Hora(s) e " & intMinutos & " minuto(s)"
                End If
            End If

        Else

            If intHoras > 7 Then
                intDias += 1
                CalcTempo = intDias & " Dia(s)"
            Else
                If intMinutos < 0 Or intHoras < 0 Then booErro = True
                If Not booErro Then
                    If intMinutos = 0 Then
                        CalcTempo = intDias & " Dia(s) e " & intHoras & " Hora(s)"
                    Else
                        CalcTempo = intDias & " Dia(s), " & intHoras & " Hora(s) e " & intMinutos & " minuto(s)"
                    End If
                Else
                    CalcTempo = intDias & " Dia(s)"
                End If
                'If booErro Then booErro = False
            End If

        End If

    End Function
    Function DescreveEquipamento(txtCodigo) As String

        Select Case Len(txtCodigo)
            Case Is = 4 'primeiro nivel
                Dim ds As New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 4) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = dr("Descricao")
            Case Is = 7 'segundo nivel
                Dim ds As New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 7) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = dr("Descricao")
                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 4) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr1 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr1("Descricao")
            Case Is = 10 'terceiro nivel
                Dim ds As New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 10) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = dr("Descricao")
                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 7) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr2 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr2("Descricao")
                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 4) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr1 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr1("Descricao")
            Case Is = 14 'quarto nivel
                Dim ds As New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 14) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = dr("Descricao")
                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 10) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr3 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr3("Descricao")

                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 7) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr2 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr2("Descricao")
                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 4) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr1 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr1("Descricao")
            Case Is = 17 'quinto nivel
                Dim ds As New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 17) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = dr("Descricao")

                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 14) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr4 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr4("Descricao")

                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 10) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr3 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr3("Descricao")

                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 7) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr2 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr2("Descricao")
                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 4) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr1 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr1("Descricao")
            Case Is = 20 'sexto nivel
                Dim ds As New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 20) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = dr("Descricao")
                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 17) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr5 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr5("Descricao")
                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 14) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr4 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr4("Descricao")

                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 10) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr3 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr3("Descricao")

                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 7) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr2 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr2("Descricao")
                ds = New DataSet
                Using da As New SqlClient.SqlDataAdapter("select * from geral where codigo= '" & Mid(txtCodigo, 1, 4) & "'", cnn)
                    da.Fill(ds, "geral")
                End Using
                Dim dr1 As DataRow = ds.Tables("geral").Rows(0)
                DescreveEquipamento = DescreveEquipamento & "/" & dr1("Descricao")

                'Case Is = 23 'sexto nivel
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 23) & "'", cnn, adOpenStatic, adLockReadOnly
                '            If Not rst.EOF Then
                '        DescreveEquipamento = DescreveEquipamento & !DESCRICAO
                '    End If
                '    .Close
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 20) & "'", cnn, adOpenStatic, adLockReadOnly
                '            If Not rst.EOF Then
                '        DescreveEquipamento = DescreveEquipamento & " / " & !DESCRICAO
                '    End If
                '    .Close
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 17) & "'", cnn, adOpenStatic, adLockReadOnly
                '            If Not rst.EOF Then
                '        DescreveEquipamento = DescreveEquipamento & " / " & !DESCRICAO
                '    End If
                '    .Close
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 14) & "'", cnn, adOpenStatic, adLockReadOnly
                '            DescreveEquipamento = DescreveEquipamento & " / " & !DESCRICAO
                '    .Close
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 10) & "'", cnn, adOpenStatic, adLockReadOnly
                '            DescreveEquipamento = DescreveEquipamento & " / " & !DESCRICAO
                '    .Close
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 7) & "'", cnn, adOpenStatic, adLockReadOnly
                '            DescreveEquipamento = DescreveEquipamento & " / " & !DESCRICAO
                '    .Close
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 4) & "'", cnn, adOpenStatic, adLockReadOnly
                '            DescreveEquipamento = DescreveEquipamento & " / " & !DESCRICAO
                '    .Close

                'Case Is = 26 'setimo nivel
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 26) & "'", cnn, adOpenStatic, adLockReadOnly
                '            If Not rst.EOF Then
                '        DescreveEquipamento = DescreveEquipamento & !DESCRICAO
                '    End If
                '    .Close
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 23) & "'", cnn, adOpenStatic, adLockReadOnly
                '            If Not rst.EOF Then
                '        DescreveEquipamento = DescreveEquipamento & " / " & !DESCRICAO
                '    End If
                '    .Close
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 20) & "'", cnn, adOpenStatic, adLockReadOnly
                '            If Not rst.EOF Then
                '        DescreveEquipamento = DescreveEquipamento & " / " & !DESCRICAO
                '    End If
                '    .Close
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 17) & "'", cnn, adOpenStatic, adLockReadOnly
                '            If Not rst.EOF Then
                '        DescreveEquipamento = DescreveEquipamento & " / " & !DESCRICAO
                '    End If
                '    .Close
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 14) & "'", cnn, adOpenStatic, adLockReadOnly
                '            DescreveEquipamento = DescreveEquipamento & " / " & !DESCRICAO
                '    .Close
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 10) & "'", cnn, adOpenStatic, adLockReadOnly
                '            DescreveEquipamento = DescreveEquipamento & " / " & !DESCRICAO
                '    .Close
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 7) & "'", cnn, adOpenStatic, adLockReadOnly
                '            DescreveEquipamento = DescreveEquipamento & " / " & !DESCRICAO
                '    .Close
                '    .Open "select * from geral where codigo= '" & Mid(txtCodigo, 1, 4) & "'", cnn, adOpenStatic, adLockReadOnly
                '            DescreveEquipamento = DescreveEquipamento & " / " & !DESCRICAO
                '    .Close
        End Select




    End Function

    Public Sub IncluirLogEvento(StrOperacaolOG As String, StrEvento As String, FrmName As String, StrNumero As Integer)

        Try
            cnnMackGeral.Open()
            comando = New SqlClient.SqlCommand("sp_insertlog", cnnMackGeral)
            With comando
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@FORMULARIO", FrmName)
                .Parameters.AddWithValue("@OPERACAO", StrOperacaolOG)
                .Parameters.AddWithValue("@NUMERO", StrNumero)
                .Parameters.AddWithValue("@HORA", "")
                .Parameters.AddWithValue("@USUARIO", strNomeUsuario)
                .Parameters.AddWithValue("@EVENTO", StrEvento)
                .Parameters.AddWithValue("@DETALHE", "SIGMA")
                reg = .ExecuteNonQuery
            End With
            cnnMackGeral.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Module
