namespace JobPortal.Core.Models;

public class Application
{
    public int Id { get; set; }
    public int JobId { get; set; }
    public string Applicant { get; set; } = null!;
    public DateTime AppliedOn { get; set; }
    public Job? Job { get; set; }
}