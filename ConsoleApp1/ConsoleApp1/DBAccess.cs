// Connect to a PG DB and fetch some data
 
 using System;
 using System.Threading.Tasks;
 using Npgsql;
 
 class DBAccess
{
    static void connectToDB()
    {
        // Code to connect to DB and fetch data
        Console.WriteLine("Connecting to DB...");
    }

    private static string connectionString = "Host=localhost;Username=postgres;Password=samirkrishna;Database=postgres";

    static async Task Main()
    {
        await using var conn = new NpgsqlConnection(connectionString);
        await conn.OpenAsync();

        await using var cmd = new NpgsqlCommand("SELECT now()", conn);
        var result = await cmd.ExecuteScalarAsync();
        Console.WriteLine($"Server time: {result}");
        
        // Example query
        cmd.CommandText = "SELECT id, name FROM categories LIMIT 5";
        await using var reader = await cmd.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            var id = reader.GetInt32(0);
            var name = reader.IsDBNull(1) ? null : reader.GetString(1);
            Console.WriteLine($"{id} - {name}");
        }

        await conn.CloseAsync();
    }
}