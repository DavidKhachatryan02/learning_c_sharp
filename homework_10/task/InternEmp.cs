using System.Text;

public class InternEmp : Employee
{
    private decimal MonthlyStipend { get; }
    private int Grade { get; }

    public InternEmp(string name, decimal monthlyStipend, int grade) : base(name, ContractType.Freelancer)
    {
        MonthlyStipend = monthlyStipend;
        Grade = grade;
    }

    public override decimal CalculateMonthlyPay()
    {
        return Grade < 50 ? 0 : MonthlyStipend;
    }

    public override string GetSummary()
    {
        StringBuilder responseBuilder = new StringBuilder();

        responseBuilder.AppendLine($"Name: {Name} | Contract: {ContractType}");
        responseBuilder.AppendLine($"Grade: {Grade} | Stipend: ${CalculateMonthlyPay()}");
        if (Grade < 50)
        {
            responseBuilder.AppendLine("Warning: Underperforming Intern");
        }

        return responseBuilder.ToString();
    }
}