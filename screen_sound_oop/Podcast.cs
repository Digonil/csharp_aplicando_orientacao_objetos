class Podcast 
{
    public string HostName { get; }
    public string Nome { get; }
    public int TotalEpisodios => episodios.Count;

    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string hostName, string nome ) 
    {
        HostName = hostName;
        Nome = nome;
    }

    public void AdicionarEpisodio(Episodio episodio) 
    {
        episodios.Add( episodio );
    }

    public void ExibirDetalhes() 
    {
        Console.WriteLine($"Podcast: {Nome} e Host: {HostName}\n");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem)) 
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine(TotalEpisodios);

    }

}