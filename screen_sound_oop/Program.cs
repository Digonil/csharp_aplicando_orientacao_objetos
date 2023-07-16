Banda queen = new Banda("Queen");

Album albumQueen = new Album("A nigth at the opera");


Musica musica1 = new Musica(queen, "Love of my life") 
{
    Duracao = 213,
    Disponivel = true
};



Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false
};


albumQueen.AdicionarMusica(musica1);
albumQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();



albumQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();

Usuario usuario01 = new Usuario("Diego");
usuario01.AdicionarMusicaNaPlaylist(musica1);
usuario01.AdicionarMusicaNaPlaylist(musica2);
usuario01.MostrarNomeDoUsuario();
usuario01.MostrarPlaylist();


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