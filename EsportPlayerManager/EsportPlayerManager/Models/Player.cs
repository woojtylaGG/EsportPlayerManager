﻿namespace EsportPlayerManager.Models;

public class Player
{
    public int Id { get; set; }
    public string Nickname { get; set; } = string.Empty;
    public string Game { get; set; } = string.Empty;
    public int SkillLevel { get; set; }
    public int StressLevel { get; set; }
    public int FatigueLevel { get; set; }
}