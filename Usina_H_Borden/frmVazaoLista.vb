Public Class frmVazaoLista
    Dim dt As DataTable
    ReadOnly bs As New BindingSource
    Dim strDataInicio As String = ""
    Dim strDataFim As String = ""
    Dim strHoraInicio As String = " 00:00"
    Dim strHoraFim As String = " 23:59:59"



    Private Sub frmVazaoLista_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AtualizaDados()

        optAberturaTodas.Checked = True

        GroupBox9.Height = 36



    End Sub
    Public Sub AtualizaDados()
        Campos = "select top(2000) * "
        Tabela = "from Vazao "
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

        Try
            Using da = New SqlClient.SqlDataAdapter(Campos & Tabela & Condicao & strFiltroAdicional & Ordem, cnnDados_CV)
                Using ds As New DataSet
                    da.Fill(ds, "Vazao")
                    dt = ds.Tables("Vazao")
                End Using
            End Using

            bs.DataSource = dt
            DataGridViewVazao.DataSource = bs
            BindingNavigator1.BindingSource = bs
            bs.MoveFirst()



            strTitulo = "Lista de Alarmes e/ou Eventos  --  " & Now

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        AtualizaDados()


    End Sub

    Private Sub optAberturaTodas_CheckedChanged(sender As Object, e As EventArgs) Handles optAberturaTodas.CheckedChanged

        AtualizaDados()

    End Sub

    Private Sub optAberturaPorPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles optAberturaPorPeriodo.CheckedChanged
        With GroupBox9
            If .Height = 60 Then .Height = 36 Else .Height = 60
        End With

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmRelVazao.ShowDialog()

    End Sub
End Class