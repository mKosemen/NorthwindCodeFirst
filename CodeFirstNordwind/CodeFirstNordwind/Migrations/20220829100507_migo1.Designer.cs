﻿// <auto-generated />
using System;
using CodeFirstNordwind.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CodeFirstNordwind.Migrations
{
    [DbContext(typeof(ProjectContext))]
    [Migration("20220829100507_migo1")]
    partial class migo1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Customer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.CustomerCustomerDemo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerDemograpgicsID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("CustomerTypeID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CustomerDemograpgicsID");

                    b.HasIndex("CustomerID");

                    b.ToTable("CustomerCustomerDemos");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.CustomerDemograpgic", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("CustomerDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("CustomerDemographics");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Extension")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("HomePhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleOfCourtesy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.EmployeeTerritory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("TerritoryID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("TerritoryID");

                    b.ToTable("EmployeeTerritories");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<decimal>("Freight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RequiredDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ShipAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipPostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShipRegion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShipVia")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShippedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ShippersID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ShippersID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Order_Detail", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<short>("Quantity")
                        .HasColumnType("smallint");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("Order_Details");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Discontinued")
                        .HasColumnType("bit");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuantityPerUnit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("ReorderLevel")
                        .HasColumnType("smallint");

                    b.Property<int>("SuplierID")
                        .HasColumnType("int");

                    b.Property<int>("SuppliersID")
                        .HasColumnType("int");

                    b.Property<short>("UnitInStock")
                        .HasColumnType("smallint");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<short>("UnitsOnOrder")
                        .HasColumnType("smallint");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("SuppliersID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Region", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("RegionDescription")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Regions");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Shipper", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Shippers");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Fax")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomePage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Territory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("RegionID")
                        .HasColumnType("int");

                    b.Property<string>("TerritortDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("RegionID");

                    b.ToTable("Territories");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.CustomerCustomerDemo", b =>
                {
                    b.HasOne("CodeFirstNordwind.Entity.Concrete.CustomerDemograpgic", "CustomerDemograpgics")
                        .WithMany("customerCustomerDemos")
                        .HasForeignKey("CustomerDemograpgicsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstNordwind.Entity.Concrete.Customer", "Customers")
                        .WithMany("CustomerCustomerDemos")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerDemograpgics");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.EmployeeTerritory", b =>
                {
                    b.HasOne("CodeFirstNordwind.Entity.Concrete.Employee", "Employees")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstNordwind.Entity.Concrete.Territory", "Territories")
                        .WithMany("EmployeeTerritories")
                        .HasForeignKey("TerritoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employees");

                    b.Navigation("Territories");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Order", b =>
                {
                    b.HasOne("CodeFirstNordwind.Entity.Concrete.Customer", "Customers")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstNordwind.Entity.Concrete.Employee", "Employees")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstNordwind.Entity.Concrete.Shipper", "Shippers")
                        .WithMany("Orders")
                        .HasForeignKey("ShippersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customers");

                    b.Navigation("Employees");

                    b.Navigation("Shippers");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Order_Detail", b =>
                {
                    b.HasOne("CodeFirstNordwind.Entity.Concrete.Order", "Orders")
                        .WithMany("Order_Details")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstNordwind.Entity.Concrete.Product", "Products")
                        .WithMany("Order_Details")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orders");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Product", b =>
                {
                    b.HasOne("CodeFirstNordwind.Entity.Concrete.Category", "Categories")
                        .WithMany("Products")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CodeFirstNordwind.Entity.Concrete.Supplier", "Suppliers")
                        .WithMany("Products")
                        .HasForeignKey("SuppliersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");

                    b.Navigation("Suppliers");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Territory", b =>
                {
                    b.HasOne("CodeFirstNordwind.Entity.Concrete.Region", "Regions")
                        .WithMany("Territories")
                        .HasForeignKey("RegionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Regions");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Customer", b =>
                {
                    b.Navigation("CustomerCustomerDemos");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.CustomerDemograpgic", b =>
                {
                    b.Navigation("customerCustomerDemos");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Employee", b =>
                {
                    b.Navigation("EmployeeTerritories");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Order", b =>
                {
                    b.Navigation("Order_Details");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Product", b =>
                {
                    b.Navigation("Order_Details");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Region", b =>
                {
                    b.Navigation("Territories");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Shipper", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Supplier", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("CodeFirstNordwind.Entity.Concrete.Territory", b =>
                {
                    b.Navigation("EmployeeTerritories");
                });
#pragma warning restore 612, 618
        }
    }
}
