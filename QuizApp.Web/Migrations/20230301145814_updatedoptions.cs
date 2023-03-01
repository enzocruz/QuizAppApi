using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizApp.Web.Migrations
{
    public partial class updatedoptions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionOptions_Questions_QuestionId",
                table: "QuestionOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Users_UserId",
                table: "Quizzes");

            migrationBuilder.DropForeignKey(
                name: "FK_UserQuestionAnswers_QuestionOptions_QuizOptionId",
                table: "UserQuestionAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserQuestionAnswers_Quizzes_QuestionId",
                table: "UserQuestionAnswers");

            migrationBuilder.DropForeignKey(
                name: "FK_UserQuestionAnswers_Users_UserId",
                table: "UserQuestionAnswers");

            migrationBuilder.DropIndex(
                name: "IX_UserQuestionAnswers_QuestionId",
                table: "UserQuestionAnswers");

            migrationBuilder.DropIndex(
                name: "IX_UserQuestionAnswers_QuizOptionId",
                table: "UserQuestionAnswers");

            migrationBuilder.DropIndex(
                name: "IX_UserQuestionAnswers_UserId",
                table: "UserQuestionAnswers");

            migrationBuilder.DropIndex(
                name: "IX_Quizzes_UserId",
                table: "Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserQuestionAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QuizOptionId",
                table: "UserQuestionAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "UserQuestionAnswers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Quizzes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Quizzes",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c2d5b74-6fa6-4472-8203-e419757d2b18", "AQAAAAEAACcQAAAAEJ5lK2rUvx/fpCXviHDrNpzsWHkWEXfEdaonubcnqVug1/l7zZmXfN5lCqwOjKfdVw==", "0aef036d-ef09-40d6-9563-ad4d2bdcb35c" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25ab6d7e-585f-469e-902b-f60008bdfb03",
                column: "ConcurrencyStamp",
                value: "57c02599-7ef2-49c3-9afc-c630c7fc4454");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "496fff02-4033-4356-a049-ccde482481a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9911b550-e25d-4889-8d72-df82d884e7b7",
                column: "ConcurrencyStamp",
                value: "baf4a37c-e58a-4311-9838-344ae7cf5665");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserQuestionAnswers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QuizOptionId",
                table: "UserQuestionAnswers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "UserQuestionAnswers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Quizzes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Quizzes",
                keyColumn: "Description",
                keyValue: null,
                column: "Description",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Quizzes",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d3bfc80-e2f8-4792-b4cf-df7afd3f6726", "AQAAAAEAACcQAAAAEPvt1C0rzdi42p1spq52CwT1mGWpUETGOtcpTb+Lgu0tWMNddfaHhQRZSLQxSxTs9A==", "56678a07-c694-4e42-8f29-21de19da0997" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25ab6d7e-585f-469e-902b-f60008bdfb03",
                column: "ConcurrencyStamp",
                value: "90cd984e-86c0-41d9-a6e5-557ea3c63679");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c5e174e-3b0e-446f-86af-483d56fd7210",
                column: "ConcurrencyStamp",
                value: "e28554a1-cd3c-4871-8cfb-30dda1e7b844");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9911b550-e25d-4889-8d72-df82d884e7b7",
                column: "ConcurrencyStamp",
                value: "715b898d-c444-450c-926c-81523a139aba");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuestionAnswers_QuestionId",
                table: "UserQuestionAnswers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuestionAnswers_QuizOptionId",
                table: "UserQuestionAnswers",
                column: "QuizOptionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuestionAnswers_UserId",
                table: "UserQuestionAnswers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_UserId",
                table: "Quizzes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionOptions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionOptions_Questions_QuestionId",
                table: "QuestionOptions",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_Users_UserId",
                table: "Quizzes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserQuestionAnswers_QuestionOptions_QuizOptionId",
                table: "UserQuestionAnswers",
                column: "QuizOptionId",
                principalTable: "QuestionOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserQuestionAnswers_Quizzes_QuestionId",
                table: "UserQuestionAnswers",
                column: "QuestionId",
                principalTable: "Quizzes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserQuestionAnswers_Users_UserId",
                table: "UserQuestionAnswers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}
