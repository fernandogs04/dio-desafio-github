using System.Text;

StringBuilder sb = new StringBuilder();

sb.AppendLine("Caracteres na primeira linha para ler");
sb.AppendLine("e a segunda linha");
sb.AppendLine("e o fim");

using StringReader sr = new StringReader(sb.ToString());
char[] buffer = new char[10];
int tamanho = 0;

do
{
    buffer = new char[10];
    tamanho = sr.Read(buffer);
    Console.WriteLine(string.Join("", buffer));
}
while (tamanho >= buffer.Length);



Console.ReadLine();