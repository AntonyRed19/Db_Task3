using Microsoft.EntityFrameworkCore.Migrations;

namespace Task3.Migrations
{
    public partial class CreateDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Alex','Love','23433',GETDATE())
  insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Modern','Talking','23433',GETDATE())
  insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Charry','Lady','23433',GETDATE())
  insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Dan','Balan','23433',GETDATE())
  insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Whatis','Love','23433',GETDATE())");
            migrationBuilder.Sql(@"insert into Project(Name, Badget, StaredDate, ClientId) values('TestProject1', 222, GETDATE(), (select Id from Client where FirstName = 'Alex'))
  insert into Project(Name, Badget, StaredDate, ClientId) values('TestProject2', '222', GETDATE(), (select Id from Client where FirstName = 'Modern'))
  insert into Project(Name, Badget, StaredDate, ClientId) values('TestProject3', '222', GETDATE(), (select Id from Client where FirstName = 'Charry'))
  insert into Project(Name, Badget, StaredDate, ClientId) values('TestProject4', '222', GETDATE(), (select Id from Client where FirstName = 'Dan'))
  insert into Project(Name, Badget, StaredDate, ClientId) values('TestProject5', '222', GETDATE(), (select Id from Client where FirstName = 'Whatis'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Alex','Love','23433',GETDATE())
  insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Modern','Talking','23433',GETDATE())
  insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Charry','Lady','23433',GETDATE())
  insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Dan','Balan','23433',GETDATE())
  insert into Client (FirstName,LastName,PhoneNumber,DateofBith) values ('Whatis','Love','23433',GETDATE())");
            migrationBuilder.Sql(@"insert into Project(Name, Badget, StaredDate, ClientId) values('TestProject1', 222, GETDATE(), (select Id from Client where FirstName = 'Alex'))
  insert into Project(Name, Badget, StaredDate, ClientId) values('TestProject2', '222', GETDATE(), (select Id from Client where FirstName = 'Modern'))
  insert into Project(Name, Badget, StaredDate, ClientId) values('TestProject3', '222', GETDATE(), (select Id from Client where FirstName = 'Charry'))
  insert into Project(Name, Badget, StaredDate, ClientId) values('TestProject4', '222', GETDATE(), (select Id from Client where FirstName = 'Dan'))
  insert into Project(Name, Badget, StaredDate, ClientId) values('TestProject5', '222', GETDATE(), (select Id from Client where FirstName = 'Whatis'))");
        }
    }
}
