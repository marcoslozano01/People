Public Class frmPersons
    Property ofdPath1 As OpenFileDialog = New OpenFileDialog
    Dim filePath As String
    Dim p As Person
    Private Sub frmPersons_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnDBSelect_Click(sender As Object, e As EventArgs) Handles btnDBSelect.Click
        ofdPath1.InitialDirectory = "C:\Users\marco\OneDrive - Universidad de Castilla-La Mancha\2ºCURSO-2020\2º_CUATRIMESTRE\BBDD\Proyecto 2\People - public\People"
        ofdPath1.Filter = "Microsoft Access Database (.accdb)|*.accdb"
        Try
            If ofdPath1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                filePath = ofdPath1.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnOpenDB.Enabled = True
        btnDBSelect.Enabled = False

    End Sub

    Private Sub btnOpenDB_Click(sender As Object, e As EventArgs) Handles btnOpenDB.Click
        Dim person As Person
        p = New Person
        Me.p.ReadAllPersons(filePath)
        Try
            For Each person In Me.p.PerDAO.Persons
                lstPersons.Items.Add(person.PersonID)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnOpenDB.Enabled = False
        btnAdd.Enabled = True
        txtID.Enabled = True
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtID.Clear()
        txtName.Clear()
        btnDelete.Enabled = False
        btnUpdate.Enabled = False
        txtID.Enabled = True
        btnAdd.Enabled = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.p = New Person(txtID.Text)
        p.PersonName = txtName.Text
        Try
            If p.InsertPerson() <> 1 Then
                MessageBox.Show("The id already exists")
                Exit Sub
            End If
            lstPersons.Items.Add(p.PersonID)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnClear.PerformClick()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.p = New Person(lstPersons.SelectedItem.ToString)
        Try
            If p.DeletePerson() <> 1 Then
                MessageBox.Show("The id already exists")
                Exit Sub
            End If
            lstPersons.Items.RemoveAt(lstPersons.SelectedIndex)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnClear.PerformClick()
    End Sub

    Private Sub lstPersons_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPersons.SelectedIndexChanged
        If lstPersons.SelectedItem IsNot Nothing Then
            Dim person As Person = New Person(lstPersons.SelectedItem.ToString)
            Try
                person.ReadPerson()
            Catch ex As Exception
                ex.ToString()
            End Try
            txtID.Text = person.PersonID
            txtName.Text = person.PersonName
        End If
        btnDelete.Enabled = True
        btnUpdate.Enabled = True
        txtID.Enabled = False
        btnAdd.Enabled = False
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Me.p = New Person(lstPersons.SelectedItem.ToString)
        p.PersonName = txtName.Text
        Try
            If p.UpdatePerson() <> 1 Then
                MessageBox.Show("The id already exists")
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        btnClear.PerformClick()
    End Sub
End Class
