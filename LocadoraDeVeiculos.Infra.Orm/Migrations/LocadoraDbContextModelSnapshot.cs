﻿// <auto-generated />
using System;
using LocadoraDeVeiculos.Infra.Orm.Compartilhado;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LocadoraDeVeiculos.Infra.Orm.Migrations
{
    [DbContext(typeof(LocadoraDbContext))]
    partial class LocadoraDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LocacaoTaxa", b =>
                {
                    b.Property<int>("LocacoesId")
                        .HasColumnType("int");

                    b.Property<int>("TaxasSelecionadasId")
                        .HasColumnType("int");

                    b.HasKey("LocacoesId", "TaxasSelecionadasId");

                    b.HasIndex("TaxasSelecionadasId");

                    b.ToTable("TBLocacaoTaxa", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloAutenticacao.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloAutenticacao.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCliente.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("NumeroDocumento")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<int>("TipoCadastro")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TBCliente", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCombustivel.ConfiguracaoCombustivel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ValorAlcool")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorDiesel")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorGas")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorGasolina")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("TBConfiguracaoCombustivel", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCondutor.Condutor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CNH")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<bool>("ClienteCondutor")
                        .HasColumnType("bit");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("ValidadeCNH")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("TBCondutor", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloFuncionario.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Admissao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("EmpresaId")
                        .HasColumnType("int");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.ToTable("TBFuncionario", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloGrupoVeiculos.GrupoVeiculos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TbGrupoVeiculos", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloLocacao.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CondutorId")
                        .HasColumnType("int");

                    b.Property<int>("ConfiguracaoCombustivelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataDevolucao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DevolucaoPrevista")
                        .HasColumnType("datetime2");

                    b.Property<int>("MarcadorCombustivel")
                        .HasColumnType("int");

                    b.Property<int>("QuilometragemPercorrida")
                        .HasColumnType("int");

                    b.Property<int>("TipoPlano")
                        .HasColumnType("int");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CondutorId");

                    b.HasIndex("ConfiguracaoCombustivelId");

                    b.HasIndex("VeiculoId");

                    b.ToTable("TBLocacao", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca.PlanoCobranca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("GrupoVeiculosId")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecoDiarioPlanoControlado")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecoDiarioPlanoDiario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecoDiarioPlanoLivre")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecoQuilometroExtrapoladoPlanoControlado")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecoQuilometroPlanoDiario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("QuilometrosDisponiveisPlanoControlado")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("GrupoVeiculosId");

                    b.ToTable("TBPlanoCobranca", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloTaxa.Taxa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int>("TipoCobranca")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("TBTaxa", (string)null);
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloVeiculo.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Alugado")
                        .HasColumnType("bit");

                    b.Property<int>("CapacidadeTanque")
                        .HasColumnType("int");

                    b.Property<byte[]>("Foto")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varbinary(max)")
                        .HasDefaultValue(new byte[0]);

                    b.Property<int>("GrupoVeiculosId")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("TipoCombustivel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GrupoVeiculosId");

                    b.ToTable("TBVeiculo", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("LocacaoTaxa", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloLocacao.Locacao", null)
                        .WithMany()
                        .HasForeignKey("LocacoesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloTaxa.Taxa", null)
                        .WithMany()
                        .HasForeignKey("TaxasSelecionadasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCondutor.Condutor", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloCliente.Cliente", "Cliente")
                        .WithMany("Condutores")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloFuncionario.Funcionario", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloAutenticacao.Usuario", "Empresa")
                        .WithMany()
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloLocacao.Locacao", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloCondutor.Condutor", "Condutor")
                        .WithMany()
                        .HasForeignKey("CondutorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloCombustivel.ConfiguracaoCombustivel", "ConfiguracaoCombustivel")
                        .WithMany()
                        .HasForeignKey("ConfiguracaoCombustivelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloVeiculo.Veiculo", "Veiculo")
                        .WithMany()
                        .HasForeignKey("VeiculoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Condutor");

                    b.Navigation("ConfiguracaoCombustivel");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloPlanoCobranca.PlanoCobranca", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloGrupoVeiculos.GrupoVeiculos", "GrupoVeiculos")
                        .WithMany()
                        .HasForeignKey("GrupoVeiculosId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("GrupoVeiculos");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloVeiculo.Veiculo", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloGrupoVeiculos.GrupoVeiculos", "GrupoVeiculos")
                        .WithMany("Veiculos")
                        .HasForeignKey("GrupoVeiculosId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("GrupoVeiculos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloAutenticacao.Perfil", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloAutenticacao.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloAutenticacao.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloAutenticacao.Perfil", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloAutenticacao.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("LocadoraDeVeiculos.Dominio.ModuloAutenticacao.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloCliente.Cliente", b =>
                {
                    b.Navigation("Condutores");
                });

            modelBuilder.Entity("LocadoraDeVeiculos.Dominio.ModuloGrupoVeiculos.GrupoVeiculos", b =>
                {
                    b.Navigation("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
