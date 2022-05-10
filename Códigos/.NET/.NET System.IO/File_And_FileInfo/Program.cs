using static System.Console;

WriteLine("Digite o nome do arquivo");
var nome = ReadLine();
nome = LimparNome(nome);

string path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt");

CriarArquivo(path);

WriteLine("Digite enter para finalizar");
ReadLine();

static string LimparNome (string nome) {
    foreach (var item in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(item, '-');
        WriteLine(item);
    }
    return nome;
}

static void CriarArquivo (string path) {
    try
    {
        using StreamWriter sw = File.CreateText(path);

        sw.WriteLine("Esta é a linha 1 do arquivo");
        sw.WriteLine("Esta é a linha 2 do arquivo");
        sw.WriteLine("Esta é a linha 3 do arquivo");
    }
    catch
    {
        WriteLine("Nome do arquivo invalido");
    }

    
}
