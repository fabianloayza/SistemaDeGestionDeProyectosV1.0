Imports MySql.Data.MySqlClient
Public Class FormCrearProyecto

    'para VINCULAR BASE DE DATOS MYSQL'
    Dim conex As New MySqlConnection("data source = localhost; user id=root; password ='';database = SGP IAE")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim da2 As MySqlDataAdapter
    Dim dt2 As DataTable
    Dim sql2 As String

    '----------------------------------------------------------------------'



    Dim cod_proyecto As String
    Dim nom_proyecto As String
    Dim temas As String
    Dim nom_establecimiento As String
    Dim direccion_est As String
    Dim capacidad As String
    Dim cant_cupos As String
    Dim fecha_ini As String
    Dim fecha_fin As String



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call InsertarDatosEnBD()
    End Sub

    Private Sub InsertarDatosEnBD()
        Try

            cod_proyecto = TextBoxcodproyecto.Text
            nom_proyecto = TextBoxnomproyecto.Text
            temas = TextBoxTemas.Text
            nom_establecimiento = TextBoxnomestablecimiento.Text
            direccion_est = TextBoxdireccion.Text
            capacidad = TextBoxcapacidad.Text
            cant_cupos = TextBoxcantcupos.Text
            fecha_ini = DateTimePicker1.Value
            fecha_fin = DateTimePicker2.Value

            sql = "INSERT INTO `sgp iae`.`Tabla_Proyectos` (`cod_proyecto` ,`nom_proyecto` ,`temas` ,`nom_establecimiento` ,`direccion_est` ,`capacidad` ,`cant_cupos` ,`fecha_ini` ,`fecha_fin`)VALUES ('" + cod_proyecto + "', '" + nom_proyecto + "', '" + temas + "', '" + nom_establecimiento + "', '" + direccion_est + "', '" + capacidad + "', '" + cant_cupos + "', '" + fecha_ini + "', '" + fecha_fin + "')"
            da = New MySqlDataAdapter(sql, conex)
            dt = New DataTable
            da.Fill(dt)
            'Datos.DataSource = dt

            MsgBox("Se Guardo con Exito!")

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Close()

    End Sub
End Class