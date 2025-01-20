using SQLite;
using System.ComponentModel;


namespace MauiPruebaSC.ViewModels
{
    [Table("Paises")]
    public class Paisesp1ViewModel : INotifyPropertyChanged
    {
        [PrimaryKey,AutoIncrement] 
        private int _ID {  get; set; }
        [Column("nombrepais"),Indexed]
        private string? _NombrePaisSebastianCadena {  get; set; }

        private string? _BuscarResultado {  get; set; }
        private string? _MostrarError {  get; set; }



        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
