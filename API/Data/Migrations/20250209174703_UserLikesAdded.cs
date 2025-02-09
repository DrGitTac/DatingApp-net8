using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserLikesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // migrationBuilder.DropForeignKey(
            //     name: "FK_Photos_Users_AppUserId",
            //     table: "Photos");

            // migrationBuilder.DropPrimaryKey(
            //     name: "PK_Photos",
            //     table: "Photos");

            // migrationBuilder.RenameTable(
            //     name: "Photos",
            //     newName: "Photo");

            // migrationBuilder.RenameColumn(
            //     name: "ID",
            //     table: "Photo",
            //     newName: "Id");

            // migrationBuilder.RenameIndex(
            //     name: "IX_Photos_AppUserId",
            //     table: "Photo",
            //     newName: "IX_Photo_AppUserId");

            // migrationBuilder.AddPrimaryKey(
            //     name: "PK_Photo",
            //     table: "Photo",
            //     column: "Id");

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    SourceUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    TargetUserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => new { x.SourceUserId, x.TargetUserId });
                    table.ForeignKey(
                        name: "FK_Likes_Users_SourceUserId",
                        column: x => x.SourceUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Likes_Users_TargetUserId",
                        column: x => x.TargetUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Likes_TargetUserId",
                table: "Likes",
                column: "TargetUserId");

            // migrationBuilder.AddForeignKey(
            //     name: "FK_Photo_Users_AppUserId",
            //     table: "Photo",
            //     column: "AppUserId",
            //     principalTable: "Users",
            //     principalColumn: "Id",
            //     onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        // protected override void Down(MigrationBuilder migrationBuilder)
        // {
        //     migrationBuilder.DropForeignKey(
        //         name: "FK_Photo_Users_AppUserId",
        //         table: "Photo");

        //     migrationBuilder.DropTable(
        //         name: "Likes");

        //     migrationBuilder.DropPrimaryKey(
        //         name: "PK_Photo",
        //         table: "Photo");

        //     migrationBuilder.RenameTable(
        //         name: "Photo",
        //         newName: "Photos");

        //     migrationBuilder.RenameColumn(
        //         name: "Id",
        //         table: "Photos",
        //         newName: "ID");

        //     migrationBuilder.RenameIndex(
        //         name: "IX_Photo_AppUserId",
        //         table: "Photos",
        //         newName: "IX_Photos_AppUserId");

        //     migrationBuilder.AddPrimaryKey(
        //         name: "PK_Photos",
        //         table: "Photos",
        //         column: "ID");

        //     migrationBuilder.AddForeignKey(
        //         name: "FK_Photos_Users_AppUserId",
        //         table: "Photos",
        //         column: "AppUserId",
        //         principalTable: "Users",
        //         principalColumn: "Id",
        //         onDelete: ReferentialAction.Cascade);
        // }
    }
}
