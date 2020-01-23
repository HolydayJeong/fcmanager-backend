﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using fc_manager_backend_da.Models;

namespace fc_manager_backend_da.Migrations
{
    [DbContext(typeof(FCMContext))]
    [Migration("20200116214400_Add-foreignkey-to-Matches")]
    partial class AddforeignkeytoMatches
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("fc_manager_backend_da.Models.Club", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("History")
                        .HasColumnType("text");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("StarteOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.Code", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("ParentCodeId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ParentCodeId");

                    b.ToTable("Codes");
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClubId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("EndedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime>("StartedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("League");
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AwayScore")
                        .HasColumnType("integer");

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("integer");

                    b.Property<int>("ClubId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("HomeScore")
                        .HasColumnType("integer");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("integer");

                    b.Property<int>("LeagueId")
                        .HasColumnType("integer");

                    b.Property<string>("Location")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ScheduledAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("ClubId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("LeagueId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.MatchRecord", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CodeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("MatchId")
                        .HasColumnType("integer");

                    b.Property<int>("MemberId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CodeId");

                    b.HasIndex("MatchId");

                    b.HasIndex("MemberId");

                    b.ToTable("MatchRecords");
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Phone")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClubId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("EndedOn")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("History")
                        .HasColumnType("text");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("StartedOn")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClubId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.TeamMember", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime?>("DeletedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsCaptain")
                        .HasColumnType("boolean");

                    b.Property<int>("MemberId")
                        .HasColumnType("integer");

                    b.Property<int?>("TeamId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamMembers");
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.Code", b =>
                {
                    b.HasOne("fc_manager_backend_da.Models.Code", "ParentCode")
                        .WithMany()
                        .HasForeignKey("ParentCodeId");
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.League", b =>
                {
                    b.HasOne("fc_manager_backend_da.Models.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.Match", b =>
                {
                    b.HasOne("fc_manager_backend_da.Models.Team", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fc_manager_backend_da.Models.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fc_manager_backend_da.Models.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fc_manager_backend_da.Models.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.MatchRecord", b =>
                {
                    b.HasOne("fc_manager_backend_da.Models.Code", "Type")
                        .WithMany()
                        .HasForeignKey("CodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fc_manager_backend_da.Models.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fc_manager_backend_da.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.Member", b =>
                {
                    b.HasOne("fc_manager_backend_da.Models.Code", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.Team", b =>
                {
                    b.HasOne("fc_manager_backend_da.Models.Club", "Club")
                        .WithMany()
                        .HasForeignKey("ClubId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("fc_manager_backend_da.Models.TeamMember", b =>
                {
                    b.HasOne("fc_manager_backend_da.Models.Member", "Member")
                        .WithMany()
                        .HasForeignKey("MemberId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("fc_manager_backend_da.Models.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamId");
                });
#pragma warning restore 612, 618
        }
    }
}
