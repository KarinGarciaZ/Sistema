Imports System.Data.SqlClient
Public Class frmConsTutores

    Dim conexionsql As SqlConnection = openConection()
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader

    Private Sub radioTutor_CheckedChanged(sender As Object, e As EventArgs) Handles radioTutor.CheckedChanged
        If radioTutor.Checked = True Then
            dgTutor.Visible = True
            lblApm.Visible = True
            lblApp.Visible = True
            txtApm.Visible = True
            txtApp.Visible = True
            cboTutor.Visible = True
        Else
            dgTutor.Visible = False
            lblApm.Visible = False
            lblApp.Visible = False
            txtApm.Visible = False
            txtApp.Visible = False
            cboTutor.Visible = False
        End If
    End Sub

    Private Sub frmConsTutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BdKinderDataSet.Tutores' Puede moverla o quitarla según sea necesario.
        Me.TutoresTableAdapter.Fill(Me.BdKinderDataSet.Tutores)
        conexionsql.Open()
    End Sub

    Private Sub radioConsulta_CheckedChanged(sender As Object, e As EventArgs) Handles radioConsulta.CheckedChanged
        dgGeneral.Rows.Clear()
        Dim R As String
        R = "SELECT * FROM Tutores"
        comando.CommandText = R
        lector = comando.ExecuteReader
        Dim gen As String
        While lector.Read
            If lector(6) Then
                gen = "Femenino"
            Else
                gen = "Masculino"
            End If
            dgGeneral.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(7), gen, lector(8), lector(9), lector(12), lector(13), lector(11))
        End While
        lector.Close()
    End Sub

    Private Sub cboTutor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTutor.SelectedIndexChanged
        dgGeneral.Rows.Clear()
        dgTutor.Rows.Clear()
        Dim id As Integer = cboTutor.SelectedValue
        Dim R As String

        If conexionsql.State = ConnectionState.Open Then
            R = "SELECT * FROM Tutores"
            comando.CommandText = R
            lector = comando.ExecuteReader
            lector.Read()
            id = lector(0)
            txtApp.Text = lector(2)
            txtApm.Text = lector(3)
            lector.Close()

            R = "SELECT Alumnos.matricula, Alumnos.nombre, Alumnos.apellidoPaterno, Alumnos.apellidoMaterno, Tutores.parentesco, Tutores.correo, Tutores.telefono, Tutores.telCelular, Tutores.ocupacion FROM Alumnos INNER JOIN Tutores on Alumnos.idTutor = Tutores.idTutor"
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read
                dgTutor.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8))
            End While
            lector.Close()
        End If

    End Sub

    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        conexionsql.Close()
        Me.Dispose()
    End Sub
End Class