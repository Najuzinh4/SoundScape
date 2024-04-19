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

    public static void FiltrarArtistasPorGeneroMusical(List <Musica> musicas, string genero)
    {
        var artistarPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >> {genero}");
        foreach(var artista in artistarPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }
 
    public static void FiltrarMusicasDeUmArtista(List <Musica> musicas, string nomeDoArtista)
    {
        var musicasDoArtistas = musicas.Where(musica => musica.Artista!.Equals(nomeDoArtista)).ToList();
        Console.WriteLine(nomeDoArtista);
        foreach (var musica in musicasDoArtistas) 
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

}
