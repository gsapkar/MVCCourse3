using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DayThree.Models
{
    public static class DataModel
    {
        public static List<EmployeeModel> Employees = new List<EmployeeModel>()
        {
            new EmployeeModel(){ID = 1, FirstName="Kliment", LastName="Jancheski", Salary=500},
            new EmployeeModel(){ID = 2, FirstName="Goce", LastName="Shapkaroski", Salary=600},
            new EmployeeModel(){ID = 3, FirstName="John", LastName="Doe", Salary=700}
        };

        public static List<Book> Books = new List<Book>() { 
            new Book { Id = "1", Name = "JavaScript for beginners", IsOnSale = false, Author = "R.P", Price = 35 },
            new Book { Id = "2", Name = "C# Advanced", IsOnSale = true, Author = "I.L", Price = 49 },
            new Book { Id = "3", Name = "Html & Css", IsOnSale = false, Author = "Y.R", Price = 27 }

        };

        
    }
}
