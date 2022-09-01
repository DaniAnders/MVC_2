﻿// <auto-generated />
using MVC_2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVC_2.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20220901135442_langtable")]
    partial class langtable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LanguagePerson_", b =>
                {
                    b.Property<int>("LanguagesId")
                        .HasColumnType("int");

                    b.Property<int>("PeopleID")
                        .HasColumnType("int");

                    b.HasKey("LanguagesId", "PeopleID");

                    b.HasIndex("PeopleID");

                    b.ToTable("LanguagePerson_");

                    b.HasData(
                        new
                        {
                            LanguagesId = 1,
                            PeopleID = 1
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleID = 1
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleID = 2
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleID = 2
                        },
                        new
                        {
                            LanguagesId = 5,
                            PeopleID = 2
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleID = 3
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleID = 4
                        },
                        new
                        {
                            LanguagesId = 3,
                            PeopleID = 5
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleID = 5
                        },
                        new
                        {
                            LanguagesId = 1,
                            PeopleID = 6
                        });
                });

            modelBuilder.Entity("MVC_2.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Vänersborg",
                            CountryId = 3
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Petrolina",
                            CountryId = 1
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Recife",
                            CountryId = 1
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Göteborg",
                            CountryId = 3
                        },
                        new
                        {
                            Id = 5,
                            CityName = "Porto",
                            CountryId = 2
                        },
                        new
                        {
                            Id = 6,
                            CityName = "Sintra",
                            CountryId = 2
                        });
                });

            modelBuilder.Entity("MVC_2.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryName = "Brazil"
                        },
                        new
                        {
                            Id = 2,
                            CountryName = "Portugal"
                        },
                        new
                        {
                            Id = 3,
                            CountryName = "Sweden"
                        });
                });

            modelBuilder.Entity("MVC_2.Models.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LanguageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LanguageName = "English"
                        },
                        new
                        {
                            Id = 2,
                            LanguageName = "French"
                        },
                        new
                        {
                            Id = 3,
                            LanguageName = "Portuguese"
                        },
                        new
                        {
                            Id = 4,
                            LanguageName = "Spanish"
                        },
                        new
                        {
                            Id = 5,
                            LanguageName = "Swedish"
                        },
                        new
                        {
                            Id = 6,
                            LanguageName = "Tupi"
                        });
                });

            modelBuilder.Entity("MVC_2.Models.Person_", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("PersonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CityId");

                    b.ToTable("People");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CityId = 1,
                            PersonName = "Karl",
                            Phone = "046111111"
                        },
                        new
                        {
                            ID = 2,
                            CityId = 4,
                            PersonName = "Anneli",
                            Phone = "046222444"
                        },
                        new
                        {
                            ID = 3,
                            CityId = 3,
                            PersonName = "Lucia",
                            Phone = "055123456"
                        },
                        new
                        {
                            ID = 4,
                            CityId = 2,
                            PersonName = "Lourdes",
                            Phone = "055323232"
                        },
                        new
                        {
                            ID = 5,
                            CityId = 5,
                            PersonName = "Antonio",
                            Phone = "0351212121"
                        },
                        new
                        {
                            ID = 6,
                            CityId = 6,
                            PersonName = "Luiza",
                            Phone = "0351212121"
                        });
                });

            modelBuilder.Entity("LanguagePerson_", b =>
                {
                    b.HasOne("MVC_2.Models.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVC_2.Models.Person_", null)
                        .WithMany()
                        .HasForeignKey("PeopleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MVC_2.Models.City", b =>
                {
                    b.HasOne("MVC_2.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("MVC_2.Models.Person_", b =>
                {
                    b.HasOne("MVC_2.Models.City", "City")
                        .WithMany("People")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("MVC_2.Models.City", b =>
                {
                    b.Navigation("People");
                });

            modelBuilder.Entity("MVC_2.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
