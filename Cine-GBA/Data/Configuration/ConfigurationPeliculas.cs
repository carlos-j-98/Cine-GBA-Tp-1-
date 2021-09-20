using Cine_GBA.Data.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cine_GBA.Data.Configuration
{
    class ConfigurationPeliculas
    {
        public ConfigurationPeliculas(EntityTypeBuilder<Peliculas> Builder)
        {
            Builder.HasKey(s => s.PeliculaId);
            Builder.Property(s => s.Titulo).IsRequired().HasMaxLength(40);
            Builder.Property(s => s.Poster).IsRequired().HasMaxLength(255);
            Builder.Property(s => s.Sinopsis).IsRequired().HasMaxLength(255);
            Builder.Property(s => s.Trailer).IsRequired().HasMaxLength(255);
            Builder.HasMany(s => s.Funciones).WithOne(x => x.Pelicula).HasForeignKey(s => s.PeliculaId);

            Builder.HasData(new Peliculas
            {
                PeliculaId = 1,
                Titulo = "Iron Man",
                Poster = "https://blogdesuperheroes.es/Iron%20Man/BDS_IronMan_Definitivo.jpg ",
                Sinopsis = "Un empresario millonario construye un traje blindado y lo usa para combatir el crimen y el terrorismo.",
                Trailer = "https://www.youtube.com/watch?v=8ugaeA-nMTc"
            });
            Builder.HasData(new Peliculas
            {
                PeliculaId = 2,
                Titulo = "El increible Hulk",
                Poster = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRJJKVg3vlPa2EW2fwI6fhsCA59NegVLJAJu-AQ7RvDWAtb6mwS",
                Sinopsis = " Bruce Banner recorre el mundo en busca de un antídoto para librarse de su alter ego. Además tendrá que hacer frente a Emil, un nuevo enemigo, lo que convertirá a Nueva York en el escenario de la última batalla entre las dos criaturas más poderosas.",
                Trailer = "https://www.youtube.com/watch?v=xbqNb2PFKKA"
            });
            Builder.HasData(new Peliculas
            {
                PeliculaId = 3,
                Titulo = "Thor",
                Poster = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSXqpi4z8LN3B88RKYW5bzrm6BNZzS4Rn-5FfN83vZLQkvZZwOW",
                Sinopsis = "Tras desatar una antigua guerra, el codicioso guerrero Thor es desterrado a la Tierra por su padre",
                Trailer = "https://www.youtube.com/watch?v=JOddp-nlNvQ"
            });
            Builder.HasData(new Peliculas
            {
                PeliculaId = 4,
                Titulo = "Rapido y Furioso",
                Poster = "https://static.wikia.nocookie.net/atodogas/images/c/c1/R%C3%A1pido_y_furioso.jpg/revision/latest?cb=20150409191706&path-prefix=es",
                Sinopsis = "Un policía encubierto se infiltra en una banda de carreras callejeras de Los Ángeles mientras investiga robos de automóviles.",
                Trailer = "https://www.youtube.com/watch?v=-oJHZre7XZY"
            });
            Builder.HasData(new Peliculas
            {
                PeliculaId = 5,
                Titulo = "La mujer maravilla",
                Poster = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSNuQHrsPeVHiab8vlU-tfS-btQ8jednhQpH0jgcyrLJODBPk72",
                Sinopsis = "Diana, hija de dioses y princesa de las amazonas, nunca ha salido de su isla",
                Trailer = "https://www.youtube.com/watch?v=R3wDsbkybVw"
            });
            Builder.HasData(new Peliculas
            {
                PeliculaId = 6,
                Titulo = "Los pitufos",
                Poster = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQeDebiKJCLYWx7cRFa0ZdXp274j28MHYHU5D_PEecvc-JkxUkU",
                Sinopsis = "Gargamel descubre la aldea mágica de los pitufos y provoca con sus malas artes que abandonen el bosque",
                Trailer = "https://www.youtube.com/watch?v=pcLv6AiTVxM"
            });
            Builder.HasData(new Peliculas
            {
                PeliculaId = 7,
                Titulo = "Dr. Strange",
                Poster = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1-MK7tHomhOcaLsoMzbNaTsfDIYG4nvx9iOXJEV93wtDdFTbC",
                Sinopsis = "Después de sufrir un accidente, un brillante y arrogante cirujano busca rehabilitarse mediante técnicas alternativas. Sus intentos le llevan a descubrir que ha sido designado para encabezar la lucha contra una fuerza oscura y sobrenatural.",
                Trailer = "https://www.youtube.com/watch?v=HSzx-zryEgM"
            });
            Builder.HasData(new Peliculas
            {
                PeliculaId = 8,
                Titulo = "The Avengers",
                Poster = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcT4prgaAFROC5b20TABhsgF4eSeehjvRjJC7uud7yQ9QdkNU4sR",
                Sinopsis = "El director de la Agencia SHIELD decide reclutar a un equipo para salvar al mundo de un desastre casi seguro cuando un enemigo inesperado surge como una gran amenaza para la seguridad mundial.",
                Trailer = "https://www.youtube.com/watch?v=eOrNdBpGMv8"
            });
            Builder.HasData(new Peliculas
            {
                PeliculaId = 9,
                Titulo = "Spider Man",
                Poster = "https://m.media-amazon.com/images/I/71c5Cavf9lL._AC_SY679_.jpg",
                Sinopsis = "Luego de sufrir la picadura de una araña genéticamente modificada, un estudiante de secundaria tímido y torpe adquiere increíbles capacidades como arácnido",
                Trailer = "https://www.youtube.com/watch?v=TYMMOjBUPMM"
            });
            Builder.HasData(new Peliculas
            {
                PeliculaId = 10,
                Titulo = "Ant-Man",
                Poster = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSEmZLAmpYpUhwsc79p3-ykHBfMjq8uiudaBMY6uFRtSxurkKyX",
                Sinopsis = "Un ladrón con la habilidad de encogerse de tamaño pero crecer en fuerza debe sacar su héroe interior y ayudar a su mentor a llevar a cabo un plan para salvar al mundo.",
                Trailer = "https://www.youtube.com/watch?v=pWdKf3MneyI"
            });

        }
    }
}
