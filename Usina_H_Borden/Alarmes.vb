Public Class Alarmes
    Dim dt As DataTable
    ReadOnly bs As New BindingSource

    Private Sub Alarmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        optAberturaTodas.Checked = True

        GroupBox9.Height = 36

        ToolStripLabel1.Text = "Atualizado em :- " & Now

        Me.Text = "Alarmes e Eventos"

        Me.Text += "   --   " + String.Format("Versão {0}", My.Application.Info.Version.ToString)

    End Sub
    Public Sub AtualizarDados()
        Dim strDataInicio As String = ""
        Dim strDataFim As String = ""
        Dim strHoraInicio As String = " 00:00"
        Dim strHoraFim As String = " 23:59:59"

        Me.Cursor = Cursors.WaitCursor

        Campos = "select top(2000)E3TimeStamp,EventTime,Area,Message, ConditionActive, Acked, Source, ActiveSource, FullAlarmSourceName, CurrentValue "
        Tabela = "from Alarms "
        Condicao = "where E3TimeStamp <> 0 "
        Ordem = "order by E3TimeStamp desc"
        strFiltroAdicional = ""
        strTitulo = ""

        If optAberturaPorPeriodo.Checked = True Then
            strDataInicio = TrataDatas(dtpAberturaInicio.Value.ToShortDateString())
            strDataFim = TrataDatas(dtpAberturaFim.Value.ToShortDateString())
            If cboHoraInicio.Text <> "" Then strHoraInicio = " " & cboHoraInicio.Text Else strHoraInicio = " 00:00"
            If cboHoraFinal.Text <> "" Then strHoraFim = " " & cboHoraFinal.Text Else strHoraFim = " 23:59:59"

            strFiltroAdicional = strFiltroAdicional & "and (E3TimeStamp >= '" & strDataInicio & strHoraInicio &
            "' and E3TimeStamp <= '" & strDataFim & strHoraFim & "') "
        End If

        If cboUnidade.Text <> "Todas" Then

            Dim u As String = "U" & cboUnidade.Text
            Dim ad As String = "AD" & cboUnidade.Text

            ad = Mid(ad, 1, 3)

            strFiltroAdicional = strFiltroAdicional & "and (Area like '%" & u & "%' or Area like '%" & ad & "%') "

        End If
        If cboRec.Text <> "Todos" Then
            Dim intRec As Integer

            If cboRec.Text = "Sim" Then intRec = 1 Else intRec = 0

            strFiltroAdicional = strFiltroAdicional & "and Acked = " & intRec

        End If

        If cboAlarmesEventos.Text <> "Todos" Then

            Dim u As String = "Eventos"

            If cboAlarmesEventos.Text = "Alarmes" Then

                strFiltroAdicional = strFiltroAdicional & "and Area not like '%" & u & "%' "

            ElseIf cboAlarmesEventos.Text = "Eventos" Then

                strFiltroAdicional = strFiltroAdicional & "and Area like '%" & u & "%' "

            End If

        End If

        If CboLocal.Text <> "Todos" Then
            Select Case CboLocal.Text
                Case "Usina Externa"
                    strFiltroAdicional = strFiltroAdicional & "and (Area like '%" & "UE." & "%' "
                    strFiltroAdicional = strFiltroAdicional & "or Area like '%" & ".UE" & "%') "
                Case "Usina Subterranea"
                    strFiltroAdicional = strFiltroAdicional & "and (Area like '%" & "US." & "%' "
                    strFiltroAdicional = strFiltroAdicional & "or Area like '%" & ".US" & "%') "

                Case "Casa de Valvulas"
                    strFiltroAdicional = strFiltroAdicional & "and (Area like '%" & "CV." & "%' "
                    strFiltroAdicional = strFiltroAdicional & "or Area like '%" & ".CV" & "%') "
                Case "Estrutura de 88kV"
                    strFiltroAdicional = strFiltroAdicional & "and Area like '%" & "E88." & "%' "
                Case "Estrutura de 230kV"
                    strFiltroAdicional = strFiltroAdicional & "and Area like '%" & "E230." & "%' "
                Case "Outras"
                    strFiltroAdicional = strFiltroAdicional & "and Area not like '%" & "UE." & "%' "
                    strFiltroAdicional = strFiltroAdicional & "and Area not like '%" & "US." & "%' "
                    strFiltroAdicional = strFiltroAdicional & "and Area not like '%" & "CV." & "%' "
                    strFiltroAdicional = strFiltroAdicional & "and Area not like '%" & "E88." & "%' "
                    strFiltroAdicional = strFiltroAdicional & "and Area not like '%" & "E230." & "%' "
                    strFiltroAdicional = strFiltroAdicional & "and Area not like '%" & ".US" & "%' "
                    strFiltroAdicional = strFiltroAdicional & "and Area not like '%" & ".UE" & "%' "
                    strFiltroAdicional = strFiltroAdicional & "and Area not like '%" & ".CV" & "%' "

            End Select
        End If

        Try
            Using da = New SqlClient.SqlDataAdapter(Campos & Tabela & Condicao & strFiltroAdicional & Ordem, My.Settings.dbAlarmes)
                Using ds As New DataSet
                    da.Fill(ds, "Alarms")
                    dt = ds.Tables("Alarms")
                End Using
            End Using

            bs.DataSource = dt
            View_1DataGridView.DataSource = bs
            BindingNavigator1.BindingSource = bs
            bs.MoveFirst()

            ToolStripLabel1.Text = "Atualizado em :- " & Now

            strTitulo = "Lista de Alarmes e/ou Eventos  --  " & Now

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        AtualizarDados()


    End Sub

    Private Sub optAberturaPorPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles optAberturaPorPeriodo.CheckedChanged
        With GroupBox9
            If .Height = 60 Then .Height = 36 Else .Height = 60
        End With

    End Sub

    Private Sub optAberturaTodas_CheckedChanged(sender As Object, e As EventArgs) Handles optAberturaTodas.CheckedChanged

        AtualizarDados()

    End Sub

    Private Sub cboUnidade_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUnidade.SelectedIndexChanged

        AtualizarDados()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmRelAlarmes.ShowDialog()

    End Sub

    Private Sub cboRec_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRec.SelectedIndexChanged

        AtualizarDados()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        AtualizarDados()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        optAberturaTodas.Checked = True
        cboUnidade.Text = "Todas"
        cboHoraInicio.Text = ""
        cboHoraFinal.Text = ""
        cboRec.Text = "Todos"
        cboAlarmesEventos.Text = "Todos"

        AtualizarDados()

    End Sub

    Private Sub cboAlarmesEventos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAlarmesEventos.SelectedIndexChanged

        AtualizarDados()

    End Sub

    Private Sub CboLocal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboLocal.SelectedIndexChanged

        AtualizarDados()

    End Sub

    Private Sub BindingNavigator1_RefreshItems(sender As Object, e As EventArgs) Handles BindingNavigator1.RefreshItems

    End Sub

    Private Sub BindingNavigatorPositionItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorPositionItem.Click

    End Sub
End Class