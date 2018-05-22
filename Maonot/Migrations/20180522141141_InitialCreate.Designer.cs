﻿// <auto-generated />
using Maonot.Data;
using Maonot.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Maonot.Migrations
{
    [DbContext(typeof(MaonotContext))]
    [Migration("20180522141141_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Maonot.Models.ApprovalKit", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int?>("HealthCondition");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int?>("LivingWithReligious")
                        .IsRequired();

                    b.Property<int?>("LivingWithSmoker")
                        .IsRequired();

                    b.Property<int>("PartnerId1");

                    b.Property<int>("PartnerId2");

                    b.Property<int>("PartnerId3");

                    b.Property<int>("PartnerId4");

                    b.Property<int?>("RegID");

                    b.Property<int?>("ReligiousType")
                        .IsRequired();

                    b.Property<int?>("RoomType")
                        .IsRequired();

                    b.Property<int>("StundetId");

                    b.HasKey("ID");

                    b.HasIndex("RegID");

                    b.ToTable("ApprovalKits");
                });

            modelBuilder.Entity("Maonot.Models.FaultForm", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Apartment");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("FullName")
                        .IsRequired();

                    b.Property<string>("PhoneNumber");

                    b.Property<int>("RoomNum");

                    b.HasKey("ID");

                    b.ToTable("FaultForms");
                });

            modelBuilder.Entity("Maonot.Models.Message", b =>
                {
                    b.Property<int>("MessageID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Addressee")
                        .IsRequired();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<string>("Subject")
                        .IsRequired();

                    b.HasKey("MessageID");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Maonot.Models.Registration", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress")
                        .IsRequired();

                    b.Property<int?>("ApertmantType")
                        .IsRequired();

                    b.Property<DateTime>("Bday");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<int?>("FieldOfStudy")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int?>("HealthCondition")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<int>("ParentAge");

                    b.Property<int>("ParentID");

                    b.Property<string>("ParentLastName");

                    b.Property<string>("PartnerFirstName");

                    b.Property<string>("PhoneNumber")
                        .IsRequired();

                    b.Property<int>("PostalCode");

                    b.Property<int?>("Seniority")
                        .IsRequired();

                    b.Property<int?>("SteadyYear")
                        .IsRequired();

                    b.Property<int>("StundetId");

                    b.Property<int?>("TypeOfService")
                        .IsRequired();

                    b.Property<int?>("UserID");

                    b.Property<int?>("gender")
                        .IsRequired();

                    b.HasKey("ID");

                    b.HasIndex("UserID");

                    b.ToTable("Registrations");
                });

            modelBuilder.Entity("Maonot.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApartmentNum");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<int?>("Room");

                    b.Property<int>("StundetId");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Maonot.Models.VisitorsLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ApartmentNum");

                    b.Property<DateTime>("EnteryDate");

                    b.Property<DateTime>("ExitDate");

                    b.Property<int?>("Room")
                        .IsRequired();

                    b.Property<bool>("Signature");

                    b.Property<string>("StudentFirstName")
                        .IsRequired();

                    b.Property<string>("StudentLasttName")
                        .IsRequired();

                    b.Property<int>("VisitorID");

                    b.Property<string>("VistorName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("VisitorsLogs");
                });

            modelBuilder.Entity("Maonot.Models.Warning", b =>
                {
                    b.Property<int>("WarningId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BlaBla");

                    b.Property<DateTime>("Date");

                    b.Property<int>("StudentId");

                    b.Property<int?>("WarningNumber")
                        .IsRequired();

                    b.Property<int?>("userID");

                    b.HasKey("WarningId");

                    b.HasIndex("userID");

                    b.ToTable("Warnings");
                });

            modelBuilder.Entity("Maonot.Models.ApprovalKit", b =>
                {
                    b.HasOne("Maonot.Models.Registration", "Reg")
                        .WithMany()
                        .HasForeignKey("RegID");
                });

            modelBuilder.Entity("Maonot.Models.Registration", b =>
                {
                    b.HasOne("Maonot.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("Maonot.Models.Warning", b =>
                {
                    b.HasOne("Maonot.Models.User", "user")
                        .WithMany()
                        .HasForeignKey("userID");
                });
#pragma warning restore 612, 618
        }
    }
}
