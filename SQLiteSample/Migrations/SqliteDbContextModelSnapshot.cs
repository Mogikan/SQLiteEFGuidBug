﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQLiteSample;

namespace SQLiteSample.Migrations
{
    [DbContext(typeof(SqliteDbContext))]
    partial class SqliteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("SQLiteSample.UserReferencesData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("BoolValue")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("ColumnId")
                        .HasColumnType("TEXT");

                    b.Property<int>("ColumnType")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("DateValue")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("DecimalValue")
                        .HasColumnType("TEXT");

                    b.Property<double?>("DoubleValue")
                        .HasColumnType("REAL");

                    b.Property<int?>("IntValue")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MetadataId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RowId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StringValue")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MetadataId");

                    b.HasIndex("RowId");

                    b.ToTable("UserReferencesData");
                });

            modelBuilder.Entity("SQLiteSample.UserReferencesMetadata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Metadata")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("UserReferencesMetadata");
                });

            modelBuilder.Entity("SQLiteSample.UserReferencesData", b =>
                {
                    b.HasOne("SQLiteSample.UserReferencesMetadata", null)
                        .WithMany()
                        .HasForeignKey("MetadataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
