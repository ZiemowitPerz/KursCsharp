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

Partial Public Class Teachers
    Public Property UserId As System.Guid
    Public Property FirstName As String
    Public Property LastName As String
    Public Property [Class] As String

    Public Overridable Property Students As ICollection(Of Students) = New HashSet(Of Students)
    Public Overridable Property Users As Users

End Class
