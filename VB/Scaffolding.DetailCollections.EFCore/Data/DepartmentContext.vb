Imports System
Imports Microsoft.EntityFrameworkCore
Imports System.Linq

Namespace Scaffolding.DetailCollectionsEFCore.Model
	Public Class DepartmentContext
		Inherits DbContext

		Public Property Departments() As DbSet(Of Department)
		Public Property Courses() As DbSet(Of Course)
		Public Property Employees() As DbSet(Of Employee)

		Protected Overrides Sub OnConfiguring(ByVal optionsBuilder As DbContextOptionsBuilder)
			optionsBuilder.UseSqlServer("Server=(localdb)\mssqllocaldb;Database=DetailCollectionsEFCore;Trusted_Connection=True;")
		End Sub

		Friend Sub EnsureSeedData()
			If Departments.Any() Then
				Return
			End If

			Dim department1 As Department = New Department With {.Name = "Music"}
			Dim department2 As Department = New Department With {.Name = "Journalism"}
			Dim department3 As Department = New Department With {.Name = "Management"}
			Departments.Add(department1)
			Departments.Add(department2)
			Departments.Add(department3)

			Courses.AddRange( {
				New Course With {.Title = "First", .Department = department1},
				New Course With {.Title = "Second", .Department = department1},
				New Course With {.Title = "Third", .Department = department1},
				New Course With {.Title = "First", .Department = department2},
				New Course With {.Title = "Second", .Department = department2},
				New Course With {.Title = "Third", .Department = department2},
				New Course With {.Title = "First", .Department = department3},
				New Course With {.Title = "Second", .Department = department3},
				New Course With {.Title = "Third", .Department = department3}
			})

			Employees.AddRange( {
				New Employee With {.Name = "Frankie West PhD", .Department = department1},
				New Employee With {.Name = "Jett Mitchell", .Department = department1},
				New Employee With {.Name = "Garrick Stiedemann DVM", .Department = department1},
				New Employee With {.Name = "Hettie Runte", .Department = department1},
				New Employee With {.Name = "Gabe Flatley", .Department = department2},
				New Employee With {.Name = "Zetta Beatty", .Department = department2},
				New Employee With {.Name = "Ms. Luis Jewess", .Department = department2},
				New Employee With {.Name = "Jefferey Legros III", .Department = department3},
				New Employee With {.Name = "Margaretta Roberts", .Department = department3}
			})

			SaveChanges()
		End Sub
	End Class
End Namespace