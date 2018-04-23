Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations

Namespace Scaffolding.DetailCollectionsEFCore.Model
	Public Class Course
		Public Property CourseID() As Integer
		<Required>
		Public Property Title() As String
		Public Property DepartmentID() As Integer
		Public Overridable Property Department() As Department
	End Class
End Namespace