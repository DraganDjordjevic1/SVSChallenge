﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class SVSChallengeEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=SVSChallengeEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property Owners() As DbSet(Of Owner)
    Public Overridable Property Pets() As DbSet(Of Pet)
    Public Overridable Property Procedures() As DbSet(Of Procedure)
    Public Overridable Property Treatments() As DbSet(Of Treatment)

End Class
