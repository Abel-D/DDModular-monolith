using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Excellerent.Standard.Advanced.Client.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "name",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Clients",
                newName: "Description");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Clients",
                newName: "description");

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
