Imports System.Data.SqlClient
Public Class Class1
    Dim conn As New SqlConnection("server=DESKTOP-IFJMVKQ\SQLEXPRESS;integrated security=true;Database=employees")

    'Data grid view
    Public Function showEmployees() As DataTable
        'Get procedure
        Dim adapter As New SqlDataAdapter("view_all", conn)
        'Create data table
        Dim table As New DataTable
        'Fill table
        adapter.Fill(table)

        Return table
    End Function

    'Add new employee
    Public Function newEmployee(name As String, address As String, area As Char, in_date As Date, out_date As Date)
        'Command
        Dim command As New SqlCommand("new_emp", conn)
        command.CommandType = CommandType.StoredProcedure
        'Parameters
        command.Parameters.AddWithValue("@full_name", name)
        command.Parameters.AddWithValue("@full_address", address)
        command.Parameters.AddWithValue("@area", area)
        command.Parameters.AddWithValue("@in_date", in_date)
        command.Parameters.AddWithValue("@out_date", out_date)

        Dim res As Integer
        'Execute query
        Try
            conn.Open()
            res = command.ExecuteNonQuery
            conn.Close()
            'Message box
            MsgBox("Added new employee")
        Catch ex As Exception
            MsgBox("Error when adding: " + ex.ToString)
        End Try

        Return res
    End Function

    'Delete employee
    Public Function deleteEmployee(id As String)
        'Command
        Dim command As New SqlCommand("del_emp", conn)
        command.CommandType = CommandType.StoredProcedure
        'Parameters
        command.Parameters.AddWithValue("@id", id)

        Dim res As String
        'Query
        Try
            conn.Open()
            res = command.ExecuteNonQuery
            conn.Close()
            'Message box
            MsgBox("Deleted employee with ID " + id)
        Catch ex As Exception
            MsgBox("Error when deleting: " + ex.ToString)
        End Try

        Return res
    End Function

    'Edit employee
    Public Function editEmployee(id As String, name As String, address As String, area As Char, in_date As Date, out_date As Date)
        'Command
        Dim command As New SqlCommand("edit_emp", conn)
        command.CommandType = CommandType.StoredProcedure
        'Parameters
        command.Parameters.AddWithValue("@id", id)
        command.Parameters.AddWithValue("@full_name", name)
        command.Parameters.AddWithValue("@full_address", address)
        command.Parameters.AddWithValue("@area", area)
        command.Parameters.AddWithValue("@in_date", in_date)
        command.Parameters.AddWithValue("@out_date", out_date)

        Dim res As String
        'Query
        Try
            conn.Open()
            res = command.ExecuteNonQuery
            conn.Close()
            'Message box
            MsgBox("Edited employee with ID " + id)
        Catch ex As Exception
            MsgBox("Error when updating: " + ex.ToString)
        End Try

        Return res
    End Function

End Class
