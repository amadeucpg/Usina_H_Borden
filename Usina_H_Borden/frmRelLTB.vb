Public Class frmRelLTB
    Private Sub frmRelLTB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        Try
            Using da = New SqlClient.SqlDataAdapter("select * from LTB where NumLic=" & intLTB, cnnMackGeral)
                da.Fill(ds, "LTB")
            End Using

            Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource("LTB", ds.Tables("LTB"))

            ReportViewer1.LocalReport.DataSources.Clear()
            ReportViewer1.LocalReport.DataSources.Add(rpt)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim ps = New System.Drawing.Printing.PageSettings
        ps.Margins.Top = 10
        ps.Margins.Left = 30
        ps.Margins.Right = 5
        ps.Margins.Bottom = 5
        ReportViewer1.SetPageSettings(ps)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)


        Me.ReportViewer1.RefreshReport()
    End Sub

End Class