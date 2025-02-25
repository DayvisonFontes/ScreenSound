class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(musica => musica.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"O album {Nome} contém as seguintes musicas\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"♫ {musica.Nome}");
        }
        Console.WriteLine($"\nEste album inteiro tem {DuracaoTotal} min de duração total.");
    }
}