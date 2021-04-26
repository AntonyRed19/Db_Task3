using Microsoft.EntityFrameworkCore.Migrations;

namespace Task3.Migrations
{
    public partial class AddDatatoClientandProject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
    }
}
