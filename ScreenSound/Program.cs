Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Dayvison");
ep1.AdicionarConvidados("Giovanna");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(1, "Técnicas de aprendizado", 50);
ep2.AdicionarConvidados("Joao");
ep2.AdicionarConvidados("Maria");
Console.WriteLine(ep2.Resumo);

Podcast pd1 = new("Técnicas", "Cleber");
pd1.AdicionarEpisodio(ep1);
pd1.AdicionarEpisodio(ep2);

pd1.ExibirDetalhes();
