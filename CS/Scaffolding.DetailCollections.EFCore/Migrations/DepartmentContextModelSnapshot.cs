using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Scaffolding.DetailCollectionsEFCore.Model;

namespace Scaffolding.DetailCollections.EFCore.Migrations {
    [DbContext(typeof(DepartmentContext))]
    partial class DepartmentContextModelSnapshot : ModelSnapshot {
        protected override void BuildModel(ModelBuilder modelBuilder) {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Scaffolding.DetailCollections.Model.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartmentID");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("CourseID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("Scaffolding.DetailCollections.Model.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Scaffolding.DetailCollections.Model.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartmentID");

                    b.Property<string>("Name");

                    b.HasKey("EmployeeID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Scaffolding.DetailCollections.Model.Course", b =>
                {
                    b.HasOne("Scaffolding.DetailCollections.Model.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Scaffolding.DetailCollections.Model.Employee", b =>
                {
                    b.HasOne("Scaffolding.DetailCollections.Model.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
