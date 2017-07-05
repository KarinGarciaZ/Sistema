Public Class frmMenu
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub AlumnosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AlumnosToolStripMenuItem.Click
        frmAlumnos.ShowDialog()
    End Sub

    Private Sub TutoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TutoresToolStripMenuItem.Click
        frmTutores.ShowDialog()
    End Sub

    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem.Click
        frmEmpleados.ShowDialog()
    End Sub

    Private Sub MaterialesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialesToolStripMenuItem.Click
        frmMateriales.ShowDialog()
    End Sub

    Private Sub GruposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GruposToolStripMenuItem.Click
        frmGrupos.ShowDialog()
    End Sub

    Private Sub EscuelasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmEscuelas.ShowDialog()
    End Sub

    Private Sub DiscapacidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DiscapacidadesToolStripMenuItem.Click
        frmDiscapacidades.ShowDialog()
    End Sub

    Private Sub SalidaDeMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaDeMaterialToolStripMenuItem.Click
        frmPrestamoMaterial.ShowDialog()
    End Sub

    Private Sub EntradaDeMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaDeMaterialToolStripMenuItem.Click
        frmEntradaMaterial.ShowDialog()
    End Sub

    Private Sub PagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem.Click
        frmPagos.ShowDialog()
    End Sub
    Private Sub GastosToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles GastosToolStripMenuItem.Click
        frmGastos.ShowDialog()
    End Sub

    Private Sub AlumnosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AlumnosToolStripMenuItem1.Click
        frmConsAlumnos.ShowDialog()
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        frmConsEmpleados.ShowDialog()
    End Sub

    Private Sub TutoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TutoresToolStripMenuItem1.Click
        frmConsTutores.ShowDialog()
    End Sub

    Private Sub MaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MaterialToolStripMenuItem.Click
        frmConsMaterial.ShowDialog()
    End Sub

    Private Sub GruposToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles GruposToolStripMenuItem1.Click
        frmConsGrupos.ShowDialog()
    End Sub

    Private Sub EscuelaToolStripMenuItem_Click(sender As Object, e As EventArgs) 
        frmConsEscuelas.ShowDialog()
    End Sub

    Private Sub DiscapacidadesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DiscapacidadesToolStripMenuItem1.Click
        frmConsDiscapacidades.ShowDialog()
    End Sub

    Private Sub EntradaMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaMaterialToolStripMenuItem.Click
        frmConsEntradaMaterial.ShowDialog()
    End Sub

    Private Sub PréstamoMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PréstamoMaterialToolStripMenuItem.Click
        frmConsPrestamo.ShowDialog()
    End Sub

    Private Sub PagosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PagosToolStripMenuItem1.Click
        frmConsPagos.ShowDialog()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class