using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP_NET__INMN3_hybryda__PA2_Z1.Migrations
{
    /// <inheritdoc />
    public partial class NowaKolumna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Państwo",
                table: "Miasta",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Państwo",
                table: "Miasta");
        }
    }
}
