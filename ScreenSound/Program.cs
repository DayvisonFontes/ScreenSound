Album albumSoad = new Album();
albumSoad.Nome = "Toxicity";

Musica musica1 = new Musica();
musica1.Nome = "Chop suey";
musica1.Duracao = 10;

Musica musica2 = new Musica();
musica2.Nome = "Toxicity";
musica2.Duracao = 5;

albumSoad.AdicionarMusica(musica1);
albumSoad.AdicionarMusica(musica2);

Banda SOAD = new Banda();
SOAD.AdicionarAlbum(albumSoad);
SOAD.ExibirDiscografia();