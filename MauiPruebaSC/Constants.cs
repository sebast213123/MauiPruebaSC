using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPruebaSC
{
    public static class Constants
    {
        private const string NombreArchivoBaseDatosSebastCadena = "SQLitePaises";
        public const SQLiteOpenFlags Flags =

            SQLiteOpenFlags.ReadWrite |
            SQLiteOpenFlags.Create |
            SQLiteOpenFlags.SharedCache;

        public static string PathBaseDatos {

            get
            {
                return Path
                    .Combine(FileSystem.AppDataDirectory,NombreArchivoBaseDatosSebastCadena);
            }
        }
    }
}
