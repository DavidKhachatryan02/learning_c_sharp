using System.Text;

public class PartTimeEmp : Employee
{
    private decimal HourlyRate { get; }
    private int HoursWorked { get; }

    public PartTimeEmp(string name, decimal hourlyRate, int hoursWorked) : base(name, ContractType.Freelancer)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override decimal CalculateMonthlyPay()
    {
        return HourlyRate * HoursWorked;
    }

    public override string GetSummary()
    {
        StringBuilder responseBuilder = new StringBuilder();

        responseBuilder.AppendLine($"Name: {Name} | Contract: {ContractType}");
        responseBuilder.AppendLine($"Salary: ${CalculateMonthlyPay()}");
        responseBuilder.AppendLine($"Hours Worked: {HoursWorked}");
        responseBuilder.AppendLine($"Hourly Pay: ${HourlyRate}");


        return responseBuilder.ToString();
    }
}