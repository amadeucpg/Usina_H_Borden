<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLTBLista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLTBLista))
        Me.DbGeralDataSet = New Usina_H_Borden.dbGeralDataSet()
        Me.LTBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LTBTableAdapter = New Usina_H_Borden.dbGeralDataSetTableAdapters.LTBTableAdapter()
        Me.TableAdapterManager = New Usina_H_Borden.dbGeralDataSetTableAdapters.TableAdapterManager()
        Me.LTBDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataAutorizado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnNavegador = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnVisualizarOds = New System.Windows.Forms.ToolStripButton()
        Me.btnAlterar = New System.Windows.Forms.ToolStripButton()
        Me.BtnAtualizar = New System.Windows.Forms.ToolStripButton()
        Me.btnLocalizar = New System.Windows.Forms.Button()
        Me.txtLocalizar = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.dtpAberturaFim = New System.Windows.Forms.DateTimePicker()
        Me.dtpAberturaInicio = New System.Windows.Forms.DateTimePicker()
        Me.optAberturaPorPeriodo = New System.Windows.Forms.RadioButton()
        Me.optAberturaTodas = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboSituacao = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboHabilitado = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboExpressamenteAutorizado = New System.Windows.Forms.ComboBox()
        CType(Me.DbGeralDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LTBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNavegador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnNavegador.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DbGeralDataSet
        '
        Me.DbGeralDataSet.DataSetName = "dbGeralDataSet"
        Me.DbGeralDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LTBBindingSource
        '
        Me.LTBBindingSource.DataMember = "LTB"
        Me.LTBBindingSource.DataSource = Me.DbGeralDataSet
        '
        'LTBTableAdapter
        '
        Me.LTBTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.LogEventosTableAdapter = Nothing
        Me.TableAdapterManager.LTBTableAdapter = Me.LTBTableAdapter
        Me.TableAdapterManager.UpdateOrder = Usina_H_Borden.dbGeralDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LTBDataGridView
        '
        Me.LTBDataGridView.AllowUserToAddRows = False
        Me.LTBDataGridView.AllowUserToDeleteRows = False
        Me.LTBDataGridView.AllowUserToOrderColumns = True
        Me.LTBDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LTBDataGridView.AutoGenerateColumns = False
        Me.LTBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LTBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataAutorizado, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn18})
        Me.LTBDataGridView.DataSource = Me.LTBBindingSource
        Me.LTBDataGridView.Location = New System.Drawing.Point(0, 32)
        Me.LTBDataGridView.Name = "LTBDataGridView"
        Me.LTBDataGridView.ReadOnly = True
        Me.LTBDataGridView.Size = New System.Drawing.Size(1134, 603)
        Me.LTBDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NumLic"
        Me.DataGridViewTextBoxColumn1.HeaderText = "NumLic"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 58
        '
        'DataAutorizado
        '
        Me.DataAutorizado.DataPropertyName = "DataAutorizado"
        Me.DataAutorizado.HeaderText = "Data"
        Me.DataAutorizado.Name = "DataAutorizado"
        Me.DataAutorizado.ReadOnly = True
        Me.DataAutorizado.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Local"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Local"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 58
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Equipamento"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Equipamento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Finalidade"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Finalidade"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Habilitado"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Habilitado"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Autorizado"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Autorizado"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "ExpAutorizado"
        Me.DataGridViewTextBoxColumn18.HeaderText = "ExpAutorizado"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'btnNavegador
        '
        Me.btnNavegador.AddNewItem = Nothing
        Me.btnNavegador.CountItem = Nothing
        Me.btnNavegador.DeleteItem = Nothing
        Me.btnNavegador.Dock = System.Windows.Forms.DockStyle.None
        Me.btnNavegador.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripSeparator1, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator2, Me.btnVisualizarOds, Me.btnAlterar, Me.BtnAtualizar})
        Me.btnNavegador.Location = New System.Drawing.Point(0, 0)
        Me.btnNavegador.MoveFirstItem = Me.ToolStripButton2
        Me.btnNavegador.MoveLastItem = Me.ToolStripButton5
        Me.btnNavegador.MoveNextItem = Me.ToolStripButton4
        Me.btnNavegador.MovePreviousItem = Me.ToolStripButton3
        Me.btnNavegador.Name = "btnNavegador"
        Me.btnNavegador.PositionItem = Nothing
        Me.btnNavegador.Size = New System.Drawing.Size(341, 25)
        Me.btnNavegador.Stretch = True
        Me.btnNavegador.TabIndex = 15
        Me.btnNavegador.Text = "BindingNavigator1"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move first"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move next"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move last"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btnVisualizarOds
        '
        Me.btnVisualizarOds.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnVisualizarOds.Image = CType(resources.GetObject("btnVisualizarOds.Image"), System.Drawing.Image)
        Me.btnVisualizarOds.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnVisualizarOds.Name = "btnVisualizarOds"
        Me.btnVisualizarOds.Size = New System.Drawing.Size(81, 22)
        Me.btnVisualizarOds.Text = "Visualizar LTB"
        Me.btnVisualizarOds.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        '
        'btnAlterar
        '
        Me.btnAlterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(60, 22)
        Me.btnAlterar.Text = "Nova LTB"
        '
        'BtnAtualizar
        '
        Me.BtnAtualizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnAtualizar.Image = CType(resources.GetObject("BtnAtualizar.Image"), System.Drawing.Image)
        Me.BtnAtualizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnAtualizar.Name = "BtnAtualizar"
        Me.BtnAtualizar.Size = New System.Drawing.Size(84, 22)
        Me.BtnAtualizar.Text = "Atualizar Lista"
        '
        'btnLocalizar
        '
        Me.btnLocalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLocalizar.Location = New System.Drawing.Point(530, 4)
        Me.btnLocalizar.Name = "btnLocalizar"
        Me.btnLocalizar.Size = New System.Drawing.Size(105, 22)
        Me.btnLocalizar.TabIndex = 17
        Me.btnLocalizar.Text = "Localizar LTB"
        Me.btnLocalizar.UseVisualStyleBackColor = True
        '
        'txtLocalizar
        '
        Me.txtLocalizar.Location = New System.Drawing.Point(468, 5)
        Me.txtLocalizar.Name = "txtLocalizar"
        Me.txtLocalizar.Size = New System.Drawing.Size(62, 20)
        Me.txtLocalizar.TabIndex = 16
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.dtpAberturaFim)
        Me.GroupBox9.Controls.Add(Me.dtpAberturaInicio)
        Me.GroupBox9.Controls.Add(Me.optAberturaPorPeriodo)
        Me.GroupBox9.Controls.Add(Me.optAberturaTodas)
        Me.GroupBox9.Location = New System.Drawing.Point(12, 649)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(190, 62)
        Me.GroupBox9.TabIndex = 18
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Por data"
        '
        'dtpAberturaFim
        '
        Me.dtpAberturaFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAberturaFim.Location = New System.Drawing.Point(101, 37)
        Me.dtpAberturaFim.Name = "dtpAberturaFim"
        Me.dtpAberturaFim.Size = New System.Drawing.Size(84, 20)
        Me.dtpAberturaFim.TabIndex = 7
        '
        'dtpAberturaInicio
        '
        Me.dtpAberturaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAberturaInicio.Location = New System.Drawing.Point(6, 37)
        Me.dtpAberturaInicio.Name = "dtpAberturaInicio"
        Me.dtpAberturaInicio.Size = New System.Drawing.Size(85, 20)
        Me.dtpAberturaInicio.TabIndex = 6
        '
        'optAberturaPorPeriodo
        '
        Me.optAberturaPorPeriodo.AutoSize = True
        Me.optAberturaPorPeriodo.Location = New System.Drawing.Point(69, 11)
        Me.optAberturaPorPeriodo.Name = "optAberturaPorPeriodo"
        Me.optAberturaPorPeriodo.Size = New System.Drawing.Size(80, 17)
        Me.optAberturaPorPeriodo.TabIndex = 5
        Me.optAberturaPorPeriodo.Text = "Por Periodo"
        Me.optAberturaPorPeriodo.UseVisualStyleBackColor = True
        '
        'optAberturaTodas
        '
        Me.optAberturaTodas.AutoSize = True
        Me.optAberturaTodas.Checked = True
        Me.optAberturaTodas.Location = New System.Drawing.Point(8, 11)
        Me.optAberturaTodas.Name = "optAberturaTodas"
        Me.optAberturaTodas.Size = New System.Drawing.Size(55, 17)
        Me.optAberturaTodas.TabIndex = 4
        Me.optAberturaTodas.TabStop = True
        Me.optAberturaTodas.Text = "Todas"
        Me.optAberturaTodas.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboSituacao)
        Me.GroupBox4.Location = New System.Drawing.Point(233, 649)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(120, 62)
        Me.GroupBox4.TabIndex = 34
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Situação"
        '
        'cboSituacao
        '
        Me.cboSituacao.FormattingEnabled = True
        Me.cboSituacao.Items.AddRange(New Object() {"Todos", "Abertas", "Encerradas"})
        Me.cboSituacao.Location = New System.Drawing.Point(6, 15)
        Me.cboSituacao.Name = "cboSituacao"
        Me.cboSituacao.Size = New System.Drawing.Size(109, 21)
        Me.cboSituacao.TabIndex = 0
        Me.cboSituacao.Text = "Todos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboHabilitado)
        Me.GroupBox1.Location = New System.Drawing.Point(361, 649)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(307, 62)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Habilitado"
        '
        'cboHabilitado
        '
        Me.cboHabilitado.FormattingEnabled = True
        Me.cboHabilitado.Items.AddRange(New Object() {"Todos", "Em Processo", "Encerradas"})
        Me.cboHabilitado.Location = New System.Drawing.Point(6, 15)
        Me.cboHabilitado.Name = "cboHabilitado"
        Me.cboHabilitado.Size = New System.Drawing.Size(295, 21)
        Me.cboHabilitado.TabIndex = 0
        Me.cboHabilitado.Text = "Todos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboExpressamenteAutorizado)
        Me.GroupBox2.Location = New System.Drawing.Point(688, 649)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(307, 62)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Expressamente Autorizado"
        '
        'cboExpressamenteAutorizado
        '
        Me.cboExpressamenteAutorizado.FormattingEnabled = True
        Me.cboExpressamenteAutorizado.Items.AddRange(New Object() {"Todos", "Em Processo", "Encerradas"})
        Me.cboExpressamenteAutorizado.Location = New System.Drawing.Point(6, 15)
        Me.cboExpressamenteAutorizado.Name = "cboExpressamenteAutorizado"
        Me.cboExpressamenteAutorizado.Size = New System.Drawing.Size(295, 21)
        Me.cboExpressamenteAutorizado.TabIndex = 0
        Me.cboExpressamenteAutorizado.Text = "Todos"
        '
        'FrmLTBLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1158, 719)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.btnLocalizar)
        Me.Controls.Add(Me.txtLocalizar)
        Me.Controls.Add(Me.btnNavegador)
        Me.Controls.Add(Me.LTBDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLTBLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Licença para Trabalhar"
        CType(Me.DbGeralDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LTBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNavegador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnNavegador.ResumeLayout(False)
        Me.btnNavegador.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DbGeralDataSet As dbGeralDataSet
    Friend WithEvents LTBBindingSource As BindingSource
    Friend WithEvents LTBTableAdapter As dbGeralDataSetTableAdapters.LTBTableAdapter
    Friend WithEvents TableAdapterManager As dbGeralDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LTBDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataAutorizado As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents btnNavegador As BindingNavigator
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents btnVisualizarOds As ToolStripButton
    Friend WithEvents btnAlterar As ToolStripButton
    Private WithEvents BtnAtualizar As ToolStripButton
    Friend WithEvents btnLocalizar As Button
    Friend WithEvents txtLocalizar As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents dtpAberturaFim As DateTimePicker
    Friend WithEvents dtpAberturaInicio As DateTimePicker
    Friend WithEvents optAberturaPorPeriodo As RadioButton
    Friend WithEvents optAberturaTodas As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cboSituacao As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboHabilitado As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboExpressamenteAutorizado As ComboBox
End Class
