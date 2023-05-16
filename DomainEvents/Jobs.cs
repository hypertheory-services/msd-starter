
namespace DomainEvents.Jobs;

public record JobCreated
{
    public static string TOPIC = "jobs.created";
    public Guid Id { get; init; }
    public string Title { get; init; } = string.Empty;
    public string Description { get; init; } = string.Empty;
}
