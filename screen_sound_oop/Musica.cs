﻿class Musica 
{
   public string Nome { get; }
   public Banda Artista { get; }
   public int Duracao { get; set; }
   public bool Disponivel { get; set; }
   public Genero Genero { get; set; }

   //Propriedade somente leitura
   public string DescricaoResumida => $"A música {Nome} pretence á banda {Artista}";


   
   public Musica(Banda artista, string nome) 
   {
        Artista= artista;
        Nome= nome;
   }

    public void ExibirFichaTecnica() 
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
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