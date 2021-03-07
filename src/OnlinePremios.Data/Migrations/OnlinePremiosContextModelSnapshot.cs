﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlinePremios.Data.Orm;

namespace OnlinePremios.Data.Migrations
{
    [DbContext(typeof(OnlinePremiosContext))]
    partial class OnlinePremiosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlinePremios.Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnName("Nome")
                        .HasColumnType("varchar(120)")
                        .HasMaxLength(120);

                    b.Property<int>("StatusCliente")
                        .HasColumnName("StatusCliente")
                        .HasColumnType("int");

                    b.Property<int>("TipoPessoa")
                        .HasColumnName("TipoPessoa")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserUpdate")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("OnlinePremios.Domain.Entities.Compra", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnName("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCompra")
                        .HasColumnName("DataCompra")
                        .HasColumnType("datetime2");

                    b.Property<int>("QtdeCotas")
                        .HasColumnName("QtdeCotas")
                        .HasColumnType("int");

                    b.Property<int>("StatusCompra")
                        .HasColumnName("StatusCompra")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserUpdate")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("OnlinePremios.Domain.Entities.Cota", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CompraId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<int>("Numero")
                        .HasColumnName("Numero")
                        .HasColumnType("int");

                    b.Property<int>("StatusCota")
                        .HasColumnName("StatusCota")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserUpdate")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Valor")
                        .HasColumnName("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.ToTable("Cota");
                });

            modelBuilder.Entity("OnlinePremios.Domain.Entities.Galeria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("SorteioId")
                        .HasColumnName("SorteioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserUpdate")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SorteioId");

                    b.ToTable("Galeria");
                });

            modelBuilder.Entity("OnlinePremios.Domain.Entities.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("FileName")
                        .IsRequired()
                        .HasColumnName("FileName")
                        .HasColumnType("varchar(90)")
                        .HasMaxLength(400);

                    b.Property<Guid>("GaleriaId")
                        .HasColumnName("GaleriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImgURL")
                        .IsRequired()
                        .HasColumnName("ImgURL")
                        .HasColumnType("varchar(90)")
                        .HasMaxLength(2000);

                    b.Property<Guid?>("UserUpdate")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GaleriaId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("OnlinePremios.Domain.Entities.Sorteio", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DataAtualizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicial")
                        .HasColumnName("DataInicial")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataSorteio")
                        .HasColumnName("DataSorteio")
                        .HasColumnType("datetime2");

                    b.Property<int>("Numero")
                        .HasColumnName("Numero")
                        .HasColumnType("int");

                    b.Property<int>("QtdeCotas")
                        .HasColumnName("QtdeCotas")
                        .HasColumnType("int");

                    b.Property<int>("StatusSorteio")
                        .HasColumnName("StatusSorteio")
                        .HasColumnType("int");

                    b.Property<Guid?>("UserUpdate")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Sorteio");
                });

            modelBuilder.Entity("OnlinePremios.Domain.Entities.Compra", b =>
                {
                    b.HasOne("OnlinePremios.Domain.Entities.Cliente", "Cliente")
                        .WithMany("Compras")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlinePremios.Domain.Entities.Cota", b =>
                {
                    b.HasOne("OnlinePremios.Domain.Entities.Compra", "Compra")
                        .WithMany("Cotas")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlinePremios.Domain.Entities.Galeria", b =>
                {
                    b.HasOne("OnlinePremios.Domain.Entities.Sorteio", "Sorteio")
                        .WithMany()
                        .HasForeignKey("SorteioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlinePremios.Domain.Entities.Produto", b =>
                {
                    b.HasOne("OnlinePremios.Domain.Entities.Galeria", "Galeria")
                        .WithMany("Produtos")
                        .HasForeignKey("GaleriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
