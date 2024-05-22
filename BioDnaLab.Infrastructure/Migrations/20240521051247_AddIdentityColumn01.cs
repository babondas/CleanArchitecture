using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BioDnaLab.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityColumn01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    PrimaryContactNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    SecondaryContactNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestMethodology",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestMethodologyName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestMethodology", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestReport",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestReportName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestReport", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestSample",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestSampleName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSample", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestSchedule",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestScheduleName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSchedule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestStorage",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestStorageName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestStorage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestVolume",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestVolumeName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestVolume", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    RefTestMethodologyId = table.Column<long>(type: "bigint", nullable: true),
                    RefTestSampleId = table.Column<long>(type: "bigint", nullable: true),
                    RefTestVolumeId = table.Column<long>(type: "bigint", nullable: true),
                    RefTestStorageId = table.Column<long>(type: "bigint", nullable: true),
                    RefTestScheduleId = table.Column<long>(type: "bigint", nullable: true),
                    RefTestReportId = table.Column<long>(type: "bigint", nullable: true),
                    MRP = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TestPriceDiscount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    TestPriceDiscountInPercent = table.Column<int>(type: "int", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Test_TestMethodology_RefTestMethodologyId",
                        column: x => x.RefTestMethodologyId,
                        principalTable: "TestMethodology",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Test_TestReport_RefTestReportId",
                        column: x => x.RefTestReportId,
                        principalTable: "TestReport",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Test_TestSample_RefTestSampleId",
                        column: x => x.RefTestSampleId,
                        principalTable: "TestSample",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Test_TestSchedule_RefTestScheduleId",
                        column: x => x.RefTestScheduleId,
                        principalTable: "TestSchedule",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Test_TestStorage_RefTestStorageId",
                        column: x => x.RefTestStorageId,
                        principalTable: "TestStorage",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Test_TestVolume_RefTestVolumeId",
                        column: x => x.RefTestVolumeId,
                        principalTable: "TestVolume",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TestPackage",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefTestPackageFirstNameId = table.Column<long>(type: "bigint", nullable: true),
                    TestPackageSecondName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    MRP = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    OfferPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestPackage", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TestPackageFirstName",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TestPackageFirstName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    TestPackageEntityId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedBy = table.Column<long>(type: "bigint", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestPackageFirstName", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TestPackageFirstName_TestPackage_TestPackageEntityId",
                        column: x => x.TestPackageEntityId,
                        principalTable: "TestPackage",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Test_RefTestMethodologyId",
                table: "Test",
                column: "RefTestMethodologyId",
                unique: true,
                filter: "[RefTestMethodologyId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Test_RefTestReportId",
                table: "Test",
                column: "RefTestReportId",
                unique: true,
                filter: "[RefTestReportId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Test_RefTestSampleId",
                table: "Test",
                column: "RefTestSampleId",
                unique: true,
                filter: "[RefTestSampleId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Test_RefTestScheduleId",
                table: "Test",
                column: "RefTestScheduleId",
                unique: true,
                filter: "[RefTestScheduleId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Test_RefTestStorageId",
                table: "Test",
                column: "RefTestStorageId",
                unique: true,
                filter: "[RefTestStorageId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Test_RefTestVolumeId",
                table: "Test",
                column: "RefTestVolumeId",
                unique: true,
                filter: "[RefTestVolumeId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TestPackage_RefTestPackageFirstNameId",
                table: "TestPackage",
                column: "RefTestPackageFirstNameId",
                unique: true,
                filter: "[RefTestPackageFirstNameId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TestPackageFirstName_TestPackageEntityId",
                table: "TestPackageFirstName",
                column: "TestPackageEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestPackage_TestPackageFirstName_RefTestPackageFirstNameId",
                table: "TestPackage",
                column: "RefTestPackageFirstNameId",
                principalTable: "TestPackageFirstName",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestPackage_TestPackageFirstName_RefTestPackageFirstNameId",
                table: "TestPackage");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropTable(
                name: "TestMethodology");

            migrationBuilder.DropTable(
                name: "TestReport");

            migrationBuilder.DropTable(
                name: "TestSample");

            migrationBuilder.DropTable(
                name: "TestSchedule");

            migrationBuilder.DropTable(
                name: "TestStorage");

            migrationBuilder.DropTable(
                name: "TestVolume");

            migrationBuilder.DropTable(
                name: "TestPackageFirstName");

            migrationBuilder.DropTable(
                name: "TestPackage");
        }
    }
}
