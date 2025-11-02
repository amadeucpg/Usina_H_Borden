Imports System.Data.SqlClient

Public Class frmArvoreEquipamentos
    Private Sub Arvore_Equipamentos_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles Arvore_Equipamentos.AfterSelect
        Dim da As SqlDataAdapter
        Dim x As Integer
        Dim nodo1 As TreeNode
        Dim dtbNivel2 As New DataTable
        Dim i As Integer
        Dim nodo2 As TreeNode
        Dim dtbNivel3 As New DataTable
        Dim j As Integer
        Dim nodo4 As TreeNode
        Dim dtbNivel4 As New DataTable
        Dim k As Integer
        Dim nodo5 As TreeNode
        Dim dtbNivel5 As New DataTable
        Dim l As Integer
        Dim nodo6 As TreeNode
        Dim dtbNivel6 As New DataTable
        Dim m As Integer

        TextBox1.Text = Arvore_Equipamentos.SelectedNode.Tag
        TextBox2.Text = Arvore_Equipamentos.SelectedNode.Index
        Try
            If Arvore_Equipamentos.SelectedNode.Nodes.Count = 0 And Len(Arvore_Equipamentos.SelectedNode.Tag) = 4 Then
                Me.Cursor = Cursors.WaitCursor
                x = Arvore_Equipamentos.SelectedNode.Index
                da = New SqlDataAdapter("select * from geral where nivel=2 and codigo like '%" & Arvore_Equipamentos.SelectedNode.Tag & "%' order by codigo", cnn)
                da.Fill(dtbNivel2)
                ProgressBar1.Maximum = dtbNivel2.Rows.Count
                ProgressBar1.Value = 0
                For i = 0 To dtbNivel2.Rows.Count - 1
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    nodo1 = Arvore_Equipamentos.Nodes(x).Nodes.Add(dtbNivel2.Rows(i).Item("Descricao"))
                    nodo1.Tag = dtbNivel2.Rows(i).Item("Codigo")
                    If Len(nodo1.Tag) = 7 Then
                        da = Nothing
                        da = New SqlDataAdapter("select * from geral where nivel=3 and codigo like '%" & nodo1.Tag & "%' order by codigo", cnn)

                        dtbNivel3.Rows.Clear()
                        da.Fill(dtbNivel3)
                        j = 0
                        For j = 0 To dtbNivel3.Rows.Count - 1
                            nodo2 = Arvore_Equipamentos.Nodes(x).Nodes(i).Nodes.Add(dtbNivel3.Rows(j).Item("Descricao"))
                            nodo2.Tag = dtbNivel3.Rows(j).Item("Codigo")
                            If Len(nodo2.Tag) = 10 Then
                                da = Nothing
                                da = New SqlDataAdapter("select * from geral where nivel=4 and codigo like '%" & nodo2.Tag & "%' order by codigo", cnn)

                                dtbNivel4.Rows.Clear()
                                da.Fill(dtbNivel4)
                                k = 0
                                For k = 0 To dtbNivel4.Rows.Count - 1
                                    nodo4 = nodo2.Nodes.Add(dtbNivel4.Rows(k).Item("Descricao"))
                                    nodo4.Tag = dtbNivel4.Rows(k).Item("Codigo")
                                    If Len(nodo4.Tag) = 14 Then
                                        da = Nothing
                                        da = New SqlDataAdapter("select * from geral where nivel=5 and codigo like '%" & nodo4.Tag & "%' order by codigo", cnn)

                                        dtbNivel5.Rows.Clear()
                                        da.Fill(dtbNivel5)
                                        l = 0
                                        For l = 0 To dtbNivel5.Rows.Count - 1
                                            nodo5 = nodo4.Nodes.Add(dtbNivel5.Rows(l).Item("Descricao"))
                                            nodo5.Tag = dtbNivel5.Rows(l).Item("Codigo")
                                            If Len(nodo5.Tag) = 17 Then
                                                da = Nothing
                                                da = New SqlDataAdapter("select * from geral where nivel=6 and codigo like '%" & nodo5.Tag & "%' order by codigo", cnn)

                                                dtbNivel6.Rows.Clear()
                                                da.Fill(dtbNivel6)
                                                m = 0
                                                For m = 0 To dtbNivel6.Rows.Count - 1
                                                    nodo6 = nodo5.Nodes.Add(dtbNivel6.Rows(m).Item("Descricao"))
                                                    nodo6.Tag = dtbNivel6.Rows(m).Item("Codigo")
                                                Next
                                            End If
                                        Next
                                    End If
                                Next
                            End If
                        Next
                    End If
                Next
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub frmArvoreEquipamentos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim da As SqlDataAdapter
        Dim dtbNivel1 As New DataTable
        Dim i As Integer
        Dim nodo As TreeNode

        Try

            'define os Adaptadores
            da = New SqlDataAdapter("select * from geral where nivel=1 order by codigo", cnn)

            'preencher o DataSet
            da.Fill(dtbNivel1)

            'Preenchendo o TreeView

            Arvore_Equipamentos.Nodes.Clear()

            'percorre cada linha na tabela categorias 
            For i = 0 To dtbNivel1.Rows.Count - 1
                'preencher todas as categorias com o nome -  CategoryName
                nodo = Arvore_Equipamentos.Nodes.Add(dtbNivel1.Rows(i).Item("Codigo") & " - " & dtbNivel1.Rows(i).Item("Descricao"))
                nodo.Tag = dtbNivel1.Rows(i).Item("Codigo")
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class