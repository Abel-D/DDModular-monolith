using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Excellerent.Standard.Advanced.Client.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class gs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Clients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
