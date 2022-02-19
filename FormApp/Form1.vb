'Make reference first
'Import [project name]
Imports Libreria

Public Class Form1
    'Object with functions
    Dim obj As New Class1

    'Load data in data grid
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load data
        dgv_all.DataSource = obj.showEmployees
    End Sub

    'Get employee data in text boxes
    Private Sub dgv_all_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_all.CellClick
        Try
            'Change textboxes
            lbl_id.Text = dgv_all.Item(0, e.RowIndex).Value
            txtbx_name.Text = dgv_all.Item(1, e.RowIndex).Value
            txtbx_address.Text = dgv_all.Item(2, e.RowIndex).Value
            txtbx_area.Text = dgv_all.Item(3, e.RowIndex).Value
            dtp_in.Text = dgv_all.Item(4, e.RowIndex).Value
            dtp_out.Text = dgv_all.Item(5, e.RowIndex).Value
        Catch ex As Exception

        End Try
    End Sub

    'Add new employee
    Private Sub mnstrp_new_Click(sender As Object, e As EventArgs) Handles mnstrp_new.Click
        Try
            'Insert new employee
            obj.newEmployee(txtbx_name.Text, txtbx_address.Text, txtbx_area.Text, CDate(dtp_in.Text), CDate(dtp_out.Text))
            'Update data grid view
            dgv_all.DataSource = obj.showEmployees

            'Clear fields
            txtbx_name.Text = ""
            txtbx_address.Text = ""
            txtbx_area.Text = ""
            lbl_id.Text = ""
            dtp_in.Value = DateTime.Now
            dtp_out.Value = DateTime.Now
        Catch ex As Exception
            MsgBox("Error when adding new employee")
        End Try
    End Sub

    'Edit employee
    Private Sub mnstrp_edit_Click(sender As Object, e As EventArgs) Handles mnstrp_edit.Click
        Try
            'Insert new employee
            obj.editEmployee(lbl_id.Text, txtbx_name.Text, txtbx_address.Text, txtbx_area.Text, CDate(dtp_in.Text), CDate(dtp_out.Text))
            'Update data grid view
            dgv_all.DataSource = obj.showEmployees

            'Clear fields
            txtbx_name.Text = ""
            txtbx_address.Text = ""
            txtbx_area.Text = ""
            lbl_id.Text = ""
            dtp_in.Value = DateTime.Now
            dtp_out.Value = DateTime.Now
        Catch ex As Exception
            MsgBox("Error when editing employee with ID " + lbl_id.Text)
        End Try
    End Sub

    'Delete employee
    Private Sub mnstrp_delete_Click(sender As Object, e As EventArgs) Handles mnstrp_delete.Click
        Try
            'Insert new employee
            obj.deleteEmployee(lbl_id.Text)
            'Update data grid view
            dgv_all.DataSource = obj.showEmployees

            'Clear fields
            txtbx_name.Text = ""
            txtbx_address.Text = ""
            txtbx_area.Text = ""
            lbl_id.Text = ""
            dtp_in.Value = DateTime.Now
            dtp_out.Value = DateTime.Now
        Catch ex As Exception
            MsgBox("Error when deleting employee with ID " + lbl_id.Text)
        End Try
    End Sub

    'Clear fields
    Private Sub mnstrp_clear_Click(sender As Object, e As EventArgs) Handles mnstrp_clear.Click
        'Clear fields
        txtbx_name.Text = ""
        txtbx_address.Text = ""
        txtbx_area.Text = ""
        lbl_id.Text = ""
        dtp_in.Value = DateTime.Now
        dtp_out.Value = DateTime.Now
    End Sub

End Class
