using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace C_ManagementSystem.Migrations
{
    public partial class InitialDBCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactModels",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    DateRegistered = table.Column<DateTime>(nullable: false),
                    CompanyName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactModels", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "FrameLensModels",
                columns: table => new
                {
                    WoID = table.Column<string>(nullable: false),
                    FrameDesc = table.Column<string>(nullable: true),
                    LensType = table.Column<string>(nullable: true),
                    LensMaterial = table.Column<string>(nullable: true),
                    LensAddOn = table.Column<string>(nullable: true),
                    LensCost = table.Column<string>(nullable: true),
                    FrameCost = table.Column<string>(nullable: true),
                    Discount = table.Column<string>(nullable: true),
                    Total = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FrameLensModels", x => x.WoID);
                });

            migrationBuilder.CreateTable(
                name: "JobModels",
                columns: table => new
                {
                    JobID = table.Column<string>(nullable: false),
                    NYSTax = table.Column<bool>(nullable: false),
                    Lab = table.Column<string>(nullable: true),
                    JobDesc = table.Column<string>(nullable: true),
                    JobDate = table.Column<DateTime>(nullable: false),
                    FrameDesc = table.Column<string>(nullable: true),
                    Subtotal = table.Column<float>(nullable: false),
                    Discount = table.Column<float>(nullable: false),
                    Total = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobModels", x => x.JobID);
                });

            migrationBuilder.CreateTable(
                name: "RxModels",
                columns: table => new
                {
                    RxID = table.Column<string>(nullable: false),
                    ODSph = table.Column<string>(nullable: true),
                    ODCyl = table.Column<string>(nullable: true),
                    ODAxis = table.Column<string>(nullable: true),
                    OSSph = table.Column<string>(nullable: true),
                    OSCyl = table.Column<string>(nullable: true),
                    OSAxis = table.Column<string>(nullable: true),
                    PatientPD = table.Column<string>(nullable: true),
                    Height = table.Column<string>(nullable: true),
                    AddPower = table.Column<string>(nullable: true),
                    TextNotes = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RxModels", x => x.RxID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactModels");

            migrationBuilder.DropTable(
                name: "FrameLensModels");

            migrationBuilder.DropTable(
                name: "JobModels");

            migrationBuilder.DropTable(
                name: "RxModels");
        }
    }
}
