using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebVehicle.Migrations
{
    /// <inheritdoc />
    public partial class InitialDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ms_storage_location",
                columns: table => new
                {
                    LocationId = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LocationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ms_storage_location", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "tr_bpkb",
                columns: table => new
                {
                    AgreementNumber = table.Column<string>(name: "Agreement_Number", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BpkbNo = table.Column<string>(name: "Bpkb_No", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BranchId = table.Column<string>(name: "Branch_Id", type: "nvarchar(10)", maxLength: 10, nullable: false),
                    BpkbDate = table.Column<DateTime>(name: "Bpkb_Date", type: "datetime", nullable: false),
                    FakturNo = table.Column<string>(name: "Faktur_No", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FakturDate = table.Column<DateTime>(name: "Faktur_Date", type: "datetime", nullable: false),
                    LocationId = table.Column<string>(name: "Location_Id", type: "nvarchar(10)", maxLength: 10, nullable: false),
                    PoliceNo = table.Column<string>(name: "Police_No", type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BpkbDateIn = table.Column<DateTime>(name: "Bpkb_Date_In", type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tr_bpkb", x => x.AgreementNumber);
                    table.ForeignKey(
                        name: "FK_tr_bpkb_ms_storage_location_Location_Id",
                        column: x => x.LocationId,
                        principalTable: "ms_storage_location",
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tr_bpkb_Location_Id",
                table: "tr_bpkb",
                column: "Location_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tr_bpkb");

            migrationBuilder.DropTable(
                name: "ms_storage_location");
        }
    }
}
