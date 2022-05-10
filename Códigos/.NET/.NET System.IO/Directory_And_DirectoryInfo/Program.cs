CriarDiretoriosGlobo();

CriarArquivo();

string origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
string destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Brasil", "brasil.txt");

MoverArquivo(origem, destino);

static void MoverArquivo(string pathOrigem, string destino)
{
    if (!File.Exists(pathOrigem))
    {
        Console.WriteLine("Arquivo de origem não existe");
        return;
    }
    if (File.Exists(destino))
    {
        Console.WriteLine("Arquivo de destino já existe");
        return;
    }
    
    File.Move(pathOrigem, destino);
}

static void CriarArquivo ()
{
    string path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
    if (!File.Exists(path))
    {
        using StreamWriter sw = File.CreateText(path);
        sw.WriteLine("População: 213MM");
        sw.WriteLine("IDH: 0,901");
        sw.WriteLine("Dados atualizados em: 20/04/2018");
    }
}


static void CriarDiretoriosGlobo ()
{   
    string path = Path.Combine(Environment.CurrentDirectory, "globo");

    if(!Directory.Exists(path))
    {
        DirectoryInfo dirGlobo = Directory.CreateDirectory(path);

        DirectoryInfo dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
        DirectoryInfo dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
        DirectoryInfo dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("Canada");
        dirAmNorte.CreateSubdirectory("Mexico");

        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Paraguai");
    }
}

