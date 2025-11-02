<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.mnuMenuPrincipal = New System.Windows.Forms.MenuStrip()
        Me.OperaçãoUHBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEquipamentos = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSeguaranca = New System.Windows.Forms.ToolStripMenuItem()
        Me.LTBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeEventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSobre = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblNomeUsuario = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CasaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenuPrincipal.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMenuPrincipal
        '
        Me.mnuMenuPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OperaçãoUHBToolStripMenuItem, Me.mnuEquipamentos, Me.mnuSeguaranca, Me.mnuConfig, Me.mnuSobre, Me.mnuSair})
        Me.mnuMenuPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenuPrincipal.Name = "mnuMenuPrincipal"
        Me.mnuMenuPrincipal.Size = New System.Drawing.Size(992, 24)
        Me.mnuMenuPrincipal.TabIndex = 0
        Me.mnuMenuPrincipal.Text = "MenuStrip1"
        '
        'OperaçãoUHBToolStripMenuItem
        '
        Me.OperaçãoUHBToolStripMenuItem.Name = "OperaçãoUHBToolStripMenuItem"
        Me.OperaçãoUHBToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.OperaçãoUHBToolStripMenuItem.Text = "Geração UHB"
        '
        'mnuEquipamentos
        '
        Me.mnuEquipamentos.Name = "mnuEquipamentos"
        Me.mnuEquipamentos.Size = New System.Drawing.Size(95, 20)
        Me.mnuEquipamentos.Text = "Equipamentos"
        '
        'mnuSeguaranca
        '
        Me.mnuSeguaranca.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LTBToolStripMenuItem})
        Me.mnuSeguaranca.Name = "mnuSeguaranca"
        Me.mnuSeguaranca.Size = New System.Drawing.Size(74, 20)
        Me.mnuSeguaranca.Text = "Segurança"
        '
        'LTBToolStripMenuItem
        '
        Me.LTBToolStripMenuItem.Name = "LTBToolStripMenuItem"
        Me.LTBToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.LTBToolStripMenuItem.Text = "LTB - Licença para Trabalhar"
        '
        'mnuConfig
        '
        Me.mnuConfig.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaDeEventosToolStripMenuItem})
        Me.mnuConfig.Name = "mnuConfig"
        Me.mnuConfig.Size = New System.Drawing.Size(96, 20)
        Me.mnuConfig.Text = "Configurações"
        '
        'ListaDeEventosToolStripMenuItem
        '
        Me.ListaDeEventosToolStripMenuItem.Name = "ListaDeEventosToolStripMenuItem"
        Me.ListaDeEventosToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ListaDeEventosToolStripMenuItem.Text = "Lista de Eventos"
        '
        'mnuSobre
        '
        Me.mnuSobre.Name = "mnuSobre"
        Me.mnuSobre.Size = New System.Drawing.Size(49, 20)
        Me.mnuSobre.Text = "Sobre"
        '
        'mnuSair
        '
        Me.mnuSair.Name = "mnuSair"
        Me.mnuSair.Size = New System.Drawing.Size(38, 20)
        Me.mnuSair.Text = "Sair"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lblHora)
        Me.GroupBox1.Controls.Add(Me.lblNomeUsuario)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 506)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(993, 30)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'lblHora
        '
        Me.lblHora.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHora.AutoSize = True
        Me.lblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHora.Location = New System.Drawing.Point(829, 11)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(34, 13)
        Me.lblHora.TabIndex = 1
        Me.lblHora.Text = "Hora"
        '
        'lblNomeUsuario
        '
        Me.lblNomeUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNomeUsuario.AutoSize = True
        Me.lblNomeUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeUsuario.Location = New System.Drawing.Point(6, 11)
        Me.lblNomeUsuario.Name = "lblNomeUsuario"
        Me.lblNomeUsuario.Size = New System.Drawing.Size(58, 13)
        Me.lblNomeUsuario.TabIndex = 0
        Me.lblNomeUsuario.Text = "Usuário:-"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'CasaToolStripMenuItem
        '
        Me.CasaToolStripMenuItem.Name = "CasaToolStripMenuItem"
        Me.CasaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CasaToolStripMenuItem.Text = "casa"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(992, 535)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.mnuMenuPrincipal)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMenuPrincipal
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gerenciamento da Manutenção e Operação"
        Me.mnuMenuPrincipal.ResumeLayout(False)
        Me.mnuMenuPrincipal.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMenuPrincipal As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuSeguaranca As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEquipamentos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuConfig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSobre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblHora As System.Windows.Forms.Label
    Friend WithEvents lblNomeUsuario As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CasaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LTBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeEventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OperaçãoUHBToolStripMenuItem As ToolStripMenuItem
End Class
