﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Warehouse.Models;

namespace Warehouse.Migrations
{
    [DbContext(typeof(WarehouseContext))]
    [Migration("20210223092112_Debitors2")]
    partial class Debitors2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Warehouse.Models.AProject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PROJECT_ID");

                    b.Property<string>("LegalFoundation")
                        .IsRequired()
                        .HasColumnType("VARCHAR(4)")
                        .HasColumnName("LEGAL_FOUNDATION");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("TITLE");

                    b.HasKey("Id");

                    b.ToTable("PROJECTS");
                });

            modelBuilder.Entity("Warehouse.Models.Debitor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DEBITOR_ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("NAME");

                    b.HasKey("Id");

                    b.ToTable("DEBITOR");
                });

            modelBuilder.Entity("Warehouse.Models.Facility", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("FACILITY_ID");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("VARCHAR(7)")
                        .HasColumnName("FACILITY_CODE");

                    b.Property<string>("FACILITY_TYPE")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("TITLE");

                    b.HasKey("Id");

                    b.ToTable("FACILITY");

                    b.HasDiscriminator<string>("FACILITY_TYPE").HasValue("FACILITY");
                });

            modelBuilder.Entity("Warehouse.Models.Subproject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SUBPROJECT_ID");

                    b.Property<bool>("AppliedResearch")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("APPLIED_RESEARCH");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("DESCRIPTION");

                    b.Property<bool>("FocusResearch")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("FOCUS_RESEARCH");

                    b.Property<int?>("INSTITUTE_ID")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.Property<bool>("TheoreticalResearch")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("THEORETICAL_RESEARCH");

                    b.HasKey("Id");

                    b.HasIndex("INSTITUTE_ID");

                    b.HasIndex("ProjectId");

                    b.ToTable("SUBPROJECTS");
                });

            modelBuilder.Entity("Warehouse.Models.RequestFundingProject", b =>
                {
                    b.HasBaseType("Warehouse.Models.AProject");

                    b.Property<bool>("IsSmallProject")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("IS_SMALL_PROJECT");

                    b.ToTable("REQUEST_FUNDING_PROJECTS");
                });

            modelBuilder.Entity("Warehouse.Models.ResearchFundingProject", b =>
                {
                    b.HasBaseType("Warehouse.Models.AProject");

                    b.Property<bool>("IsEUSponsored")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("IS_EU_SPONSORED");

                    b.Property<bool>("IsFFGSponsored")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("IS_FFG_SPONSORED");

                    b.Property<bool>("IsFWFSponsored")
                        .HasColumnType("TINYINT(1)")
                        .HasColumnName("IS_FWF_SPONSORED");

                    b.ToTable("RESEARCH_FUNDING_PROJECTS");
                });

            modelBuilder.Entity("Warehouse.Models.Faculty", b =>
                {
                    b.HasBaseType("Warehouse.Models.Facility");

                    b.ToTable("FACILITY");

                    b.HasDiscriminator().HasValue("Faculty");
                });

            modelBuilder.Entity("Warehouse.Models.Institute", b =>
                {
                    b.HasBaseType("Warehouse.Models.Facility");

                    b.ToTable("FACILITY");

                    b.HasDiscriminator().HasValue("INSTITUTE");
                });

            modelBuilder.Entity("Warehouse.Models.Subproject", b =>
                {
                    b.HasOne("Warehouse.Models.Institute", "Institute")
                        .WithMany()
                        .HasForeignKey("INSTITUTE_ID");

                    b.HasOne("Warehouse.Models.AProject", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.Navigation("Institute");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Warehouse.Models.RequestFundingProject", b =>
                {
                    b.HasOne("Warehouse.Models.AProject", null)
                        .WithOne()
                        .HasForeignKey("Warehouse.Models.RequestFundingProject", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Warehouse.Models.ResearchFundingProject", b =>
                {
                    b.HasOne("Warehouse.Models.AProject", null)
                        .WithOne()
                        .HasForeignKey("Warehouse.Models.ResearchFundingProject", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
