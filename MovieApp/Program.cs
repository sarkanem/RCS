using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi sev interesējošo filmu: ");
            string nosaukums = Console.ReadLine();
            
            using(HttpClient client = new HttpClient())
            // labais taustiņs uz HttpCleint un pieliek automātiski NuGet package bibliotēku
            // liek using lai atbrīvotu atmiņu 
            {
                client.BaseAddress = new Uri("http://www.omdbapi.com/");

                var response = client.GetAsync(String.Format("?apikey=184ff483&s={0}", nosaukums)).Result; // rezultāts ir jāieliek mainīgajā

                if (response.IsSuccessStatusCode) // pārbauda vai nav servera errori piem. 5xx errori
                {
                    SearchResult result = response.Content.ReadAsAsync<SearchResult>().Result;

                    if (result.Response == "False")
                    {
                        Console.WriteLine("Filma netika atrasta!");
                    }

                    else
                    {
                        foreach (Movie movie in result.Search)
                        {
                            Console.WriteLine("Nosaukums = {0}, gads = {1}", movie.Title, movie.Year);
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Notika neparedzēta kļūda");
                }                
            }
            Console.ReadLine();
        }
    }
}
