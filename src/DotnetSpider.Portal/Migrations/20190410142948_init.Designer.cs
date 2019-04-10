﻿// <auto-generated />
using System;
using DotnetSpider.Portal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotnetSpider.Portal.Migrations
{
    [DbContext(typeof(PortalDbContext))]
    [Migration("20190410142948_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DotnetSpider.Portal.Entity.DockerImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("creation_time");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnName("image")
                        .HasMaxLength(255);

                    b.Property<int>("RepositoryId")
                        .HasColumnName("repository_id");

                    b.HasKey("Id");

                    b.HasIndex("Image")
                        .IsUnique();

                    b.ToTable("docker_image");
                });

            modelBuilder.Entity("DotnetSpider.Portal.Entity.DockerRepository", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("creation_time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(255);

                    b.Property<string>("Registry")
                        .IsRequired()
                        .HasColumnName("registry")
                        .HasMaxLength(255);

                    b.Property<string>("Repository")
                        .IsRequired()
                        .HasColumnName("repository")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CreationTime");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.HasIndex("Repository")
                        .IsUnique();

                    b.ToTable("docker_repository");
                });

            modelBuilder.Entity("DotnetSpider.Portal.Entity.Spider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<string>("Arguments")
                        .HasColumnName("arguments")
                        .HasMaxLength(255);

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("creation_time");

                    b.Property<string>("Cron")
                        .IsRequired()
                        .HasColumnName("cron")
                        .HasMaxLength(255);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnName("image")
                        .HasMaxLength(255);

                    b.Property<DateTime>("LastModificationTime")
                        .HasColumnName("last_modification_time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("name")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CreationTime");

                    b.HasIndex("Image");

                    b.HasIndex("Name");

                    b.ToTable("spider");
                });

            modelBuilder.Entity("DotnetSpider.Portal.Entity.SpiderContainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id");

                    b.Property<Guid>("ContainerId")
                        .HasColumnName("container_id");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnName("creation_time");

                    b.Property<DateTime?>("ExitTime")
                        .HasColumnName("exit_time");

                    b.Property<int>("SpiderId")
                        .HasColumnName("spider_id");

                    b.HasKey("Id");

                    b.HasIndex("ContainerId");

                    b.HasIndex("CreationTime");

                    b.ToTable("spider_container");
                });
#pragma warning restore 612, 618
        }
    }
}
