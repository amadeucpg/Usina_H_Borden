Public Class frmUnidade
    Private Sub frmUnidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizaDados()

    End Sub
    Private Sub AtualizaDados()
        Dim dt As DataTable

        Try
            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Temperaturas_Estator_UG6 ORDER BY E3TimeStamp DESC", My.Settings.UG6ConnectionString)
                Using ds As New DataSet
                    da.Fill(ds, "Temperaturas_Estator_UG6")
                    dt = ds.Tables("Temperaturas_Estator_UG6")
                End Using
            End Using

            Dim dr As DataRow = dt.Rows(0)

            TxtRanhura2.Text = Decimal.Parse(dr("Temp_Ranhura_2")).ToString("#,##0.00") & " " & "°C"
            TxtRanhura69.Text = Decimal.Parse(dr("Temp_Ranhura_69")).ToString("#,##0.00") & " " & "°C"
            TxtRanhura72.Text = Decimal.Parse(dr("Temp_Ranhura_72")).ToString("#,##0.00") & " " & "°C"
            TxtRanhura142.Text = Decimal.Parse(dr("Temp_Ranhura_142")).ToString("#,##0.00") & " " & "°C"
            TxtRanhura209.Text = Decimal.Parse(dr("Temp_Ranhura_209")).ToString("#,##0.00") & " " & "°C"

            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Historico_Geral_UG06 ORDER BY E3TimeStamp DESC", My.Settings.UG6ConnectionString)
                Using ds As New DataSet
                    da.Fill(ds, "Historico_Geral_UG06")
                    dt = ds.Tables("Historico_Geral_UG06")
                End Using
            End Using

            Dim dr1 As DataRow = dt.Rows(0)

            TxtTensao.Text = Decimal.Parse(dr1("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"
            TxtPressaoHPU.Text = Decimal.Parse(dr1("Pressao_HPU_Controle")).ToString("#,##0.00") & " " & "Bar"

            TextBox1.Text = Now

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        AtualizaDados()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtPressaoHPU.TextChanged

    End Sub
End Class