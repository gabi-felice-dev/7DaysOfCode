
using RestSharp;

internal class Program
{
    private static async Task Main(string[] args)
    {
        Console.WriteLine("7DaysOfCode - C# 1/7: Conexão com uma API Rest");

        var url = "https://pokeapi.co/api/v2/pokemon";
        var client = new RestClient(url);
        var request = new RestRequest(url, Method.Get);
        RestResponse response = await client.ExecuteAsync(request);

        Console.WriteLine(response.Content);
    }
}