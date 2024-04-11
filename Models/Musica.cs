using System.Text.Json.Serialization;

namespace SoundScape.Models;

internal class Musica
{
    [JsonPropertyName("song")] //Atributo que representa um metadado específica para a prorpiedade nome
    public string? Nome { get; set; }

    [JsonPropertyName("artist")]
    public string? Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Música: {Nome}");
        Console.WriteLine($"Duração em segundos: {Duracao /1000}");
        Console.WriteLine($"Gênero musical: {Genero}");
    }

}
