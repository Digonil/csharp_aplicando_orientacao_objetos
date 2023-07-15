class Album 
{
    public string Nome { get; set; }
    public int DuracaoTotal => listaDeMusicas.Sum( m => m.Duracao);

    //Lista privada para a classe
    private List<Musica> listaDeMusicas = new List<Musica>();

    //Método público para adição de música na lista
    public void AdicionarMusica(Musica musica) 
    {
        listaDeMusicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum() 
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}");
        foreach(var musica in listaDeMusicas) 
        {
            Console.WriteLine($"Musica: {musica.Nome}");         
        }
        Console.WriteLine($"Para ouvir esse álbum inteiro, você precisa de {DuracaoTotal}");
    }
}