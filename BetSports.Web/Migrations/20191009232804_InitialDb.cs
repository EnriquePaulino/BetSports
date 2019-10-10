using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BetSports.Web.Migrations
{
    public partial class InitialDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bankings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Document = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Owner = table.Column<int>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    MinutesCancelTicket = table.Column<int>(nullable: false),
                    MaximumTicketsCancelDay = table.Column<int>(nullable: false),
                    MinimumTicketAmount = table.Column<decimal>(nullable: false),
                    MinimumPlaysBuyPoints = table.Column<int>(nullable: false),
                    DailySaleLimit = table.Column<int>(nullable: false),
                    DeactivationBalance = table.Column<int>(nullable: false),
                    MinimumPlaysFuture = table.Column<int>(nullable: false),
                    MultiPlayMoneyLine = table.Column<decimal>(nullable: false),
                    Active = table.Column<bool>(nullable: false),
                    ToPrint = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bankings", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bankings");
        }
    }
}
