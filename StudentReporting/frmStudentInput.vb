Public Class frmStudentInput

    ' Clear form and focus cursor on Student ID
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtStudentId.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtStreet1.Clear()
        txtStreet2.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZipCode.Clear()

        txtStudentId.Focus()
    End Sub

    ' Set all of Student information and create Student object on the output form
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim aStudent As New Student

        aStudent.setStudentId(txtStudentId.Text)
        aStudent.setFirstName(txtFirstName.Text)
        aStudent.setLastName(txtLastName.Text)

        aStudent.HomeAddress.setStreet1(txtStreet1.Text)
        aStudent.HomeAddress.setStreet2(txtStreet2.Text)
        aStudent.HomeAddress.setCity(txtCity.Text)
        aStudent.HomeAddress.setState(txtState.Text)
        aStudent.HomeAddress.setZip(txtZipCode.Text)

        Dim outputForm As New frmOutput(aStudent)

        outputForm.ShowDialog()
    End Sub

    ' Exit application
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        System.Environment.Exit(0)
    End Sub
End Class
