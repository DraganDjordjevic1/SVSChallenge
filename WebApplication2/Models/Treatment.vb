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

Partial Public Class Treatment
    Public Property PetName As String
    Public Property OwnerID As Integer
    Public Property ProcedureID As Integer
    Public Property TreatmentDate As Date
    Public Property Notes As String
    Public Property TreatmentPrice As Decimal

    Public Overridable Property Pet As Pet
    Public Overridable Property Procedure As Procedure

End Class
