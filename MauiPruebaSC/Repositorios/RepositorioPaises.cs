using MauiPruebaSC.ViewModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPruebaSC.Repositorios
{
    public class RepositorioPaises
    {
        SQLiteConnection coneccion;

        public RepositorioPaises()
        {

            coneccion = new SQLiteConnection(Constants.PathBaseDatos,Constants.Flags);

            coneccion.CreateTable<Paisesp1ViewModel>();
        }
            

    }
}
