using System;
using EsportPlayerManager.Services;

class Program
{
    static void Main(string[] args)
    {
        var connectionString = "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=Postgres";
        var databaseService = new DatabaseService(connectionString);

        databaseService.DisplayTableColumns("players");
    }
}