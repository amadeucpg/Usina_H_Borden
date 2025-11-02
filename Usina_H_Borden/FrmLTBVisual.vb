Public Class FrmLTBVisual
    Dim DataIni, DataTerm As String
    Dim tRow As DataRow
    Dim tTbl As DataTable
    Dim comando As New SqlClient.SqlCommand
    Dim reg As Short
    Dim sqlIncluir As String
    Dim sqlAlterar As String
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As DataSet
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        If (ComboBox1.Text <> "" And ComboBox2.Text <> "" And ComboBox3.Text <> "" And ComboBox4.Text <> "") Then
            If (ComboBox1.Text <> ":" And ComboBox2.Text <> ":" And ComboBox3.Text <> ":" And ComboBox4.Text <> ":") Then
                If (ComboBox1.Text <> "-" And ComboBox2.Text <> "-" And ComboBox3.Text <> "-" And ComboBox4.Text <> "-") Then

                    DataIni = DateTimePicker1.Value.Day.ToString() & "/" & DateTimePicker1.Value.Month.ToString() & "/" & DateTimePicker1.Value.Year.ToString()
                    DataTerm = DateTimePicker2.Value.Day.ToString() & "/" & DateTimePicker2.Value.Month.ToString() & "/" & DateTimePicker2.Value.Year.ToString()

                    TextBox5.Text = CalcTempo(DataIni, DataTerm, DataIni & " " & ComboBox1.Text & ":" & ComboBox2.Text, DataTerm & " " & ComboBox4.Text & ":" & ComboBox3.Text)
                End If
            End If
        End If
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If (ComboBox1.Text <> "" And ComboBox2.Text <> "" And ComboBox3.Text <> "" And ComboBox4.Text <> "") Then
            If (ComboBox1.Text <> ":" And ComboBox2.Text <> ":" And ComboBox3.Text <> ":" And ComboBox4.Text <> ":") Then
                If (ComboBox1.Text <> "-" And ComboBox2.Text <> "-" And ComboBox3.Text <> "-" And ComboBox4.Text <> "-") Then

                    DataIni = DateTimePicker1.Value.Day.ToString() & "/" & DateTimePicker1.Value.Month.ToString() & "/" & DateTimePicker1.Value.Year.ToString()
                    DataTerm = DateTimePicker2.Value.Day.ToString() & "/" & DateTimePicker2.Value.Month.ToString() & "/" & DateTimePicker2.Value.Year.ToString()

                    TextBox5.Text = CalcTempo(DataIni, DataTerm, DataIni & " " & ComboBox1.Text & ":" & ComboBox2.Text, DataTerm & " " & ComboBox4.Text & ":" & ComboBox3.Text)
                End If
            End If
        End If
    End Sub
    Private Sub FrmLTBVisual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If StrOperacaoLTB = "Incluir" Then
            Label6.Text = "Licença para Trabalhar - Nova"
            DestravaControles()
            LimparDados()
            Button1.Enabled = False
            Button2.Enabled = False
            BtnSalvar.Enabled = True

        ElseIf StrOperacaoLTB = "Alterar" Then
            Label6.Text = "Licença para Trabalhar - Alteração"
            'MsgBox("teste)")

        ElseIf StrOperacaoLTB = "Visualizar" Then
            Label6.Text = "Licença para Trabalhar - Visualização"
            ExibirDados()
            TravaControles()
            Button1.Enabled = True
            Button2.Enabled = True
            BtnSalvar.Enabled = False

            If ComboBox5.Text <> "" Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If
            If TextBox1.Text <> "" Then
                Button1.Enabled = False
            Else
                Button1.Enabled = True
            End If

        End If

        If intRegUsuario = 1195 Then
            Button3.Enabled = True
        Else
            Button3.Enabled = False
        End If

    End Sub
    Private Sub CboLocal_DropDown(sender As Object, e As EventArgs) Handles CboLocal.DropDown
        Try
            Using da As New SqlClient.SqlDataAdapter("Select Local from Locais order by local", cnnMackGeral)
                Using ds As New DataSet
                    da.Fill(ds, "Locais")
                    tTbl = ds.Tables("Locais")
                End Using
            End Using
            With CboLocal
                .Items.Clear()
                .BeginUpdate()
                For Each tRow In tTbl.Rows
                    .Items.Add(tRow(0).ToString)
                Next
                .EndUpdate()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Me.Refresh()
        Me.Close()

    End Sub
    Private Sub CboHabilitada_DropDown(sender As Object, e As EventArgs) Handles CboHabilitada.DropDown
        Try
            Using da As New SqlClient.SqlDataAdapter("Select Nome from PessoalQQ where Local like '%" & "GPH" & "%' order by Nome", cnnMackGeral)
                Using ds As New DataSet
                    da.Fill(ds, "PessoalQQ")
                    tTbl = ds.Tables("PessoalQQ")
                End Using
            End Using
            With CboHabilitada
                .Items.Clear()
                .BeginUpdate()
                For Each tRow In tTbl.Rows
                    .Items.Add(tRow(0).ToString)
                Next
                .EndUpdate()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        If StrOperacaoLTB = "Incluir" Then
            IncluirRegistro()
        ElseIf StrOperacaoLTB = "Alterar" Then
            AlterarRegistro()
        End If

        Me.Close()

    End Sub
    Private Sub CboAutorizada_DropDown(sender As Object, e As EventArgs) Handles CboAutorizada.DropDown
        Try
            Using da As New SqlClient.SqlDataAdapter("Select Nome from PessoalQQ where (Local like '%" & "GPH" & "%' AND LTB ='" & "Autorizada" & "') order by Nome", cnnMackGeral)
                Using ds As New DataSet
                    da.Fill(ds, "PessoalQQ")
                    tTbl = ds.Tables("PessoalQQ")
                End Using
            End Using
            With CboAutorizada
                .Items.Clear()
                .BeginUpdate()
                For Each tRow In tTbl.Rows
                    .Items.Add(tRow(0).ToString)
                Next
                .EndUpdate()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CboExpAutorizada_DropDown(sender As Object, e As EventArgs) Handles CboExpAutorizada.DropDown

        Try
            Using da As New SqlClient.SqlDataAdapter("Select Nome from PessoalQQ where (Local like '%" & "GPH" & "%' AND LTB ='" & "ExpressamenteAutorizada" & "') order by Nome", cnnMackGeral)
                Using ds As New DataSet
                    da.Fill(ds, "PessoalQQ")
                    tTbl = ds.Tables("PessoalQQ")
                End Using
            End Using
            With CboExpAutorizada
                .Items.Clear()
                .BeginUpdate()
                For Each tRow In tTbl.Rows
                    .Items.Add(tRow(0).ToString)
                Next
                .EndUpdate()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub IncluirRegistro()
        Dim hi As String = ComboBox1.Text & ":" & ComboBox2.Text
        Dim hf As String = ComboBox4.Text & ":" & ComboBox3.Text
        Dim ha As String = ComboBox6.Text & ":" & ComboBox7.Text
        Dim hea As String = ComboBox8.Text & ":" & ComboBox9.Text
        Try
            cnnMackGeral.Open()
            comando = New SqlClient.SqlCommand("INSERIR_LTB", cnnMackGeral)
            With comando
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@LOCAL", CboLocal.Text)
                .Parameters.AddWithValue("@EQUIPAMENTO", TxtEquipamento.Text)
                .Parameters.AddWithValue("@PREVTEMPO", TextBox5.Text)
                .Parameters.AddWithValue("@UNIDADE", CboUnidade.Text)
                .Parameters.AddWithValue("@HORAINICIO", hi)
                .Parameters.AddWithValue("@DATAINICIO", DateTimePicker1.Value)
                .Parameters.AddWithValue("@HORAFINAL", hf)
                .Parameters.AddWithValue("@DATAFINAL", DateTimePicker2.Value)
                .Parameters.AddWithValue("@FINALIDADE", TxtFinalidade.Text)
                .Parameters.AddWithValue("@HABILITADO", CboHabilitada.Text)
                .Parameters.AddWithValue("@AUTORIZADO", CboAutorizada.Text)
                .Parameters.AddWithValue("@HORAAUTORIZADO", ha)
                .Parameters.AddWithValue("@DATAAUTORIZADO", DateTimePicker3.Value)
                .Parameters.AddWithValue("@EXPAUTORIZADO", CboExpAutorizada.Text)
                .Parameters.AddWithValue("@HORAEXPAUTORIZADO", hea)
                .Parameters.AddWithValue("@DATAEXPAUTORIZADO", DateTimePicker4.Value)
                .Parameters.AddWithValue("@OBSERVACAO", TxtObservacao.Text)
                .Parameters.AddWithValue("@DISPONIBILIDADE", TxtDisponibilidade.Text)
                .Parameters.AddWithValue("@NEWLTB", 0).Direction = ParameterDirection.Output

                reg = .ExecuteNonQuery

                If reg > 0 Then
                    If MsgBox("A LTB n° " & .Parameters("@NEWLTB").Value & " Foi incluida com sucesso. Deseja imprimir a LTB?", MsgBoxStyle.YesNo) = vbYes Then
                        intLTB = .Parameters("@NEWLTB").Value
                        frmRelLTB.ShowDialog()
                    End If
                End If

            End With


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnnMackGeral.Close()
        End Try
    End Sub
    Private Sub AlterarRegistro()
        Dim hi As String = ComboBox1.Text & ":" & ComboBox2.Text
        Dim hf As String = ComboBox4.Text & ":" & ComboBox3.Text
        Dim ha As String = ComboBox6.Text & ":" & ComboBox7.Text
        Dim hea As String = ComboBox8.Text & ":" & ComboBox9.Text
        Try
            cnnMackGeral.Open()
            comando = New SqlClient.SqlCommand("ALTERAR_LTB", cnnMackGeral)
            With comando
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@ID", intLTB)
                .Parameters.AddWithValue("@LOCAL", CboLocal.Text)
                .Parameters.AddWithValue("@EQUIPAMENTO", TxtEquipamento.Text)
                .Parameters.AddWithValue("@PREVTEMPO", TextBox5.Text)
                .Parameters.AddWithValue("@UNIDADE", CboUnidade.Text)
                .Parameters.AddWithValue("@HORAINICIO", hi)
                .Parameters.AddWithValue("@DATAINICIO", DateTimePicker1.Value)
                .Parameters.AddWithValue("@HORAFINAL", hf)
                .Parameters.AddWithValue("@DATAFINAL", DateTimePicker2.Value)
                .Parameters.AddWithValue("@FINALIDADE", TxtFinalidade.Text)
                .Parameters.AddWithValue("@HABILITADO", CboHabilitada.Text)
                .Parameters.AddWithValue("@AUTORIZADO", CboAutorizada.Text)
                .Parameters.AddWithValue("@HORAAUTORIZADO", ha)
                .Parameters.AddWithValue("@DATAAUTORIZADO", DateTimePicker3.Value)
                .Parameters.AddWithValue("@EXPAUTORIZADO", CboExpAutorizada.Text)
                .Parameters.AddWithValue("@HORAEXPAUTORIZADO", hea)
                .Parameters.AddWithValue("@DATAEXPAUTORIZADO", DateTimePicker4.Value)
                .Parameters.AddWithValue("@OBSERVACAO", TxtObservacao.Text)
                .Parameters.AddWithValue("@DISPONIBILIDADE", TxtDisponibilidade.Text)

                reg = .ExecuteNonQuery
            End With
            If reg <> 0 Then

                If MsgBox(" Registro alterado com sucesso. Deseja imprimir a LTB?", MsgBoxStyle.YesNo) = vbYes Then

                    frmRelLTB.ShowDialog()

                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnnMackGeral.Close()
        End Try
    End Sub
    Private Sub TravaControles()

        For Each c As Control In Me.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Or
                TypeOf c Is DateTimePicker Or TypeOf c Is CheckBox Then

                c.Enabled = False
            End If
        Next
        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Or
                TypeOf c Is DateTimePicker Or TypeOf c Is CheckBox Then

                c.Enabled = False
            End If
        Next
    End Sub
    Private Sub DestravaControles()

        For Each c As Control In Me.Controls
            If c.Tag <> "Bloqueado" Then
                If TypeOf c Is TextBox Or TypeOf c Is ComboBox Or
                    TypeOf c Is DateTimePicker Or TypeOf c Is CheckBox Then

                    c.Enabled = True

                End If
            End If
        Next
        For Each c As Control In Me.GroupBox1.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Or
                TypeOf c Is DateTimePicker Or TypeOf c Is CheckBox Then

                c.Enabled = True
            End If
        Next
    End Sub
    Private Sub ExibirDados()

        Try
            Using da = New SqlClient.SqlDataAdapter("select * from LTB where NumLic=" & intLTB, cnnMackGeral)
                Using ds As New DataSet
                    da.Fill(ds, "LTB")

                    Dim dr As DataRow = ds.Tables("LTB").Rows(0)

                    TxtNumLic.Text = dr("NumLic")
                    If Not (dr("Local") Is DBNull.Value) Then CboLocal.Text = dr("Local") Else CboLocal.Text = ""
                    If Not dr("Unidade") Is DBNull.Value Then CboUnidade.Text = dr("Unidade") Else CboUnidade.Text = ""
                    If Not (dr("Equipamento") Is DBNull.Value) Then TxtEquipamento.Text = dr("Equipamento") Else TxtEquipamento.Text = ""
                    If Not (dr("DataInicio") Is DBNull.Value) Then DateTimePicker1.Value = dr("DataInicio")
                    If Not dr("DataFinal") Is DBNull.Value Then DateTimePicker2.Value = dr("DataFinal")
                    If Not dr("Finalidade") Is DBNull.Value Then TxtFinalidade.Text = dr("Finalidade") Else TxtFinalidade.Text = ""
                    If Not (dr("Habilitado") Is DBNull.Value) Then CboHabilitada.Text = dr("Habilitado") Else CboHabilitada.Text = ""
                    If Not dr("Autorizado") Is DBNull.Value Then CboAutorizada.Text = dr("Autorizado") Else CboAutorizada.Text = ""
                    If Not dr("DataAutorizado") Is DBNull.Value Then DateTimePicker3.Value = dr("DataAutorizado")
                    If Not dr("ExpAutorizado") Is DBNull.Value Then CboExpAutorizada.Text = dr("ExpAutorizado") Else CboExpAutorizada.Text = ""
                    If Not dr("DataExpAutorizado") Is DBNull.Value Then DateTimePicker4.Value = dr("DataExpAutorizado")
                    If Not dr("PrevTempo") Is DBNull.Value Then TextBox5.Text = dr("PrevTempo") Else TextBox5.Text = ""
                    If Not dr("Observacao") Is DBNull.Value Then TxtObservacao.Text = dr("Observacao") Else TxtObservacao.Text = ""
                    If Not dr("PrazoDisponibilidade") Is DBNull.Value Then TxtDisponibilidade.Text = dr("PrazoDisponibilidade") Else TxtDisponibilidade.Text = ""
                    If Not dr("ExpAutorizadoEncerramento") Is DBNull.Value Then ComboBox5.Text = dr("ExpAutorizadoEncerramento") Else ComboBox5.Text = ""
                    If Not dr("DataEncerramento") Is DBNull.Value Then TextBox1.Text = dr("DataEncerramento") Else TextBox1.Text = ""
                    If Not dr("HoraInicio") Is DBNull.Value Then
                        If Len(dr("HoraInicio")) = 4 Then
                            ComboBox1.Text = Mid(dr("HoraInicio"), 1, 1)
                            ComboBox2.Text = Mid(dr("HoraInicio"), 3, 2)
                        ElseIf Len(dr("HoraInicio")) = 5 Then
                            ComboBox1.Text = Mid(dr("HoraInicio"), 1, 2)
                            ComboBox2.Text = Mid(dr("HoraInicio"), 4, 2)
                        Else
                            ComboBox1.Text = "-"
                            ComboBox2.Text = "-"
                        End If
                    End If
                    If Not dr("HoraFinal") Is DBNull.Value Then
                        If Len(dr("HoraFinal")) = 4 Then
                            ComboBox4.Text = Mid(dr("HoraFinal"), 1, 1)
                            ComboBox3.Text = Mid(dr("HoraFinal"), 3, 2)
                        ElseIf Len(dr("HoraFinal")) = 5 Then
                            ComboBox4.Text = Mid(dr("HoraFinal"), 1, 2)
                            ComboBox3.Text = Mid(dr("HoraFinal"), 4, 2)
                        Else
                            ComboBox4.Text = "-"
                            ComboBox3.Text = "-"

                        End If
                    End If
                    If Not dr("HoraAutorizado") Is DBNull.Value Then
                        If Len(dr("HoraAutorizado")) = 4 Then
                            ComboBox6.Text = Mid(dr("HoraAutorizado"), 1, 1)
                            ComboBox7.Text = Mid(dr("HoraAutorizado"), 3, 2)
                        ElseIf Len(dr("HoraAutorizado")) = 5 Then
                            ComboBox6.Text = Mid(dr("HoraAutorizado"), 1, 2)
                            ComboBox7.Text = Mid(dr("HoraAutorizado"), 4, 2)
                        Else
                            ComboBox6.Text = "-"
                            ComboBox7.Text = "-"
                        End If
                    End If
                    If Not dr("HoraExpAutorizado") Is DBNull.Value Then
                        If Len(dr("HoraExpAutorizado")) = 4 Then
                            ComboBox8.Text = Mid(dr("HoraExpAutorizado"), 1, 1)
                            ComboBox9.Text = Mid(dr("HoraExpAutorizado"), 3, 2)
                        ElseIf Len(dr("HoraExpAutorizado")) = 5 Then
                            ComboBox8.Text = Mid(dr("HoraExpAutorizado"), 1, 2)
                            ComboBox9.Text = Mid(dr("HoraExpAutorizado"), 4, 2)
                        Else
                            ComboBox8.Text = "-"
                            ComboBox9.Text = "-"
                        End If
                    End If
                    If Not dr("HoraExpAutorizado") Is DBNull.Value Then
                        If Len(dr("HoraExpAutorizado")) = 4 Then
                            ComboBox8.Text = Mid(dr("HoraExpAutorizado"), 1, 1)
                            ComboBox9.Text = Mid(dr("HoraExpAutorizado"), 3, 2)
                        ElseIf Len(dr("HoraExpAutorizado")) = 5 Then
                            ComboBox8.Text = Mid(dr("HoraExpAutorizado"), 1, 2)
                            ComboBox9.Text = Mid(dr("HoraExpAutorizado"), 4, 2)
                        Else
                            ComboBox8.Text = "-"
                            ComboBox9.Text = "-"
                        End If
                    End If
                    If Not dr("HoraEncerramento") Is DBNull.Value Then
                        If Len(dr("HoraEncerramento")) = 4 Then
                            ComboBox10.Text = Mid(dr("HoraEncerramento"), 1, 1)
                            ComboBox11.Text = Mid(dr("HoraEncerramento"), 3, 2)
                        ElseIf Len(dr("HoraInicio")) = 5 Then
                            ComboBox10.Text = Mid(dr("HoraEncerramento"), 1, 2)
                            ComboBox11.Text = Mid(dr("HoraEncerramento"), 4, 2)
                        Else
                            ComboBox10.Text = "-"
                            ComboBox11.Text = "-"
                        End If
                    End If


                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ComboBox1_LostFocus(sender As Object, e As EventArgs) Handles ComboBox1.LostFocus
        If (ComboBox2.Text <> "" And ComboBox3.Text <> "" And ComboBox4.Text <> "") Then
            If (ComboBox1.Text <> ":" And ComboBox2.Text <> ":" And ComboBox3.Text <> ":" And ComboBox4.Text <> ":") Then
                If (ComboBox1.Text <> "-" And ComboBox2.Text <> "-" And ComboBox3.Text <> "-" And ComboBox4.Text <> "-") Then

                    DataIni = DateTimePicker1.Value.Day.ToString() & "/" & DateTimePicker1.Value.Month.ToString() & "/" & DateTimePicker1.Value.Year.ToString()
                    DataTerm = DateTimePicker2.Value.Day.ToString() & "/" & DateTimePicker2.Value.Month.ToString() & "/" & DateTimePicker2.Value.Year.ToString()

                    TextBox5.Text = CalcTempo(DataIni, DataTerm, DataIni & " " & ComboBox1.Text & ":" & ComboBox2.Text, DataTerm & " " & ComboBox4.Text & ":" & ComboBox3.Text)
                End If
            End If
        End If
    End Sub
    Private Sub ComboBox2_LostFocus(sender As Object, e As EventArgs) Handles ComboBox2.LostFocus
        If (ComboBox1.Text <> ":" And ComboBox2.Text <> ":" And ComboBox3.Text <> ":" And ComboBox4.Text <> ":") Then
            If (ComboBox1.Text <> "-" And ComboBox2.Text <> "-" And ComboBox3.Text <> "-" And ComboBox4.Text <> "-") Then
                If (ComboBox1.Text <> "-" And ComboBox3.Text <> "-" And ComboBox4.Text <> "-") Then
                    DataIni = DateTimePicker1.Value.Day.ToString() & "/" & DateTimePicker1.Value.Month.ToString() & "/" & DateTimePicker1.Value.Year.ToString()
                    DataTerm = DateTimePicker2.Value.Day.ToString() & "/" & DateTimePicker2.Value.Month.ToString() & "/" & DateTimePicker2.Value.Year.ToString()

                    TextBox5.Text = CalcTempo(DataIni, DataTerm, DataIni & " " & ComboBox1.Text & ":" & ComboBox2.Text, DataTerm & " " & ComboBox4.Text & ":" & ComboBox3.Text)
                End If
            End If
        End If

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        DestravaControles()
        BtnSalvar.Enabled = True
        Button1.Enabled = False
        Label6.Text = "Licença para Trabalhar - Alteração"
        StrOperacaoLTB = "Alterar"

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        frmRelLTB.ShowDialog()

    End Sub
    Private Sub ComboBox4_LostFocus(sender As Object, e As EventArgs) Handles ComboBox4.LostFocus
        If (ComboBox1.Text <> ":" And ComboBox2.Text <> ":" And ComboBox3.Text <> ":" And ComboBox4.Text <> ":") Then
            If (ComboBox1.Text <> "-" And ComboBox2.Text <> "-" And ComboBox3.Text <> "-" And ComboBox4.Text <> "-") Then
                If (ComboBox2.Text <> "-" And ComboBox3.Text <> "-" And ComboBox1.Text <> "-") Then

                    DataIni = DateTimePicker1.Value.Day.ToString() & "/" & DateTimePicker1.Value.Month.ToString() & "/" & DateTimePicker1.Value.Year.ToString()
                    DataTerm = DateTimePicker2.Value.Day.ToString() & "/" & DateTimePicker2.Value.Month.ToString() & "/" & DateTimePicker2.Value.Year.ToString()

                    TextBox5.Text = CalcTempo(DataIni, DataTerm, DataIni & " " & ComboBox1.Text & ":" & ComboBox2.Text, DataTerm & " " & ComboBox4.Text & ":" & ComboBox3.Text)
                End If
            End If
        End If

    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub ComboBox3_LostFocus(sender As Object, e As EventArgs) Handles ComboBox3.LostFocus
        If (ComboBox1.Text <> ":" And ComboBox2.Text <> ":" And ComboBox3.Text <> ":" And ComboBox4.Text <> ":") Then
            If (ComboBox1.Text <> "-" And ComboBox2.Text <> "-" And ComboBox3.Text <> "-" And ComboBox4.Text <> "-") Then
                If (ComboBox2.Text <> "-" And ComboBox1.Text <> "-" And ComboBox4.Text <> "-") Then

                    DataIni = DateTimePicker1.Value.Day.ToString() & "/" & DateTimePicker1.Value.Month.ToString() & "/" & DateTimePicker1.Value.Year.ToString()
                    DataTerm = DateTimePicker2.Value.Day.ToString() & "/" & DateTimePicker2.Value.Month.ToString() & "/" & DateTimePicker2.Value.Year.ToString()

                    TextBox5.Text = CalcTempo(DataIni, DataTerm, DataIni & " " & ComboBox1.Text & ":" & ComboBox2.Text, DataTerm & " " & ComboBox4.Text & ":" & ComboBox3.Text)
                End If
            End If
        End If

    End Sub

    Private Sub CboHabilitada_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboHabilitada.SelectedIndexChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        frmEncerramentoLtb.ShowDialog()


    End Sub

    Private Sub LimparDados()

        TxtNumLic.Text = ""
        CboLocal.Text = ""
        CboUnidade.Text = "-"
        TxtEquipamento.Text = ""
        ComboBox1.Text = "-"
        ComboBox2.Text = "-"
        ComboBox3.Text = "-"
        ComboBox4.Text = "-"
        DateTimePicker1.Value = Now
        DateTimePicker2.Value = Now
        TxtFinalidade.Text = ""
        CboHabilitada.Text = ""
        CboAutorizada.Text = ""
        DateTimePicker3.Value = Now
        CboExpAutorizada.Text = ""
        DateTimePicker4.Value = Now
        TextBox5.Text = ""
        TxtObservacao.Text = ""
        ComboBox6.Text = "-"
        ComboBox7.Text = "-"
        ComboBox8.Text = "-"
        ComboBox9.Text = "-"
        TxtDisponibilidade.Text = ""
        ComboBox5.Text = ""
        TextBox1.Text = ""
        ComboBox10.Text = ""
        ComboBox11.Text = ""

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub EncerrarLtb()

    End Sub
End Class