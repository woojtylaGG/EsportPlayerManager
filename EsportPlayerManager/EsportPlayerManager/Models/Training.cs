namespace EsportPlayerManager.Models;

public class Training
{
    public int Id { get; set; }
    public string Type { get; set; } = string.Empty;
    public int SkillIncrease { get; set; }
    public int FatigueIncrease { get; set; }
}