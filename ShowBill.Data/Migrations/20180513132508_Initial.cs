using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ShowBill.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Places",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Places", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exhibitions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<double>(nullable: true),
                    Descriprion = table.Column<string>(nullable: true),
                    EndDate = table.Column<DateTime>(nullable: false),
                    PlaceId = table.Column<int>(nullable: true),
                    Raiting = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exhibitions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exhibitions_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<double>(nullable: true),
                    Descriprion = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    PlaceId = table.Column<int>(nullable: true),
                    Raiting = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Performances",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<double>(nullable: true),
                    Descriprion = table.Column<string>(nullable: true),
                    Director = table.Column<string>(nullable: true),
                    PlaceId = table.Column<int>(nullable: true),
                    Raiting = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Performances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Performances_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<double>(nullable: true),
                    Descriprion = table.Column<string>(nullable: true),
                    PlaceId = table.Column<int>(nullable: true),
                    Raiting = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sport_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MovieId = table.Column<int>(nullable: true),
                    MovieId1 = table.Column<int>(nullable: true),
                    MovieId2 = table.Column<int>(nullable: true),
                    MovieId3 = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    PerformanceId = table.Column<int>(nullable: true),
                    PerformanceId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Movies_MovieId1",
                        column: x => x.MovieId1,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Movies_MovieId2",
                        column: x => x.MovieId2,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Movies_MovieId3",
                        column: x => x.MovieId3,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Performances_PerformanceId",
                        column: x => x.PerformanceId,
                        principalTable: "Performances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Performances_PerformanceId1",
                        column: x => x.PerformanceId1,
                        principalTable: "Performances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DateTime = table.Column<DateTime>(nullable: false),
                    MovieId = table.Column<int>(nullable: true),
                    SportId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dates_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dates_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Concerts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cost = table.Column<double>(nullable: true),
                    DateId = table.Column<int>(nullable: true),
                    Descriprion = table.Column<string>(nullable: true),
                    PlaceId = table.Column<int>(nullable: true),
                    Raiting = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concerts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Concerts_Dates_DateId",
                        column: x => x.DateId,
                        principalTable: "Dates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Concerts_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConcertId = table.Column<int>(nullable: true),
                    ExhibitionId = table.Column<int>(nullable: true),
                    MovieId = table.Column<int>(nullable: true),
                    PerformanceId = table.Column<int>(nullable: true),
                    SportId = table.Column<int>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Photos_Concerts_ConcertId",
                        column: x => x.ConcertId,
                        principalTable: "Concerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Photos_Exhibitions_ExhibitionId",
                        column: x => x.ExhibitionId,
                        principalTable: "Exhibitions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Photos_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Photos_Performances_PerformanceId",
                        column: x => x.PerformanceId,
                        principalTable: "Performances",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Photos_Sport_SportId",
                        column: x => x.SportId,
                        principalTable: "Sport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Concerts_DateId",
                table: "Concerts",
                column: "DateId");

            migrationBuilder.CreateIndex(
                name: "IX_Concerts_PlaceId",
                table: "Concerts",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_MovieId",
                table: "Dates",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Dates_SportId",
                table: "Dates",
                column: "SportId");

            migrationBuilder.CreateIndex(
                name: "IX_Exhibitions_PlaceId",
                table: "Exhibitions",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_PlaceId",
                table: "Movies",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Performances_PlaceId",
                table: "Performances",
                column: "PlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MovieId",
                table: "Persons",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MovieId1",
                table: "Persons",
                column: "MovieId1");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MovieId2",
                table: "Persons",
                column: "MovieId2");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_MovieId3",
                table: "Persons",
                column: "MovieId3");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PerformanceId",
                table: "Persons",
                column: "PerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_PerformanceId1",
                table: "Persons",
                column: "PerformanceId1");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ConcertId",
                table: "Photos",
                column: "ConcertId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ExhibitionId",
                table: "Photos",
                column: "ExhibitionId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_MovieId",
                table: "Photos",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_PerformanceId",
                table: "Photos",
                column: "PerformanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_SportId",
                table: "Photos",
                column: "SportId");

            migrationBuilder.CreateIndex(
                name: "IX_Sport_PlaceId",
                table: "Sport",
                column: "PlaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Concerts");

            migrationBuilder.DropTable(
                name: "Exhibitions");

            migrationBuilder.DropTable(
                name: "Performances");

            migrationBuilder.DropTable(
                name: "Dates");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Sport");

            migrationBuilder.DropTable(
                name: "Places");
        }
    }
}
