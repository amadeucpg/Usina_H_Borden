Public Class FrmInstante

    Dim dt As DataTable
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AtualizaDados()

        Me.Text = "Potências Instantâneas"
        Me.Text += "   --   " + String.Format("Versão {0}", My.Application.Info.Version.ToString)

    End Sub

    Private Sub AtualizaDados()

        Dim somaPotAtiva88 As Double = 0
        Dim somaPotReativa88 As Double = 0
        Dim somaPotAtiva230 As Double = 0
        Dim somaPotReativa230 As Double = 0
        Dim PosicaoDisjuntor As Integer


        Try
            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG01 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                Using ds As New DataSet
                    da.Fill(ds, "Medidas_Eletricas_UG01")
                    dt = ds.Tables("Medidas_Eletricas_UG01")
                End Using
            End Using

            Dim dr As DataRow = dt.Rows(0)

            TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

            PosicaoDisjuntor = ((2 * dr("Disjuntor_Aberto")) + (1 * dr("Disjuntor_Fechado")))

            Select Case PosicaoDisjuntor
                Case = 2
                    Label39.BackColor = Color.Transparent
                Case = 1
                    Label39.BackColor = Color.DarkGray
                Case = 0
                    Label39.BackColor = Color.Red
                Case = 3
                    Label39.BackColor = Color.Red
            End Select

            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG02 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                Using ds As New DataSet
                    da.Fill(ds, "Medidas_Eletricas_UG02")
                    dt = ds.Tables("Medidas_Eletricas_UG02")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox8.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

            PosicaoDisjuntor = ((2 * dr("Disjuntor_Aberto")) + (1 * dr("Disjuntor_Fechado")))

            Select Case PosicaoDisjuntor
                Case = 2
                    Label9.BackColor = Color.Transparent
                Case = 1
                    Label9.BackColor = Color.DarkGray
                Case = 0
                    Label9.BackColor = Color.Red
                Case = 3
                    Label9.BackColor = Color.Red
            End Select

            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG03 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                Using ds As New DataSet
                    da.Fill(ds, "Medidas_Eletricas_UG03")
                    dt = ds.Tables("Medidas_Eletricas_UG03")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox11.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

            PosicaoDisjuntor = ((2 * dr("Disjuntor_Aberto")) + (1 * dr("Disjuntor_Fechado")))

            Select Case PosicaoDisjuntor
                Case = 2
                    Label13.BackColor = Color.Transparent
                Case = 1
                    Label13.BackColor = Color.DarkGray
                Case = 0
                    Label13.BackColor = Color.Red
                Case = 3
                    Label13.BackColor = Color.Red
            End Select


            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG04 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                Using ds As New DataSet
                    da.Fill(ds, "Medidas_Eletricas_UG04")
                    dt = ds.Tables("Medidas_Eletricas_UG04")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox5.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"
            PosicaoDisjuntor = ((2 * dr("Disjuntor_Aberto")) + (1 * dr("Disjuntor_Fechado")))

            Select Case PosicaoDisjuntor
                Case = 2
                    Label5.BackColor = Color.Transparent
                Case = 1
                    Label5.BackColor = Color.DarkGray
                Case = 0
                    Label5.BackColor = Color.Red
                Case = 3
                    Label5.BackColor = Color.Red
            End Select

            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG05 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                Using ds As New DataSet
                    da.Fill(ds, "Medidas_Eletricas_UG05")
                    dt = ds.Tables("Medidas_Eletricas_UG05")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox14.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

            PosicaoDisjuntor = ((2 * dr("Disjuntor_Aberto")) + (1 * dr("Disjuntor_Fechado")))

            Select Case PosicaoDisjuntor
                Case = 2
                    Label19.BackColor = Color.Transparent
                Case = 1
                    Label19.BackColor = Color.DarkGray
                Case = 0
                    Label19.BackColor = Color.Red
                Case = 3
                    Label19.BackColor = Color.Red
            End Select


            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG06 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                Using ds As New DataSet
                    da.Fill(ds, "Medidas_Eletricas_UG06")
                    dt = ds.Tables("Medidas_Eletricas_UG06")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox17.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

            PosicaoDisjuntor = ((2 * dr("Disjuntor_Aberto")) + (1 * dr("Disjuntor_Fechado")))

            Select Case PosicaoDisjuntor
                Case = 2
                    Label23.BackColor = Color.Transparent
                Case = 1
                    Label23.BackColor = Color.DarkGray
                Case = 0
                    Label23.BackColor = Color.Red
                Case = 3
                    Label23.BackColor = Color.Red
            End Select


            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG07 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                Using ds As New DataSet
                    da.Fill(ds, "Medidas_Eletricas_UG07")
                    dt = ds.Tables("Medidas_Eletricas_UG07")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox20.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

            PosicaoDisjuntor = ((2 * dr("Disjuntor_Aberto")) + (1 * dr("Disjuntor_Fechado")))

            Select Case PosicaoDisjuntor
                Case = 2
                    Label27.BackColor = Color.Transparent
                Case = 1
                    Label27.BackColor = Color.DarkGray
                Case = 0
                    Label27.BackColor = Color.Red
                Case = 3
                    Label27.BackColor = Color.Red
            End Select


            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG08 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                Using ds As New DataSet
                    da.Fill(ds, "Medidas_Eletricas_UG08")
                    dt = ds.Tables("Medidas_Eletricas_UG08")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox23.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

            PosicaoDisjuntor = ((2 * dr("Disjuntor_Aberto")) + (1 * dr("Disjuntor_Fechado")))

            Select Case PosicaoDisjuntor
                Case = 2
                    Label31.BackColor = Color.Transparent
                Case = 1
                    Label31.BackColor = Color.DarkGray
                Case = 0
                    Label31.BackColor = Color.Red
                Case = 3
                    Label31.BackColor = Color.Red
            End Select


            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG11 ORDER BY E3TimeStamp DESC", cnnDados_US)
                Using ds As New DataSet
                    da.Fill(ds, "Medidas_Eletricas_UG11")
                    dt = ds.Tables("Medidas_Eletricas_UG11")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox26.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG12 ORDER BY E3TimeStamp DESC", cnnDados_US)
                Using ds As New DataSet
                    da.Fill(ds, "Medidas_Eletricas_UG12")
                    dt = ds.Tables("Medidas_Eletricas_UG12")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox29.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG13 ORDER BY E3TimeStamp DESC", cnnDados_US)
                Using ds As New DataSet
                    da.Fill(ds, "Medidas_Eletricas_UG13")
                    dt = ds.Tables("Medidas_Eletricas_UG13")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox32.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG14 ORDER BY E3TimeStamp DESC", cnnDados_US)
                Using ds As New DataSet
                    da.Fill(ds, "Medidas_Eletricas_UG14")
                    dt = ds.Tables("Medidas_Eletricas_UG14")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox35.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from HIST_UG15 ORDER BY E3TimeStamp DESC", cnnBDUsinaSubterranea)
                Using ds As New DataSet
                    da.Fill(ds, "HIST_UG15")
                    dt = ds.Tables("HIST_UG15")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox38.Text = Decimal.Parse(dr("Campo10")).ToString("#,##0.00") & " " & "kV"
            TextBox37.Text = Decimal.Parse(dr("Campo7")).ToString("#,##0.00") & " " & "MW"
            somaPotAtiva230 = dr("Campo7")
            TextBox36.Text = Decimal.Parse(dr("Campo8")).ToString("#,##0.00") & " " & "MVAR"
            somaPotReativa230 = dr("Campo8")

            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG16 ORDER BY E3TimeStamp DESC", cnnDados_US)
                Using ds As New DataSet
                    da.Fill(ds, "Medidas_Eletricas_UG16")
                    dt = ds.Tables("Medidas_Eletricas_UG16")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox41.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"


            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                Using ds As New DataSet
                    da.Fill(ds, "Hist__Medidores")
                    dt = ds.Tables("Hist__Medidores")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox1.Text = Decimal.Parse(dr("Unidade_1_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            TextBox2.Text = dr("Unidade_1_P_Reativa").ToString & " " & "MVAR"
            TextBox7.Text = Decimal.Parse(dr("Unidade_2_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            TextBox6.Text = dr("Unidade_2_P_Reativa").ToString & " " & "MVAR"
            TextBox10.Text = Decimal.Parse(dr("Unidade_3_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            TextBox9.Text = dr("Unidade_3_P_Reativa") & " " & "MVAR"
            TextBox4.Text = Decimal.Parse(dr("Unidade_4_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            If dr("Unidade_4_P_Ativa") > 0 Then
                TextBox4.BackColor = Color.LightGray
            End If
            TextBox3.Text = dr("Unidade_4_P_Reativa") & " " & "MVAR"
            TextBox13.Text = Decimal.Parse(dr("Unidade_5_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            TextBox12.Text = dr("Unidade_5_P_Reativa") & " " & "MVAR"
            TextBox16.Text = Decimal.Parse(dr("Unidade_6_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            TextBox15.Text = dr("Unidade_6_P_Reativa") & " " & "MVAR"
            TextBox19.Text = Decimal.Parse(dr("Unidade_7_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            TextBox18.Text = dr("Unidade_7_P_Reativa") & " " & "MVAR"
            TextBox22.Text = Decimal.Parse(dr("Unidade_8_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            TextBox21.Text = dr("Unidade_8_P_Reativa") & " " & "MVAR"
            TextBox25.Text = Decimal.Parse(dr("Unidade_11_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            TextBox24.Text = dr("Unidade_11_P_Reativa") & " " & "MVAR"
            TextBox28.Text = Decimal.Parse(dr("Unidade_12_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            TextBox27.Text = dr("Unidade_12_P_Reativa") & " " & "MVAR"
            TextBox31.Text = Decimal.Parse(dr("Unidade_13_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            TextBox30.Text = dr("Unidade_13_P_Reativa") & " " & "MVAR"
            TextBox34.Text = Decimal.Parse(dr("Unidade_14_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            TextBox33.Text = dr("Unidade_14_P_Reativa") & " " & "MVAR"
            'TextBox37.Text = Decimal.Parse(dr("Unidade_15_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            'TextBox36.Text = dr("Unidade_15_P_Reativa") & " " & "MVAR"
            TextBox40.Text = Decimal.Parse(dr("Unidade_16_P_Ativa")).ToString("#,##0.00") & " " & "MW"
            TextBox39.Text = dr("Unidade_16_P_Reativa") & " " & "MVAR"


            somaPotAtiva88 = Decimal.Parse(dr("Unidade_1_P_Ativa") + dr("Unidade_2_P_Ativa") + dr("Unidade_3_P_Ativa") + dr("Unidade_4_P_Ativa") +
                                           dr("Unidade_5_P_Ativa") + dr("Unidade_6_P_Ativa") + dr("Unidade_7_P_Ativa")).ToString("#,##0.00")
            somaPotReativa88 = dr("Unidade_1_P_Reativa") + dr("Unidade_2_P_Reativa") + dr("Unidade_3_P_Reativa") + dr("Unidade_4_P_Reativa") + dr("Unidade_5_P_Reativa") +
                dr("Unidade_6_P_Reativa") + dr("Unidade_7_P_Reativa")

            somaPotAtiva230 += dr("Unidade_8_P_Ativa") + dr("Unidade_11_P_Ativa") + dr("Unidade_12_P_Ativa") + dr("Unidade_13_P_Ativa") +
                                            dr("Unidade_14_P_Ativa") + dr("Unidade_16_P_Ativa")
            somaPotReativa230 += dr("Unidade_8_P_Reativa") + dr("Unidade_11_P_Reativa") + dr("Unidade_12_P_Reativa") + dr("Unidade_13_P_Reativa") +
                dr("Unidade_14_P_Reativa") + dr("Unidade_16_P_Reativa")

            Label6.Text = "Ativa " & somaPotAtiva88 & " MW"
            Label7.Text = "Reativa " & somaPotReativa88 & " MVAR"
            Label37.Text = "Ativa " & Decimal.Parse(somaPotAtiva230.ToString("#,##0.00")) & " MW"
            Label36.Text = "Reativa " & Decimal.Parse(somaPotReativa230.ToString("#,##0.00")) & " MVAR"
            Label38.Text = "Atualizado em:- " & Now & " hrs"

            Label78.Text = "Ativa " & Decimal.Parse(somaPotAtiva88 + somaPotAtiva230.ToString("#,##0.00")) & " MW"
            Label41.Text = "Reativa " & Decimal.Parse(somaPotReativa88 + somaPotReativa230.ToString("#,##0.00")) & " MVAR"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        AtualizaDados()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        AtualizaDados()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Alarmes.ShowDialog()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        frmVazaoLista.ShowDialog()

    End Sub

    Private Sub btnMedidoresHorario_Click(sender As Object, e As EventArgs) Handles btnMedidoresHorario.Click

        frmMedidoresHorario.ShowDialog()

    End Sub


    Private Sub Panel1_DoubleClick(sender As Object, e As EventArgs) Handles Panel1.DoubleClick, Panel6.DoubleClick

        intUnidade = 1

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub Label63_Click(sender As Object, e As EventArgs) Handles Label63.Click

        intUnidade = 1

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub Label64_Click(sender As Object, e As EventArgs) Handles Label64.Click

        intUnidade = 2

        frmDetalhesUnidade.ShowDialog()
    End Sub

    Private Sub Label65_Click(sender As Object, e As EventArgs) Handles Label65.Click

        intUnidade = 3

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub Label66_Click(sender As Object, e As EventArgs) Handles Label66.Click

        intUnidade = 4

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub Label67_Click(sender As Object, e As EventArgs) Handles Label67.Click

        intUnidade = 5

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub Label68_Click(sender As Object, e As EventArgs) Handles Label68.Click

        intUnidade = 6

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub Label71_Click(sender As Object, e As EventArgs) Handles Label71.Click
        intUnidade = 7

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub Label69_Click(sender As Object, e As EventArgs) Handles Label69.Click
        intUnidade = 8

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub Label70_Click(sender As Object, e As EventArgs) Handles Label70.Click
        intUnidade = 11

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub Label72_Click(sender As Object, e As EventArgs) Handles Label72.Click
        intUnidade = 12

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub Label73_Click(sender As Object, e As EventArgs) Handles Label73.Click
        intUnidade = 13

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub Label75_Click(sender As Object, e As EventArgs) Handles Label75.Click
        intUnidade = 14

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub Label74_Click(sender As Object, e As EventArgs) Handles Label74.Click
        intUnidade = 15

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub Label76_Click(sender As Object, e As EventArgs) Handles Label76.Click
        intUnidade = 16

        frmDetalhesUnidade.ShowDialog()

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class