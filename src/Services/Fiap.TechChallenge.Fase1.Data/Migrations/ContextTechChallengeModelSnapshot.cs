﻿// <auto-generated />
using System;
using Fiap.TechChallenge.Fase1.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Fiap.TechChallenge.Fase1.Data.Migrations
{
    [DbContext(typeof(ContextTechChallenge))]
    partial class ContextTechChallengeModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("7f0a3f35-4b4a-49a4-a3db-5fba9ba1839a"),
                            DDD = 11,
                            Dt_Registro = new DateTime(2024, 10, 1, 0, 35, 11, 123, DateTimeKind.Local).AddTicks(3423),
                            Email = "emailtestecontato@gmail.com",
                            Excluido = false,
                            Nome = "Nome Teste",
                            Telefone = "994918888"
                        },
                        new
                        {
                            Id = new Guid("25fd01b7-1638-4c0d-a946-365e8cebe5d8"),
                            DDD = 11,
                            Dt_Registro = new DateTime(2024, 10, 1, 0, 35, 11, 123, DateTimeKind.Local).AddTicks(3439),
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
                            Id = new Guid("6bdbce48-1553-489b-a876-2f6e5001eef8"),
                            DDD = 11,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("7f672a14-2d5c-41a5-a3fe-eca8a1fb9f4f"),
                            DDD = 12,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("7ec13e97-d599-4322-ad49-b3e4ba601a7c"),
                            DDD = 13,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("eb22184f-7095-4f6a-83cf-8d4ac057c806"),
                            DDD = 14,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("da0a913c-b30c-4690-b9d3-38cb2fe668e8"),
                            DDD = 15,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("f2c0efec-a834-408a-83ab-ce5a0afed325"),
                            DDD = 16,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("e177345f-1bd3-4728-bd72-cc87d886263a"),
                            DDD = 17,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("3a96fd34-758d-4f42-bf6b-6ac684460d49"),
                            DDD = 18,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("3c811bc8-8b87-4d13-981b-8e5a66081582"),
                            DDD = 19,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("e9018cb0-b89d-4b72-a1df-fe4551332a83"),
                            DDD = 21,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RJ",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("b5e35f8b-06fa-47d2-9ef5-ff56fd1640eb"),
                            DDD = 22,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RJ",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("f78cee32-9c15-4b3d-b931-3fcc4ae263bd"),
                            DDD = 24,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RJ",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("0427f265-d5be-46e9-9a00-7b7b12158b89"),
                            DDD = 27,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "ES",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("d5ba787e-d78c-4ec2-99a3-d178484a27da"),
                            DDD = 28,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "ES",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("c78efda5-8bd3-4451-8ce5-b996d18ff4c7"),
                            DDD = 31,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("e1cea211-3b45-450f-83fc-2567e1eda42f"),
                            DDD = 32,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("5121d4fa-ab58-4739-a565-9e0d96b38b45"),
                            DDD = 33,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("d86fc811-ad9f-41e2-ac34-63a667a94c46"),
                            DDD = 34,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("50cc0efb-f9e7-42fb-a4da-e9ce8147785b"),
                            DDD = 35,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("2f37addd-a3b9-4939-ae33-bd6bf6f87418"),
                            DDD = 37,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("7c9f0664-b3a4-415e-9104-463aa5763641"),
                            DDD = 38,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("1733b2d1-abb3-4770-b219-129f04c91462"),
                            DDD = 41,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("ba12604b-2445-4cca-a47f-fbff9e8e7244"),
                            DDD = 42,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SC",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("9c482435-0622-4cb1-9dbd-8e41f35efd0b"),
                            DDD = 43,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("6912675f-6a36-46a8-8574-8fdaec20efb4"),
                            DDD = 44,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("77f8e38d-5433-45b5-a3fd-dc5a72472bb9"),
                            DDD = 45,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("928ca632-a5e8-4fe9-817c-509cf507adcb"),
                            DDD = 46,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("69f73d4b-1ff6-494c-b218-c4e46e782468"),
                            DDD = 47,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SC",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("a576c747-1a18-4268-9f8c-33001f2f19d5"),
                            DDD = 48,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SC",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("a5e18c39-1290-4c2e-b51a-e940cd1071f5"),
                            DDD = 49,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SC",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("c9b17613-6515-4a28-a4c7-178cf82a206a"),
                            DDD = 51,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RS",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("6d5074fa-21e6-4808-a2fe-4e94053b95bc"),
                            DDD = 53,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RS",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("1d838d01-959e-435b-a1c2-6f255a27c463"),
                            DDD = 54,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RS",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("41dd356f-659f-44a9-9434-4cf23b5bac50"),
                            DDD = 55,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RS",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("f7ceb563-44d6-4be2-a8c6-2cb5e294c64d"),
                            DDD = 61,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "DF",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("e5a71d54-187d-4be1-ab77-9fa7fc75bb03"),
                            DDD = 62,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "GO",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("8d806054-0317-4da3-a6d0-b6f24e7faa0e"),
                            DDD = 63,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "TO",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("2050ff15-b36c-493a-aedd-d9280a794703"),
                            DDD = 64,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "GO",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("de5189dc-016e-441e-a011-dec67cbac3ca"),
                            DDD = 65,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MT",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("7de0a81f-5d36-46a3-a200-4d37558fe7b2"),
                            DDD = 66,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MT",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("5aaf6d86-a9e3-4c70-84f4-7c1409e89c91"),
                            DDD = 67,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MS",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("3a1625c1-9b10-4ada-a63d-52d315d5c691"),
                            DDD = 68,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AC",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("b53fa0be-b98c-4cdc-ae76-296f2bf4226e"),
                            DDD = 69,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RO",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("ddc21aec-52a0-466d-bd9b-05645a72161e"),
                            DDD = 71,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("922dfc5d-7acd-40f4-ac4f-8d3fe897b614"),
                            DDD = 73,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("7183ebbf-15ff-4290-9a6a-14753b52e5ef"),
                            DDD = 74,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("dc53cbb8-a9c6-4559-8f1a-84ce639be7a6"),
                            DDD = 75,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("9fd0c718-e000-403c-babf-6e2707a4c6ad"),
                            DDD = 77,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("d828b74e-6771-4995-9c20-d99910424e15"),
                            DDD = 79,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("72367f12-4564-471a-8eff-d3d7f86c4540"),
                            DDD = 81,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("56441eb3-ced7-4a89-8ebd-d623d764fd68"),
                            DDD = 82,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AL",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("6dfa7d09-43c6-4daf-9b01-16001020b4fc"),
                            DDD = 83,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PB",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("8c86ce74-7492-4ba7-bcc9-9d5c31a2a6ef"),
                            DDD = 84,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RN",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("c6d8ff3f-81f2-401b-a243-cfbebeee4568"),
                            DDD = 85,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "CE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("68fd600e-f7ea-4e10-a97a-61fdc25fb621"),
                            DDD = 86,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PI",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("109280a0-5e82-4cbe-9129-a8b46ad80005"),
                            DDD = 87,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("7769e187-a41d-47df-b5a5-d9356c91cbbc"),
                            DDD = 88,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "CE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("5dbcdc30-6568-4535-a559-f3d32dc15c05"),
                            DDD = 89,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PI",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("76517eba-61c3-4349-822a-9b261f8aff9e"),
                            DDD = 91,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PA",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("d24c2854-441e-43bf-89b8-afd9206cb0da"),
                            DDD = 92,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AM",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("5a5d1e56-3579-4cb2-9c7a-66c5ecc85f65"),
                            DDD = 93,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PA",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("34f0d4b0-89f1-4c6f-bbe7-f9b58addc64b"),
                            DDD = 94,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PA",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("af8153c3-49cb-419b-8941-8168b42463c8"),
                            DDD = 95,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RR",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("cb2ccaaa-a496-4952-bbf5-208b1caf9271"),
                            DDD = 96,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AP",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("3eee4a9e-70d5-41a1-ae28-86fbc97842bf"),
                            DDD = 97,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AM",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("d8e5b3ed-9529-4183-8b20-92d14232e675"),
                            DDD = 98,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("25184530-9eee-4767-9ccc-5db4196d4634"),
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
                            Id = new Guid("7a6e23c8-70d4-4dc0-81f9-534b973a7d89"),
                            Dt_Registro = new DateTime(2024, 10, 1, 0, 35, 11, 123, DateTimeKind.Local).AddTicks(3362),
                            Email = "admin@gmail.com",
                            Excluido = false,
                            Nome = "Administrador",
                            Role = (short)0,
                            Senha = "$2b$12$/nj7LJgiUFp32SZ9A2A98e83JwjOtWPhOLTnplHMCRQqKfqGHAmVS"
                        },
                        new
                        {
                            Id = new Guid("1432aeba-7316-4d0b-aa97-8235bccd5245"),
                            Dt_Registro = new DateTime(2024, 10, 1, 0, 35, 11, 123, DateTimeKind.Local).AddTicks(3390),
                            Email = "emailtesteusuario@gmail.com",
                            Excluido = false,
                            Nome = "Usuario",
                            Role = (short)1,
                            Senha = "$2b$12$/nj7LJgiUFp32SZ9A2A98e83JwjOtWPhOLTnplHMCRQqKfqGHAmVS"
                        },
                        new
                        {
                            Id = new Guid("c5d447d8-24bc-4478-8a9a-4dd236f9f7db"),
                            Dt_Registro = new DateTime(2024, 10, 1, 0, 35, 11, 123, DateTimeKind.Local).AddTicks(3404),
                            Email = "emailtesteusuarioexcluir@gmail.com",
                            Excluido = false,
                            Nome = "Usuario",
                            Role = (short)1,
                            Senha = "$2b$12$/nj7LJgiUFp32SZ9A2A98e83JwjOtWPhOLTnplHMCRQqKfqGHAmVS"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
