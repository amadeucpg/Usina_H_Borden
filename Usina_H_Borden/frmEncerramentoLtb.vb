Public Class frmEncerramentoLtb
    Dim DataIni, DataTerm As String
    Dim tRow As DataRow
    Dim tTbl As DataTable
    Dim comando As New SqlClient.SqlCommand
    Dim reg As Short
    Dim sqlIncluir As String
    Dim sqlAlterar As String
    Dim da As SqlClient.SqlDataAdapter
    Dim ds As DataSet

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click

        EncerrarLtb()

        Me.Close()

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

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

        Me.Refresh()
        Me.Close()

    End Sub

    Private Sub EncerrarLtb()
        Dim he As String = ComboBox8.Text & ":" & ComboBox9.Text
        Try
            cnnMackGeral.Open()
            comando = New SqlClient.SqlCommand("ENCERRAR_LTB", cnnMackGeral)
            With comando
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@ID", intLTB)
                .Parameters.AddWithValue("@EXPAUTORIZADO", CboExpAutorizada.Text)
                .Parameters.AddWithValue("@HORAEXPAUTORIZADO", he)
                .Parameters.AddWithValue("@DATAEXPAUTORIZADO", DateTimePicker4.Value)

                reg = .ExecuteNonQuery
            End With

            If reg <> 0 Then

                MsgBox(" Ltb encerrada com sucesso.")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnnMackGeral.Close()
        End Try
    End Sub

End Class