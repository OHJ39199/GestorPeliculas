using GestorPeliculas.MVVM.Models;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Windows.Input;

namespace GestorPeliculas.MVVM.ViewModels
{
    public class MainViewModel
    {
        public ObservableCollection<Film> Films { get; set; } = new ObservableCollection<Film>();

        #region PRIVATE FIELDS
        private HttpClient _httpClient = new HttpClient();
        private JsonSerializerOptions _jsonOptions = new JsonSerializerOptions(JsonSerializerDefaults.Web);

        private string _urlBase = "https://678685c5f80b78923aa73076.mockapi.io/api/v1";
       
        #endregion

        #region COMMAND
        public ICommand GetAllFilmsCommand
        {
            get
            {
                return new Command(async () =>
                {
                    String url = $"{_urlBase}/films";
                    HttpResponseMessage response = await _httpClient.GetAsync(url);
                    if (response.IsSuccessStatusCode)
                    {
                        using (var data = await response.Content.ReadAsStreamAsync())
                        {
                            var jsonFilms = await JsonSerializer.DeserializeAsync<List<Film>>(
                                data, 
                                _jsonOptions
                            );

                            if (jsonFilms != null)
                            {
                                Films.Clear();
                                foreach (var film in jsonFilms)
                                {
                                    Films.Add(film);
                                }
                                Console.WriteLine("peliculas cargadas.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("ha habido un error");
                    }
                });
            }
        }             
                
        public ICommand GetFilmById => new Command(async (id) =>
        {
            Film? film = null;
            try
            {
                var url = $"{_urlBase}/films/{id}";
                var response = await _httpClient.GetFromJsonAsync<Film>(url, _jsonOptions);
                if(film != null)
                {
                    Films.Add(film);
                }
                else
                {
                    Console.WriteLine($"No film found with ID {id}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        });

        public ICommand AddFilm => new Command(async () =>
        {

            var url = $"{_urlBase}/films";
            var film = new Film
            {
                Nombre = "Twisters",
                Genero = "Acción/Aventura",
                Director = "Lee Isaac Chung",
                Year = 2024
            };

            var json = JsonSerializer.Serialize(film, _jsonOptions);

            StringContent content = new StringContent(
                json,
                Encoding.UTF8,
                "application/json"
            );
            var response = await _httpClient.PostAsync(url, content);
            if (response.IsSuccessStatusCode)
            {
                if (film != null)
                {
                    Films.Add(film);
                    Console.WriteLine("Film added successfully");
                }
                else
                {
                    Console.WriteLine("Fail to add the new film.");
                }
            }
        });

        public ICommand UpdateFilm => new Command(async () =>
        {

            var film = Films.FirstOrDefault();
            if (film != null)
            {
                var url = $"{_urlBase}/films/:id";
                film.Nombre = "actualizacion";
                film.Director = "actualizacion";
                film.Year = 2010;


                var json = JsonSerializer.Serialize(film, _jsonOptions);

                StringContent content = new StringContent(
                    json,
                    Encoding.UTF8,
                    "application/json"
                );

                var response = await _httpClient.PutAsync(url, content);
            }

        });

        public ICommand DeleteFilm => new Command(async () =>
        {
            var url = $"{_urlBase}/films/1";
            var response = await _httpClient.DeleteAsync(url);

        });

        public string? HttpResponseMessage { get; private set; }
        #endregion
    }
}
