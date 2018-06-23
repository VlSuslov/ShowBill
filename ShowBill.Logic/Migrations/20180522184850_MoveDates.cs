using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShowBill.Data.Migrations
{
    public partial class MoveDates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Concerts_Dates_DateId",
                table: "Concerts");

            migrationBuilder.DropIndex(
                name: "IX_Concerts_DateId",
                table: "Concerts");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Exhibitions");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Exhibitions");

            migrationBuilder.DropColumn(
                name: "DateId",
                table: "Concerts");

            migrationBuilder.AddColumn<Guid>(
                name: "ConcertId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ExhibitionId",
                table: "Persons",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "Performances",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DirectorId",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ConcertId",
                table: "Dates",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ExhibitionId",
                table: "Dates",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PerformanceId",
                table: "Dates",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ConcertId",
                table: "Persons",
                column: "ConcertId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_ExhibitionId",
                table: "Persons",
                column: "ExhibitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_DirectorId",
                table: "Performances",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DirectorId",
                table: "Movies",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_ConcertId",
                table: "Dates",
                column: "ConcertId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_ExhibitionId",
                table: "Dates",
                column: "ExhibitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_PerformanceId",
                table: "Dates",
                column: "PerformanceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Concerts_ConcertId",
                table: "Dates",
                column: "ConcertId",
                principalTable: "Concerts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Exhibitions_ExhibitionId",
                table: "Dates",
                column: "ExhibitionId",
                principalTable: "Exhibitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Dates_Performances_PerformanceId",
                table: "Dates",
                column: "PerformanceId",
                principalTable: "Performances",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Persons_DirectorId",
                table: "Movies",
                column: "DirectorId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Persons_DirectorId",
                table: "Performances",
                column: "DirectorId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Concerts_ConcertId",
                table: "Persons",
                column: "ConcertId",
                principalTable: "Concerts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Persons_Exhibitions_ExhibitionId",
                table: "Persons",
                column: "ExhibitionId",
                principalTable: "Exhibitions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Concerts_ConcertId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Exhibitions_ExhibitionId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Dates_Performances_PerformanceId",
                table: "Dates");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Persons_DirectorId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Persons_DirectorId",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Concerts_ConcertId",
                table: "Persons");

            migrationBuilder.DropForeignKey(
                name: "FK_Persons_Exhibitions_ExhibitionId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ConcertId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Persons_ExhibitionId",
                table: "Persons");

            migrationBuilder.DropIndex(
                name: "IX_Performances_DirectorId",
                table: "Performances");

            migrationBuilder.DropIndex(
                name: "IX_Movies_DirectorId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Dates_ConcertId",
                table: "Dates");

            migrationBuilder.DropIndex(
                name: "IX_Dates_ExhibitionId",
                table: "Dates");

            migrationBuilder.DropIndex(
                name: "IX_Dates_PerformanceId",
                table: "Dates");

            migrationBuilder.DropColumn(
                name: "ConcertId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "ExhibitionId",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "DirectorId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "ConcertId",
                table: "Dates");

            migrationBuilder.DropColumn(
                name: "ExhibitionId",
                table: "Dates");

            migrationBuilder.DropColumn(
                name: "PerformanceId",
                table: "Dates");

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Performances",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Exhibitions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Exhibitions",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DateId",
                table: "Concerts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Concerts_DateId",
                table: "Concerts",
                column: "DateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Concerts_Dates_DateId",
                table: "Concerts",
                column: "DateId",
                principalTable: "Dates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
