using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TCD.Migrations
{
    /// <inheritdoc />
    public partial class MigrationInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pergunta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Texto = table.Column<string>(type: "TEXT", nullable: true),
                    Selecionado = table.Column<int>(type: "INTEGER", nullable: false),
                    NumAvaliacoes = table.Column<int>(type: "INTEGER", nullable: false),
                    Avaliacao = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pergunta", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pergunta",
                columns: new[] { "Id", "Avaliacao", "NumAvaliacoes", "Selecionado", "Texto" },
                values: new object[,]
                {
                    { 1, 0.0, 0, 0, "Como você avaliaria a competência e o comprometimento dos professores?" },
                    { 2, 0.0, 0, 0, "As atividades práticas e teóricas das disciplinas do curso são equilibradas de maneira eficaz?" },
                    { 3, 0.0, 0, 0, "A instituição oferece recursos tecnológicos adequados para apoiar o aprendizado?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pergunta");
        }
    }
}
