<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelVazao
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.VazaoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Dados_CVDataSet = New Usina_H_Borden.Dados_CVDataSet()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VazaoTableAdapter = New Usina_H_Borden.Dados_CVDataSetTableAdapters.VazaoTableAdapter()
        CType(Me.VazaoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dados_CVDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VazaoBindingSource
        '
        Me.VazaoBindingSource.DataMember = "Vazao"
        Me.VazaoBindingSource.DataSource = Me.Dados_CVDataSet
        '
        'Dados_CVDataSet
        '
        Me.Dados_CVDataSet.DataSetName = "Dados_CVDataSet"
        Me.Dados_CVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.VazaoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Usina_H_Borden.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1353, 617)
        Me.ReportViewer1.TabIndex = 0
        '
        'VazaoTableAdapter
        '
        Me.VazaoTableAdapter.ClearBeforeFill = True
        '
        'frmRelVazao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1353, 617)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmRelVazao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRelVazao"
        CType(Me.VazaoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dados_CVDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VazaoBindingSource As BindingSource
    Friend WithEvents Dados_CVDataSet As Dados_CVDataSet
    Friend WithEvents VazaoTableAdapter As Dados_CVDataSetTableAdapters.VazaoTableAdapter
End Class
