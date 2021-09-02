using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SQLiteSample.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserReferencesMetadata",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Metadata = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReferencesMetadata", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserReferencesData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MetadataId = table.Column<int>(type: "INTEGER", nullable: false),
                    RowId = table.Column<int>(type: "INTEGER", nullable: false),
                    ColumnId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ColumnType = table.Column<int>(type: "INTEGER", nullable: false),
                    DateValue = table.Column<DateTime>(type: "TEXT", nullable: true),
                    StringValue = table.Column<string>(type: "TEXT", nullable: true),
                    IntValue = table.Column<int>(type: "INTEGER", nullable: true),
                    DoubleValue = table.Column<double>(type: "REAL", nullable: true),
                    BoolValue = table.Column<bool>(type: "INTEGER", nullable: true),
                    DecimalValue = table.Column<decimal>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserReferencesData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserReferencesData_UserReferencesMetadata_MetadataId",
                        column: x => x.MetadataId,
                        principalTable: "UserReferencesMetadata",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserReferencesData_MetadataId",
                table: "UserReferencesData",
                column: "MetadataId");

            migrationBuilder.CreateIndex(
                name: "IX_UserReferencesData_RowId",
                table: "UserReferencesData",
                column: "RowId");

            var sql = "insert into UserReferencesMetadata(Id, Name) values (-1,'Meta1');" +
                "insert into UserReferencesMetadata(Id, Name) values (-2,'Meta2');";
            migrationBuilder.Sql(sql);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserReferencesData");

            migrationBuilder.DropTable(
                name: "UserReferencesMetadata");
        }
    }
}
