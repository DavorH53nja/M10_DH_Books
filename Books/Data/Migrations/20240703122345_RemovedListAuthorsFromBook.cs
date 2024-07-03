using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedListAuthorsFromBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Author_Books_BookId",
                table: "Author");

            migrationBuilder.DropIndex(
                name: "IX_Author_BookId",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Author");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Author",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Author_BookId",
                table: "Author",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Author_Books_BookId",
                table: "Author",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");
        }
    }
}
