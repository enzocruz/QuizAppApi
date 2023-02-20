using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApp.Web.Migrations
{
    public partial class added_new_models3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuizOpt",
                table: "QuestionOptions",
                newName: "QuestionOpt");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QuestionOpt",
                table: "QuestionOptions",
                newName: "QuizOpt");
        }
    }
}
