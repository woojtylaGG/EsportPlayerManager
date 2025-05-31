using System;
using System.Data;
using Npgsql;

namespace EsportPlayerManager.Services
{
    public class DatabaseService
    {
        private readonly string _connectionString;

        public DatabaseService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void DisplayTableColumns(string tableName)
        {
            using var connection = new NpgsqlConnection(_connectionString);

            try
            {
                connection.Open();
                Console.WriteLine($"Połączono z bazą danych. Wyświetlanie kolumn tabeli: {tableName}");

                using var command = connection.CreateCommand();
                command.CommandText = $"SELECT * FROM {tableName} LIMIT 0";
                command.CommandType = CommandType.Text;

                using var reader = command.ExecuteReader();
                Console.WriteLine($"Kolumny tabeli {tableName}:");

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(reader.GetName(i));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Błąd: {ex.Message}");
            }
        }
    }
}