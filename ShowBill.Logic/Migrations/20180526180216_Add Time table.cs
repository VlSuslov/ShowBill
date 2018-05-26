using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShowBill.Logic.Migrations
{
    public partial class AddTimetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DurationId",
                table: "Sport",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DurationId",
                table: "Performances",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DurationId",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DurationId",
                table: "Exhibitions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DurationId",
                table: "Concerts",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Time",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConcertId = table.Column<Guid>(nullable: true),
                    ExhibitionId = table.Column<Guid>(nullable: true),
                    MovieId = table.Column<Guid>(nullable: true),
                    PerformanceId = table.Column<Guid>(nullable: true),
                    SportId = table.Column<Guid>(nullable: true),
                    Time = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Time", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Time_Concerts_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Time_Exhibitions_ExhibitionId",
                        column: x => x.ExhibitionId,
                        principalTable: "Exhibitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Time_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Time_Performances_PerformanceId",
                        column: x => x.PerformanceId,
                        principalTable: "Performances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Time_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sport_DurationId",
                table: "Sport",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_DurationId",
                table: "Performances",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DurationId",
                table: "Movies",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Exhibitions_DurationId",
                table: "Exhibitions",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Concerts_DurationId",
                table: "Concerts",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Time_ConcertId",
                table: "Time",
                column: "ConcertId");

            migrationBuilder.CreateIndex(
                name: "IX_Time_ExhibitionId",
                table: "Time",
                column: "ExhibitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Time_MovieId",
                table: "Time",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Time_PerformanceId",
                table: "Time",
                column: "PerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Time_SportId",
                table: "Time",
                column: "SportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Concerts_Time_DurationId",
                table: "Concerts",
                column: "DurationId",
                principalTable: "Time",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exhibitions_Time_DurationId",
                table: "Exhibitions",
                column: "DurationId",
                principalTable: "Time",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Time_DurationId",
                table: "Movies",
                column: "DurationId",
                principalTable: "Time",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Performances_Time_DurationId",
                table: "Performances",
                column: "DurationId",
                principalTable: "Time",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sport_Time_DurationId",
                table: "Sport",
                column: "DurationId",
                principalTable: "Time",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Concerts_Time_DurationId",
                table: "Concerts");

            migrationBuilder.DropForeignKey(
                name: "FK_Exhibitions_Time_DurationId",
                table: "Exhibitions");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Time_DurationId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Performances_Time_DurationId",
                table: "Performances");

            migrationBuilder.DropForeignKey(
                name: "FK_Sport_Time_DurationId",
                table: "Sport");

            migrationBuilder.DropTable(
                name: "Time");

            migrationBuilder.DropIndex(
                name: "IX_Sport_DurationId",
                table: "Sport");

            migrationBuilder.DropIndex(
                name: "IX_Performances_DurationId",
                table: "Performances");

            migrationBuilder.DropIndex(
                name: "IX_Movies_DurationId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Exhibitions_DurationId",
                table: "Exhibitions");

            migrationBuilder.DropIndex(
                name: "IX_Concerts_DurationId",
                table: "Concerts");

            migrationBuilder.DropColumn(
                name: "DurationId",
                table: "Sport");

            migrationBuilder.DropColumn(
                name: "DurationId",
                table: "Performances");

            migrationBuilder.DropColumn(
                name: "DurationId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "DurationId",
                table: "Exhibitions");

            migrationBuilder.DropColumn(
                name: "DurationId",
                table: "Concerts");
        }
    }
}
