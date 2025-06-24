using System.Text;

public class FullTimeEmp : Employee
{
    private decimal BaseSalory { get; }
    private decimal PerfBonus { get; }
    private int PerScore { get; }

    public FullTimeEmp(string name, decimal baseSalory, decimal perfBonus, int perScore) : base(name, ContractType.FullTime)
    {
        BaseSalory = baseSalory;
        PerfBonus = perfBonus;
        PerScore = perScore;
    }

    public override decimal CalculateMonthlyPay()
    {
        return PerScore > 80 ? BaseSalory + PerfBonus : BaseSalory;
    }

    public override string GetSummary()
    {
        StringBuilder responseBuilder = new StringBuilder();

        responseBuilder.AppendLine($"Name: {Name} | Contract: {ContractType}");
        responseBuilder.AppendLine($"Salary: ${CalculateMonthlyPay()}");
        responseBuilder.AppendLine($"Performance Bonus Applied: {(PerScore > 80 ? "yes" : "no")} | Score: ({PerScore})");

        return responseBuilder.ToString();
    }
}