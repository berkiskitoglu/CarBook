using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarBook.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class tagcloud_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagClouds_Blogs_BlogId",
                table: "TagClouds");

            migrationBuilder.RenameColumn(
                name: "BlogId",
                table: "TagClouds",
                newName: "BlogID");

            migrationBuilder.RenameIndex(
                name: "IX_TagClouds_BlogId",
                table: "TagClouds",
                newName: "IX_TagClouds_BlogID");

            migrationBuilder.AddForeignKey(
                name: "FK_TagClouds_Blogs_BlogID",
                table: "TagClouds",
                column: "BlogID",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TagClouds_Blogs_BlogID",
                table: "TagClouds");

            migrationBuilder.RenameColumn(
                name: "BlogID",
                table: "TagClouds",
                newName: "BlogId");

            migrationBuilder.RenameIndex(
                name: "IX_TagClouds_BlogID",
                table: "TagClouds",
                newName: "IX_TagClouds_BlogId");

            migrationBuilder.AddForeignKey(
                name: "FK_TagClouds_Blogs_BlogId",
                table: "TagClouds",
                column: "BlogId",
                principalTable: "Blogs",
                principalColumn: "BlogID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
