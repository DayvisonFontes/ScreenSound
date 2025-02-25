class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}";

    public void ExibirFichaTecinica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine($"A música {Nome} está dísponivel nas plataformas digitais");
        }
        else
        {
            Console.WriteLine($"A música {Nome} não está dísponivel nas plataformas digitais");
        }
    }
}
