﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StarCitizen.eShop.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Update_Satellite_AddParentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ParentId",
                table: "Satellite",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentId",
                table: "Satellite");
        }
    }
}
