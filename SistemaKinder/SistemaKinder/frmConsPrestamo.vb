Public Class frmConsPrestamo
    Private Sub radioPrestamo_CheckedChanged(sender As Object, e As EventArgs) Handles radioPrestamo.CheckedChanged
        If radioPrestamo.Checked = True Then
            cboPrestamo.Visible = True
        Else
            cboPrestamo.Visible = False
        End If
    End Sub

    Private Sub radioEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles radioEmpleado.CheckedChanged
        If radioEmpleado.Checked = True Then
            cboEmpleado.Visible = True
            lblApm.Visible = True
            lblApp.Visible = True
            txtApm.Visible = True
            txtApp.Visible = True
        Else
            cboEmpleado.Visible = False
            lblApm.Visible = False
            lblApp.Visible = False
            txtApm.Visible = False
            txtApp.Visible = False
        End If
    End Sub

    Private Sub radioMaterial_CheckedChanged(sender As Object, e As EventArgs) Handles radioMaterial.CheckedChanged
        If radioMaterial.Checked = True Then
            cboMaterial.Visible = True
        Else
            cboMaterial.Visible = False
        End If
    End Sub


End Class