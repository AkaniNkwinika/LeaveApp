using System.Collections.Generic;
using System.Data.Entity;
using LeaveApp.DAL;
using LeaveApp.Models;

public class LeaveDbInitializer : DropCreateDatabaseIfModelChanges<LeaveDbContext>
{
    protected override void Seed(LeaveDbContext context)
    {
        var employees = new List<Employee>
        {
            // Management Team
            new Employee { FullName = "Linda Jenkins", EmployeeNumber = "0001", EmailAddress = null, CellphoneNumber = null },
            new Employee { FullName = "Milton Coleman", EmployeeNumber = "0002", EmailAddress = "miltoncoleman@amce.com", CellphoneNumber = "+27 55 937 274" },
            new Employee { FullName = "Colin Horton", EmployeeNumber = "0003", EmailAddress = "colinhorton@amce.com", CellphoneNumber = "+27 20 915 7545" },

            // Support Team
            new Employee { FullName = "Charlotte Osborne", EmployeeNumber = "1005", EmailAddress = "charlotteosborne@acme.com", CellphoneNumber = "+27 55 760 177" },
            new Employee { FullName = "Marie Walters", EmployeeNumber = "1006", EmailAddress = "mariewalters@acme.com", CellphoneNumber = "+27 20 918 6908" },
            new Employee { FullName = "Leonard Gill", EmployeeNumber = "1008", EmailAddress = "leonardgill@acme.com", CellphoneNumber = "+27 55 525 585" },
            new Employee { FullName = "Enrique Thomas", EmployeeNumber = "1009", EmailAddress = "enriquethomas@acme.com", CellphoneNumber = "+27 20 916 1335" },
            new Employee { FullName = "Omar Dunn", EmployeeNumber = "1010", EmailAddress = "omardunn@acme.com", CellphoneNumber = null },
            new Employee { FullName = "Dewey George", EmployeeNumber = "1012", EmailAddress = "deweygeorge@acme.com", CellphoneNumber = "+27 55 260 127" },
            new Employee { FullName = "Rudy Lewis", EmployeeNumber = "1013", EmailAddress = "rudylewis@acme.com", CellphoneNumber = null },
            new Employee { FullName = "Neal French", EmployeeNumber = "1015", EmailAddress = "nealfrench@acme.com", CellphoneNumber = "+27 20 919 4882" },

            // Dev Team
            new Employee { FullName = "Ella Jefferson", EmployeeNumber = "2005", EmailAddress = "ellajefferson@acme.com", CellphoneNumber = "+27 55 979 367" },
            new Employee { FullName = "Earl Craig", EmployeeNumber = "2006", EmailAddress = "earlcraig@acme.com", CellphoneNumber = "+27 20 916 5608" },
            new Employee { FullName = "Marsha Murphy", EmployeeNumber = "2008", EmailAddress = "marshamurphy@acme.com", CellphoneNumber = "+36 55 949 891" },
            new Employee { FullName = "Luis Ortega", EmployeeNumber = "2009", EmailAddress = "luisortega@acme.com", CellphoneNumber = "+27 20 917 1339" },
            new Employee { FullName = "Faye Dennis", EmployeeNumber = "2010", EmailAddress = "fayedennis@acme.com", CellphoneNumber = null },
            new Employee { FullName = "Amy Burns", EmployeeNumber = "2012", EmailAddress = "amyburns@acme.com", CellphoneNumber = "+27 20 914 1775" },
            new Employee { FullName = "Darrel Weber", EmployeeNumber = "2013", EmailAddress = "darrelweber@acme.com", CellphoneNumber = "+27 55 615 463" }
        };

        context.Employees.AddRange(employees);
        context.SaveChanges();

        base.Seed(context);
    }

    public override void InitializeDatabase(LeaveDbContext context)
    {
        if (context.Database.Exists())
        {
            // Force single user mode to drop database
            context.Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction,
                @"ALTER DATABASE [" + context.Database.Connection.Database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
        }

        base.InitializeDatabase(context);
    }
}
