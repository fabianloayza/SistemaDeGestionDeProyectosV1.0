Public Class FormGerente


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FormHistorialProyectos As New FormHistorialProyectos
        FormHistorialProyectos.Show()

    End Sub
End Class