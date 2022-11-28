using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoJudo.Infra.Migrations
{
    public partial class ChangingSenha : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SENHA",
                table: "TB_USUARIOS",
                type: "varchar(254)",
                unicode: false,
                maxLength: 254,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(255)",
                oldUnicode: false,
                oldMaxLength: 255);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SENHA",
                table: "TB_USUARIOS",
                type: "varchar(255)",
                unicode: false,
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(254)",
                oldUnicode: false,
                oldMaxLength: 254);
        }
    }
}
