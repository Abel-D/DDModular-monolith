using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Excellerent.Standard.Advanced.Client.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class secondtrial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Clients",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Clients",
                newName: "description");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AffectedColumns",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Name",
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

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Clients",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Clients",
                newName: "Description");

            migrationBuilder.AddColumn<Guid>(
                name: "ClientId",
                table: "Clients",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}
