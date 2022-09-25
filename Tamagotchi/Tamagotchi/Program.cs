using RestSharp;
using System;
using System.Text.Json;
using Tamagotchi;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("7DaysOfCode - C# 2/7: Conexão com uma API Rest \r\n");
        Console.WriteLine("Qual espécie: ");
        string especie = Console.ReadLine();

        var url = $"https://pokeapi.co/api/v2/pokemon/{especie}";
        var client = new RestClient(url);
        var request = new RestRequest(url, Method.Get);
        RestResponse response = await client.ExecuteAsync(request);

        Console.WriteLine("\r\n_______________________________________\r\n\r\n");

        if (response.IsSuccessful)
        {
            var pokemon = JsonSerializer.Deserialize<Pokemon>(response.Content);

            Console.WriteLine($"Nome Pokemon: {pokemon.name}");
            Console.WriteLine($"Altura: {pokemon.height}");
            Console.WriteLine($"Peso: {pokemon.weight}");
            Console.WriteLine($"Habilitades: ");

            foreach (var item in pokemon.abilities)
            {
                Console.WriteLine($"    - {item.ability.name}");
            }
        }
        else
        {
            Console.WriteLine($"Não Encontrado");
        }
    }
}