﻿// <auto-generated />
using System;
using Bob.Migrations.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bob.Migrations.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240210175126_addNullToTheAdressTable")]
    partial class addNullToTheAdressTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bob.Model.Entities.Organization", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Domain")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("DomainSuffix")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Organizations");
                });

            modelBuilder.Entity("Bob.Model.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<string>("DispalyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Language1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiddleName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nationality1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Prefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pronouns")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("OrganizationId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Bob.Model.Entities.UserAddress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AddressLine1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("PostalCode")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique()
                        .HasFilter("[UserId] IS NOT NULL");

                    b.ToTable("UserAddresses");
                });

            modelBuilder.Entity("Bob.Model.Entities.UserContact", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MobileNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("NationalId")
                        .HasColumnType("int");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("PassportNumber")
                        .HasColumnType("int");

                    b.Property<string>("PersonalEmail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("SSN")
                        .HasColumnType("int");

                    b.Property<int?>("TaxIdNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserContact");
                });

            modelBuilder.Entity("Bob.Model.Entities.UserEmploymentInformation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Contract")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EmploymentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("WeeklyHours")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("WorkingPattern")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserEmploymentInformations");
                });

            modelBuilder.Entity("Bob.Model.Entities.UserFinancial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AccountName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("AccountNumber")
                        .HasColumnType("int");

                    b.Property<string>("BankAccountType")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BankAddress")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("BankName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("RatingNumber")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserFinancials");
                });

            modelBuilder.Entity("Bob.Model.Entities.UserPayroll", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("BaseSalary")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("EffectiveDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("SalaryPayFrequency")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalaryPayPeriod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserPayrolls");
                });

            modelBuilder.Entity("Bob.Model.Entities.UserSocial", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("About")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FoodPrefrence")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Hobbies")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("ModificationDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("OrganizationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Socials")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Superpowers")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("UserSocials");
                });

            modelBuilder.Entity("Bob.Model.Entities.UserAddress", b =>
                {
                    b.HasOne("Bob.Model.Entities.User", "User")
                        .WithOne("UserAddress")
                        .HasForeignKey("Bob.Model.Entities.UserAddress", "UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bob.Model.Entities.UserContact", b =>
                {
                    b.HasOne("Bob.Model.Entities.User", "User")
                        .WithOne("userContact")
                        .HasForeignKey("Bob.Model.Entities.UserContact", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bob.Model.Entities.UserEmploymentInformation", b =>
                {
                    b.HasOne("Bob.Model.Entities.User", "User")
                        .WithOne("UserEmploymentInformation")
                        .HasForeignKey("Bob.Model.Entities.UserEmploymentInformation", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bob.Model.Entities.UserFinancial", b =>
                {
                    b.HasOne("Bob.Model.Entities.User", "User")
                        .WithOne("UserFinancial")
                        .HasForeignKey("Bob.Model.Entities.UserFinancial", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bob.Model.Entities.UserPayroll", b =>
                {
                    b.HasOne("Bob.Model.Entities.User", "User")
                        .WithOne("UserPayroll")
                        .HasForeignKey("Bob.Model.Entities.UserPayroll", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bob.Model.Entities.UserSocial", b =>
                {
                    b.HasOne("Bob.Model.Entities.User", "User")
                        .WithOne("UserSocial")
                        .HasForeignKey("Bob.Model.Entities.UserSocial", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bob.Model.Entities.User", b =>
                {
                    b.Navigation("UserAddress")
                        .IsRequired();

                    b.Navigation("UserEmploymentInformation")
                        .IsRequired();

                    b.Navigation("UserFinancial")
                        .IsRequired();

                    b.Navigation("UserPayroll")
                        .IsRequired();

                    b.Navigation("UserSocial")
                        .IsRequired();

                    b.Navigation("userContact")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
