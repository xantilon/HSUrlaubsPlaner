﻿// <auto-generated />
using System;
using HSUrlaubsPlaner.GrpcService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GrpcService.Migrations
{
    [DbContext(typeof(LeaveRequestContext))]
    partial class LeaveRequestContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HSUrlaubsPlaner.GrpcService.Data.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"), 1L, 1);

                    b.Property<DateTimeOffset>("DateOfEntry")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaxLeaveDays")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            DateOfEntry = new DateTimeOffset(new DateTime(2017, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            Email = "e.holzke@hamann-software.de",
                            MaxLeaveDays = 27,
                            Name = "Edgar Holzke"
                        },
                        new
                        {
                            EmployeeId = 2,
                            DateOfEntry = new DateTimeOffset(new DateTime(2022, 4, 8, 21, 28, 49, 559, DateTimeKind.Unspecified).AddTicks(1248), new TimeSpan(0, 2, 0, 0, 0)),
                            Email = "b.atman@hamann-software.de",
                            MaxLeaveDays = 27,
                            Name = "Bruce Wayne"
                        });
                });

            modelBuilder.Entity("HSUrlaubsPlaner.GrpcService.Data.Models.LeaveAllocation", b =>
                {
                    b.Property<int>("LeaveAllocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeaveAllocationId"), 1L, 1);

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("LeaveRequestId")
                        .HasColumnType("int");

                    b.Property<int>("LeaveType")
                        .HasColumnType("int");

                    b.Property<float>("NumberOfDays")
                        .HasColumnType("real");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("LeaveAllocationId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("LeaveAllocations");
                });

            modelBuilder.Entity("HSUrlaubsPlaner.GrpcService.Data.Models.LeaveRequest", b =>
                {
                    b.Property<int>("LeaveRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeaveRequestId"), 1L, 1);

                    b.Property<bool>("Approved")
                        .HasColumnType("bit");

                    b.Property<int?>("ApproverId")
                        .HasColumnType("int");

                    b.Property<bool>("Canceled")
                        .HasColumnType("bit");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("DateActioned")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("DateRequested")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset>("EndDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("LeaveType")
                        .HasColumnType("int");

                    b.Property<int?>("RequesterId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("StartDate")
                        .HasColumnType("datetimeoffset");

                    b.HasKey("LeaveRequestId");

                    b.HasIndex("ApproverId");

                    b.HasIndex("RequesterId");

                    b.ToTable("LeaveRequests");

                    b.HasData(
                        new
                        {
                            LeaveRequestId = 1,
                            Approved = false,
                            Canceled = false,
                            Comment = "",
                            DateActioned = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            DateRequested = new DateTimeOffset(new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LeaveType = 0,
                            RequesterId = 1,
                            StartDate = new DateTimeOffset(new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0))
                        },
                        new
                        {
                            LeaveRequestId = 2,
                            Approved = false,
                            Canceled = false,
                            Comment = "",
                            DateActioned = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            DateRequested = new DateTimeOffset(new DateTime(2022, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            EndDate = new DateTimeOffset(new DateTime(2022, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0)),
                            LeaveType = 0,
                            RequesterId = 2,
                            StartDate = new DateTimeOffset(new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 2, 0, 0, 0))
                        });
                });

            modelBuilder.Entity("HSUrlaubsPlaner.GrpcService.Data.Models.LeaveAllocation", b =>
                {
                    b.HasOne("HSUrlaubsPlaner.GrpcService.Data.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HSUrlaubsPlaner.GrpcService.Data.Models.LeaveRequest", b =>
                {
                    b.HasOne("HSUrlaubsPlaner.GrpcService.Data.Models.Employee", "Approver")
                        .WithMany()
                        .HasForeignKey("ApproverId");

                    b.HasOne("HSUrlaubsPlaner.GrpcService.Data.Models.Employee", "Requester")
                        .WithMany()
                        .HasForeignKey("RequesterId");

                    b.Navigation("Approver");

                    b.Navigation("Requester");
                });
#pragma warning restore 612, 618
        }
    }
}
