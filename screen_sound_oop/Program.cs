Album albumQueen = new Album();
albumQueen.Nome = "A nigth at the opera";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Duracao = 213;


Musica musica2= new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);

albumQueen.ExibirMusicasDoAlbum();


/* Exemplo de criação de classe adicionando possibilidades de aplicação de regras de negócio.
 class Endereco
{
    private string rua;
    private string cidade;
    private string estado;

    public string Rua
    {
        get { return rua; }
        set { rua = value; }
    }

    public string Cidade
    {
        get { return cidade; }
        set { cidade = value; }
    }

    public string Estado
    {
        get { return estado; }
        set { estado = value; }
    }
}

 */















/*
Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;
Console.WriteLine(musica1.DescricaoResumida);


Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;
Console.WriteLine(musica2.Disponivel);

musica1.ExibirFichaTecnica();

musica2.ExibirFichaTecnica();

musica1.ExibirNomeMusicaEArtista();

musica2.ExibirNomeMusicaEArtista();
*/

// Declaraçao de função lambda
// public int somar (int a, int b) => a + b;