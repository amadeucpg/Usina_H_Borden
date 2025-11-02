Imports System.IO
Imports System.Security.Principal.WindowsIdentity

Public Class frmPrincipal

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        Dim dr As DataRow
        Try
            Using da = New SqlClient.SqlDataAdapter("select * from PessoalQQ where registro=" & UsuarioWindows(), cnnMackGeral)
                Using ds As New DataSet
                    da.Fill(ds, "Usuario")
                    dt = ds.Tables("Usuario")
                End Using
            End Using
            If dt.Rows.Count > 0 Then
                dr = dt.Rows(0)
                intRegUsuario = dr("Registro")
                strNomeUsuario = dr("Nome")
                If Not (dr("Local") Is DBNull.Value) Then strLocalUsuario = dr("Local") Else strLocalUsuario = ""
            Else
                strNomeUsuario = GetCurrent.Name
                MsgBox("O usuario logado na rede não é usuario cadastrado no sistema de manutenção.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        lblHora.Text = Now
        lblNomeUsuario.Text = lblNomeUsuario.Text & "  " & strNomeUsuario & "  -   " & strLocalUsuario
        Me.Text += "   --   " + String.Format("Versão {0}", My.Application.Info.Version.ToString) + "   -------   " + My.Application.Info.Description

        IncluirLogEvento("ENTRAR", "ENTROU NO SISTEMA", Me.Name, 0)

    End Sub

    Private Sub CadastroEmUsoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'StrCanceladas = False

        'strCampos = "SelecT Ods, usina as Estrutura, arquivo as Titular, desc1 as Descrição," &
        '    "pedn as Pedido,pedd as Abertura,PFECH as Previsão,fecha as Conclusão," &
        '    "unidade as Unidade,equipamento as Equipamento, ODI as ODI "
        'strTabela = "from ods "
        'strFiltro = "where (destaque <> 1) and (pedd >'" & limite & "' or fecha is null) "
        'strOrdem = "order by ods"

        'frmOdsLista.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        lblHora.Text = Now

    End Sub

    Private Sub mnuEquipamentos_Click(sender As System.Object, e As System.EventArgs) Handles mnuEquipamentos.Click

        frmArvoreEquipamentos.ShowDialog()

    End Sub

    Private Sub frmPrincipal_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Dim diretor As String = Application.StartupPath & "\Imagens\usinas"   '"\\172.16.4.186\Manutencao\Imagens\usinas" 
        Dim DirDiretorio As DirectoryInfo = New DirectoryInfo(diretor)
        Dim oFileInfoCollection() As FileInfo
        Dim i As Integer
        Dim a As String
        Static x As System.Random = New System.Random()

        Try

            oFileInfoCollection = DirDiretorio.GetFiles("*.jpg")

            i = x.Next(1, oFileInfoCollection.Length())

            If i = 0 Then i += 1

            a = diretor & "\" & i & ".jpg"

            BackgroundImage = Image.FromFile(a)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub LTBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LTBToolStripMenuItem.Click

        FrmLTBLista.ShowDialog()

    End Sub

    Private Sub CadastrarNovaLTBToolStripMenuItem_Click(sender As Object, e As EventArgs)

        StrOperacaoLTB = "Incluir"

        ' FrmLTBVisual.ShowDialog()

    End Sub

    Private Sub VisualizarLTBToolStripMenuItem_Click(sender As Object, e As EventArgs)

        StrOperacaoLTB = "Visualizar"

        'FrmLTBVisual.ShowDialog()

    End Sub

    Private Sub ListagemDeLTBsToolStripMenuItem_Click(sender As Object, e As EventArgs)

        'FrmLTBLista.ShowDialog()

    End Sub

    Private Sub mnuSair_Click(sender As Object, e As EventArgs) Handles mnuSair.Click

        Close()

    End Sub

    Private Sub mnuSobre_Click(sender As Object, e As EventArgs) Handles mnuSobre.Click

        AboutBox1.ShowDialog()

    End Sub

    Private Sub CanceladasToolStripMenuItem_Click(sender As Object, e As EventArgs)

        'limite = TrataDatas(DateAdd("d", -1460, Today))

        'strCampos = "Select Ods, usina as Estrutura, arquivo as Titular, desc1 as Descrição," &
        '    "pedn as Pedido,pedd as Abertura,PFECH as Previsão,fecha as Conclusão," &
        '    "unidade as Unidade,equipamento as Equipamento, ODI as ODI "
        'strTabela = "from ods "
        'strFiltro = "where (destaque = 1) " 'and (pedd >'" & limite & "') "
        'strOrdem = "order by ods"

        'StrCanceladas = True

        'frmOdsLista.ShowDialog()

    End Sub

    Private Sub frmPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        IncluirLogEvento("FECHAR", "SAIU DO SISTEMA", Me.Name, 0)

    End Sub

    Private Sub LiToolStripMenuItem_Click(sender As Object, e As EventArgs)

        'FrmLTBLista.ShowDialog()

    End Sub

    Private Sub OperaçãoUHBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OperaçãoUHBToolStripMenuItem.Click

        FrmInstante.ShowDialog()

    End Sub

    Private Sub mnuMenuPrincipal_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles mnuMenuPrincipal.ItemClicked

    End Sub
End Class
