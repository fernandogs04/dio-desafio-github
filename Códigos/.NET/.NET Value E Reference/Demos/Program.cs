public class Program {

    static void Main(string[] args)
    {
        int[] numeros = new int[]{ 0, 2, 4, 6, 8 };

        System.Console.WriteLine($"Digite o número que gostaria de encontrar");

        var numero = int.Parse(System.Console.ReadLine());

        var idxEncontrado = EncontrarNumero(numeros, numero);

        if (idxEncontrado >= 0)
        {
            System.Console.WriteLine($"O numero digitado está na posição {idxEncontrado}");
        }
        else {
            System.Console.WriteLine("Numero não foi encontrado");
        }
    }

    static int EncontrarNumero (int[] numeros, int numero)
    {
        for (int i = 0; i < numeros.Length; i++)
        {
            if (numeros[i] == numero)
            {
                return i;
            }
        }
        return -1;
    }
    
    /*
    static void Demo1() {
        int a = 2;
        a = Adicionar20(a);
        Console.WriteLine($"O valor da variável é: {a}");
    }
    static int Adicionar20(int x)
    {
        return x + 20;
    }
    */

    /*
    static void Demo2() {
        Pessoa p1 = new Pessoa();
        p1.Nome = "Ricardo";
        p1.Idade = 30;
        p1.Documento = "1234";

        Pessoa p2 = p1.Clone();

        TrocarNome(p1, "José");

        Console.WriteLine($@"
        O nome p1 é {p1.Nome}
        O nome p2 é {p2.Nome}
        ");
    }
    static void TrocarNome (Pessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
    }
    */
    

    /*
    static void Demo3() {
        StructPessoa p1 = new StructPessoa()
        {
            Documento = "1234",
            Idade = 30,
            Nome = "Ricardo"
        };

        StructPessoa p2 = p1;

        p1 = TrocarNome(p1, "João");

        Console.WriteLine($@"
        O nome p1 é {p1.Nome}
        O nome p2 é {p2.Nome}
        ");
    }

    static StructPessoa TrocarNome (StructPessoa p1, string nomeNovo)
    {
        p1.Nome = nomeNovo;
        return p1;
    }
    */

    /*
    static void Demo4() {
        string nome = "Ricardo";

        TrocarNome(nome, "José");

        Console.WriteLine($"O novo nome é {nome}");
    }
    static void TrocarNome (string nome, string nomeNovo) {
        nome = nomeNovo;
    }
    */

    /*
    static void Demo1() {
        int[] pares = new int[]{ 0, 2, 4, 6, 8 };

        MudarParaImpar(pares);

        Console.WriteLine($"Os impares {string.Join(", ", pares)}");
    }
    static void MudarParaImpar(int[] pares) {
        for (int i = 0; i < pares.Length; i++)
        {
            pares[i] = pares[i] + 1;
        }
    }
    */

}