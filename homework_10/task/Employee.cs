public abstract class Employee
{
    public Guid Id { get; } = Guid.NewGuid();
    public string Name { get; }
    public ContractType ContractType { get; }

    protected Employee(string name, ContractType contractType)
    {
        Name = name;
        ContractType = contractType;
    }
    public abstract decimal CalculateMonthlyPay();
    public abstract string GetSummary();
}