using Microsoft.EntityFrameworkCore.Migrations;

namespace Murad.Api.CQRSandMediatorPattern.Migrations
{
    public partial class NewCQRSMediatorDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Group", "Name", "Surname" },
                values: new object[,]
                {
                    { 1, 21, "M652A2", "Murad", "Aliyev" },
                    { 2, 21, "N674", "Parviz", "Yunisli" },
                    { 3, 21, "M455", "Khuraman", "Taghizadeh" },
                    { 4, 21, "mM652A2", "Elshad", "Babayev" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
