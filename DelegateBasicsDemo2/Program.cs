/*using System;
using System.Collections.Generic; // list
class Program
{
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { Id = 101, Name = "Mayuri", Salary = 100000, Experience = 5 });
        empList.Add(new Employee() { Id = 102, Name = "Johnny", Salary = 4000, Experience = 4 });
        empList.Add(new Employee() { Id = 103, Name = "Edward", Salary = 15000, Experience = 6 });
        empList.Add(new Employee() { Id = 104, Name = "Sam", Salary = 3000, Experience = 3 });

        IsPromotable isPromotable = new IsPromotable(Promote);
        Employee.PromoteEmployee(empList, isPromotable);//passing a delegate as parameter
    }

    public static bool Promote(Employee emp)
    {
        if (emp.Experience >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
//to make code very flexible use delegate

delegate bool IsPromotable(Employee empl);

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    //make PromoteEmployee method static so we can invoke them without creating instance of employee class
    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote) // here we are passing delegate as a parameter [IsPromotable]
    {
        foreach (Employee employee in employeeList)
        {
            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }

} */

using System;
using System.Collections.Generic; // list
class Program
{
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { Id = 101, Name = "Mayuri", Salary = 100000, Experience = 5 });
        empList.Add(new Employee() { Id = 102, Name = "Johnny", Salary = 4000, Experience = 4 });
        empList.Add(new Employee() { Id = 103, Name = "Edward", Salary = 15000, Experience = 6 });
        empList.Add(new Employee() { Id = 104, Name = "Sam", Salary = 3000, Experience = 3 });

        /*IsPromotable isPromotable = new IsPromotable(Promote);
        Employee.PromoteEmployee(empList, isPromotable);//passing a delegate as parameter
        */
        Employee.PromoteEmployee(empList, emp => emp.Experience >= 5);
    }

    /*public static bool Promote(Employee emp)
    {
        if (emp.Experience >= 5)
        {
            return true;
        }
        else
        {
            return false;
        }
    }*/ //instead of this use the lambda function 
}
//to make code very flexible use delegate

delegate bool IsPromotable(Employee empl);

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    //make PromoteEmployee method static so we can invoke them without creating instance of employee class
    public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligibleToPromote) // here we are passing delegate as a parameter [IsPromotable]
    {
        foreach (Employee employee in employeeList)
        {
            if (IsEligibleToPromote(employee))
            {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }

}