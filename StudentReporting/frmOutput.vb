Public Class frmOutput
    Public Sub New(StudentRecord As Student)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtOutput.Text = "Student ID: " & StudentRecord.getStudentId & Environment.NewLine &
        "Name: " & StudentRecord.getLastName & ", " & StudentRecord.getFirstName & Environment.NewLine &
        "Address: " & Environment.NewLine &
        StudentRecord.HomeAddress.getStreet1 & Environment.NewLine &
        StudentRecord.HomeAddress.getStreet2 & Environment.NewLine &
        StudentRecord.HomeAddress.getCity & ", " &
        StudentRecord.HomeAddress.getState & " " &
        StudentRecord.HomeAddress.getZip
    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Close window
        Me.Close()
    End Sub
End Class