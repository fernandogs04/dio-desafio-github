string path = @"C:\Users\Fernando\Desktop\DIO Projetos\.NET System.IO\Directory_And_DirectoryInfo\globo";

using FileSystemWatcher fsw = new FileSystemWatcher(path);

fsw.Created += OnCreated;
fsw.Renamed += OnRenamed;
fsw.Deleted += OnDeleted;

fsw.EnableRaisingEvents = true;
fsw.IncludeSubdirectories = true;

Console.WriteLine("Pressione enter para finalizar");
Console.ReadLine();

void OnCreated(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi criado o arquivo {e.Name}");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    Console.WriteLine($"Foi renomeado o arquivo {e.OldName} para {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Foi excluído o arquivo {e.Name}");
}