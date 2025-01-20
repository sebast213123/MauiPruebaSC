using SQLite;

public class PaisModel
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string NombreOficial { get; set; }
    public string Region { get; set; }
    public string LinkMaps { get; set; }
    public string NombreBD { get; set; }
}

public class SQLiteRepository
{
    private SQLiteConnection _database;

    public SQLiteRepository(string dbPath)
    {
        _database = new SQLiteConnection(dbPath);
        _database.CreateTable<PaisModel>();
    }

    public void GuardarPais(PaisModel pais)
    {
        _database.Insert(pais);
    }

    public List<PaisModel> ObtenerPaises()
    {
        return _database.Table<PaisModel>().ToList();
    }
}

