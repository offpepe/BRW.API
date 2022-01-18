﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BRW.API.Migrations
{
    public partial class fkTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "role",
                table: "users");

            migrationBuilder.AddColumn<int>(
                name: "caster_championship_id",
                table: "users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "mvp_caster_championship_id",
                table: "users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_users_caster_championship_id",
                table: "users",
                column: "caster_championship_id");

            migrationBuilder.CreateIndex(
                name: "ix_users_mvp_caster_championship_id",
                table: "users",
                column: "mvp_caster_championship_id");

            migrationBuilder.AddForeignKey(
                name: "fk_users_championship_caster_championship_id",
                table: "users",
                column: "caster_championship_id",
                principalTable: "championship",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "fk_users_championship_mvp_caster_championship_id",
                table: "users",
                column: "mvp_caster_championship_id",
                principalTable: "championship",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_users_championship_caster_championship_id",
                table: "users");

            migrationBuilder.DropForeignKey(
                name: "fk_users_championship_mvp_caster_championship_id",
                table: "users");

            migrationBuilder.DropIndex(
                name: "ix_users_caster_championship_id",
                table: "users");

            migrationBuilder.DropIndex(
                name: "ix_users_mvp_caster_championship_id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "caster_championship_id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "mvp_caster_championship_id",
                table: "users");

            migrationBuilder.AddColumn<char>(
                name: "role",
                table: "users",
                type: "character(1)",
                nullable: false,
                defaultValue: ' ');
        }
    }
}
