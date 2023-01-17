﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mOSP.Persistence.EF;

namespace mOSP.Persistence.EF.Migrations
{
    [DbContext(typeof(mOSPContext))]
    [Migration("20230117204817_UserAndRoleAdd")]
    partial class UserAndRoleAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("mOSP.Domain.Common.Container", b =>
                {
                    b.Property<int>("ContainerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OspId")
                        .HasColumnType("int");

                    b.HasKey("ContainerId");

                    b.HasIndex("OspId");

                    b.ToTable("Container");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Container");
                });

            modelBuilder.Entity("mOSP.Domain.Common.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ContainerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.HasIndex("ContainerId");

                    b.ToTable("Item");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Item");
                });

            modelBuilder.Entity("mOSP.Domain.Entities.OSP", b =>
                {
                    b.Property<int>("OspId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OspId");

                    b.ToTable("Osps");

                    b.HasData(
                        new
                        {
                            OspId = 1,
                            Name = "OSP1"
                        },
                        new
                        {
                            OspId = 2,
                            Name = "OSP2"
                        });
                });

            modelBuilder.Entity("mOSP.Domain.Entities.Role", b =>
                {
                    b.Property<int>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleID");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("mOSP.Domain.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OspID")
                        .HasColumnType("int");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleID")
                        .HasColumnType("int");

                    b.HasKey("UserId");

                    b.HasIndex("OspID");

                    b.HasIndex("RoleID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("mOSP.Domain.Entities.MedKit", b =>
                {
                    b.HasBaseType("mOSP.Domain.Common.Container");

                    b.Property<int>("ContainerType")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("MedKit");

                    b.HasData(
                        new
                        {
                            ContainerId = 1,
                            CreatedDate = new DateTime(2023, 1, 17, 21, 48, 17, 321, DateTimeKind.Local).AddTicks(8939),
                            Name = "Kit1",
                            OspId = 1,
                            ContainerType = 0
                        },
                        new
                        {
                            ContainerId = 2,
                            CreatedDate = new DateTime(2023, 1, 17, 21, 48, 17, 321, DateTimeKind.Local).AddTicks(9330),
                            Name = "Kit2",
                            OspId = 1,
                            ContainerType = 0
                        },
                        new
                        {
                            ContainerId = 3,
                            CreatedDate = new DateTime(2023, 1, 17, 21, 48, 17, 321, DateTimeKind.Local).AddTicks(9342),
                            Name = "Kit3",
                            OspId = 1,
                            ContainerType = 0
                        },
                        new
                        {
                            ContainerId = 4,
                            CreatedDate = new DateTime(2023, 1, 17, 21, 48, 17, 321, DateTimeKind.Local).AddTicks(9345),
                            Name = "Kit4",
                            OspId = 1,
                            ContainerType = 0
                        },
                        new
                        {
                            ContainerId = 5,
                            CreatedDate = new DateTime(2023, 1, 17, 21, 48, 17, 321, DateTimeKind.Local).AddTicks(9348),
                            Name = "Kit5",
                            OspId = 1,
                            ContainerType = 0
                        });
                });

            modelBuilder.Entity("mOSP.Domain.Entities.MedItem", b =>
                {
                    b.HasBaseType("mOSP.Domain.Common.Item");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsIgnored")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("MedItem");

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            ContainerId = 1,
                            CreatedDate = new DateTime(2023, 1, 17, 21, 48, 17, 318, DateTimeKind.Local).AddTicks(1108),
                            Name = "Item1",
                            ExpirationDate = new DateTime(2023, 3, 8, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(3556),
                            IsIgnored = false
                        },
                        new
                        {
                            ItemId = 2,
                            ContainerId = 1,
                            CreatedDate = new DateTime(2023, 1, 17, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4950),
                            Name = "Item2",
                            ExpirationDate = new DateTime(2023, 3, 9, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4967),
                            IsIgnored = false
                        },
                        new
                        {
                            ItemId = 3,
                            ContainerId = 1,
                            CreatedDate = new DateTime(2023, 1, 17, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4972),
                            Name = "Item3",
                            ExpirationDate = new DateTime(2023, 3, 11, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4975),
                            IsIgnored = false
                        },
                        new
                        {
                            ItemId = 4,
                            ContainerId = 1,
                            CreatedDate = new DateTime(2023, 1, 17, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4979),
                            Name = "Item4",
                            ExpirationDate = new DateTime(2023, 3, 12, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4982),
                            IsIgnored = false
                        },
                        new
                        {
                            ItemId = 5,
                            ContainerId = 1,
                            CreatedDate = new DateTime(2023, 1, 17, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(4986),
                            Name = "Item5",
                            ExpirationDate = new DateTime(2023, 3, 13, 21, 48, 17, 320, DateTimeKind.Local).AddTicks(5119),
                            IsIgnored = false
                        });
                });

            modelBuilder.Entity("mOSP.Domain.Common.Container", b =>
                {
                    b.HasOne("mOSP.Domain.Entities.OSP", "Osp")
                        .WithMany("Containers")
                        .HasForeignKey("OspId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Osp");
                });

            modelBuilder.Entity("mOSP.Domain.Common.Item", b =>
                {
                    b.HasOne("mOSP.Domain.Common.Container", "Container")
                        .WithMany("Items")
                        .HasForeignKey("ContainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Container");
                });

            modelBuilder.Entity("mOSP.Domain.Entities.User", b =>
                {
                    b.HasOne("mOSP.Domain.Entities.OSP", "Osp")
                        .WithMany()
                        .HasForeignKey("OspID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("mOSP.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Osp");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("mOSP.Domain.Common.Container", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("mOSP.Domain.Entities.OSP", b =>
                {
                    b.Navigation("Containers");
                });
#pragma warning restore 612, 618
        }
    }
}
