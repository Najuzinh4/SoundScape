using SoundScape.Models;
namespace SoundScape.Filtros;


internal class LinqFilter
{
    public static void FiltraTodososGenerosMusicais(List <Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais) 
        { 
            Console.WriteLine($"-{genero}");
        }
    }
}
