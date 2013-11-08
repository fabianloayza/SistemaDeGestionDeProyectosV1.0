Imports MySql.Data.MySqlClient
Public Class FormHistorialProyectos
    Dim conex As New MySqlConnection("data source = localhost; user id=root; password ='';database = sgp iae")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim da2 As MySqlDataAdapter
    Dim dt2 As DataTable
    Dim sql2 As String





    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call MostrarProyectos()
    End Sub

    Private Sub MostrarProyectos()
        Try
            sql = "SELECT * FROM `tabla_proyectos` "
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            GrillaProyectos.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub
End Class