using System;
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateofBith = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.Id);
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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.Sql(@" insert into Project (Name,Badget,StaredDate,ClientId) values('Test Project1', 222, GETDATE())
  insert into Project (Name,Badget,StaredDate,ClientId) values('Test Project2', 222, GETDATE())
  insert into Project (Name,Badget,StaredDate,ClientId) values('Test Project3', 222, GETDATE())
  insert into Project (Name,Badget,StaredDate,ClientId) values('Test Project4', 222, GETDATE())
  insert into Project (Name,Badget,StaredDate,ClientId) values('Test Project5', 222, GETDATE())");
            migrationBuilder.Sql(@" insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Alex','Love','23433',GETDATE(), (select ClientId from Project where Name ='Test Project1'))
  insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Modern','Talking','23433',GETDATE(), (select ClientId from Project where Name ='Test Project2'))
  insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Charry','Lady','23433',GETDATE(), (select ClientId from Project where Name ='Test Project3'))
  insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('dan','Balan','23433',GETDATE(), (select ClientId from Project where Name ='Test Project4'))
  insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Whatis','Love','23433',GETDATE(), (select ClientId from Project where Name ='Test Project5'))");
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
