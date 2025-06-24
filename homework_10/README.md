===============================
HOMEWORK: Workforce System for HexaTech Corp
===============================

🎯 Objective:
Build a class-based workforce management system for a tech company that hires different types of employees under different contracts. The system should calculate monthly salaries based on contract type and other conditions like performance, projects, or hours worked.

===============================
🔧 Requirements
===============================

1. Enum: ContractType
-------------------------------
Define an enum to represent employee contract types:

enum ContractType
{
    FullTime,
    PartTime,
    Freelancer,
    Intern
}

2. Base Abstract Class: Employee
-------------------------------
Each employee should have:

- Guid Id
- string Name
- ContractType Contract
- Abstract method: decimal CalculateMonthlyPay()
- Abstract method: string GetSummary()

abstract class Employee
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; set; }
    public ContractType Contract { get; protected set; }

    public abstract decimal CalculateMonthlyPay();
    public abstract string GetSummary();
}

3. Derived Classes
-------------------------------

a) FullTimeEmployee
- decimal BaseSalary
- decimal PerformanceBonus
- int PerformanceScore
- If PerformanceScore > 80, include PerformanceBonus in salary.

b) PartTimeEmployee
- int HoursWorked
- decimal HourlyRate

c) Freelancer
- List<Project> Projects
- Each project has Title, Fee, and IsCompleted
- Only completed projects are counted for salary.

d) Intern
- decimal MonthlyStipend
- int Grade (0–100)
- If Grade < 50, stipend is $0.

4. Project Class
-------------------------------
Each freelancer works on one or more projects.

class Project
{
    public string Title { get; set; }
    public decimal Fee { get; set; }
    public bool IsCompleted { get; set; }
}

5. : IPerformanceEvaluated
-------------------------------
interface IPerformanceEvaluated
{
    int PerformanceScore { get; set; }
}

Implement this interface in FullTimeEmployee and Intern.

6. Program.cs Test Logic
-------------------------------
- Create a List<Employee> with 1-2 instances of each employee type.
- Assign projects to freelancers.
- Assign random performance scores to full-time employees and interns.
- Print summary for each employee:
  - Name
  - Contract type
  - Salary
  - Performance status (if applicable)
  - Projects (if freelancer)

7. Bonus Tasks (Optional)
-------------------------------
- Track total payroll for the month.
- Use LINQ to:
  - Filter employees with salary > $1000
  - Find top performer(s)
- Export employee summary to CSV or JSON.

===============================
📘 Sample Output (Console)
===============================

--- Employee Summary ---
Name: Alice | Contract: FullTime | Salary: $4,500.00
Performance Bonus Applied: Yes (Score: 92)

Name: Bob | Contract: Freelancer | Salary: $1,800.00
Projects: API Integration ($1,000), Landing Page ($800)

Name: Clara | Contract: Intern | Grade: 48 | Stipend: $0.00
Warning: Underperforming Intern

Total Payroll: $6,300.00

===============================
📚 Learning Outcomes
===============================
- Use of abstract classes, inheritance, and interfaces
- Real-world contract logic modeling
- Polymorphism and override behavior
- List and LINQ operations
- Console output formatting
- Optional: JSON or CSV export

===============================
📂 Submission
===============================
1. Source files: Employee.cs, Program.cs, Project.cs
2. Screenshot of output
3. Bonus: CSV or JSON file of employees (optional)
