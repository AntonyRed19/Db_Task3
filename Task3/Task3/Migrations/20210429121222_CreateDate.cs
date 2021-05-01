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
            migrationBuilder.Sql(@"insert into Office (Title,Location) values('TestOffice1','Kharkiv')
            insert into Office (Title,Location) values('TestOffice2','Kyiv')
            insert into Office (Title,Location) values('TestOffice3','Dnipro')
            insert into Office (Title,Location) values('TestOffice4','Lviv')
            insert into Office (Title,Location) values('TestOffice5','Poltava')");
            migrationBuilder.Sql(@" insert into Title (Name) values ('Junior')
            insert into Title (Name) values ('QA')
            insert into Title (Name) values ('Manager')
            insert into Title (Name) values ('Senior')
            insert into Title (Name) values ('Middle')");
            migrationBuilder.Sql(@"insert into Employee (FirstName,LastName,HiredDate,DateofBirth,OfficeId,TitleId) values ('Antony','Hopkins',GETDATE(),CAST('2020-09-09' as date),(select OfficeId from Office where Title ='TestOffice1'),(select TitleId from Title where Name ='QA'))
            insert into Employee (FirstName,LastName,HiredDate,DateofBirth,OfficeId,TitleId) values ('Billy','Jean',GETDATE(),CAST('2010-10-09' as date),(select OfficeId from Office where Title ='TestOffice2'),(select TitleId from Title where Name ='Middle'))
            insert into Employee (FirstName,LastName,HiredDate,DateofBirth,OfficeId,TitleId) values ('Tony','Stark',GETDATE(),CAST('2019-08-08' as date),(select OfficeId from Office where Title ='TestOffice3'),(select TitleId from Title where Name ='Senior'))
            insert into Employee (FirstName,LastName,HiredDate,DateofBirth,OfficeId,TitleId) values ('Hulk','Hogan',GETDATE(),CAST('2017-06-09' as date),(select OfficeId from Office where Title ='TestOffice4'),(select TitleId from Title where Name ='Manager'))
            insert into Employee (FirstName,LastName,HiredDate,DateofBirth,OfficeId,TitleId) values ('Noob','Noooo',GETDATE(),CAST('2009-05-09' as date),(select OfficeId from Office where Title ='TestOffice5'),(select TitleId from Title where Name ='Junior'))");
            migrationBuilder.Sql(@"insert into EmployeeProject (Rate,StartedDate,EmployeeId,ProjectId) values('1',GETDATE(),(select EmployeeId from Employee where FirstName ='Antony'),(select ProjectId from Project where Name ='TestProject1'))
            insert into EmployeeProject (Rate,StartedDate,EmployeeId,ProjectId) values('2',GETDATE(),(select EmployeeId from Employee where FirstName ='Tony'),(select ProjectId from Project where Name ='TestProject2'))
	        insert into EmployeeProject (Rate,StartedDate,EmployeeId,ProjectId) values('3',GETDATE(),(select EmployeeId from Employee where FirstName ='Hulk'),(select ProjectId from Project where Name ='TestProject3'))
	        insert into EmployeeProject (Rate,StartedDate,EmployeeId,ProjectId) values('4',GETDATE(),(select EmployeeId from Employee where FirstName ='Billy'),(select ProjectId from Project where Name ='TestProject4'))
		    insert into EmployeeProject (Rate,StartedDate,EmployeeId,ProjectId) values('5',GETDATE(),(select EmployeeId from Employee where FirstName ='Noob'),(select ProjectId from Project where Name ='TestProject5'))");
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
            migrationBuilder.Sql(@"insert into Office (Title,Location) values('TestOffice1','Kharkiv')
            insert into Office (Title,Location) values('TestOffice2','Kyiv')
            insert into Office (Title,Location) values('TestOffice3','Dnipro')
            insert into Office (Title,Location) values('TestOffice4','Lviv')
            insert into Office (Title,Location) values('TestOffice5','Poltava')");
            migrationBuilder.Sql(@" insert into Title (Name) values ('Junior')
            insert into Title (Name) values ('QA')
            insert into Title (Name) values ('Manager')
            insert into Title (Name) values ('Senior')
            insert into Title (Name) values ('Middle')");
            migrationBuilder.Sql(@"insert into Employee (FirstName,LastName,HiredDate,DateofBirth,OfficeId,TitleId) values ('Antony','Hopkins',GETDATE(),CAST('2020-09-09' as date),(select OfficeId from Office where Title ='TestOffice1'),(select TitleId from Title where Name ='QA''Senior'))
            insert into Employee (FirstName,LastName,HiredDate,DateofBirth,OfficeId,TitleId) values ('Billy','Jean',GETDATE(),CAST('2010-10-09' as date),(select OfficeId from Office where Title ='TestOffice2'),(select TitleId from Title where Name ='Middle''Junior'))
            insert into Employee (FirstName,LastName,HiredDate,DateofBirth,OfficeId,TitleId) values ('Tony','Stark',GETDATE(),CAST('2019-08-08' as date),(select OfficeId from Office where Title ='TestOffice3'),(select TitleId from Title where Name ='QA''Middle'))
            insert into Employee (FirstName,LastName,HiredDate,DateofBirth,OfficeId,TitleId) values ('Hulk','Hogan',GETDATE(),CAST('2017-06-09' as date),(select OfficeId from Office where Title ='TestOffice4'),(select TitleId from Title where Name ='Manager''Senior'))
            insert into Employee (FirstName,LastName,HiredDate,DateofBirth,OfficeId,TitleId) values ('Noob','Noooo',GETDATE(),CAST('2009-05-09' as date),(select OfficeId from Office where Title ='TestOffice5'),(select TitleId from Title where Name ='Junior''Senior'))");
            migrationBuilder.Sql(@"insert into EmployeeProject (Rate,StartedDate,EmployeeId,ProjectId) values('1',GETDATE(),(select EmployeeId from Employee where FirstName ='Hulk''Antony'),(select ProjectId from Project where Name ='TestProject1'))
            insert into EmployeeProject (Rate,StartedDate,EmployeeId,ProjectId) values('2',GETDATE(),(select EmployeeId from Employee where FirstName ='Billy''Tony'),(select ProjectId from Project where Name ='TestProject2'))
	        insert into EmployeeProject (Rate,StartedDate,EmployeeId,ProjectId) values('3',GETDATE(),(select EmployeeId from Employee where FirstName ='Hulk''Billy'),(select ProjectId from Project where Name ='TestProject3'))
	        insert into EmployeeProject (Rate,StartedDate,EmployeeId,ProjectId) values('4',GETDATE(),(select EmployeeId from Employee where FirstName ='Billy''Antony'),(select ProjectId from Project where Name ='TestProject4'))
		    insert into EmployeeProject (Rate,StartedDate,EmployeeId,ProjectId) values('5',GETDATE(),(select EmployeeId from Employee where FirstName ='Noob''Tony'),(select ProjectId from Project where Name ='TestProject5'))");
        }
    }
}
