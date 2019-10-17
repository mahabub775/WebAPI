using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Trade = table.Column<int>(type: "varchar(10)", nullable: false),
                    Lavel = table.Column<int>(type: "varchar(10)", nullable: false),
                    Language = table.Column<int>(type: "varchar(100)", nullable: false),
                    SyllabusName = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    SyllabusFile = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    TestPlanFile = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    DeptOffName = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    ManagerName = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    ActiveDate = table.Column<DateTime>(type: "DateTime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
