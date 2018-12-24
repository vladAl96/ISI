using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ISIPISI.Migrations
{
    public partial class AreaReport : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    AreaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PH = table.Column<double>(nullable: false),
                    PollutionPercentage = table.Column<double>(nullable: false),
                    NocSubsQTTY = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.AreaId);
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    EventReportId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    areaId = table.Column<int>(nullable: false),
                    reporterUsername = table.Column<string>(nullable: true),
                    ReportDate = table.Column<string>(nullable: true),
                    reportDescription = table.Column<string>(nullable: false),
                    PHChange = table.Column<double>(nullable: false),
                    PollutionPercentageChange = table.Column<double>(nullable: false),
                    NocSubsQTYChange = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.EventReportId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Reports");
        }
    }
}
