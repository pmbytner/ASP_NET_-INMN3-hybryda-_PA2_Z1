using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_NET__INMN3_hybryda__PA2_Z1.Migrations
{
    /// <inheritdoc />
    public partial class KorektaNazwyTabeliMiasta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Miasto",
                table: "Miasto");

            migrationBuilder.RenameTable(
                name: "Miasto",
                newName: "Miasta");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Miasta",
                table: "Miasta",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Miasta",
                table: "Miasta");

            migrationBuilder.RenameTable(
                name: "Miasta",
                newName: "Miasto");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Miasto",
                table: "Miasto",
                column: "Id");
        }
    }
}
