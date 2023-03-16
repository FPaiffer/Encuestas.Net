﻿// <auto-generated />
using System;
using Encuestas.Net.Infrastructure.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Encuestas.Net.Infrastructure.Data.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Encuestas.Net.Domain.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("QuestionGoTo")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("Encuestas.Net.Domain.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("SurveyId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("Encuestas.Net.Domain.Entities.Respondent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Respondent");
                });

            modelBuilder.Entity("Encuestas.Net.Domain.Entities.RespondentResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RespondentReferenceId")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<int>("SurveyReferenceId")
                        .HasColumnType("int")
                        .HasColumnOrder(2);

                    b.Property<int>("QuestionReferenceId")
                        .HasColumnType("int")
                        .HasColumnOrder(3);

                    b.Property<int>("AnswerReferenceId")
                        .HasColumnType("int")
                        .HasColumnOrder(4);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id", "RespondentReferenceId", "SurveyReferenceId", "QuestionReferenceId", "AnswerReferenceId");

                    b.HasIndex("RespondentReferenceId");

                    b.HasIndex("SurveyReferenceId");

                    b.ToTable("RespondentResponse");
                });

            modelBuilder.Entity("Encuestas.Net.Domain.Entities.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Survey");
                });

            modelBuilder.Entity("Encuestas.Net.Domain.Entities.Answer", b =>
                {
                    b.HasOne("Encuestas.Net.Domain.Entities.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId");
                });

            modelBuilder.Entity("Encuestas.Net.Domain.Entities.Question", b =>
                {
                    b.HasOne("Encuestas.Net.Domain.Entities.Survey", null)
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId");
                });

            modelBuilder.Entity("Encuestas.Net.Domain.Entities.RespondentResponse", b =>
                {
                    b.HasOne("Encuestas.Net.Domain.Entities.Respondent", "RespondentReference")
                        .WithMany()
                        .HasForeignKey("RespondentReferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Encuestas.Net.Domain.Entities.Survey", "SurveyReference")
                        .WithMany()
                        .HasForeignKey("SurveyReferenceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RespondentReference");

                    b.Navigation("SurveyReference");
                });

            modelBuilder.Entity("Encuestas.Net.Domain.Entities.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("Encuestas.Net.Domain.Entities.Survey", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
