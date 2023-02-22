using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Excellerent.Standard.Advanced.Client.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class df : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Clients",
                newName: "description");

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

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Clients",
                newName: "Description");
        }
    }
}
