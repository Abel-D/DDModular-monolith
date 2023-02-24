using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Excellerent.Standard.Advanced.Shared.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class modelmodifiato : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AffectedColumns",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "NewValues",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "OldValues",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "PrimaryKey",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "TableName",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Clients");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AffectedColumns",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTime",
                table: "Clients",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NewValues",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OldValues",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PrimaryKey",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TableName",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Clients",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
