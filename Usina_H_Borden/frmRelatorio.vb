Public Class frmRelatorio
    Dim dt As DataTable
    ReadOnly bs As New BindingSource
    ReadOnly ds As New DataSet

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'dbGeralDataSet.ViewMedidoresHorario'. Você pode movê-la ou removê-la conforme necessário.

        Dim dataRel As String

        dataRel = TrataDatas(Today)

        Using da = New SqlClient.SqlDataAdapter("select * 
                    from Hist__Medidores_Horario where E3TimeStamp > '" & dataRel & "' ORDER BY E3TimeStamp DESC", My.Settings.dbGeral)
            da.Fill(ds, "Hist__Medidores_Horario")
            dt = ds.Tables("Hist__Medidores_Horario")
            bs.DataSource = dt
        End Using

        Dim rpt As New Microsoft.Reporting.WinForms.ReportDataSource("tABELA", ds.Tables("Hist__Medidores_Horario"))

        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(rpt)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class