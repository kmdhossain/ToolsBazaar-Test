namespace ToolsBazaar.Domain.CustomerAggregate;

public class Customer
{
    public string name;
    public int Id { get; init; }

    public string Name
    {
        get => name;
        init => name = value;
    }

    public string? Email { get; init; }
    public string? Address { get; init; }

    public void UpdateName(string name) => this.name =name;
}