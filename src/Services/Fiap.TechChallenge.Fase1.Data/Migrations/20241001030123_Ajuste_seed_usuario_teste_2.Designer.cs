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
    [Migration("20241001030123_Ajuste_seed_usuario_teste_2")]
    partial class Ajuste_seed_usuario_teste_2
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
                            Id = new Guid("4d02b56c-76f3-4ae7-828e-b64e85fc1c3f"),
                            DDD = 11,
                            Dt_Registro = new DateTime(2024, 10, 1, 0, 1, 22, 879, DateTimeKind.Local).AddTicks(8744),
                            Email = "emailtestecontato@gmail.com",
                            Excluido = false,
                            Nome = "Nome Teste",
                            Telefone = "994918888"
                        },
                        new
                        {
                            Id = new Guid("663b72bc-b38d-4201-94f3-23ded28c9d25"),
                            DDD = 11,
                            Dt_Registro = new DateTime(2024, 10, 1, 0, 1, 22, 879, DateTimeKind.Local).AddTicks(8761),
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
                            Id = new Guid("2079ca34-346d-497a-b25b-084f7e47311e"),
                            DDD = 11,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("4529f7dc-6b87-4888-8042-781bbdd3c47a"),
                            DDD = 12,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("2e25b5b4-62da-4a50-8517-c11ca88ea0e9"),
                            DDD = 13,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("354a6305-af88-4233-a757-ad93eb2db228"),
                            DDD = 14,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("bbedda4e-e076-4473-b45a-dd5db4ff9148"),
                            DDD = 15,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("9255588a-4cb1-49de-9877-ab49382c77a4"),
                            DDD = 16,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("58039324-e172-4710-a7f3-5be8b56c0fb2"),
                            DDD = 17,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("8e643803-31d2-44b3-bbf6-5939640d55b8"),
                            DDD = 18,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("6b45a03a-af82-4da1-9fc5-3399d5e650b3"),
                            DDD = 19,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SP",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("bba6a692-4e14-4e07-ba9e-16e3862296d0"),
                            DDD = 21,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RJ",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("d7d923f0-998e-4381-993c-b0dd561a1761"),
                            DDD = 22,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RJ",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("444b40f8-0de4-4037-b0ac-e1fc196c3168"),
                            DDD = 24,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RJ",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("85ab3493-e640-41e6-90f5-5f76bed2f9f6"),
                            DDD = 27,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "ES",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("93da1136-176e-4d80-87b2-7851cdcba929"),
                            DDD = 28,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "ES",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("77d14a27-e4bc-4842-9b53-a0d6c937ba24"),
                            DDD = 31,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("77add373-a7fd-4014-9d07-3d92c06b750b"),
                            DDD = 32,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("06ab71f7-a804-40c5-ad48-d9c79dc3934b"),
                            DDD = 33,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("2ed1640f-eb1d-4f3f-9471-109af1930d6d"),
                            DDD = 34,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("2aeeea82-8ac3-4392-a37d-a1f26a0562d8"),
                            DDD = 35,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("186291d5-2439-4f1b-bc66-59d1d7064c83"),
                            DDD = 37,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("89a68cfb-563a-48a3-afdc-5a1e532b07ef"),
                            DDD = 38,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MG",
                            Excluido = false,
                            Regiao = "Sudeste"
                        },
                        new
                        {
                            Id = new Guid("2570be4a-eff5-4caf-818f-83875ae9a150"),
                            DDD = 41,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("0e0782f6-b35d-4adb-a7cf-807b046238f5"),
                            DDD = 42,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SC",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("0c7173c2-e2e6-4973-89aa-0520ec0efed3"),
                            DDD = 43,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("b9137b2d-2fdc-447b-bfff-33339fc5e644"),
                            DDD = 44,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("89b5fdca-51e5-42ae-970b-ea387eca60ad"),
                            DDD = 45,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("c1f1cca5-3050-4e92-a928-c2a2dc647a38"),
                            DDD = 46,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PR",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("c1c70bbb-a068-4ed8-8893-baf1dc46dd04"),
                            DDD = 47,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SC",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("293b59fb-8dbf-4bb7-923a-5f2c80947ac2"),
                            DDD = 48,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SC",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("b3a6c544-dddf-4be9-85c7-739266e403dc"),
                            DDD = 49,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SC",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("a6ee8e72-b5e6-40bc-a29e-8889a088780f"),
                            DDD = 51,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RS",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("66055a31-56ae-4cd1-9c0f-b469cbd05f4a"),
                            DDD = 53,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RS",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("11f4d2bd-771e-4925-9808-f75a95402ba8"),
                            DDD = 54,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RS",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("25b0e0fe-46ce-41c0-8fec-2d40583b9b85"),
                            DDD = 55,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RS",
                            Excluido = false,
                            Regiao = "Sul"
                        },
                        new
                        {
                            Id = new Guid("da83fd0f-6d69-4ece-bcb5-0b0a91be4b42"),
                            DDD = 61,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "DF",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("46c499ce-009d-467c-8254-7d44d904aa2a"),
                            DDD = 62,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "GO",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("c386d136-e06a-40fe-86f8-ec9065eac083"),
                            DDD = 63,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "TO",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("91de01f0-80c3-4b10-9ae8-aa8e53b82fba"),
                            DDD = 64,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "GO",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("14c6bce6-ee6c-4968-9696-31b3f0528b11"),
                            DDD = 65,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MT",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("d646d3aa-7a02-412e-bb8f-1de2c1e8a4cb"),
                            DDD = 66,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MT",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("fc884669-b270-4210-9824-e524aadb002b"),
                            DDD = 67,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MS",
                            Excluido = false,
                            Regiao = "Centro-Oeste"
                        },
                        new
                        {
                            Id = new Guid("ec96f5a6-faef-4a69-a7e4-27e068b6f65f"),
                            DDD = 68,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AC",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("2fbb4b23-6dae-4670-9b27-d4c778f7c764"),
                            DDD = 69,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RO",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("0138a539-2bbf-44bc-847a-2970275f5310"),
                            DDD = 71,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("c992198b-aeaa-4c33-93d7-79cc70aa80e5"),
                            DDD = 73,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("bdce5415-c5c4-43a6-aa16-5c5ff69845cc"),
                            DDD = 74,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("0051e299-873f-44d9-8733-ade537db1d4c"),
                            DDD = 75,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("b3b6b359-1002-4ab7-8feb-dfe04679027e"),
                            DDD = 77,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "BA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("6ca4d0f5-ad60-4fff-b067-aa3daf06d29d"),
                            DDD = 79,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "SE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("fcc41f5a-0c31-4ef2-93e2-4da5afc4f908"),
                            DDD = 81,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("a1e25bb7-d52e-4abb-8f37-19e8872d0c4f"),
                            DDD = 82,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AL",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("3ffc4b7e-2d6e-4169-8aad-d5085040aee1"),
                            DDD = 83,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PB",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("c9311985-c86f-444b-bdc8-f642e1cf1fcd"),
                            DDD = 84,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RN",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("2b41110a-55c5-4fcd-910f-9ba0f19a5b33"),
                            DDD = 85,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "CE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("ddf68a0f-96a2-415d-bb74-c06bf46b7092"),
                            DDD = 86,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PI",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("4dd9c791-84ae-412d-80af-774786732b8b"),
                            DDD = 87,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("e66c7762-1598-45d3-8623-7f1b8b2681cf"),
                            DDD = 88,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "CE",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("399b9ab0-5b63-481a-b459-60250424bc49"),
                            DDD = 89,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PI",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("cb9a869a-b129-45b2-8b4e-52ae4eeba932"),
                            DDD = 91,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PA",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("d369a9be-1bdd-4e30-9fae-abbdf055d9b8"),
                            DDD = 92,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AM",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("a09c963e-9598-4dce-b48b-8721d1719e92"),
                            DDD = 93,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PA",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("c04671cf-6351-49a3-a039-dcc872812f48"),
                            DDD = 94,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "PA",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("bd28e2e4-1ac2-45f5-8667-2d908d0388f4"),
                            DDD = 95,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "RR",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("a709185e-9171-4cde-aa12-3d68a0c9ca4c"),
                            DDD = 96,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AP",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("aae2c280-4a12-4741-af85-ce250c029fe2"),
                            DDD = 97,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "AM",
                            Excluido = false,
                            Regiao = "Norte"
                        },
                        new
                        {
                            Id = new Guid("181f25fd-93fe-443a-a959-b024874b03a5"),
                            DDD = 98,
                            Dt_Registro = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Estado = "MA",
                            Excluido = false,
                            Regiao = "Nordeste"
                        },
                        new
                        {
                            Id = new Guid("0ad2c856-82e6-4109-a402-5a54d38d19ef"),
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
                            Id = new Guid("91f1d712-ff58-4de9-818e-5efa53fa8ed6"),
                            Dt_Registro = new DateTime(2024, 10, 1, 0, 1, 22, 879, DateTimeKind.Local).AddTicks(8660),
                            Email = "admin@gmail.com",
                            Excluido = false,
                            Nome = "Administrador",
                            Role = (short)0,
                            Senha = "$2b$12$/nj7LJgiUFp32SZ9A2A98e83JwjOtWPhOLTnplHMCRQqKfqGHAmVS"
                        },
                        new
                        {
                            Id = new Guid("e5ebc2be-39ed-4048-9488-b5ebb7730f6f"),
                            Dt_Registro = new DateTime(2024, 10, 1, 0, 1, 22, 879, DateTimeKind.Local).AddTicks(8710),
                            Email = "emailtesteusuario@gmail.com",
                            Excluido = false,
                            Nome = "Usuario",
                            Role = (short)1,
                            Senha = "$2b$12$/nj7LJgiUFp32SZ9A2A98e83JwjOtWPhOLTnplHMCRQqKfqGHAmVS"
                        },
                        new
                        {
                            Id = new Guid("13f9f09d-291d-4f6b-ac0c-f8fef1233da6"),
                            Dt_Registro = new DateTime(2024, 10, 1, 0, 1, 22, 879, DateTimeKind.Local).AddTicks(8726),
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