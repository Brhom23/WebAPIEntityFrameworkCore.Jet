using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAPIEntityFrameworkCoreJet.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MName",
                table: "TodoItems",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(155)",
                oldMaxLength: 155,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MName",
                table: "TodoItems",
                type: "varchar(155)",
                maxLength: 155,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 150,
                oldNullable: true);
        }
    }
}
