using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace daraz.Migrations
{
    /// <inheritdoc />
    public partial class sssp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Block",
                columns: table => new
                {
                    Block_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Block_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Block_Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Block_Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Suggestions = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Block", x => x.Block_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Block");
        }
    }
}
