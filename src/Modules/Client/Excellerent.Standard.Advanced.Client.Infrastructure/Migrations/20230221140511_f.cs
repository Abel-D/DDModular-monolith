using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Excellerent.Standard.Advanced.Client.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class f : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Clients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
