﻿Public Class Student
    Private LastName As String
    Private FirstName As String
    Private Id As String
    Public HomeAddress As Address

    ' Set and Get Student values
    Public Sub setLastName(value As String)
        LastName = value
    End Sub

    Public Function getLastName() As String
        Return LastName
    End Function

    Public Sub setFirstName(value As String)
        FirstName = value
    End Sub

    Public Function getFirstName() As String
        Return FirstName
    End Function

    Public Sub setStudentId(value As String)
        Id = value
    End Sub

    Public Function getStudentId() As String
        Return Id
    End Function

    Public Sub New()
        HomeAddress = New Address
    End Sub
End Class
