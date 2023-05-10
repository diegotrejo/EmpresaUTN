using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaUTN.API.Migrations
{
    /// <inheritdoc />
    public partial class v02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cantones_Provincias_ProvinciaId",
                table: "Cantones");

            migrationBuilder.DropForeignKey(
                name: "FK_Provincias_Paises_PaisCodigoPais",
                table: "Provincias");

            migrationBuilder.AlterColumn<int>(
                name: "PaisCodigoPais",
                table: "Provincias",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ProvinciaId",
                table: "Cantones",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddForeignKey(
                name: "FK_Cantones_Provincias_ProvinciaId",
                table: "Cantones",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Provincias_Paises_PaisCodigoPais",
                table: "Provincias",
                column: "PaisCodigoPais",
                principalTable: "Paises",
                principalColumn: "CodigoPais");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cantones_Provincias_ProvinciaId",
                table: "Cantones");

            migrationBuilder.DropForeignKey(
                name: "FK_Provincias_Paises_PaisCodigoPais",
                table: "Provincias");

            migrationBuilder.AlterColumn<int>(
                name: "PaisCodigoPais",
                table: "Provincias",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProvinciaId",
                table: "Cantones",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cantones_Provincias_ProvinciaId",
                table: "Cantones",
                column: "ProvinciaId",
                principalTable: "Provincias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provincias_Paises_PaisCodigoPais",
                table: "Provincias",
                column: "PaisCodigoPais",
                principalTable: "Paises",
                principalColumn: "CodigoPais",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
