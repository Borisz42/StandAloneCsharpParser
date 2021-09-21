﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StandAloneCSharpParser.modell;

namespace StandAloneCSharpParser.Migrations
{
    [DbContext(typeof(CsharpDbContext))]
    partial class javadbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("StandAloneCSharpParser.modell.CsharpAstNode", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("astType")
                        .HasColumnType("integer");

                    b.Property<string>("astValue")
                        .HasColumnType("text");

                    b.Property<long>("entityHash")
                        .HasColumnType("bigint");

                    b.Property<long>("location_file")
                        .HasColumnType("bigint");

                    b.Property<long>("location_range_end_column")
                        .HasColumnType("bigint");

                    b.Property<long>("location_range_end_line")
                        .HasColumnType("bigint");

                    b.Property<long>("location_range_start_column")
                        .HasColumnType("bigint");

                    b.Property<long>("location_range_start_line")
                        .HasColumnType("bigint");

                    b.Property<int>("rawKind")
                        .HasColumnType("integer");

                    b.Property<int>("symbolType")
                        .HasColumnType("integer");

                    b.Property<bool>("visibleInSourceCode")
                        .HasColumnType("boolean");

                    b.HasKey("id");

                    b.ToTable("csharpAstNodes");
                });

            modelBuilder.Entity("StandAloneCSharpParser.modell.CsharpEntity", b =>
                {
                    b.Property<long>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("astNodeId")
                        .HasColumnType("bigint");

                    b.Property<long>("entityHash")
                        .HasColumnType("bigint");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("qualifiedName")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("sharpEntitys");

                    b.HasDiscriminator<string>("Discriminator").HasValue("CsharpEntity");
                });

            modelBuilder.Entity("StandAloneCSharpParser.modell.CsharpTypedEntity", b =>
                {
                    b.HasBaseType("StandAloneCSharpParser.modell.CsharpEntity");

                    b.Property<string>("qualifiedType")
                        .HasColumnType("text");

                    b.Property<long>("typeHash")
                        .HasColumnType("bigint");

                    b.HasDiscriminator().HasValue("CsharpTypedEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
