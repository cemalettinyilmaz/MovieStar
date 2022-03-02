using HtmlAgilityPack;
using MovieStarEFUygulama.Data;
using MovieStarEFUygulama.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieStarEFUygulama
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            await VerileriYukle();
            Application.Run(new MainForm());
        }

        static async Task VerileriYukle()
        {
            AppDbContext db = new AppDbContext();

            if (db.Filmler.Any())
                return;

            //1. Adım imdb.com sitesindeki film idlerini okuma.
            List<string> filmIds = new List<string>();

            string url = "https://www.imdb.com/search/title/?groups=top_250&sort=user_rating";
            // string url = "https://www.imdb.com/chart/top/";

            //Web parse işlemi HtmlAgilityPack yüklenir nugetten.
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);
            HtmlNodeCollection films = doc.DocumentNode.SelectNodes("//div[@data-tconst]");//XPATH
            foreach (HtmlNode film in films)
            {
                filmIds.Add(film.Attributes["data-tconst"].Value);

            }

            //2. Adım omdapiye u idlere göre istek atma velen gelen veriyi istediğimiz şekllinde alma.

            //https://www.omdbapi.com/?apikey=569fde10&i=tt10189514

            string apiUrl = "https://www.omdbapi.com/?apikey=569fde10&i=";
            List<MovieDTO> movies = new List<MovieDTO>();
            HttpClient httpClient = new HttpClient();
            foreach (string filmId in filmIds)
            {
                HttpResponseMessage result = await httpClient.GetAsync(apiUrl + filmId);
                if (result.IsSuccessStatusCode)
                {
                    //Microsoft.AspNet.WebApi.Client nugetten indirdik
                    movies.Add(await result.Content.ReadAsAsync<MovieDTO>());
                }
            }
            foreach (MovieDTO movie in movies)
            {
                Film film = new Film()
                {
                    FilmAdi = movie.Title,
                    imdbID = movie.imdbID,
                    IMDBPuani = movie.imdbRating,
                    Yil = movie.Year,
                    Poster = movie.Poster
                };

                string genreAd = movie.Genre.Split(',')[0].Trim();
                Tur tur = db.Turler.FirstOrDefault(x => x.TurAdi == genreAd);
                if (tur != null)
                {
                    film.Tur = tur;
                }
                else
                {
                    film.Tur = new Tur()
                    {
                        TurAdi = genreAd
                    };
                }
                List<string> oyuncular = movie.Actors.Split(',').ToList();
                foreach (var item in oyuncular)
                {
                    Oyuncu oyuncu = db.Oyuncular.FirstOrDefault(x => x.OyuncuAdSoyad == item.Trim());
                    if (oyuncu != null)
                    {
                        film.Oyuncular.Add(oyuncu);
                    }
                    else
                    {
                        film.Oyuncular.Add(new Oyuncu()
                        {
                            OyuncuAdSoyad = item.Trim()
                        });
                    }
                }
                db.Filmler.Add(film);
                await db.SaveChangesAsync();
            }



        }
    }
}
