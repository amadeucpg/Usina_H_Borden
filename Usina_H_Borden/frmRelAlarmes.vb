Public Class frmRelAlarmes

    Private Sub frmRelAlarmes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ds As New DataSet
        Try
            Using da = New SqlClient.SqlDataAdapter(Campos & Tabela & Condicao & strFiltroAdicional & Ordem, My.Settings.dbAlarmes)
                da.Fill(ds, "Alarms")
            End Using

            Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource("DataSetAlarmes", ds.Tables("Alarms"))

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rpt)

            Dim Titulo = New Microsoft.Reporting.WinForms.ReportParameter("ParamTitulo", strTitulo)
            ReportViewer1.LocalReport.SetParameters(Titulo)


            Dim ps = New System.Drawing.Printing.PageSettings
            ps.Margins.Top = 10
            ps.Margins.Left = 10
            ps.Margins.Right = 5
            ps.Margins.Bottom = 5
            ps.Landscape = True
            ReportViewer1.SetPageSettings(ps)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)


            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Me.Text += "   --   " + String.Format("Versão {0}", My.Application.Info.Version.ToString)

    End Sub
End Class