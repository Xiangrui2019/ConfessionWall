﻿// <auto-generated />
using System;
using ConfessionWall.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConfessionWall.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200727063558_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("ConfessionWall.Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .HasColumnType("TEXT");

                    b.Property<string>("Image")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PublishTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("TaName")
                        .HasColumnType("TEXT");

                    b.Property<string>("YourEmail")
                        .HasColumnType("TEXT");

                    b.Property<string>("YourName")
                        .HasColumnType("TEXT");

                    b.Property<string>("YourQq")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
