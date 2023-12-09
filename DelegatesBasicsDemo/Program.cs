using System;
using System.Collections.Generic; // list
class Program
{
    public static void Main()
    {
        List<Employee> empList = new List<Employee>();
        empList.Add(new Employee() { Id = 101, Name= "Mayuri", Salary = 100000, Experience = 5 });
        empList.Add(new Employee() { Id = 102, Name = "Johnny", Salary = 4000, Experience = 4 });
        empList.Add(new Employee() { Id = 103, Name = "Edward", Salary = 15000, Experience = 6 });
        empList.Add(new Employee() { Id = 104, Name = "Sam", Salary = 3000, Experience = 3 });


        Employee.PromoteEmployee(empList);
    }
}

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary {  get; set;}
    public int Experience { get; set; }
     
    //make PromoteEmployee method static so we can invoke them without creating instance of employee class
    public static void PromoteEmployee(List<Employee> employeeList) // it is not flexible if you want to change criteria of employee promoted then 
        //always you need to modify this part of code which is not good so in the next example we can use delegate to make this flexible
    {
        foreach(Employee employee in employeeList)
        {
            if(employee.Experience >= 5)
            {
                Console.WriteLine(employee.Name + " promoted");
            }
        }
    }

}