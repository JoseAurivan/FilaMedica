﻿// <auto-generated />
using System;
using AtendimentoMedico.Data.AppContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AtendimentoMedico.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220121191854_Atendimento_Status")]
    partial class Atendimento_Status
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AtendimentoMedico.Data.Atendimento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Atendido")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<int>("Prioridade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("atendimento");
                });

            modelBuilder.Entity("AtendimentoMedico.Data.Medico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AtendimentoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sala")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AtendimentoId");

                    b.ToTable("medico");
                });

            modelBuilder.Entity("AtendimentoMedico.Data.Medico", b =>
                {
                    b.HasOne("AtendimentoMedico.Data.Atendimento", "Atendimento")
                        .WithMany()
                        .HasForeignKey("AtendimentoId");

                    b.Navigation("Atendimento");
                });
#pragma warning restore 612, 618
        }
    }
}
