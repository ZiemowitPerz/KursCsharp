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

Partial Public Class Users
    Public Property ApplicationId As System.Guid
    Public Property UserId As System.Guid
    Public Property UserName As String
    Public Property IsAnonymous As Boolean
    Public Property LastActivityDate As Date
    Public Property UserPassword As String

    Public Overridable Property Students As Students
    Public Overridable Property Teachers As Teachers

End Class
