class Usuario 
{ 
    public string Nome { get; }
    List<Musica> playlist = new List<Musica>();

    public Usuario(string nome) {
        Nome = nome;
    }

    public void AdicionarMusicaNaPlaylist(Musica musica) 
    {
        playlist.Add(musica);
    }

    public void MostrarPlaylist() 
    {
        foreach(Musica musica in playlist) 
        {
            Console.WriteLine(musica.Nome);
        }
    }

    public void MostrarNomeDoUsuario() 
    {
        Console.WriteLine($"Nome do usuário: {Nome}");
    }
}