using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Cine_GBA.Migrations
{
    public partial class hola : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Peliculas",
                columns: table => new
                {
                    PeliculaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    Poster = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sinopsis = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Trailer = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.PeliculaId);
                });

            migrationBuilder.CreateTable(
                name: "Salas",
                columns: table => new
                {
                    SalaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Capacidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salas", x => x.SalaId);
                });

            migrationBuilder.CreateTable(
                name: "Funciones",
                columns: table => new
                {
                    FuncionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PeliculaId = table.Column<int>(type: "int", nullable: false),
                    SalaId = table.Column<int>(type: "int", nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Horario = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funciones", x => x.FuncionId);
                    table.ForeignKey(
                        name: "FK_Funciones_Peliculas_PeliculaId",
                        column: x => x.PeliculaId,
                        principalTable: "Peliculas",
                        principalColumn: "PeliculaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Funciones_Salas_SalaId",
                        column: x => x.SalaId,
                        principalTable: "Salas",
                        principalColumn: "SalaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TiketId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FuncionId = table.Column<int>(type: "int", nullable: false),
                    Usuarios = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => new { x.TiketId, x.FuncionId });
                    table.ForeignKey(
                        name: "FK_Tickets_Funciones_FuncionId",
                        column: x => x.FuncionId,
                        principalTable: "Funciones",
                        principalColumn: "FuncionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Peliculas",
                columns: new[] { "PeliculaId", "Poster", "Sinopsis", "Titulo", "Trailer" },
                values: new object[,]
                {
                    { 1, "https://blogdesuperheroes.es/Iron%20Man/BDS_IronMan_Definitivo.jpg ", "Un empresario millonario construye un traje blindado y lo usa para combatir el crimen y el terrorismo.", "Iron Man", "https://www.youtube.com/watch?v=8ugaeA-nMTc" },
                    { 2, "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcRJJKVg3vlPa2EW2fwI6fhsCA59NegVLJAJu-AQ7RvDWAtb6mwS", " Bruce Banner recorre el mundo en busca de un antídoto para librarse de su alter ego. Además tendrá que hacer frente a Emil, un nuevo enemigo, lo que convertirá a Nueva York en el escenario de la última batalla entre las dos criaturas más poderosas.", "El increible Hulk", "https://www.youtube.com/watch?v=xbqNb2PFKKA" },
                    { 3, "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSXqpi4z8LN3B88RKYW5bzrm6BNZzS4Rn-5FfN83vZLQkvZZwOW", "Tras desatar una antigua guerra, el codicioso guerrero Thor es desterrado a la Tierra por su padre", "Thor", "https://www.youtube.com/watch?v=JOddp-nlNvQ" },
                    { 4, "https://static.wikia.nocookie.net/atodogas/images/c/c1/R%C3%A1pido_y_furioso.jpg/revision/latest?cb=20150409191706&path-prefix=es", "Un policía encubierto se infiltra en una banda de carreras callejeras de Los Ángeles mientras investiga robos de automóviles.", "Rapido y Furioso", "https://www.youtube.com/watch?v=-oJHZre7XZY" },
                    { 5, "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcSNuQHrsPeVHiab8vlU-tfS-btQ8jednhQpH0jgcyrLJODBPk72", "Diana, hija de dioses y princesa de las amazonas, nunca ha salido de su isla", "La mujer maravilla", "https://www.youtube.com/watch?v=R3wDsbkybVw" },
                    { 6, "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQeDebiKJCLYWx7cRFa0ZdXp274j28MHYHU5D_PEecvc-JkxUkU", "Gargamel descubre la aldea mágica de los pitufos y provoca con sus malas artes que abandonen el bosque", "Los pitufos", "https://www.youtube.com/watch?v=pcLv6AiTVxM" },
                    { 7, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ1-MK7tHomhOcaLsoMzbNaTsfDIYG4nvx9iOXJEV93wtDdFTbC", "Después de sufrir un accidente, un brillante y arrogante cirujano busca rehabilitarse mediante técnicas alternativas. Sus intentos le llevan a descubrir que ha sido designado para encabezar la lucha contra una fuerza oscura y sobrenatural.", "Dr. Strange", "https://www.youtube.com/watch?v=HSzx-zryEgM" },
                    { 8, "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcT4prgaAFROC5b20TABhsgF4eSeehjvRjJC7uud7yQ9QdkNU4sR", "El director de la Agencia SHIELD decide reclutar a un equipo para salvar al mundo de un desastre casi seguro cuando un enemigo inesperado surge como una gran amenaza para la seguridad mundial.", "The Avengers", "https://www.youtube.com/watch?v=eOrNdBpGMv8" },
                    { 9, "https://m.media-amazon.com/images/I/71c5Cavf9lL._AC_SY679_.jpg", "Luego de sufrir la picadura de una araña genéticamente modificada, un estudiante de secundaria tímido y torpe adquiere increíbles capacidades como arácnido", "Spider Man", "https://www.youtube.com/watch?v=TYMMOjBUPMM" },
                    { 10, "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcSEmZLAmpYpUhwsc79p3-ykHBfMjq8uiudaBMY6uFRtSxurkKyX", "Un ladrón con la habilidad de encogerse de tamaño pero crecer en fuerza debe sacar su héroe interior y ayudar a su mentor a llevar a cabo un plan para salvar al mundo.", "Ant-Man", "https://www.youtube.com/watch?v=pWdKf3MneyI" }
                });

            migrationBuilder.InsertData(
                table: "Salas",
                columns: new[] { "SalaId", "Capacidad" },
                values: new object[,]
                {
                    { 1, 5 },
                    { 2, 15 },
                    { 3, 35 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funciones_PeliculaId",
                table: "Funciones",
                column: "PeliculaId");

            migrationBuilder.CreateIndex(
                name: "IX_Funciones_SalaId",
                table: "Funciones",
                column: "SalaId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_FuncionId",
                table: "Tickets",
                column: "FuncionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Funciones");

            migrationBuilder.DropTable(
                name: "Peliculas");

            migrationBuilder.DropTable(
                name: "Salas");
        }
    }
}
