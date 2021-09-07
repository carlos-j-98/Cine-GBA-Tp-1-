﻿// <auto-generated />
using System;
using Cine_GBA.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cine_GBA.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210907031005_hola")]
    partial class hola
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cine_GBA.Data.Models.Funciones", b =>
                {
                    b.Property<int>("FuncionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("Horario")
                        .HasColumnType("time");

                    b.Property<int>("PeliculaId")
                        .HasColumnType("int");

                    b.Property<int>("SalaId")
                        .HasColumnType("int");

                    b.HasKey("FuncionId");

                    b.HasIndex("PeliculaId");

                    b.HasIndex("SalaId");

                    b.ToTable("Funciones");
                });

            modelBuilder.Entity("Cine_GBA.Data.Models.Peliculas", b =>
                {
                    b.Property<int>("PeliculaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Poster")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Sinopsis")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<string>("Trailer")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("PeliculaId");

                    b.ToTable("Peliculas");

                    b.HasData(
                        new
                        {
                            PeliculaId = 1,
                            Poster = "https://blogdesuperheroes.es/Iron%20Man/BDS_IronMan_Definitivo.jpg ",
                            Sinopsis = "Un empresario millonario construye un traje blindado y lo usa para combatir el crimen y el terrorismo.",
                            Titulo = "Iron Man",
                            Trailer = "https://www.youtube.com/watch?v=8ugaeA-nMTc"
                        },
                        new
                        {
                            PeliculaId = 2,
                            Poster = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRJJKVg3vlPa2EW2fwI6fhsCA59NegVLJAJu-AQ7RvDWAtb6mwS",
                            Sinopsis = " Bruce Banner recorre el mundo en busca de un antídoto para librarse de su alter ego. Además tendrá que hacer frente a Emil, un nuevo enemigo, lo que convertirá a Nueva York en el escenario de la última batalla entre las dos criaturas más poderosas.",
                            Titulo = "El increible Hulk",
                            Trailer = "https://www.youtube.com/watch?v=xbqNb2PFKKA"
                        },
                        new
                        {
                            PeliculaId = 3,
                            Poster = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSXqpi4z8LN3B88RKYW5bzrm6BNZzS4Rn-5FfN83vZLQkvZZwOW",
                            Sinopsis = "Tras desatar una antigua guerra, el codicioso guerrero Thor es desterrado a la Tierra por su padre",
                            Titulo = "Thor",
                            Trailer = "https://www.youtube.com/watch?v=JOddp-nlNvQ"
                        },
                        new
                        {
                            PeliculaId = 4,
                            Poster = "https://static.wikia.nocookie.net/atodogas/images/c/c1/R%C3%A1pido_y_furioso.jpg/revision/latest?cb=20150409191706&path-prefix=es",
                            Sinopsis = "Un policía encubierto se infiltra en una banda de carreras callejeras de Los Ángeles mientras investiga robos de automóviles.",
                            Titulo = "Rapido y Furioso",
                            Trailer = "https://www.youtube.com/watch?v=-oJHZre7XZY"
                        },
                        new
                        {
                            PeliculaId = 5,
                            Poster = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSNuQHrsPeVHiab8vlU-tfS-btQ8jednhQpH0jgcyrLJODBPk72",
                            Sinopsis = "Diana, hija de dioses y princesa de las amazonas, nunca ha salido de su isla",
                            Titulo = "La mujer maravilla",
                            Trailer = "https://www.youtube.com/watch?v=R3wDsbkybVw"
                        },
                        new
                        {
                            PeliculaId = 6,
                            Poster = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQeDebiKJCLYWx7cRFa0ZdXp274j28MHYHU5D_PEecvc-JkxUkU",
                            Sinopsis = "Gargamel descubre la aldea mágica de los pitufos y provoca con sus malas artes que abandonen el bosque",
                            Titulo = "Los pitufos",
                            Trailer = "https://www.youtube.com/watch?v=pcLv6AiTVxM"
                        },
                        new
                        {
                            PeliculaId = 7,
                            Poster = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1-MK7tHomhOcaLsoMzbNaTsfDIYG4nvx9iOXJEV93wtDdFTbC",
                            Sinopsis = "Después de sufrir un accidente, un brillante y arrogante cirujano busca rehabilitarse mediante técnicas alternativas. Sus intentos le llevan a descubrir que ha sido designado para encabezar la lucha contra una fuerza oscura y sobrenatural.",
                            Titulo = "Dr. Strange",
                            Trailer = "https://www.youtube.com/watch?v=HSzx-zryEgM"
                        },
                        new
                        {
                            PeliculaId = 8,
                            Poster = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcT4prgaAFROC5b20TABhsgF4eSeehjvRjJC7uud7yQ9QdkNU4sR",
                            Sinopsis = "El director de la Agencia SHIELD decide reclutar a un equipo para salvar al mundo de un desastre casi seguro cuando un enemigo inesperado surge como una gran amenaza para la seguridad mundial.",
                            Titulo = "The Avengers",
                            Trailer = "https://www.youtube.com/watch?v=eOrNdBpGMv8"
                        },
                        new
                        {
                            PeliculaId = 9,
                            Poster = "https://m.media-amazon.com/images/I/71c5Cavf9lL._AC_SY679_.jpg",
                            Sinopsis = "Luego de sufrir la picadura de una araña genéticamente modificada, un estudiante de secundaria tímido y torpe adquiere increíbles capacidades como arácnido",
                            Titulo = "Spider Man",
                            Trailer = "https://www.youtube.com/watch?v=TYMMOjBUPMM"
                        },
                        new
                        {
                            PeliculaId = 10,
                            Poster = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSEmZLAmpYpUhwsc79p3-ykHBfMjq8uiudaBMY6uFRtSxurkKyX",
                            Sinopsis = "Un ladrón con la habilidad de encogerse de tamaño pero crecer en fuerza debe sacar su héroe interior y ayudar a su mentor a llevar a cabo un plan para salvar al mundo.",
                            Titulo = "Ant-Man",
                            Trailer = "https://www.youtube.com/watch?v=pWdKf3MneyI"
                        });
                });

            modelBuilder.Entity("Cine_GBA.Data.Models.Salas", b =>
                {
                    b.Property<int>("SalaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Capacidad")
                        .HasColumnType("int");

                    b.HasKey("SalaId");

                    b.ToTable("Salas");

                    b.HasData(
                        new
                        {
                            SalaId = 1,
                            Capacidad = 5
                        },
                        new
                        {
                            SalaId = 2,
                            Capacidad = 15
                        },
                        new
                        {
                            SalaId = 3,
                            Capacidad = 35
                        });
                });

            modelBuilder.Entity("Cine_GBA.Data.Models.Tickets", b =>
                {
                    b.Property<Guid>("TiketId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FuncionId")
                        .HasColumnType("int");

                    b.Property<string>("Usuarios")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("TiketId", "FuncionId");

                    b.HasIndex("FuncionId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Cine_GBA.Data.Models.Funciones", b =>
                {
                    b.HasOne("Cine_GBA.Data.Models.Peliculas", "Pelicula")
                        .WithMany("Funciones")
                        .HasForeignKey("PeliculaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Cine_GBA.Data.Models.Salas", "Sala")
                        .WithMany("Funciones")
                        .HasForeignKey("SalaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pelicula");

                    b.Navigation("Sala");
                });

            modelBuilder.Entity("Cine_GBA.Data.Models.Tickets", b =>
                {
                    b.HasOne("Cine_GBA.Data.Models.Funciones", "Funciones")
                        .WithMany("Tickets")
                        .HasForeignKey("FuncionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Funciones");
                });

            modelBuilder.Entity("Cine_GBA.Data.Models.Funciones", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Cine_GBA.Data.Models.Peliculas", b =>
                {
                    b.Navigation("Funciones");
                });

            modelBuilder.Entity("Cine_GBA.Data.Models.Salas", b =>
                {
                    b.Navigation("Funciones");
                });
#pragma warning restore 612, 618
        }
    }
}
