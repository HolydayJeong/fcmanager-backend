﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace fc_manager_backend_da.Migrations
{
    public partial class Added_ScoreMemberId_AssistMemberId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchRecords_Members_AssistBy",
                table: "MatchRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchRecords_Members_ScoreBy",
                table: "MatchRecords");

            migrationBuilder.DropIndex(
                name: "IX_MatchRecords_AssistBy",
                table: "MatchRecords");

            migrationBuilder.DropIndex(
                name: "IX_MatchRecords_ScoreBy",
                table: "MatchRecords");

            migrationBuilder.DropColumn(
                name: "AssistBy",
                table: "MatchRecords");

            migrationBuilder.DropColumn(
                name: "ScoreBy",
                table: "MatchRecords");

            migrationBuilder.AddColumn<int>(
                name: "AssistMemberId",
                table: "MatchRecords",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ScoreMemberId",
                table: "MatchRecords",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MatchRecords_AssistMemberId",
                table: "MatchRecords",
                column: "AssistMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchRecords_ScoreMemberId",
                table: "MatchRecords",
                column: "ScoreMemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchRecords_Members_AssistMemberId",
                table: "MatchRecords",
                column: "AssistMemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchRecords_Members_ScoreMemberId",
                table: "MatchRecords",
                column: "ScoreMemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MatchRecords_Members_AssistMemberId",
                table: "MatchRecords");

            migrationBuilder.DropForeignKey(
                name: "FK_MatchRecords_Members_ScoreMemberId",
                table: "MatchRecords");

            migrationBuilder.DropIndex(
                name: "IX_MatchRecords_AssistMemberId",
                table: "MatchRecords");

            migrationBuilder.DropIndex(
                name: "IX_MatchRecords_ScoreMemberId",
                table: "MatchRecords");

            migrationBuilder.DropColumn(
                name: "AssistMemberId",
                table: "MatchRecords");

            migrationBuilder.DropColumn(
                name: "ScoreMemberId",
                table: "MatchRecords");

            migrationBuilder.AddColumn<int>(
                name: "AssistBy",
                table: "MatchRecords",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ScoreBy",
                table: "MatchRecords",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MatchRecords_AssistBy",
                table: "MatchRecords",
                column: "AssistBy");

            migrationBuilder.CreateIndex(
                name: "IX_MatchRecords_ScoreBy",
                table: "MatchRecords",
                column: "ScoreBy");

            migrationBuilder.AddForeignKey(
                name: "FK_MatchRecords_Members_AssistBy",
                table: "MatchRecords",
                column: "AssistBy",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MatchRecords_Members_ScoreBy",
                table: "MatchRecords",
                column: "ScoreBy",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
