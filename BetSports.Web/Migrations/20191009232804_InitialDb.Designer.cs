﻿// <auto-generated />
using BetSports.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BetSports.Web.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20191009232804_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BetSports.Web.Data.Entities.Banking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int>("DailySaleLimit");

                    b.Property<int>("DeactivationBalance");

                    b.Property<string>("Document")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Location");

                    b.Property<int>("MaximumTicketsCancelDay");

                    b.Property<int>("MinimumPlaysBuyPoints");

                    b.Property<int>("MinimumPlaysFuture");

                    b.Property<decimal>("MinimumTicketAmount");

                    b.Property<int>("MinutesCancelTicket");

                    b.Property<decimal>("MultiPlayMoneyLine");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Owner");

                    b.Property<bool>("ToPrint");

                    b.HasKey("Id");

                    b.ToTable("Bankings");
                });
#pragma warning restore 612, 618
        }
    }
}