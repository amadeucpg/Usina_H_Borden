<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRelAlarmes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRelAlarmes))
        Me.View_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlarmesDataSet1 = New Usina_H_Borden.AlarmesDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.View_1TableAdapter = New Usina_H_Borden.AlarmesDataSet1TableAdapters.View_1TableAdapter()
        CType(Me.View_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlarmesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'View_1BindingSource
        '
        Me.View_1BindingSource.DataMember = "View_1"
        Me.View_1BindingSource.DataSource = Me.AlarmesDataSet1
        '
        'AlarmesDataSet1
        '
        Me.AlarmesDataSet1.DataSetName = "AlarmesDataSet1"
        Me.AlarmesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.AutoSize = True
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.DocumentMapWidth = 1
        ReportDataSource1.Name = "DataSetAlarmes"
        ReportDataSource1.Value = Me.View_1BindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Usina_H_Borden.rptAlarmes.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(982, 653)
        Me.ReportViewer1.TabIndex = 0
        '
        'View_1TableAdapter
        '
        Me.View_1TableAdapter.ClearBeforeFill = True
        '
        'frmRelAlarmes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 653)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRelAlarmes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Alarmes e Eventos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.View_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlarmesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents View_1BindingSource As BindingSource
    Friend WithEvents AlarmesDataSet1 As AlarmesDataSet1
    Friend WithEvents View_1TableAdapter As AlarmesDataSet1TableAdapters.View_1TableAdapter
End Class
