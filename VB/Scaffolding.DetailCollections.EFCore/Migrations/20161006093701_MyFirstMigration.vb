Imports System
Imports System.Collections.Generic
Imports Microsoft.EntityFrameworkCore.Migrations
Imports Microsoft.EntityFrameworkCore.Metadata

Namespace Scaffolding.DetailCollections.EFCore.Migrations
	Partial Public Class MyFirstMigration
		Inherits Migration

		Protected Overrides Sub Up(ByVal migrationBuilder As MigrationBuilder)
			migrationBuilder.CreateTable(name:= "Departments", columns:= Function(table) New With {Key .DepartmentID = table.Column(Of Integer)(nullable:= False).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn), Key .Name = table.Column(Of String)(nullable:= True)}, constraints:= Function(table) table.PrimaryKey("PK_Departments", Function(x) x.DepartmentID))

			migrationBuilder.CreateTable(name:= "Courses", columns:= Function(table) New With {Key .CourseID = table.Column(Of Integer)(nullable:= False).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn), Key .DepartmentID = table.Column(Of Integer)(nullable:= False), Key .Title = table.Column(Of String)(nullable:= False)}, constraints:= Sub(table)
					table.PrimaryKey("PK_Courses", Function(x) x.CourseID)
					table.ForeignKey(name:= "FK_Courses_Departments_DepartmentID", column:= Function(x) x.DepartmentID, principalTable:= "Departments", principalColumn:= "DepartmentID", onDelete:= ReferentialAction.Cascade)
				End Sub)

			migrationBuilder.CreateTable(name:= "Employees", columns:= Function(table) New With {Key .EmployeeID = table.Column(Of Integer)(nullable:= False).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn), Key .DepartmentID = table.Column(Of Integer)(nullable:= False), Key .Name = table.Column(Of String)(nullable:= True)}, constraints:= Sub(table)
					table.PrimaryKey("PK_Employees", Function(x) x.EmployeeID)
					table.ForeignKey(name:= "FK_Employees_Departments_DepartmentID", column:= Function(x) x.DepartmentID, principalTable:= "Departments", principalColumn:= "DepartmentID", onDelete:= ReferentialAction.Cascade)
				End Sub)

			migrationBuilder.CreateIndex(name:= "IX_Courses_DepartmentID", table:= "Courses", column:= "DepartmentID")

			migrationBuilder.CreateIndex(name:= "IX_Employees_DepartmentID", table:= "Employees", column:= "DepartmentID")
		End Sub

		Protected Overrides Sub Down(ByVal migrationBuilder As MigrationBuilder)
			migrationBuilder.DropTable(name:= "Courses")

			migrationBuilder.DropTable(name:= "Employees")

			migrationBuilder.DropTable(name:= "Departments")
		End Sub
	End Class
End Namespace
