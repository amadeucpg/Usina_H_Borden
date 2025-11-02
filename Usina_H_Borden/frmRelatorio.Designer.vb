<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRelatorio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelatorio))
        Me.ViewMedidoresHorarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbGeralDataSet = New Usina_H_Borden.dbGeralDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ViewMedidoresHorarioTableAdapter = New Usina_H_Borden.dbGeralDataSetTableAdapters.ViewMedidoresHorarioTableAdapter()
        CType(Me.ViewMedidoresHorarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbGeralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ViewMedidoresHorarioBindingSource
        '
        Me.ViewMedidoresHorarioBindingSource.DataMember = "ViewMedidoresHorario"
        Me.ViewMedidoresHorarioBindingSource.DataSource = Me.dbGeralDataSet
        '
        'dbGeralDataSet
        '
        Me.dbGeralDataSet.DataSetName = "dbGeralDataSet"
        Me.dbGeralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "tABELA"
        ReportDataSource1.Value = Me.ViewMedidoresHorarioBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Usina_H_Borden.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(925, 506)
        Me.ReportViewer1.TabIndex = 0
        '
        'ViewMedidoresHorarioTableAdapter
        '
        Me.ViewMedidoresHorarioTableAdapter.ClearBeforeFill = True
        '
        'frmRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 606)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatórios"
        CType(Me.ViewMedidoresHorarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbGeralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ViewMedidoresHorarioBindingSource As BindingSource
    Friend WithEvents dbGeralDataSet As dbGeralDataSet
    Friend WithEvents ViewMedidoresHorarioTableAdapter As dbGeralDataSetTableAdapters.ViewMedidoresHorarioTableAdapter
End Class
