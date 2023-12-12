using System;
namespace Mayuri
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set;}
    }

    class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        Employee[] EmpList;

        public Department()
        {
            DeptId = 10;
            DeptName = "Sales";
            EmpList = new Employee[3]
            {
                new Employee { Id = 101, Name = "Johnny", Salary = 30000 },
                new Employee { Id = 102, Name = "Alex", Salary = 45000 },
                new Employee { Id = 103, Name = "Jenny", Salary = 50000 }
            };
        }
        public Employee GetEmployee(int id)
        {
            foreach (Employee emp in  EmpList)
            {
                if (id == emp.Id)
                    return emp;
            }
            return null;
        }

        public Employee GetEmployee(string name)
        {
            foreach (Employee emp in EmpList)
            {
                if (name == emp.Name)
                    return emp;
            }
            return null;
        }

        public Employee this[int id]
        {
            get
            {
                foreach(Employee emp in EmpList)
                {
                    if (id == emp.Id)
                        return emp;
                }
                return null;
            }
        }

        public Employee this[string name]
        {
            get
            {
                foreach (Employee emp in EmpList)
                {
                    if (name == emp.Name)
                        return emp;
                }
                return null;
            }
        }
    }

    class Program
    {
        public static void Main()
        {
            Department dept = new Department();
            Console.WriteLine(dept[101].Name);
            Console.WriteLine(dept["Brad"].Id);
        }
    }
}