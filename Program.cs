using System;
using System.Net.Http;
using System.Text.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8;

HttpClient cliente = new HttpClient();
string url = "https://catfact.ninja/fact";

Console.WriteLine("Iniciando requisição para obter um fato sobre gatos:");
Console.WriteLine();
Console.WriteLine(" " + url);
Console.WriteLine();

// pega o texto que a api devolve
string resposta = await cliente.GetStringAsync(url);

// transforma o texto em json e pega o fato
JsonDocument json = JsonDocument.Parse(resposta);
string? fato = json.RootElement.GetProperty("fact").GetString();

Console.WriteLine("Fato sobre Gatos:");
Console.WriteLine(fato);