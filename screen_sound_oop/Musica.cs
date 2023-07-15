class Musica 
{
   public string Nome { get; set; }
   public string Artista { get; set; }
   public int Duracao { get; set; }
   public bool Disponivel { get; set; }
   public Genero Genero { get; set; }


    //Propriedade somente leitura
    public string DescricaoResumida => $"A música {Nome} pretence á banda {Artista}";


    public void ExibirFichaTecnica() 
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel) 
        {
            Console.WriteLine($"Dísponivel no plano");
        } else 
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
            
    }

    public void ExibirNomeMusicaEArtista() 
    {
        Console.WriteLine($"Nome: {Nome} artista: {Artista}");
    }
}