class Banda
{
    private List<Album> albuns = new List<Album>();
    public string Nome { get; set; }

    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}\n");
        foreach (var album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome} ({album.DuracaoTotal} Min)");
        }
    }
}