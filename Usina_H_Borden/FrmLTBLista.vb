Public Class FrmLTBLista
    Dim dt As DataTable
    ReadOnly bs As New BindingSource
    Dim tTbl
    'Dim tRow As DataRow, tTbl As DataTable

    Private Sub FrmLTBLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        strTabela = " LTB "
        strFiltro = " WHERE NumLic <> 0 "
        strFiltroAdicional = ""
        optAberturaTodas.Checked = True
        GroupBox9.Height = 36

        'AplicarFiltro()

    End Sub

    Private Sub btnVisualizarOds_Click(sender As Object, e As EventArgs) Handles btnVisualizarOds.Click

        Try
            StrOperacaoLTB = "Visualizar"
            intLTB = LTBDataGridView.CurrentRow.Cells(0).Value
            FrmLTBVisual.ShowDialog()
            AtualizarLista()
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub BtnAtualizar_Click(sender As Object, e As EventArgs) Handles BtnAtualizar.Click

        AplicarFiltro()

    End Sub

    Private Sub AtualizarLista()

        Try
            intLTB = LTBDataGridView.CurrentRow.Cells(0).Value
            Using da = New SqlClient.SqlDataAdapter("SELECT * FROM" & strTabela & strFiltro & strFiltroAdicional & "ORDER BY NumLic DESC", cnnMackGeral)
                Using ds As New DataSet
                    da.Fill(ds, "LTB")
                    dt = ds.Tables("LTB")

                End Using
            End Using

            bs.DataSource = dt
            LTBDataGridView.DataSource = bs
            btnNavegador.BindingSource = bs
            bs.Position = bs.Find("NumLic", intLTB)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click

        StrOperacaoLTB = "Incluir"
        FrmLTBVisual.ShowDialog()
        AtualizarLista()

    End Sub

    Private Sub LTBDataGridView_SelectionChanged(sender As Object, e As EventArgs) Handles LTBDataGridView.SelectionChanged

        Try
            If bs.Position >= 0 And bs.Position < bs.Count Then
                txtLocalizar.Text = LTBDataGridView.CurrentRow.Cells(0).Value.ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnLocalizar_Click(sender As Object, e As EventArgs) Handles btnLocalizar.Click
        Try
            bs.Position = bs.Find("NumLic", txtLocalizar.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub LTBDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles LTBDataGridView.CellDoubleClick

        Try
            StrOperacaoLTB = "Visualizar"
            intLTB = LTBDataGridView.CurrentRow.Cells(0).Value
            FrmLTBVisual.ShowDialog()
            AtualizarLista()
        Catch ex As Exception
            MsgBox(ex)
        End Try

    End Sub

    Private Sub cboHabilitado_DropDown(sender As Object, e As EventArgs) Handles cboHabilitado.DropDown
        Try
            Using da As New SqlClient.SqlDataAdapter("select distinct Habilitado from" & strTabela & strFiltro & strFiltroAdicional & "order by Habilitado", cnnMackGeral)
                Using ds As New DataSet
                    da.Fill(ds, "Habilitado")
                    tTbl = ds.Tables("Habilitado")
                End Using
            End Using
            With cboHabilitado
                .Items.Clear()
                .BeginUpdate()
                For Each tRow In tTbl.Rows
                    .Items.Add(tRow(0).ToString)
                Next
                .Items.Add("Todos")
                .EndUpdate()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cboExpressamenteAutorizado_DropDown(sender As Object, e As EventArgs) Handles cboExpressamenteAutorizado.DropDown
        Try
            Using da As New SqlClient.SqlDataAdapter("select distinct ExpAutorizado from" & strTabela & strFiltro & strFiltroAdicional & "order by ExpAutorizado", cnnMackGeral)
                Using ds As New DataSet
                    da.Fill(ds, "LTB")
                    tTbl = ds.Tables("LTB")
                End Using
            End Using
            With cboExpressamenteAutorizado
                .Items.Clear()
                .BeginUpdate()
                For Each tRow In tTbl.Rows
                    .Items.Add(tRow(0).ToString)
                Next
                .Items.Add("Todos")
                .EndUpdate()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub AplicarFiltro()
        Dim strDataInicio As String = ""
        Dim strDataFim As String = ""
        Dim strHoraInicio As String = " 00:00"
        Dim strHoraFim As String = " 23:59:59"

        'Me.Cursor = Cursors.WaitCursor

        strTabela = " LTB "
        strFiltro = "WHERE NumLic <> 0 "
        strFiltroAdicional = ""

        If optAberturaPorPeriodo.Checked = True Then
            strDataInicio = TrataDatas(dtpAberturaInicio.Value.ToShortDateString())
            strDataFim = TrataDatas(dtpAberturaFim.Value.ToShortDateString())

            strFiltroAdicional = strFiltroAdicional & "and (DataAutorizado >= '" & strDataInicio &
            "' and DataAutorizado <= '" & strDataFim & "') "
        End If


        If cboHabilitado.Text <> "Todos" Then

            strFiltroAdicional = strFiltroAdicional & "and Habilitado like '%" & cboHabilitado.Text & "%' "

        End If

        If cboExpressamenteAutorizado.Text <> "Todos" Then

            strFiltroAdicional = strFiltroAdicional & "and ExpAutorizado like '%" & cboExpressamenteAutorizado.Text & "%' "

        End If

        If cboSituacao.Text <> "Todos" Then

            If cboSituacao.Text = "Abertas" Then
                strFiltroAdicional = strFiltroAdicional & "and DataEncerramento is null "
            ElseIf cboSituacao.Text = "Encerradas" Then
                strFiltroAdicional = strFiltroAdicional & "and DataEncerramento is not null "
            End If

        End If

        Try
            Using da = New SqlClient.SqlDataAdapter("SELECT * FROM" & strTabela & strFiltro & strFiltroAdicional & "ORDER BY NumLic DESC", cnnMackGeral)
                Using ds As New DataSet
                    da.Fill(ds, "LTB")
                    dt = ds.Tables("LTB")
                End Using
            End Using

            bs.DataSource = dt
            LTBDataGridView.DataSource = bs
            btnNavegador.BindingSource = bs
            bs.Position = bs.Find("NumLic", intLTB)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cboSituacao_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSituacao.SelectedIndexChanged

        AplicarFiltro()


    End Sub

    Private Sub cboHabilitado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboHabilitado.SelectedIndexChanged

        AplicarFiltro()

    End Sub

    Private Sub cboExpressamenteAutorizado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExpressamenteAutorizado.SelectedIndexChanged

        AplicarFiltro()


    End Sub

    Private Sub optAberturaPorPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles optAberturaPorPeriodo.CheckedChanged

        With GroupBox9
            If .Height = 60 Then .Height = 36 Else .Height = 60
        End With

    End Sub

    Private Sub optAberturaTodas_CheckedChanged(sender As Object, e As EventArgs) Handles optAberturaTodas.CheckedChanged

        AplicarFiltro()

    End Sub
End Class