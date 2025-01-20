using System.Text.Json;
using System.Net.Http;


namespace MauiPruebaSC;

public partial class Pagina1 : ContentPage
{
    public Pagina1()
    {
        InitializeComponent();
    }

    private async void Buscar_Clicked(object sender, EventArgs e)
    {
        string nombrePais = scadena_entryPais.Text;

        if (string.IsNullOrEmpty(nombrePais))
        {
            await DisplayAlert("Error", "Por favor ingrese un nombre de pa�s.", "OK");
            return;
        }

        // Llama a la funci�n para buscar el pa�s
        await BuscarPais(nombrePais);
    }

    private void Limpiar_Clicked(object sender, EventArgs e)
    {
        scadena_entryPais.Text = string.Empty;
    }

    private async Task BuscarPais(string nombrePais)
    {
        try
        {
            string url = $"https://restcountries.com/v3.1/name/{nombrePais}?fields=name,region,maps";
            HttpClient client = new HttpClient();
            var response = await client.GetStringAsync(url);

            // Deserializa la respuesta
            var paises = JsonSerializer.Deserialize<List<Pais>>(response);

            if (paises != null && paises.Count > 0)
            {
                var primerPais = paises[0];

                // Guarda el pa�s en SQLite
                await GuardarPaisEnBD(primerPais);
                await DisplayAlert("�xito", $"Pa�s guardado: {primerPais.name.official}", "OK");
            }
            else
            {
                await DisplayAlert("Error", "No se encontr� el pa�s.", "OK");
            }
        }
        catch (Exception ex)
        {
            await DisplayAlert("Error", $"Ocurri� un error: {ex.Message}", "OK");
        }
    }
}

// Modelos para la API
public class Pais
{
    public Name name { get; set; }
    public string region { get; set; }
    public Maps maps { get; set; }
}

public class Name
{
    public string official { get; set; }
}

public class Maps
{
    public string googleMaps { get; set; }
}