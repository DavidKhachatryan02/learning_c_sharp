namespace _homework_10
{
  class Program
{
  static void Main()
  {
    Project project1 = new Project("Proj 1", 5000, true);
    Project project2 = new Project("Proj 2", 4000, false);
    Project project3 = new Project("Proj 3", 1000, true);
    Project project4 = new Project("Proj 4", 2000, true);

    FullTimeEmp fullTimeEmp1 = new FullTimeEmp("FullTime 1", 666m, 100m, 85);
    FullTimeEmp fullTimeEmp2 = new FullTimeEmp("FullTime 2", 333m, 33m, 15);

    PartTimeEmp partTimeEmp = new PartTimeEmp("PartTime 2", 16m, 15);

    InternEmp intern1 = new InternEmp("Intern 2", 50m, 52);
    InternEmp intern2 = new InternEmp("Intern 2", 24m, 11);

    Freelancer freelancer1 = new Freelancer("Frelancer 1", new List<Project> { project1, project2 });
    Freelancer freelancer2 = new Freelancer("Frelancer 2", new List<Project> { project3, project4 });
    Freelancer freelancer3 = new Freelancer("Frelancer 3", new List<Project> { });

    Employee[] employees = [fullTimeEmp1, fullTimeEmp2, partTimeEmp, intern1, intern2, freelancer1, freelancer2, freelancer3];
    decimal totalPayroll = 0;
    for (int i = 0; i < employees.Length; i++)
    {
      Employee employee = employees[i];
      totalPayroll += employee.CalculateMonthlyPay();
      Console.WriteLine(employee.GetSummary());
    }
    Console.WriteLine($"Total Payroll: ${totalPayroll}");

    //LINQ BONUS

    var selectedPeople = from emp in employees
                         where emp.CalculateMonthlyPay() > 1000
                         orderby emp.CalculateMonthlyPay()
                         select emp;
    foreach (Employee emp in selectedPeople)
    {
      Console.WriteLine(emp.Name);
    }
  }
}
}