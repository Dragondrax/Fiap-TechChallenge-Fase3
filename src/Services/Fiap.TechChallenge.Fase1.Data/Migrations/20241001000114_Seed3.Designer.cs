﻿// <auto-generated />
using System;
using Fiap.TechChallenge.Fase1.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Fiap.TechChallenge.Fase1.Data.Migrations
{
    [DbContext(typeof(ContextTechChallenge))]
    [Migration("20241001000114_Seed3")]
    partial class Seed3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Fiap.TechChallenge.Fase1.Dominio.Entidades.Contato", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("DDD")
                        .HasColumnType("INT")
                        .HasColumnName("ddd");

                    b.Property<DateTime?>("Dt_Alteracao")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_alteracao");

                    b.Property<DateTime?>("Dt_Exclusao")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_exclusao");

                    b.Property<DateTime>("Dt_Registro")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_registro");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("email");

                    b.Property<bool>("Excluido")
                        .HasColumnType("BOOL")
                        .HasColumnName("excluido");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("nome");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(9)")
                        .HasColumnName("telefone");

                    b.HasKey("Id")
                        .HasName("pk_contato");

                    b.ToTable("contato", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("86eb986d-cf80-4cd5-871d-a4c218d71c3b"),
                            DDD = 11,
                            Dt_Registro = new DateTime(2024, 9, 30, 21, 1, 14, 529, DateTimeKind.Local).AddTicks(9316),
                            Email = "emailtestecontato@gmail.com",
                            Excluido = false,
                            Nome = "Nome Teste",
                            Telefone = "994918888"
                        },
                        new
                        {
                            Id = new Guid("593f3aaa-3122-4c87-9efa-e8399697eb6a"),
                            DDD = 11,
                            Dt_Registro = new DateTime(2024, 9, 30, 21, 1, 14, 529, DateTimeKind.Local).AddTicks(9334),
                            Email = "emailtestecontatoexcluir@gmail.com",
                            Excluido = false,
                            Nome = "Nome Teste",
                            Telefone = "994918888"
                        });
                });

            modelBuilder.Entity("Fiap.TechChallenge.Fase1.Dominio.Entidades.DDDRegiao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<int>("DDD")
                        .HasColumnType("INT")
                        .HasColumnName("ddd");

                    b.Property<DateTime?>("Dt_Alteracao")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_alteracao");

                    b.Property<DateTime?>("Dt_Exclusao")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_exclusao");

                    b.Property<DateTime>("Dt_Registro")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_registro");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("estado");

                    b.Property<bool>("Excluido")
                        .HasColumnType("BOOL")
                        .HasColumnName("excluido");

                    b.Property<string>("Regiao")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("regiao");

                    b.HasKey("Id")
                        .HasName("pk_regiao");

                    b.ToTable("regiao", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("0adf526e-2df3-48b4-85b6-214ebe5097a4"),
                            DDD = 11,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("eb654774-a9e5-4ed3-bc60-74b812bc084a"),
                            DDD = 12,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("ec2e08bc-7f8b-43ca-94bc-9eeeea0b495a"),
                            DDD = 13,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("6d2d1a52-bb16-416f-b162-1ce7e75506ea"),
                            DDD = 14,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("d1be4e86-41bb-459f-b987-b2220760ab79"),
                            DDD = 15,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("fcea6a50-4147-45e8-ae5a-89e137ed953a"),
                            DDD = 16,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("258c3c3b-f57f-4b37-b1e0-e1a69d3b76df"),
                            DDD = 17,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("4f334349-02a9-47d0-93ac-25d2b1e2844a"),
                            DDD = 18,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("2ae4c903-71fd-4173-9885-3c4805e3d635"),
                            DDD = 19,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("fe5b26de-fdae-4b40-9771-26abd5f9daef"),
                            DDD = 21,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RJ",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("02141d90-ee27-4c21-a159-b08fc04c91a0"),
                            DDD = 22,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RJ",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("a9378581-05a5-4afb-bcfb-d2d3b9a96dbf"),
                            DDD = 24,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RJ",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("53dec7d5-e7b8-410f-8d52-5e996d01d4b1"),
                            DDD = 27,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "ES",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("1de6ebb4-cc56-4a15-abe6-b05310687d21"),
                            DDD = 28,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "ES",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("1ddd58d6-a3a3-418c-8150-872394d05ec5"),
                            DDD = 31,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("82d401c4-f05f-48b1-807f-959ddbdd4164"),
                            DDD = 32,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("f370e818-cff7-4ef3-8344-c415d4aaeb78"),
                            DDD = 33,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("92a6f2c7-6ea2-44da-bfb8-ee8ec8ffabf7"),
                            DDD = 34,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("9b477ba9-b933-4c21-b311-9159b94747a4"),
                            DDD = 35,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("7a3ab5e5-0a1c-4de4-b43b-cdd1f3d6c6f8"),
                            DDD = 37,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("3dbe3377-3905-4276-953e-b0f029c1b271"),
                            DDD = 38,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("58f1e436-7a17-456b-a90e-340b7471d641"),
                            DDD = 41,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("e77abdaf-04f7-405d-88de-e58469303aa3"),
                            DDD = 42,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SC",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("cb716157-5cd0-41f2-b40f-8ae5a8ce9fb1"),
                            DDD = 43,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("50267298-a0f9-4b25-aa63-faa49580bf90"),
                            DDD = 44,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("14f86c86-91a5-41f2-8ae2-cd37755b0679"),
                            DDD = 45,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("522b2daa-856c-4042-816b-fe208ce0c83a"),
                            DDD = 46,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("6e61e421-267a-492f-a939-b4db57004dc2"),
                            DDD = 47,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SC",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("4a24d169-dd16-424f-a3c8-853662f4e9a4"),
                            DDD = 48,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SC",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("fb14b573-ffc6-493b-ba01-b972b36b2bd4"),
                            DDD = 49,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SC",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("655cc3e2-19f5-4d35-a1e7-dccaf5de43fc"),
                            DDD = 51,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RS",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("8e754872-5761-45fe-99f8-7868f294d7ca"),
                            DDD = 53,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RS",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("ca624b1c-f84c-4709-bba2-b4311d4af466"),
                            DDD = 54,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RS",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("0325c6c8-873c-4598-83cd-3affb19d825d"),
                            DDD = 55,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RS",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("42c867a7-40d7-4844-ba1c-729b5426d196"),
                            DDD = 61,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "DF",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("bf4c4e07-6e73-4afb-be34-08dfb3e5d7ca"),
                            DDD = 62,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "GO",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("a18d59a1-6dcc-4dd6-b5d5-593eb81f0407"),
                            DDD = 63,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "TO",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("be977955-3c58-43c7-9273-d8c60bb3ac3a"),
                            DDD = 64,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "GO",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("b2f55cde-2428-4e06-9709-3be6bd1996dd"),
                            DDD = 65,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MT",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("aaf52dc9-7ddb-4d14-87bb-5589679b3fca"),
                            DDD = 66,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MT",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("1a28b3f7-d105-42f5-b95b-d3b0dcd857a9"),
                            DDD = 67,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MS",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("440b5879-8edf-46fa-ab82-a05573ec7a7b"),
                            DDD = 68,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AC",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("ec84189f-f231-4a25-b09d-3d1130608aa0"),
                            DDD = 69,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RO",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("d202d8c8-a3a1-4bfc-a7fc-7b9dba399c65"),
                            DDD = 71,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("7611348d-3bfb-4aaa-9f19-0c006af03b1e"),
                            DDD = 73,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("fa36fc91-f42f-414e-83a0-5aa5afc0da3a"),
                            DDD = 74,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("7adf6121-6c68-41bb-ac5d-c344d3c63dc9"),
                            DDD = 75,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("e479c83d-0151-4692-8d4b-b02fda7e726f"),
                            DDD = 77,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("be3a017e-230d-4c1e-a62e-fb852d7a0991"),
                            DDD = 79,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("6f909d57-cfb8-4b3e-a42a-a58718c14704"),
                            DDD = 81,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("dab3b7ac-4606-404f-99f4-1a926e3dbac6"),
                            DDD = 82,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AL",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("cff4af55-50b1-4985-81cd-c2bb8c9cc75f"),
                            DDD = 83,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PB",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("80b05b1c-b8d4-4999-bead-11d523670a19"),
                            DDD = 84,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RN",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("f58bd18c-c43a-40d4-9859-f83e03c956e6"),
                            DDD = 85,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "CE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("cc158567-2a21-4d71-b26a-19ae532fa6c8"),
                            DDD = 86,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PI",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("84e2593e-2aeb-44ae-b472-fc213ea2ab22"),
                            DDD = 87,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("c4609e05-9921-48e6-aa8a-6da66a7ea3a5"),
                            DDD = 88,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "CE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("36ab7481-3dd5-473d-8a27-ab6d0392fa57"),
                            DDD = 89,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PI",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("7cb63460-7589-4590-b2ea-9cfa35365d56"),
                            DDD = 91,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PA",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("2044111b-137d-4c4d-9d9c-2290ece0b81c"),
                            DDD = 92,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AM",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("f1e3ca99-5c8f-4b2c-a45d-d465477b9796"),
                            DDD = 93,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PA",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("a7218739-47b9-4906-840d-58ec28726be5"),
                            DDD = 94,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PA",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("6962f7e1-deca-4e4c-a431-3a94d40949d4"),
                            DDD = 95,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RR",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("2098e0da-7664-4075-9630-4ff54a331efb"),
                            DDD = 96,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AP",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("7edaaae2-c4b6-4c1b-937e-5ef7707d902d"),
                            DDD = 97,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AM",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("576ac670-3e38-4978-ae4d-b46ff4c694d3"),
                            DDD = 98,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("9b51e5fb-ae32-4fad-9d6e-e5e9209521a4"),
                            DDD = 99,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        });
                });

            modelBuilder.Entity("Fiap.TechChallenge.Fase1.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTime?>("Dt_Alteracao")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_alteracao");

                    b.Property<DateTime?>("Dt_Exclusao")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_exclusao");

                    b.Property<DateTime>("Dt_Registro")
                        .HasColumnType("timestamp")
                        .HasColumnName("dt_registro");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR(150)")
                        .HasColumnName("email");

                    b.Property<bool>("Excluido")
                        .HasColumnType("BOOL")
                        .HasColumnName("excluido");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("nome");

                    b.Property<short>("Role")
                        .HasColumnType("SMALLINT")
                        .HasColumnName("role");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR(500)")
                        .HasColumnName("senha");

                    b.HasKey("Id")
                        .HasName("pk_usuario");

                    b.ToTable("usuario", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("fed93faa-e3dc-4539-bf5d-24b0e2af602d"),
                            Dt_Registro = new DateTime(2024, 9, 30, 21, 1, 14, 529, DateTimeKind.Local).AddTicks(9265),
                            Email = "admin@gmail.com",
                            Excluido = false,
                            Nome = "Administrador",
                            Role = (short)0,
                            Senha = "$2b$12$/nj7LJgiUFp32SZ9A2A98e83JwjOtWPhOLTnplHMCRQqKfqGHAmVS"
                        },
                        new
                        {
                            Id = new Guid("72c0b29c-9b9a-4233-b8be-d82af9381b69"),
                            Dt_Registro = new DateTime(2024, 9, 30, 21, 1, 14, 529, DateTimeKind.Local).AddTicks(9296),
                            Email = "emailtesteusuario@gmail.com",
                            Excluido = false,
                            Nome = "Usuario",
                            Role = (short)0,
                            Senha = "$2b$12$/nj7LJgiUFp32SZ9A2A98e83JwjOtWPhOLTnplHMCRQqKfqGHAmVS"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
