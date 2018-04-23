Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Namespace Scaffolding.DetailCollectionsEFCore.Model
	Public Class Department
		Public Sub New()
			Courses = New HashSet(Of Course)()
			Employees = New HashSet(Of Employee)()
		End Sub
		Public Property DepartmentID() As Integer
		Public Property Name() As String
		Public Overridable Property Courses() As ICollection(Of Course)
		Public Overridable Property Employees() As ICollection(Of Employee)
	End Class
End Namespace