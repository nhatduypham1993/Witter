﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Witter.Data;

namespace Witter.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Witter.Models.Bet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("MatchId");

                    b.Property<float>("Odds");

                    b.Property<int>("Prediction");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Bets");
                });

            modelBuilder.Entity("Witter.Models.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<float>("DrawOdds");

                    b.Property<int?>("TeamAId");

                    b.Property<float>("TeamAOdds");

                    b.Property<int?>("TeamBId");

                    b.Property<float>("TeamBOdds");

                    b.HasKey("Id");

                    b.HasIndex("TeamAId");

                    b.HasIndex("TeamBId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Witter.Models.Score", b =>
                {
                    b.Property<int>("MatchId");

                    b.Property<int>("TeamAGoals");

                    b.Property<int>("TeamBGoals");

                    b.HasKey("MatchId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("Witter.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Coach");

                    b.Property<string>("Name");

                    b.Property<string>("PhotoUrl");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Witter.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("Ban");

                    b.Property<bool>("IsAdmin");

                    b.Property<byte[]>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt");

                    b.Property<bool>("PermanentBan");

                    b.Property<float>("Score");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Witter.Models.Match", b =>
                {
                    b.HasOne("Witter.Models.Team", "TeamA")
                        .WithMany()
                        .HasForeignKey("TeamAId");

                    b.HasOne("Witter.Models.Team", "TeamB")
                        .WithMany()
                        .HasForeignKey("TeamBId");
                });

            modelBuilder.Entity("Witter.Models.Score", b =>
                {
                    b.HasOne("Witter.Models.Match")
                        .WithOne("Score")
                        .HasForeignKey("Witter.Models.Score", "MatchId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
