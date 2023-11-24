using System;

public class Connection
{
	private const string SERVER = "localhost";
    private const string DATABASE = "sdgdb";
    private const string USER = "root";
    private const string PASSWORD = "";

    public MySqlConnection ObtainConnection()
    {
        string connectionString = $"Server= {SERVER}; Database= {DATABASE}; User= {USER}; Password= {PASSWORD};";
        MySqlConnection connection = new MySqlConnection(connectionString);
        return connection;
    }
}
