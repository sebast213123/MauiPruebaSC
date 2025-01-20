using SQLite;
using System.ComponentModel;

namespace MauiPruebaSC.ViewModels
{
    [Table("Paises")]
    public class Paisesp1ViewModel : INotifyPropertyChanged
    {
        private int _id;
        [PrimaryKey, AutoIncrement]
        public int ID
        {
            get => _id;
            set { _id = value; OnPropertyChanged(); }
        }

        private string _nombrePais;
        [Column("nombrepais"), Indexed]
        public string NombrePais
        {
            get => _nombrePais;
            set { _nombrePais = value; OnPropertyChanged(); }
        }

        private string _buscarResultado;
        public string BuscarResultado
        {
            get => _buscarResultado;
            set { _buscarResultado = value; OnPropertyChanged(); }
        }

        private string _mostrarError;
        public string MostrarError
        {
            get => _mostrarError;
            set { _mostrarError = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

