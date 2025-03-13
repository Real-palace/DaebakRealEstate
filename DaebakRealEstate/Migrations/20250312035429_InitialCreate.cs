using Microsoft.EntityFrameworkCore.Migrations;
using System;

#nullable disable

namespace DaebakRealEstate.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "USERS",
                columns: table => new
                {
                    USER_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USERNAME = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PASSWORD_HASH = table.Column<string>(type: "nvarchar(255)", nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ROLE = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    FIRST_NAME = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    LAST_NAME = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PHONE_NUMBER = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    HOUSE_NUMBER = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    PROFILE_PICTURE = table.Column<string>(type: "nvarchar(255)", nullable: true),
                    CREATED_AT = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()"),
                    UPDATED_AT = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS", x => x.USER_ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "USERS");
        }
    }
}
