Public Class frmMedidoresHorario
    Dim dt As DataTable
    ReadOnly bs As New BindingSource

    Private Sub frmMedidoresHorario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AtualizarLista()

        Me.Text += "   --   " + String.Format("Versão {0}", My.Application.Info.Version.ToString)

    End Sub
    Private Sub AtualizarLista()
        Try
            Using da = New SqlClient.SqlDataAdapter("Select * from ViewMedidoresHorario", My.Settings.dbGeral)
                Using ds As New DataSet
                    da.Fill(ds, "ViewMedidoresHorario")
                    dt = ds.Tables("ViewMedidoresHorario")
                End Using
            End Using

            bs.DataSource = dt
            ViewMedidoresHorarioDataGridView.DataSource = bs
            DataGridView1.DataSource = bs
            bs.MoveFirst()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        AtualizarLista()


    End Sub
End Class