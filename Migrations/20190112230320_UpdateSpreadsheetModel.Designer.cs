﻿// <auto-generated />
using System;
using Everis.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Everis.Migrations
{
    [DbContext(typeof(ProductsContext))]
    [Migration("20190112230320_UpdateSpreadsheetModel")]
    partial class UpdateSpreadsheetModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Everis.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddType");

                    b.Property<int>("Code");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("DateAdded");

                    b.Property<int>("EditType");

                    b.Property<int>("Income");

                    b.Property<DateTime>("LastEdit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<int>("Outcome");

                    b.Property<int?>("SpreadsheetIdID");

                    b.Property<int>("Stock");

                    b.HasKey("ID");

                    b.HasIndex("SpreadsheetIdID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Everis.Models.SpreadsheetEntry", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("ReferenceDate");

                    b.Property<string>("Title")
                        .HasMaxLength(255);

                    b.HasKey("ID");

                    b.ToTable("SpreadsheetEntries");
                });

            modelBuilder.Entity("Everis.Models.Product", b =>
                {
                    b.HasOne("Everis.Models.SpreadsheetEntry", "SpreadsheetId")
                        .WithMany()
                        .HasForeignKey("SpreadsheetIdID");
                });
#pragma warning restore 612, 618
        }
    }
}
