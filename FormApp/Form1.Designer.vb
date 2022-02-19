<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnstrp_clear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnstrp_new = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnstrp_edit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnstrp_delete = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgv_all = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtp_in = New System.Windows.Forms.DateTimePicker()
        Me.dtp_out = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbx_name = New System.Windows.Forms.TextBox()
        Me.txtbx_address = New System.Windows.Forms.TextBox()
        Me.txtbx_area = New System.Windows.Forms.TextBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgv_all, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnstrp_clear, Me.mnstrp_new, Me.mnstrp_edit, Me.mnstrp_delete})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnstrp_clear
        '
        Me.mnstrp_clear.Name = "mnstrp_clear"
        Me.mnstrp_clear.Size = New System.Drawing.Size(50, 21)
        Me.mnstrp_clear.Text = "Clear"
        '
        'mnstrp_new
        '
        Me.mnstrp_new.Name = "mnstrp_new"
        Me.mnstrp_new.Size = New System.Drawing.Size(47, 21)
        Me.mnstrp_new.Text = "New"
        '
        'mnstrp_edit
        '
        Me.mnstrp_edit.Name = "mnstrp_edit"
        Me.mnstrp_edit.Size = New System.Drawing.Size(43, 21)
        Me.mnstrp_edit.Text = "Edit"
        '
        'mnstrp_delete
        '
        Me.mnstrp_delete.Name = "mnstrp_delete"
        Me.mnstrp_delete.Size = New System.Drawing.Size(58, 21)
        Me.mnstrp_delete.Text = "Delete"
        '
        'dgv_all
        '
        Me.dgv_all.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_all.Location = New System.Drawing.Point(12, 265)
        Me.dgv_all.Name = "dgv_all"
        Me.dgv_all.RowTemplate.Height = 25
        Me.dgv_all.Size = New System.Drawing.Size(776, 173)
        Me.dgv_all.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(12, 241)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "All"
        '
        'dtp_in
        '
        Me.dtp_in.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dtp_in.Location = New System.Drawing.Point(571, 140)
        Me.dtp_in.Name = "dtp_in"
        Me.dtp_in.Size = New System.Drawing.Size(200, 23)
        Me.dtp_in.TabIndex = 3
        '
        'dtp_out
        '
        Me.dtp_out.CalendarFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.dtp_out.Location = New System.Drawing.Point(571, 191)
        Me.dtp_out.Name = "dtp_out"
        Me.dtp_out.Size = New System.Drawing.Size(200, 23)
        Me.dtp_out.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 21)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Data"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(121, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 21)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(92, 142)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 21)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(78, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(470, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 21)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Out Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(483, 140)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 21)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "In Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(503, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 21)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Area"
        '
        'txtbx_name
        '
        Me.txtbx_name.Location = New System.Drawing.Point(172, 140)
        Me.txtbx_name.Name = "txtbx_name"
        Me.txtbx_name.Size = New System.Drawing.Size(200, 23)
        Me.txtbx_name.TabIndex = 12
        '
        'txtbx_address
        '
        Me.txtbx_address.Location = New System.Drawing.Point(172, 191)
        Me.txtbx_address.Name = "txtbx_address"
        Me.txtbx_address.Size = New System.Drawing.Size(200, 23)
        Me.txtbx_address.TabIndex = 13
        '
        'txtbx_area
        '
        Me.txtbx_area.Location = New System.Drawing.Point(571, 94)
        Me.txtbx_area.Name = "txtbx_area"
        Me.txtbx_area.Size = New System.Drawing.Size(200, 23)
        Me.txtbx_area.TabIndex = 14
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbl_id.Location = New System.Drawing.Point(172, 96)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(0, 21)
        Me.lbl_id.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.txtbx_area)
        Me.Controls.Add(Me.txtbx_address)
        Me.Controls.Add(Me.txtbx_name)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_out)
        Me.Controls.Add(Me.dtp_in)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_all)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgv_all, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnstrp_clear As ToolStripMenuItem
    Friend WithEvents mnstrp_new As ToolStripMenuItem
    Friend WithEvents mnstrp_edit As ToolStripMenuItem
    Friend WithEvents mnstrp_delete As ToolStripMenuItem
    Friend WithEvents dgv_all As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents dtp_in As DateTimePicker
    Friend WithEvents dtp_out As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtbx_name As TextBox
    Friend WithEvents txtbx_address As TextBox
    Friend WithEvents txtbx_area As TextBox
    Friend WithEvents lbl_id As Label
End Class
