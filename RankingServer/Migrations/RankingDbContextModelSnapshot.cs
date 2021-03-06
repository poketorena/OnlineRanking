﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RankingServer.Data;

namespace RankingServer.Migrations
{
    [DbContext(typeof(RankingDbContext))]
    partial class RankingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("RankingServer.Models.ScoreData", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("Score");

                    b.HasKey("Id");

                    b.ToTable("ScoreData");
                });
#pragma warning restore 612, 618
        }
    }
}
