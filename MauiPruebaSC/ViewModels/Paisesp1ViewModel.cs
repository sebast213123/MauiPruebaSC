using System.ComponentModel;

namespace MauiPruebaSC.ViewModels
{
    public class Paisesp1ViewModel : INotifyPropertyChanged
    {

        private string? _NombrePaisSebastianCadena {  get; set; }

        private string? _BuscarResultado {  get; set; }
        private string? _MostrarError {  get; set; }



        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
