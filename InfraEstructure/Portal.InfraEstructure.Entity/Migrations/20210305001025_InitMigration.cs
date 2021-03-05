using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Portal.InfraEstructure.Entity.Migrations
{
    public partial class InitMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Enable = table.Column<bool>(type: "boolean", nullable: false),
                    ClientId = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    ProtocolType = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    ClientName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    LogoClientUri = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    AcessTokenLifetime = table.Column<int>(type: "integer", nullable: false),
                    TokenLifetime = table.Column<int>(type: "integer", nullable: false),
                    ClientType = table.Column<string>(type: "text", nullable: false),
                    ClientUri = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ClientScopes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ScopeLabel = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    IdClient = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientScopes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClientScopes_Clients_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CorsOrigins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Uri = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    IdClient = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorsOrigins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorsOrigins_Clients_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RedirectLogouts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Uri = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    IdClient = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedirectLogouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RedirectLogouts_Clients_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RedirectUris",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Uri = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    IdClient = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RedirectUris", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RedirectUris_Clients_IdClient",
                        column: x => x.IdClient,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientScopes_IdClient",
                table: "ClientScopes",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_CorsOrigins_IdClient",
                table: "CorsOrigins",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_RedirectLogouts_IdClient",
                table: "RedirectLogouts",
                column: "IdClient");

            migrationBuilder.CreateIndex(
                name: "IX_RedirectUris_IdClient",
                table: "RedirectUris",
                column: "IdClient");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientScopes");

            migrationBuilder.DropTable(
                name: "CorsOrigins");

            migrationBuilder.DropTable(
                name: "RedirectLogouts");

            migrationBuilder.DropTable(
                name: "RedirectUris");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
