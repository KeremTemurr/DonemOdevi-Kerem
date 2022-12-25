﻿// <auto-generated />
using System;
using HotelManagement.Dal.EfCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace HotelManagement.Dal.Migrations
{
    [DbContext(typeof(HotelManagementContext))]
    [Migration("20220828104043_PersonelEklemeSayfalariEklendi")]
    partial class PersonelEklemeSayfalariEklendi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("HotelManagement.Entity.Models.Systems.Lookup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool?>("BooleanValue1")
                        .HasColumnType("boolean");

                    b.Property<bool?>("BooleanValue2")
                        .HasColumnType("boolean");

                    b.Property<string>("Code")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("integer");

                    b.Property<int>("DataStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LastUpdatedUserId")
                        .HasColumnType("integer");

                    b.Property<int?>("LookupTypeId")
                        .HasColumnType("integer");

                    b.Property<int?>("LookupTypeId1")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LookupTypeId1");

                    b.HasIndex("ParentId");

                    b.ToTable("Lookup");
                });

            modelBuilder.Entity("HotelManagement.Entity.Models.Systems.LookupType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(150)")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("LookupType");

                    b.HasData(
                        new
                        {
                            Id = 8,
                            Name = "Cinsiyet"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Ülke"
                        },
                        new
                        {
                            Id = 10,
                            Name = "İl"
                        },
                        new
                        {
                            Id = 11,
                            Name = "İlçe"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Döviz"
                        });
                });

            modelBuilder.Entity("HotelManagement.Entity.Models.Systems.Page", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<string>("AllName")
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<string>("AllRouterLink")
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Color")
                        .HasColumnType("character varying(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Description")
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<bool>("HomeWidget")
                        .HasColumnType("boolean");

                    b.Property<string>("Icon")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<bool>("MenuShow")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(75)")
                        .HasMaxLength(75);

                    b.Property<short>("Order")
                        .HasColumnType("smallint");

                    b.Property<int?>("ParentId")
                        .HasColumnType("integer");

                    b.Property<string>("RouterLink")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("WidgetIcon")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Pages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AllName = "Yönetim Paneli",
                            AllRouterLink = "/yonetim",
                            HomeWidget = false,
                            MenuShow = true,
                            Name = "Yönetim Paneli",
                            Order = (short)0,
                            RouterLink = "/yonetim"
                        },
                        new
                        {
                            Id = 2,
                            AllName = "Yönetim Paneli / Ana Sayfa",
                            AllRouterLink = "/yonetim/ana-sayfa",
                            HomeWidget = false,
                            Icon = "fa fa-home",
                            MenuShow = true,
                            Name = "Ana Sayfa",
                            Order = (short)0,
                            ParentId = 1,
                            RouterLink = "/ana-sayfa"
                        },
                        new
                        {
                            Id = 3,
                            AllName = "Yönetim Paneli / İdari İşler",
                            AllRouterLink = "/yonetim/idari-isler",
                            HomeWidget = false,
                            Icon = "fa fa-copy",
                            MenuShow = true,
                            Name = "İdari İşler",
                            Order = (short)1,
                            ParentId = 1,
                            RouterLink = "/idari-isler"
                        },
                        new
                        {
                            Id = 4,
                            AllName = "Yönetim Paneli / İdari İşler/ Kullanıcı İşlemleri",
                            AllRouterLink = "/yonetim/idari-isler/kullanici-islemleri",
                            HomeWidget = false,
                            Icon = "fa fa-user",
                            MenuShow = true,
                            Name = "Kullanıcı İşlemleri",
                            Order = (short)1,
                            ParentId = 3,
                            RouterLink = "/kullanici-islemleri"
                        },
                        new
                        {
                            Id = 5,
                            AllName = "Yönetim Paneli / İdari İşler/ Kullanıcı İşlemleri / Tüm Kullanıcılar",
                            AllRouterLink = "/yonetim/idari-isler/kullanici-islemleri/tum-kullanicilar",
                            HomeWidget = false,
                            MenuShow = true,
                            Name = "Tüm Kullanıcılar",
                            Order = (short)0,
                            ParentId = 4,
                            RouterLink = "/tum-kullanicilar"
                        },
                        new
                        {
                            Id = 6,
                            AllName = "Yönetim Paneli / İdari İşler/ Kullanıcı İşlemleri / Yeni Kullanıcı",
                            AllRouterLink = "/yonetim/idari-isler/kullanici-islemleri/tum-kullanicilar/yeni-kullanici",
                            HomeWidget = false,
                            MenuShow = true,
                            Name = "Yeni Kullanıcı",
                            Order = (short)1,
                            ParentId = 4,
                            RouterLink = "/yeni-kullanici"
                        },
                        new
                        {
                            Id = 7,
                            AllName = "Yönetim Paneli / İdari İşler/ Personel İşlemleri",
                            AllRouterLink = "/yonetim/idari-isler/personel-islemleri",
                            HomeWidget = false,
                            Icon = "fa fa-users",
                            MenuShow = true,
                            Name = "Personel İşlemleri",
                            Order = (short)1,
                            ParentId = 3,
                            RouterLink = "/personel-islemleri"
                        },
                        new
                        {
                            Id = 8,
                            AllName = "Yönetim Paneli / İdari İşler/ Personel İşlemleri / Tüm Personeller",
                            AllRouterLink = "/yonetim/idari-isler/personel-islemleri/tum-personeller",
                            HomeWidget = false,
                            MenuShow = true,
                            Name = "Tüm Kullanıcılar",
                            Order = (short)0,
                            ParentId = 7,
                            RouterLink = "/tum-personeller"
                        },
                        new
                        {
                            Id = 9,
                            AllName = "Yönetim Paneli / İdari İşler/ Personel İşlemleri / Yeni Personel",
                            AllRouterLink = "/yonetim/idari-isler/personel-islemleri/tum-kullanicilar/yeni-personel",
                            HomeWidget = false,
                            MenuShow = true,
                            Name = "Yeni Kullanıcı",
                            Order = (short)1,
                            ParentId = 7,
                            RouterLink = "/yeni-personel"
                        });
                });

            modelBuilder.Entity("HotelManagement.Entity.Models.Systems.PagePermission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("integer");

                    b.Property<int>("DataStatus")
                        .HasColumnType("integer");

                    b.Property<bool>("Forbidden")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LastUpdatedUserId")
                        .HasColumnType("integer");

                    b.Property<int>("PageId")
                        .HasColumnType("integer");

                    b.Property<int?>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("PageId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("PagePermissions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedUserId = 1,
                            DataStatus = 2,
                            Forbidden = false,
                            PageId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedUserId = 1,
                            DataStatus = 2,
                            Forbidden = false,
                            PageId = 2,
                            RoleId = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedUserId = 1,
                            DataStatus = 2,
                            Forbidden = false,
                            PageId = 3,
                            RoleId = 1
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedUserId = 1,
                            DataStatus = 2,
                            Forbidden = false,
                            PageId = 4,
                            RoleId = 1
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedUserId = 1,
                            DataStatus = 2,
                            Forbidden = false,
                            PageId = 5,
                            RoleId = 1
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedUserId = 1,
                            DataStatus = 2,
                            Forbidden = false,
                            PageId = 6,
                            RoleId = 1
                        },
                        new
                        {
                            Id = 7,
                            CreatedAt = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedUserId = 1,
                            DataStatus = 2,
                            Forbidden = false,
                            PageId = 7,
                            RoleId = 1
                        },
                        new
                        {
                            Id = 8,
                            CreatedAt = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedUserId = 1,
                            DataStatus = 2,
                            Forbidden = false,
                            PageId = 8,
                            RoleId = 1
                        },
                        new
                        {
                            Id = 9,
                            CreatedAt = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedUserId = 1,
                            DataStatus = 2,
                            Forbidden = false,
                            PageId = 9,
                            RoleId = 1
                        });
                });

            modelBuilder.Entity("HotelManagement.Entity.Models.Users.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("integer");

                    b.Property<int>("DataStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LastUpdatedUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataStatus = 2,
                            Name = "Admin"
                        });
                });

            modelBuilder.Entity("HotelManagement.Entity.Models.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("integer");

                    b.Property<int>("DataStatus")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LastUpdatedUserId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Password")
                        .HasColumnType("character varying(150)")
                        .HasMaxLength(150);

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("character varying(150)")
                        .HasMaxLength(150);

                    b.Property<string>("Username")
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataStatus = 2,
                            Email = "admin@mail.com",
                            FullName = "Yönetici Admin",
                            Name = "Yönetici",
                            Password = "9K7Cwg3Qw/8FR/S9VvrNdgl8znxhPagMZ4QrajV/3AQ=",
                            Surname = "Admin"
                        });
                });

            modelBuilder.Entity("HotelManagement.Entity.Models.Users.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("integer");

                    b.Property<int>("DataStatus")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LastUpdatedUserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DataStatus = 2,
                            RoleId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("HotelManagement.Entity.Models.Users.UserSession", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("LoginAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("RemoteIpAddress")
                        .HasColumnType("character varying(30)")
                        .HasMaxLength(30);

                    b.Property<string>("RequestHeader")
                        .HasColumnType("text");

                    b.Property<string>("Token")
                        .HasColumnType("character varying(1500)")
                        .HasMaxLength(1500);

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserSessions");
                });

            modelBuilder.Entity("HotelManagement_Entity.Models.Employees.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("integer");

                    b.Property<int>("DataStatus")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("EmployeeCode")
                        .HasColumnType("text");

                    b.Property<int>("EmployeeType")
                        .HasColumnType("integer");

                    b.Property<DateTime>("JobStartDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("LastUpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int?>("LastUpdatedUserId")
                        .HasColumnType("integer");

                    b.Property<int>("MyProperty")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .HasColumnType("text");

                    b.Property<int?>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("HotelManagement.Entity.Models.Systems.Lookup", b =>
                {
                    b.HasOne("HotelManagement.Entity.Models.Systems.LookupType", "LookupType")
                        .WithMany("Lookup")
                        .HasForeignKey("LookupTypeId1");

                    b.HasOne("HotelManagement.Entity.Models.Systems.Lookup", "Parent")
                        .WithMany()
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("HotelManagement.Entity.Models.Systems.Page", b =>
                {
                    b.HasOne("HotelManagement.Entity.Models.Systems.Page", "Parent")
                        .WithMany("Childs")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("HotelManagement.Entity.Models.Systems.PagePermission", b =>
                {
                    b.HasOne("HotelManagement.Entity.Models.Systems.Page", "Page")
                        .WithMany("PagePermission")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelManagement.Entity.Models.Users.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("HotelManagement.Entity.Models.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("HotelManagement.Entity.Models.Users.UserRole", b =>
                {
                    b.HasOne("HotelManagement.Entity.Models.Users.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HotelManagement.Entity.Models.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelManagement.Entity.Models.Users.UserSession", b =>
                {
                    b.HasOne("HotelManagement.Entity.Models.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HotelManagement_Entity.Models.Employees.Employee", b =>
                {
                    b.HasOne("HotelManagement.Entity.Models.Users.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
