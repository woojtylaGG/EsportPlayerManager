namespace EsportPlayerManager.Models;

public class Tournament
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int EntryFee { get; set; }
    public int PrizePool { get; set; }
    public int MinSkillRequired { get; set; }
}