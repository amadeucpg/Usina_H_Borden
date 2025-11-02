Public Class frmDetalhesUnidade
    Dim dt As DataTable
    Dim dr As DataRow

    Private Sub frmDetalhesUnidade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AtualizarDados()

        Me.Text = "Detalhes Unidade"
        Me.Text += "   --   " + String.Format("Versão {0}", My.Application.Info.Version.ToString)


    End Sub
    Private Sub AtualizarDados()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        TextBox14.Text = ""
        TextBox15.Text = ""

        Try

            Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Banco_1_Temperaturas ORDER BY E3TimeStamp DESC", cnnDados_E88)
                Using ds As New DataSet
                    da.Fill(ds, "Banco_1_Temperaturas")
                    dt = ds.Tables("Banco_1_Temperaturas")
                End Using
            End Using

            dr = dt.Rows(0)

            TextBox13.Text = Decimal.Parse(dr("Temperatura_Ambiente")).ToString("#,##0.00") & " " & "°C"


            Select Case intUnidade
                Case 1
                    Label1.Text = "Unidade 1"
                    PainelTrafo.Visible = False
                    PainelBanco.Visible = True
                    PainelTrafoSub.Visible = False

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG01 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                        Using ds As New DataSet
                            da.Fill(ds, "Medidas_Eletricas_UG01")
                            dt = ds.Tables("Medidas_Eletricas_UG01")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

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

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Banco_1_Temperaturas ORDER BY E3TimeStamp DESC", cnnDados_E88)
                        Using ds As New DataSet
                            da.Fill(ds, "Banco_1_Temperaturas")
                            dt = ds.Tables("Banco_1_Temperaturas")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox3.Text = Decimal.Parse(dr("Fase_Azul_Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox4.Text = Decimal.Parse(dr("Fase_Azul_Temp_Enrolamento")).ToString("#,##0.00") & " " & "°C"
                    TextBox5.Text = Decimal.Parse(dr("Fase_Branca_Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox6.Text = Decimal.Parse(dr("Fase_Branca_Temp_Enrolamento")).ToString("#,##0.00") & " " & "°C"
                    TextBox7.Text = Decimal.Parse(dr("Fase_Verm.Temp,Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox8.Text = Decimal.Parse(dr("Fase_Verm.Temp,Enrolamento")).ToString("#,##0.00") & " " & "°C"

                Case 2

                    Label1.Text = "Unidade 2"
                    PainelTrafo.Visible = False
                    PainelBanco.Visible = True
                    PainelTrafoSub.Visible = False

                    Try

                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG02 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                        Using ds As New DataSet
                            da.Fill(ds, "Medidas_Eletricas_UG02")
                            dt = ds.Tables("Medidas_Eletricas_UG02")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"
                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                        Using ds As New DataSet
                            da.Fill(ds, "Hist__Medidores")
                            dt = ds.Tables("Hist__Medidores")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox1.Text = Decimal.Parse(dr("Unidade_2_P_Ativa")).ToString("#,##0.00") & " " & "MW"
                    TextBox2.Text = dr("Unidade_2_P_Reativa").ToString & " " & "MVAR"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Banco_2_Temperaturas ORDER BY E3TimeStamp DESC", cnnDados_E88)
                        Using ds As New DataSet
                            da.Fill(ds, "Banco_2_Temperaturas")
                            dt = ds.Tables("Banco_2_Temperaturas")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox3.Text = Decimal.Parse(dr("Fase_Azul_Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox4.Text = Decimal.Parse(dr("Fase_Azul_Temp_Enrolamento")).ToString("#,##0.00") & " " & "°C"
                    TextBox5.Text = Decimal.Parse(dr("Fase_Branca_Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox6.Text = Decimal.Parse(dr("Fase_Branca_Temp_Enrolamento")).ToString("#,##0.00") & " " & "°C"
                    TextBox7.Text = Decimal.Parse(dr("Fase_Verm.Temp,Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox8.Text = Decimal.Parse(dr("Fase_Verm.Temp,Enrolamento")).ToString("#,##0.00") & " " & "°C"

                Case 3
                    Label1.Text = "Unidade 3"
                    PainelTrafo.Visible = False
                    PainelBanco.Visible = True
                    PainelTrafoSub.Visible = False

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG03 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                        Using ds As New DataSet
                            da.Fill(ds, "Medidas_Eletricas_UG03")
                            dt = ds.Tables("Medidas_Eletricas_UG03")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                        Using ds As New DataSet
                            da.Fill(ds, "Hist__Medidores")
                            dt = ds.Tables("Hist__Medidores")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox1.Text = Decimal.Parse(dr("Unidade_3_P_Ativa")).ToString("#,##0.00") & " " & "MW"
                    TextBox2.Text = dr("Unidade_3_P_Reativa").ToString & " " & "MVAR"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Banco_3_Temperaturas ORDER BY E3TimeStamp DESC", cnnDados_E88)
                        Using ds As New DataSet
                            da.Fill(ds, "Banco_3_Temperaturas")
                            dt = ds.Tables("Banco_3_Temperaturas")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox3.Text = Decimal.Parse(dr("Fase_Azul_Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox4.Text = ""
                    TextBox5.Text = Decimal.Parse(dr("Fase_Branca_Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox6.Text = ""
                    TextBox7.Text = Decimal.Parse(dr("Fase_Verm.Temp,Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox8.Text = ""



                Case 4
                    Label1.Text = "Unidade 4"
                    PainelTrafo.Visible = True
                    PainelBanco.Visible = False
                    PainelTrafoSub.Visible = False

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG04 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                        Using ds As New DataSet
                            da.Fill(ds, "Medidas_Eletricas_UG04")
                            dt = ds.Tables("Medidas_Eletricas_UG04")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                        Using ds As New DataSet
                            da.Fill(ds, "Hist__Medidores")
                            dt = ds.Tables("Hist__Medidores")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox1.Text = Decimal.Parse(dr("Unidade_4_P_Ativa")).ToString("#,##0.00") & " " & "MW"
                    TextBox2.Text = dr("Unidade_4_P_Reativa").ToString & " " & "MVAR"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Trafo_4_Temperaturas ORDER BY E3TimeStamp DESC", cnnDados_E88)
                        Using ds As New DataSet
                            da.Fill(ds, "Trafo_4_Temperaturas")
                            dt = ds.Tables("Trafo_4_Temperaturas")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox9.Text = Decimal.Parse(dr("Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox10.Text = Decimal.Parse(dr("Fase_Azul_Temp_Enrolamento")).ToString("#,##0.00") & " " & "°C"
                    TextBox11.Text = Decimal.Parse(dr("Fase_Branca_Temp_Enrolamento")).ToString("#,##0.00") & " " & "°C"
                    TextBox12.Text = Decimal.Parse(dr("Fase_Verm.Temp,Enrolamento")).ToString("#,##0.00") & " " & "°C"


                Case 5
                    Label1.Text = "Unidade 5"
                    PainelTrafo.Visible = False
                    PainelBanco.Visible = True
                    PainelTrafoSub.Visible = False

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG05 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                        Using ds As New DataSet
                            da.Fill(ds, "Medidas_Eletricas_UG05")
                            dt = ds.Tables("Medidas_Eletricas_UG05")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                        Using ds As New DataSet
                            da.Fill(ds, "Hist__Medidores")
                            dt = ds.Tables("Hist__Medidores")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox1.Text = Decimal.Parse(dr("Unidade_5_P_Ativa")).ToString("#,##0.00") & " " & "MW"
                    TextBox2.Text = dr("Unidade_5_P_Reativa").ToString & " " & "MVAR"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Banco_2_Temperaturas ORDER BY E3TimeStamp DESC", cnnDados_E88)
                        Using ds As New DataSet
                            da.Fill(ds, "Banco_2_Temperaturas")
                            dt = ds.Tables("Banco_2_Temperaturas")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox3.Text = Decimal.Parse(dr("Fase_Azul_Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox4.Text = Decimal.Parse(dr("Fase_Azul_Temp_Enrolamento")).ToString("#,##0.00") & " " & "°C"
                    TextBox5.Text = Decimal.Parse(dr("Fase_Branca_Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox6.Text = Decimal.Parse(dr("Fase_Branca_Temp_Enrolamento")).ToString("#,##0.00") & " " & "°C"
                    TextBox7.Text = Decimal.Parse(dr("Fase_Verm.Temp,Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox8.Text = Decimal.Parse(dr("Fase_Verm.Temp,Enrolamento")).ToString("#,##0.00") & " " & "°C"

                Case 6
                    Label1.Text = "Unidade 6"
                    PainelTrafo.Visible = True
                    PainelBanco.Visible = False
                    PainelTrafoSub.Visible = False

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG06 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                        Using ds As New DataSet
                            da.Fill(ds, "Medidas_Eletricas_UG06")
                            dt = ds.Tables("Medidas_Eletricas_UG06")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                        Using ds As New DataSet
                            da.Fill(ds, "Hist__Medidores")
                            dt = ds.Tables("Hist__Medidores")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox1.Text = Decimal.Parse(dr("Unidade_" & intUnidade & "_P_Ativa")).ToString("#,##0.00") & " " & "MW"
                    TextBox2.Text = dr("Unidade_" & intUnidade & "_P_Reativa").ToString & " " & "MVAR"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Trafo_6_Temperaturas ORDER BY E3TimeStamp DESC", cnnDados_E88)
                        Using ds As New DataSet
                            da.Fill(ds, "Trafo_6_Temperaturas")
                            dt = ds.Tables("Trafo_6_Temperaturas")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox9.Text = Decimal.Parse(dr("Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox10.Text = Decimal.Parse(dr("Fase_Azul_Temp_Enrolamento")).ToString("#,##0.00") & " " & "°C"
                    TextBox11.Text = Decimal.Parse(dr("Fase_Branca_Temp_Enrolamento")).ToString("#,##0.00") & " " & "°C"
                    TextBox12.Text = Decimal.Parse(dr("Fase_Verm.Temp,Enrolamento")).ToString("#,##0.00") & " " & "°C"




                Case 7
                    Label1.Text = "Unidade 7"
                    PainelTrafo.Visible = False
                    PainelBanco.Visible = True
                    PainelTrafoSub.Visible = False

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG07 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                        Using ds As New DataSet
                            da.Fill(ds, "Medidas_Eletricas_UG07")
                            dt = ds.Tables("Medidas_Eletricas_UG07")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                        Using ds As New DataSet
                            da.Fill(ds, "Hist__Medidores")
                            dt = ds.Tables("Hist__Medidores")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox1.Text = Decimal.Parse(dr("Unidade_" & intUnidade & "_P_Ativa")).ToString("#,##0.00") & " " & "MW"
                    TextBox2.Text = dr("Unidade_" & intUnidade & "_P_Reativa").ToString & " " & "MVAR"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Banco_7_Temperaturas ORDER BY E3TimeStamp DESC", cnnDados_E88)
                        Using ds As New DataSet
                            da.Fill(ds, "Banco_7_Temperaturas")
                            dt = ds.Tables("Banco_7_Temperaturas")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox3.Text = Decimal.Parse(dr("Fase_Azul_Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox4.Text = ""
                    TextBox5.Text = Decimal.Parse(dr("Fase_Branca_Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox6.Text = ""
                    TextBox7.Text = Decimal.Parse(dr("Fase_Verm.Temp,Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox8.Text = ""


                Case 8
                    Label1.Text = "Unidade 8"
                    PainelTrafo.Visible = False
                    PainelBanco.Visible = True
                    PainelTrafoSub.Visible = False

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG08 ORDER BY E3TimeStamp DESC", cnnDados_UE)
                        Using ds As New DataSet
                            da.Fill(ds, "Medidas_Eletricas_UG08")
                            dt = ds.Tables("Medidas_Eletricas_UG08")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                        Using ds As New DataSet
                            da.Fill(ds, "Hist__Medidores")
                            dt = ds.Tables("Hist__Medidores")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox1.Text = Decimal.Parse(dr("Unidade_" & intUnidade & "_P_Ativa")).ToString("#,##0.00") & " " & "MW"
                    TextBox2.Text = dr("Unidade_" & intUnidade & "_P_Reativa").ToString & " " & "MVAR"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Banco_8_Temperaturas ORDER BY E3TimeStamp DESC", cnnDados_E88)
                        Using ds As New DataSet
                            da.Fill(ds, "Banco_8_Temperaturas")
                            dt = ds.Tables("Banco_8_Temperaturas")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox3.Text = Decimal.Parse(dr("Fase_Azul_Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox4.Text = ""
                    TextBox5.Text = Decimal.Parse(dr("Fase_Branca_Temp_Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox6.Text = ""
                    TextBox7.Text = Decimal.Parse(dr("Fase_Verm.Temp,Oleo")).ToString("#,##0.00") & " " & "°C"
                    TextBox8.Text = ""


                Case 11
                    Label1.Text = "Unidade 11"
                    PainelTrafo.Visible = False
                    PainelBanco.Visible = False
                    PainelTrafoSub.Visible = True

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG11 ORDER BY E3TimeStamp DESC", cnnDados_US)
                        Using ds As New DataSet
                            da.Fill(ds, "Medidas_Eletricas_UG11")
                            dt = ds.Tables("Medidas_Eletricas_UG11")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                        Using ds As New DataSet
                            da.Fill(ds, "Hist__Medidores")
                            dt = ds.Tables("Hist__Medidores")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox1.Text = Decimal.Parse(dr("Unidade_" & intUnidade & "_P_Ativa")).ToString("#,##0.00") & " " & "MW"
                    TextBox2.Text = dr("Unidade_" & intUnidade & "_P_Reativa").ToString & " " & "MVAR"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from HIST_TR" & intUnidade & " ORDER BY E3TimeStamp DESC", cnnBDUsinaSubterranea)
                        Using ds As New DataSet
                            da.Fill(ds, "HIST_TR" & intUnidade)
                            dt = ds.Tables("HIST_TR" & intUnidade)
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox14.Text = Decimal.Parse(dr("Campo21")).ToString("#,##0.00") & " " & "°C"
                    TextBox15.Text = Decimal.Parse(dr("Campo22")).ToString("#,##0.00") & " " & "°C"

                Case 12
                    Label1.Text = "Unidade 12"
                    PainelTrafo.Visible = False
                    PainelBanco.Visible = False
                    PainelTrafoSub.Visible = True

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG12 ORDER BY E3TimeStamp DESC", cnnDados_US)
                        Using ds As New DataSet
                            da.Fill(ds, "Medidas_Eletricas_UG12")
                            dt = ds.Tables("Medidas_Eletricas_UG12")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                        Using ds As New DataSet
                            da.Fill(ds, "Hist__Medidores")
                            dt = ds.Tables("Hist__Medidores")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox1.Text = Decimal.Parse(dr("Unidade_" & intUnidade & "_P_Ativa")).ToString("#,##0.00") & " " & "MW"
                    TextBox2.Text = dr("Unidade_" & intUnidade & "_P_Reativa").ToString & " " & "MVAR"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from HIST_TR" & intUnidade & " ORDER BY E3TimeStamp DESC", cnnBDUsinaSubterranea)
                        Using ds As New DataSet
                            da.Fill(ds, "HIST_TR" & intUnidade)
                            dt = ds.Tables("HIST_TR" & intUnidade)
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox14.Text = Decimal.Parse(dr("Campo21")).ToString("#,##0.00") & " " & "°C"
                    TextBox15.Text = Decimal.Parse(dr("Campo22")).ToString("#,##0.00") & " " & "°C"


                Case 13
                    Label1.Text = "Unidade 13"
                    PainelTrafo.Visible = False
                    PainelBanco.Visible = False
                    PainelTrafoSub.Visible = True

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG13 ORDER BY E3TimeStamp DESC", cnnDados_US)
                        Using ds As New DataSet
                            da.Fill(ds, "Medidas_Eletricas_UG13")
                            dt = ds.Tables("Medidas_Eletricas_UG13")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                        Using ds As New DataSet
                            da.Fill(ds, "Hist__Medidores")
                            dt = ds.Tables("Hist__Medidores")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox1.Text = Decimal.Parse(dr("Unidade_" & intUnidade & "_P_Ativa")).ToString("#,##0.00") & " " & "MW"
                    TextBox2.Text = dr("Unidade_" & intUnidade & "_P_Reativa").ToString & " " & "MVAR"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from HIST_TR" & intUnidade & " ORDER BY E3TimeStamp DESC", cnnBDUsinaSubterranea)
                        Using ds As New DataSet
                            da.Fill(ds, "HIST_TR" & intUnidade)
                            dt = ds.Tables("HIST_TR" & intUnidade)
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox14.Text = Decimal.Parse(dr("Campo21")).ToString("#,##0.00") & " " & "°C"
                    TextBox15.Text = Decimal.Parse(dr("Campo22")).ToString("#,##0.00") & " " & "°C"


                Case 14
                    Label1.Text = "Unidade 14"
                    PainelTrafo.Visible = False
                    PainelBanco.Visible = False
                    PainelTrafoSub.Visible = True
                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG14 ORDER BY E3TimeStamp DESC", cnnDados_US)
                        Using ds As New DataSet
                            da.Fill(ds, "Medidas_Eletricas_UG14")
                            dt = ds.Tables("Medidas_Eletricas_UG14")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                        Using ds As New DataSet
                            da.Fill(ds, "Hist__Medidores")
                            dt = ds.Tables("Hist__Medidores")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox1.Text = Decimal.Parse(dr("Unidade_" & intUnidade & "_P_Ativa")).ToString("#,##0.00") & " " & "MW"
                    TextBox2.Text = dr("Unidade_" & intUnidade & "_P_Reativa").ToString & " " & "MVAR"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from HIST_TR" & intUnidade & " ORDER BY E3TimeStamp DESC", cnnBDUsinaSubterranea)
                        Using ds As New DataSet
                            da.Fill(ds, "HIST_TR" & intUnidade)
                            dt = ds.Tables("HIST_TR" & intUnidade)
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox14.Text = Decimal.Parse(dr("Campo21")).ToString("#,##0.00") & " " & "°C"
                    TextBox15.Text = Decimal.Parse(dr("Campo22")).ToString("#,##0.00") & " " & "°C"


                Case 15
                    Label1.Text = "Unidade 15"
                    PainelTrafo.Visible = False
                    PainelBanco.Visible = False
                    PainelTrafoSub.Visible = True

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from HIST_UG15 ORDER BY E3TimeStamp DESC", cnnBDUsinaSubterranea)
                        Using ds As New DataSet
                            da.Fill(ds, "HIST_UG15")
                            dt = ds.Tables("HIST_UG15")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Campo10")).ToString("#,##0.00") & " " & "kV"

                    'Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    'from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                    '    Using ds As New DataSet
                    '        da.Fill(ds, "Hist__Medidores")
                    '        dt = ds.Tables("Hist__Medidores")
                    '    End Using
                    'End Using

                    'dr = dt.Rows(0)

                    TextBox1.Text = Decimal.Parse(dr("Campo7")).ToString("#,##0.00") & " " & "MW"
                    TextBox2.Text = Decimal.Parse(dr("Campo8")).ToString("#,##0.00") & " " & "MVAR"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from HIST_TR" & intUnidade & " ORDER BY E3TimeStamp DESC", cnnBDUsinaSubterranea)
                        Using ds As New DataSet
                            da.Fill(ds, "HIST_TR" & intUnidade)
                            dt = ds.Tables("HIST_TR" & intUnidade)
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox14.Text = Decimal.Parse(dr("Campo21")).ToString("#,##0.00") & " " & "°C"
                    TextBox15.Text = Decimal.Parse(dr("Campo22")).ToString("#,##0.00") & " " & "°C"


                Case 16
                    Label1.Text = "Unidade 16"
                    PainelTrafo.Visible = False
                    PainelBanco.Visible = False
                    PainelTrafoSub.Visible = True

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Medidas_Eletricas_UG16 ORDER BY E3TimeStamp DESC", cnnDados_US)
                        Using ds As New DataSet
                            da.Fill(ds, "Medidas_Eletricas_UG16")
                            dt = ds.Tables("Medidas_Eletricas_UG16")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TxtKV_Unidade.Text = Decimal.Parse(dr("Tensao_Armadura")).ToString("#,##0.00") & " " & "kV"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from Hist__Medidores ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
                        Using ds As New DataSet
                            da.Fill(ds, "Hist__Medidores")
                            dt = ds.Tables("Hist__Medidores")
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox1.Text = Decimal.Parse(dr("Unidade_" & intUnidade & "_P_Ativa")).ToString("#,##0.00") & " " & "MW"
                    TextBox2.Text = dr("Unidade_" & intUnidade & "_P_Reativa").ToString & " " & "MVAR"

                    Using da = New SqlClient.SqlDataAdapter("select TOP(1) * 
                    from HIST_TR" & intUnidade & " ORDER BY E3TimeStamp DESC", cnnBDUsinaSubterranea)
                        Using ds As New DataSet
                            da.Fill(ds, "HIST_TR" & intUnidade)
                            dt = ds.Tables("HIST_TR" & intUnidade)
                        End Using
                    End Using

                    dr = dt.Rows(0)

                    TextBox14.Text = Decimal.Parse(dr("Campo21")).ToString("#,##0.00") & " " & "°C"
                    TextBox15.Text = Decimal.Parse(dr("Campo22")).ToString("#,##0.00") & " " & "°C"


            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Label38.Text = "Atualizado em:- " & Now & " hrs"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        AtualizarDados()

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        AtualizarDados()

    End Sub
End Class