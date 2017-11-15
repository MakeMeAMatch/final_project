﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Popcorn.Data;
using System;

namespace Popcorn.Migrations.PopcornDb
{
    [DbContext(typeof(PopcornDbContext))]
    [Migration("20171115191608_Corrections")]
    partial class Corrections
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Popcorn.Models.Answers", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.HasKey("ID");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("Popcorn.Models.Matches", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UserMatchedId");

                    b.Property<int>("UserMatchingId");

                    b.HasKey("Id");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("Popcorn.Models.Personality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Choices");

                    b.Property<int?>("QuestionsId");

                    b.HasKey("Id");

                    b.HasIndex("QuestionsId");

                    b.ToTable("Personality");
                });

            modelBuilder.Entity("Popcorn.Models.Profiles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AnswersId");

                    b.Property<int>("ApplicationUserId");

                    b.Property<int>("QuestionsId");

                    b.Property<int>("ResponsesId");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });

            modelBuilder.Entity("Popcorn.Models.Questions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("QuestionText");

                    b.HasKey("Id");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Popcorn.Models.Responses", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Diet");

                    b.Property<int>("Entertainment");

                    b.Property<int>("HonestySpectrum");

                    b.Property<int>("Politics");

                    b.Property<int>("Religion");

                    b.Property<int>("Sports");

                    b.HasKey("Id");

                    b.ToTable("Responses");
                });

            modelBuilder.Entity("Popcorn.Models.Personality", b =>
                {
                    b.HasOne("Popcorn.Models.Questions")
                        .WithMany("Answers")
                        .HasForeignKey("QuestionsId");
                });
#pragma warning restore 612, 618
        }
    }
}
