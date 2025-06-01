using System;
using Npgsql;

namespace EsportPlayerManager.Services;

public class DatabaseService
{
    private readonly string _connectionString;

    public DatabaseService(string connectionString)
    {
        _connectionString = connectionString;
    }

    public void AddPlayer(string nickname, string game, int aimSkill, int strategySkill, int reflexSkill, int stressLevel, int fatigueLevel)
    {
        using var connection = new NpgsqlConnection(_connectionString);

        try
        {
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Players (Nickname, Game, AimSkill, StrategySkill, ReflexSkill, StressLevel, FatigueLevel)
                VALUES (@nickname, @game, @aimSkill, @strategySkill, @reflexSkill, @stressLevel, @fatigueLevel)";
            command.Parameters.AddWithValue("nickname", nickname);
            command.Parameters.AddWithValue("game", game);
            command.Parameters.AddWithValue("aimSkill", aimSkill);
            command.Parameters.AddWithValue("strategySkill", strategySkill);
            command.Parameters.AddWithValue("reflexSkill", reflexSkill);
            command.Parameters.AddWithValue("stressLevel", stressLevel);
            command.Parameters.AddWithValue("fatigueLevel", fatigueLevel);

            command.ExecuteNonQuery();
            Console.WriteLine("Zawodnik został dodany do bazy danych.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Błąd podczas dodawania zawodnika: {ex.Message}");
        }
    }
}