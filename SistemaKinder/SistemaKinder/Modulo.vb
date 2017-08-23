Imports System.Data.SqlClient
Module Modulo
    Public Function openConection()
        Dim conexionsql As New SqlConnection("Data Source = 'DIEGO'; Initial catalog = 'bdKinder'; Integrated security = 'true'")
        Return conexionsql
    End Function
End Module
