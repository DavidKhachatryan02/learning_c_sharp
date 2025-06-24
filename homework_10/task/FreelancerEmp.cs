using System.Text;

public class Freelancer : Employee
{
    private List<Project> Projects { get; }

    public Freelancer(string name, List<Project> projects) : base(name, ContractType.Freelancer)
    {
        Projects = projects ?? new List<Project>();
    }

    public override decimal CalculateMonthlyPay()
    {
        decimal salary = 0;
        for (int i = 0; i < Projects.Count; i++)
        {
            if (Projects[i].IsCompleted)
            {
                salary += Projects[i].Fee;
            }
        }
        return salary;
    }

    public override string GetSummary()
    {
        StringBuilder responseBuilder = new StringBuilder();

        responseBuilder.AppendLine($"Name: {Name} | Contract: {ContractType}");
        responseBuilder.AppendLine($"Salary: ${CalculateMonthlyPay()}");
        responseBuilder.AppendLine($"Projects: {GetProjectList()}");

        return responseBuilder.ToString();
    }

    private string GetProjectList()
    {
        StringBuilder projectListBuilder = new StringBuilder();
        if (Projects.Count == 0)
        {
            projectListBuilder.Append("No Project");
        }
        else
        {
            for (int i = 0; i < Projects.Count; i++)
            {
                projectListBuilder.Append($"{Projects[i].Title} (${Projects[i].Fee})");
                if (i < Projects.Count - 1)
                {
                    projectListBuilder.Append(", ");
                }
            }
        }
        return projectListBuilder.ToString();
    }
}
