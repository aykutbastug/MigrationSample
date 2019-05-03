using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace MigrationSample.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }
    }

    internal class DbInitializer
    {
        public static void Initialize(DatabaseContext context)
        {
            context.Database.EnsureCreated();

            AddFakeEmployees(context);
            AddFakeCompanies(context);

        }

        private static void AddFakeCompanies(DatabaseContext context)
        {
            if (context.Companies.Any())
            {
                return;
            }

            for (int i = 0; i < 5; i++)
            {
                context.Companies.Add(new Company
                {
                    Name = FakeData.NameData.GetCompanyName(),
                    Size = FakeData.NumberData.GetNumber(5, 99),
                    Address = FakeData.PlaceData.GetAddress()
                });
            }

            context.SaveChanges();
        }

        private static void AddFakeEmployees(DatabaseContext context)
        {
            if (context.Employees.Any())
            {
                return;
            }

            for (int i = 0; i < 20; i++)
            {
                context.Employees.Add(new Employee
                {
                    Name = FakeData.NameData.GetFirstName(),
                    SurName = FakeData.NameData.GetSurname(),
                    Age = FakeData.NumberData.GetNumber(18,99),
                    phoneNumber = FakeData.PhoneNumberData.GetPhoneNumber()
                });
            }

            context.SaveChanges();
        }

    }
}
