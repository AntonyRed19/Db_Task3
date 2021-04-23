using Microsoft.EntityFrameworkCore.Migrations;

namespace Task3.Migrations
{
    public partial class CreateTableClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HiredDate = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateofBirth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Project_ClientId",
                table: "Project",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.Sql("Insert into Clients(FirstName,LastName,PhoneNumber,Description) values('Anton','Rachenko','2323323','******')");
            migrationBuilder.Sql("Insert into Clients(FirstName,LastName,PhoneNumber,Description) values('Alex','Rachenko','2323354','******')");
            migrationBuilder.Sql("Insert into Clients(FirstName,LastName,PhoneNumber,Description) values('Modern','Talking','2323263','******')");
            migrationBuilder.Sql("Insert into Clients(FirstName,LastName,PhoneNumber,Description) values('Cherry','Lady','2323321','******')");
            migrationBuilder.Sql("Insert into Clients(FirstName,LastName,PhoneNumber,Description) values('Ya','c#','23233','******')");
            migrationBuilder.Sql("Insert into Project(Name,Badget,StaredDate) values('AAA',243,GETDATE())");
            migrationBuilder.Sql("Insert into Project(Name,Badget,StaredDate) values('BBB',321,GETDATE())");
            migrationBuilder.Sql("Insert into Project(Name,Badget,StaredDate) values('CCC',5422,GETDATE())");
            migrationBuilder.Sql("Insert into Project(Name,Badget,StaredDate) values('DDD',24322,GETDATE())");
            migrationBuilder.Sql("Insert into Project(Name,Badget,StaredDate) values('WWW',2413,GETDATE())");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_Client_ClientId",
                table: "Project");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropIndex(
                name: "IX_Project_ClientId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Project");
        }
    }
}
