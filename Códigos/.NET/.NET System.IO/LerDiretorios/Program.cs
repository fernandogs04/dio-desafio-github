string path = @"C:\Users\Fernando\Desktop\DIO Projetos\.NET System.IO\Directory_And_DirectoryInfo\globo";

//LerDiretorios(path);
LerArquivos(path);

Console.WriteLine("Aperte enter para fechar a janela");
Console.ReadLine();

static void LerArquivos (string path)
{
    string[] arquivos = Directory.GetFiles(path,"*",SearchOption.AllDirectories);
    foreach (var arquivo in arquivos)
    {
        var fileInfo = new FileInfo(arquivo);
        Console.WriteLine($"[Nome]:{fileInfo.Name}");
        Console.WriteLine($"[Raiz]:{fileInfo.Length}");
        Console.WriteLine($"[Raiz]:{fileInfo.LastAccessTime}");
        Console.WriteLine($"[Raiz]:{fileInfo.DirectoryName}");
        Console.WriteLine("-----------------------------");
    }
}


static void LerDiretorios (string path)
{
    if (Directory.Exists(path))
    {
        string[] diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
        foreach (var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            Console.WriteLine($"[Nome]:{dirInfo.Name}");
            Console.WriteLine($"[Raiz]:{dirInfo.Root}");
            if (dirInfo.Parent != null)
                Console.WriteLine($"[Pai]:{dirInfo.Parent.Name}");

            Console.WriteLine("-----------------------------");
        }
    }
    else
    {
        Console.WriteLine($"{path} não existe");
    }
}