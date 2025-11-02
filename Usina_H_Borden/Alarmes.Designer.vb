<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Alarmes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alarmes))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.View_1DataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E3TimeStamp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Message = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActiveSource = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullAlarmSourceName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.View_1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AlarmesDataSet1 = New Usina_H_Borden.AlarmesDataSet1()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.cboHoraFinal = New System.Windows.Forms.ComboBox()
        Me.cboHoraInicio = New System.Windows.Forms.ComboBox()
        Me.dtpAberturaFim = New System.Windows.Forms.DateTimePicker()
        Me.dtpAberturaInicio = New System.Windows.Forms.DateTimePicker()
        Me.optAberturaPorPeriodo = New System.Windows.Forms.RadioButton()
        Me.optAberturaTodas = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CboLocal = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cboAlarmesEventos = New System.Windows.Forms.ComboBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboRec = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cboUnidade = New System.Windows.Forms.ComboBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.View_1TableAdapter = New Usina_H_Borden.AlarmesDataSet1TableAdapters.View_1TableAdapter()
        Me.TableAdapterManager = New Usina_H_Borden.AlarmesDataSet1TableAdapters.TableAdapterManager()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.View_1DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.View_1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlarmesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripSeparator4, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.ToolStripLabel1})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.BindingNavigator1.Size = New System.Drawing.Size(1105, 25)
        Me.BindingNavigator1.TabIndex = 1
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(57, 22)
        Me.ToolStripButton1.Text = "Atualizar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(93, 22)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'View_1DataGridView
        '
        Me.View_1DataGridView.AllowUserToAddRows = False
        Me.View_1DataGridView.AllowUserToDeleteRows = False
        Me.View_1DataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.View_1DataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.View_1DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.View_1DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.View_1DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.E3TimeStamp, Me.DataGridViewTextBoxColumn4, Me.Message, Me.ActiveSource, Me.FullAlarmSourceName, Me.CurrentValue})
        Me.View_1DataGridView.DataSource = Me.View_1BindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.View_1DataGridView.DefaultCellStyle = DataGridViewCellStyle4
        Me.View_1DataGridView.Location = New System.Drawing.Point(12, 28)
        Me.View_1DataGridView.Name = "View_1DataGridView"
        Me.View_1DataGridView.ReadOnly = True
        Me.View_1DataGridView.Size = New System.Drawing.Size(1086, 597)
        Me.View_1DataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "E3TimeStamp"
        DataGridViewCellStyle2.Format = "dd/MM/yyyy HH:mm:ss.fff"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "E3TimeStamp"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 109
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "EventTime"
        Me.DataGridViewTextBoxColumn2.HeaderText = "EventTime"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Area"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Area"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 58
        '
        'E3TimeStamp
        '
        Me.E3TimeStamp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.E3TimeStamp.DataPropertyName = "ConditionActive"
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        Me.E3TimeStamp.DefaultCellStyle = DataGridViewCellStyle3
        Me.E3TimeStamp.HeaderText = "CA"
        Me.E3TimeStamp.Name = "E3TimeStamp"
        Me.E3TimeStamp.ReadOnly = True
        Me.E3TimeStamp.Width = 55
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Message"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Message"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 500
        '
        'Message
        '
        Me.Message.DataPropertyName = "Source"
        Me.Message.HeaderText = "Source"
        Me.Message.Name = "Message"
        Me.Message.ReadOnly = True
        '
        'ActiveSource
        '
        Me.ActiveSource.DataPropertyName = "ActiveSource"
        Me.ActiveSource.HeaderText = "ActiveSource"
        Me.ActiveSource.Name = "ActiveSource"
        Me.ActiveSource.ReadOnly = True
        '
        'FullAlarmSourceName
        '
        Me.FullAlarmSourceName.DataPropertyName = "FullAlarmSourceName"
        Me.FullAlarmSourceName.HeaderText = "FullAlarmSourceName"
        Me.FullAlarmSourceName.Name = "FullAlarmSourceName"
        Me.FullAlarmSourceName.ReadOnly = True
        '
        'CurrentValue
        '
        Me.CurrentValue.DataPropertyName = "CurrentValue"
        Me.CurrentValue.HeaderText = "CurrentValue"
        Me.CurrentValue.Name = "CurrentValue"
        Me.CurrentValue.ReadOnly = True
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
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.cboHoraFinal)
        Me.GroupBox9.Controls.Add(Me.cboHoraInicio)
        Me.GroupBox9.Controls.Add(Me.dtpAberturaFim)
        Me.GroupBox9.Controls.Add(Me.dtpAberturaInicio)
        Me.GroupBox9.Controls.Add(Me.optAberturaPorPeriodo)
        Me.GroupBox9.Controls.Add(Me.optAberturaTodas)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(341, 62)
        Me.GroupBox9.TabIndex = 10
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Por data"
        '
        'cboHoraFinal
        '
        Me.cboHoraFinal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHoraFinal.FormattingEnabled = True
        Me.cboHoraFinal.Items.AddRange(New Object() {"00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "23:59:59"})
        Me.cboHoraFinal.Location = New System.Drawing.Point(281, 37)
        Me.cboHoraFinal.Name = "cboHoraFinal"
        Me.cboHoraFinal.Size = New System.Drawing.Size(56, 21)
        Me.cboHoraFinal.TabIndex = 9
        '
        'cboHoraInicio
        '
        Me.cboHoraInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboHoraInicio.FormattingEnabled = True
        Me.cboHoraInicio.Items.AddRange(New Object() {"00:00", "01:00", "02:00", "03:00", "04:00", "05:00", "06:00", "07:00", "08:00", "09:00", "10:00", "11:00", "12:00", "13:00", "14:00", "15:00", "16:00", "17:00", "18:00", "19:00", "20:00", "21:00", "22:00", "23:00", "23:59:59"})
        Me.cboHoraInicio.Location = New System.Drawing.Point(97, 36)
        Me.cboHoraInicio.Name = "cboHoraInicio"
        Me.cboHoraInicio.Size = New System.Drawing.Size(55, 21)
        Me.cboHoraInicio.TabIndex = 8
        '
        'dtpAberturaFim
        '
        Me.dtpAberturaFim.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAberturaFim.Location = New System.Drawing.Point(191, 37)
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.GroupBox9)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 631)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1086, 126)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pesquisa"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.CboLocal)
        Me.GroupBox5.Location = New System.Drawing.Point(522, 21)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(182, 60)
        Me.GroupBox5.TabIndex = 34
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Local"
        '
        'CboLocal
        '
        Me.CboLocal.FormattingEnabled = True
        Me.CboLocal.Items.AddRange(New Object() {"Casa de Valvulas", "Estrutura de 230kV", "Estrutura de 88kV", "Outras", "Todos", "Usina Externa", "Usina Subterranea"})
        Me.CboLocal.Location = New System.Drawing.Point(6, 15)
        Me.CboLocal.Name = "CboLocal"
        Me.CboLocal.Size = New System.Drawing.Size(170, 21)
        Me.CboLocal.Sorted = True
        Me.CboLocal.TabIndex = 0
        Me.CboLocal.Text = "Todos"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cboAlarmesEventos)
        Me.GroupBox4.Location = New System.Drawing.Point(374, 21)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(120, 60)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Alarmes/Eventos"
        '
        'cboAlarmesEventos
        '
        Me.cboAlarmesEventos.FormattingEnabled = True
        Me.cboAlarmesEventos.Items.AddRange(New Object() {"Todos", "Alarmes", "Eventos"})
        Me.cboAlarmesEventos.Location = New System.Drawing.Point(6, 15)
        Me.cboAlarmesEventos.Name = "cboAlarmesEventos"
        Me.cboAlarmesEventos.Size = New System.Drawing.Size(109, 21)
        Me.cboAlarmesEventos.TabIndex = 0
        Me.cboAlarmesEventos.Text = "Todos"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(939, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(141, 28)
        Me.Button3.TabIndex = 32
        Me.Button3.Text = "Limpar Filtros"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(939, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(141, 28)
        Me.Button2.TabIndex = 31
        Me.Button2.Text = "Atualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboRec)
        Me.GroupBox3.Location = New System.Drawing.Point(839, 19)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(89, 60)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rec"
        '
        'cboRec
        '
        Me.cboRec.FormattingEnabled = True
        Me.cboRec.Items.AddRange(New Object() {"Todos", "Sim", "Não"})
        Me.cboRec.Location = New System.Drawing.Point(6, 15)
        Me.cboRec.Name = "cboRec"
        Me.cboRec.Size = New System.Drawing.Size(75, 21)
        Me.cboRec.TabIndex = 0
        Me.cboRec.Text = "Todos"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(939, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 28)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Imprimir Lista"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cboUnidade)
        Me.GroupBox2.Location = New System.Drawing.Point(732, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(79, 60)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Unidade"
        '
        'cboUnidade
        '
        Me.cboUnidade.FormattingEnabled = True
        Me.cboUnidade.Items.AddRange(New Object() {"1.", "2.", "3.", "4.", "5.", "6.", "7.", "8.", "11.", "12.", "13.", "14.", "15.", "16.", "Todas"})
        Me.cboUnidade.Location = New System.Drawing.Point(6, 18)
        Me.cboUnidade.MaxDropDownItems = 6
        Me.cboUnidade.Name = "cboUnidade"
        Me.cboUnidade.Size = New System.Drawing.Size(66, 21)
        Me.cboUnidade.TabIndex = 27
        Me.cboUnidade.Text = "Todas"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'View_1TableAdapter
        '
        Me.View_1TableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Usina_H_Borden.AlarmesDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'Alarmes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 749)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.View_1DataGridView)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Alarmes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alarmes e Eventos"
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.View_1DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.View_1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlarmesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents AlarmesDataSet1 As AlarmesDataSet1
    Friend WithEvents View_1BindingSource As BindingSource
    Friend WithEvents View_1TableAdapter As AlarmesDataSet1TableAdapters.View_1TableAdapter
    Friend WithEvents TableAdapterManager As AlarmesDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents View_1DataGridView As DataGridView
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents dtpAberturaFim As DateTimePicker
    Friend WithEvents dtpAberturaInicio As DateTimePicker
    Friend WithEvents optAberturaPorPeriodo As RadioButton
    Friend WithEvents optAberturaTodas As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboUnidade As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Button1 As Button
    Friend WithEvents cboHoraInicio As ComboBox
    Friend WithEvents cboHoraFinal As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cboRec As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cboAlarmesEventos As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents CboLocal As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents E3TimeStamp As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Message As DataGridViewTextBoxColumn
    Friend WithEvents ActiveSource As DataGridViewTextBoxColumn
    Friend WithEvents FullAlarmSourceName As DataGridViewTextBoxColumn
    Friend WithEvents CurrentValue As DataGridViewTextBoxColumn
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
End Class
