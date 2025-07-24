using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BFConfigApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CaseConfigurations",
                columns: table => new
                {
                    ConfigId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TotalCaseNum = table.Column<int>(type: "INTEGER", nullable: false),
                    Linens = table.Column<string>(type: "TEXT", nullable: false),
                    MinCashRange = table.Column<int>(type: "INTEGER", nullable: false),
                    MaxCashRange = table.Column<int>(type: "INTEGER", nullable: false),
                    IsTableTop = table.Column<bool>(type: "INTEGER", nullable: false),
                    selectedInfra = table.Column<int>(type: "INTEGER", nullable: false),
                    ConfigurationName = table.Column<string>(type: "TEXT", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseConfigurations", x => x.ConfigId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    HashedPassword = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "CaseDetails",
                columns: table => new
                {
                    CaseId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CaseType = table.Column<int>(type: "INTEGER", nullable: false),
                    CaseName = table.Column<string>(type: "TEXT", nullable: false),
                    CaseSessionId = table.Column<int>(type: "INTEGER", nullable: false),
                    KeyName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaseDetails", x => x.CaseId);
                    table.ForeignKey(
                        name: "FK_CaseDetails_CaseConfigurations_CaseSessionId",
                        column: x => x.CaseSessionId,
                        principalTable: "CaseConfigurations",
                        principalColumn: "ConfigId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CaseDetails_CaseSessionId",
                table: "CaseDetails",
                column: "CaseSessionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CaseDetails");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "CaseConfigurations");
        }
    }
}
