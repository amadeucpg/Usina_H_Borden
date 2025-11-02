Imports System.Data.SqlClient
Imports System.Security
Imports System.Security.Principal.WindowsIdentity

Public Class Form1
    Dim dt As DataTable
    Dim bs As New BindingSource

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'UG6DataSet.View_3'. Você pode movê-la ou removê-la conforme necessário.
        Me.View_3TableAdapter.Fill(Me.UG6DataSet.View_3)
        'TODO: esta linha de código carrega dados na tabela 'UG6DataSet.View_2'. Você pode movê-la ou removê-la conforme necessário.
        Atualizar()


    End Sub
    Private Sub Atualizar()
        Try
            Dim cnn As New SqlConnection(
                "Data Source=SRVMACKENZIE\ELIPSEDATA;Initial Catalog=UG6;Persist Security Info=True;User ID=emae@elipse;Password=emae#_2018")

            Using da = New SqlClient.SqlDataAdapter("select * from View_3", cnn)
                Using ds As New DataSet
                    da.Fill(ds, "View_3")
                    dt = ds.Tables("View_3")
                End Using
            End Using

            bs.DataSource = dt
            View_3DataGridView.DataSource = bs
            BindingNavigator1.BindingSource = bs
            View_3DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            bs.MoveFirst()

            Dim dr As DataRow = dt.Rows(0)

            Label1.Text = "Atualizado em:" & Now


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Atualizar()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Atualizar()

    End Sub
End Class
