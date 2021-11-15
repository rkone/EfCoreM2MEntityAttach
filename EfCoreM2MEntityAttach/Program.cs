using EfCoreM2MEntityAttach.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;


//initialize 
var connection = new SqliteConnection("DataSource=:memory:");
connection.Open();
var options = new DbContextOptionsBuilder<NorthwindDbContext>().UseSqlite(connection).Options;
var context = new NorthwindDbContext(options);
context.Database.EnsureCreated();
var initTerritory = new Territory { TerritoryId = "01581", TerritoryDescription = "Westboro" };
context.Territories.Add(initTerritory);
context.Employees.Add(new Employee
{
    EmployeeId = 1,
    LastName = "Davolio",
    FirstName = "Nancy",
    BirthDate = DateTime.Parse("1948-12-08"),
    HireDate = DateTime.Parse("1992-05-01"),
    City = "Seattle",
    Country = "USA",
    Territories = new List<Territory> { initTerritory }
});
context.SaveChanges();

//change
var employee = context.Employees.First();
var territory = employee.Territories.First();
context.Entry(territory).State = EntityState.Detached;
//how can I re-attach territory here and keep the EmployeeTerritory State as Unchanged?
context.Entry(territory).State = EntityState.Modified;

context.SaveChanges(); //fails due to duplicate key.