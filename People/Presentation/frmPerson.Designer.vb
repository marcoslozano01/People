<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPersons
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnOpenDB = New System.Windows.Forms.Button()
        Me.ofdPath = New System.Windows.Forms.OpenFileDialog()
        Me.lstPersons = New System.Windows.Forms.ListBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDBSelect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOpenDB
        '
        Me.btnOpenDB.Enabled = False
        Me.btnOpenDB.Location = New System.Drawing.Point(90, 314)
        Me.btnOpenDB.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOpenDB.Name = "btnOpenDB"
        Me.btnOpenDB.Size = New System.Drawing.Size(112, 35)
        Me.btnOpenDB.TabIndex = 0
        Me.btnOpenDB.Text = "Connect!"
        Me.btnOpenDB.UseVisualStyleBackColor = True
        '
        'ofdPath
        '
        Me.ofdPath.FileName = "OpenFileDialog1"
        '
        'lstPersons
        '
        Me.lstPersons.FormattingEnabled = True
        Me.lstPersons.ItemHeight = 20
        Me.lstPersons.Location = New System.Drawing.Point(56, 68)
        Me.lstPersons.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstPersons.Name = "lstPersons"
        Me.lstPersons.Size = New System.Drawing.Size(178, 224)
        Me.lstPersons.TabIndex = 1
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(352, 77)
        Me.txtID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(157, 26)
        Me.txtID.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(352, 135)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(157, 26)
        Me.txtName.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Enabled = False
        Me.btnAdd.Location = New System.Drawing.Point(274, 226)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(81, 51)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Insert"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Location = New System.Drawing.Point(378, 226)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(81, 51)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Location = New System.Drawing.Point(378, 306)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 51)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(274, 306)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(81, 51)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(270, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "PersonID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(294, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name"
        '
        'btnDBSelect
        '
        Me.btnDBSelect.Location = New System.Drawing.Point(90, 358)
        Me.btnDBSelect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDBSelect.Name = "btnDBSelect"
        Me.btnDBSelect.Size = New System.Drawing.Size(112, 35)
        Me.btnDBSelect.TabIndex = 10
        Me.btnDBSelect.Text = "Choose DB"
        Me.btnDBSelect.UseVisualStyleBackColor = True
        '
        'frmPersons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(554, 417)
        Me.Controls.Add(Me.btnDBSelect)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lstPersons)
        Me.Controls.Add(Me.btnOpenDB)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPersons"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Databases - Project2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnOpenDB As Button
    Friend WithEvents ofdPath As OpenFileDialog
    Friend WithEvents lstPersons As ListBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDBSelect As Button
End Class
