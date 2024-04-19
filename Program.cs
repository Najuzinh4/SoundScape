using SoundScape.Models;
using System.Text.Json;
using SoundScape.Filtros;
//não coloquei o ; no final -> significa que vamos usar esse recurso, só que só dentro do using, mas porque isso?
//O using já conhecemos, só que em outro contexto, esse tem o contexo de gerenciar o recurso e esse recurso vai ser gerenciado até o final quando a chave fecha, quando fehcar eu vou liberar esse recurso que
//no caso é o objeto client.
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //o Async vamos utilizar pois a gente nao sabe quantas musicas tem ai nem o tamnaho do recurso que a gente vai ta recebendo e queremos garantir que iremos receber todos os recursos
        //o Await vai esperar a tarefa ser concluida para ser concluida e depois você coloca o resultado da tarefa e coloca no resultado.
        Console.WriteLine(resposta);

        //O deserialize vai fazer o seguinte: pega esse json e converte esse json em um objeto que é manipula´vel no c# e esse processo se chama Desserialização (comum em várias linguagens).
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltraTodososGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Ariana Grande");

        var musicasPreferidasDoDaniel

    }
    catch (Exception ex)
    {s
        Console.WriteLine($"Temos um problema: {ex.Message}");

    }
    
}