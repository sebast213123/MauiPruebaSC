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

        public string mensajeestado {  get; set; }

        public RepositorioPaises() 
        {

            coneccion = new SQLiteConnection(Constants.PathBaseDatos,Constants.Flags);

            coneccion.CreateTable<Paisesp1ViewModel>();
        }

        public void Add(Paisesp1ViewModel nuevoPais)


        {
            int result = 0;
            try
            {
                result=coneccion.Insert(nuevoPais);
                mensajeestado=
                $"{result} row(s) added";
            }
            catch(Exception ex)
            {
            mensajeestado=
                $"Error: {ex.Message}";
            }
        }
            
        public List<Paisesp1ViewModel> GetAll()
        {
            try
            {
                return coneccion.Table<Paisesp1ViewModel>().ToList();
            }
            catch(Exception ex)
            {
                mensajeestado =
                $"Error: {ex.Message}";
            }
            return null;

        }

        public Paisesp1ViewModel Get(int id)
        {

            try
            {
                return
                    coneccion.Table<Paisesp1ViewModel>()
                    .FirstOrDefault(x=> x._ID==id);
            }

            catch(Exception ex)
            {
                mensajeestado =
                $"Error: {ex.Message}";
            }
            return null;
    }
}
