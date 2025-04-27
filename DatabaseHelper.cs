using System.Data;
using System.Data.SQLite;

public class DatabaseHelper
{
    private string connectionString;

    public DatabaseHelper(string dbPath)
    {
        connectionString = $"Data Source={dbPath};Version=3;";
    }
   



    public DataTable GetAllTabletnki()
    {
        using (SQLiteConnection conn = new SQLiteConnection(connectionString))
        {
            conn.Open();
            string query = "SELECT id, name, proizvod, typeof, edu, Kolichestvo, timeto, recept FROM tablентki";
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}


