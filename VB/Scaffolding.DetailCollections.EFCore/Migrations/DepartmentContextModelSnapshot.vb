Imports System
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.EntityFrameworkCore.Infrastructure
Imports Microsoft.EntityFrameworkCore.Metadata
Imports Microsoft.EntityFrameworkCore.Migrations
Imports Scaffolding.DetailCollectionsEFCore.Model

Namespace Scaffolding.DetailCollections.EFCore.Migrations
	<DbContext(GetType(DepartmentContext))>
	Partial Friend Class DepartmentContextModelSnapshot
		Inherits ModelSnapshot

		Protected Overrides Sub BuildModel(ByVal modelBuilder As ModelBuilder)
			modelBuilder.HasAnnotation("ProductVersion", "1.0.1").HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)

			modelBuilder.Entity("Scaffolding.DetailCollections.Model.Course", Sub(b)
				b.Property(Of Integer)("CourseID").ValueGeneratedOnAdd()
				b.Property(Of Integer)("DepartmentID")
				b.Property(Of String)("Title").IsRequired()
				b.HasKey("CourseID")
				b.HasIndex("DepartmentID")
				b.ToTable("Courses")
			End Sub)

			modelBuilder.Entity("Scaffolding.DetailCollections.Model.Department", Sub(b)
				b.Property(Of Integer)("DepartmentID").ValueGeneratedOnAdd()
				b.Property(Of String)("Name")
				b.HasKey("DepartmentID")
				b.ToTable("Departments")
			End Sub)

			modelBuilder.Entity("Scaffolding.DetailCollections.Model.Employee", Sub(b)
				b.Property(Of Integer)("EmployeeID").ValueGeneratedOnAdd()
				b.Property(Of Integer)("DepartmentID")
				b.Property(Of String)("Name")
				b.HasKey("EmployeeID")
				b.HasIndex("DepartmentID")
				b.ToTable("Employees")
			End Sub)

			modelBuilder.Entity("Scaffolding.DetailCollections.Model.Course", Sub(b) b.HasOne("Scaffolding.DetailCollections.Model.Department", "Department").WithMany("Courses").HasForeignKey("DepartmentID").OnDelete(DeleteBehavior.Cascade))

			modelBuilder.Entity("Scaffolding.DetailCollections.Model.Employee", Sub(b) b.HasOne("Scaffolding.DetailCollections.Model.Department", "Department").WithMany("Employees").HasForeignKey("DepartmentID").OnDelete(DeleteBehavior.Cascade))
		End Sub
	End Class
End Namespace
