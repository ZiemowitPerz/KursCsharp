'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Students
    Public Property UserId As System.Guid
    Public Property FirstName As String
    Public Property LastName As String
    Public Property ImageName As String
    Public Property TeacherUserId As Nullable(Of System.Guid)

    Public Overridable Property Grades As ICollection(Of Grades) = New HashSet(Of Grades)
    Public Overridable Property Users As Users
    Public Overridable Property Teachers As Teachers

End Class
