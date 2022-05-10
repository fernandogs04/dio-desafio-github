string textReaderText = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. " + 
    "Etiam quis metus id tortor cursus ultricies nec vitae turpis. " +
    "Nullam eleifend lorem ut diam facilisis, nec ultrices ipsum porta. " +
    "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.\n\n" +
    "Curabitur vel felis diam. " +
    "Quisque cursus tempus maximus. " +
    "Aliquam ut fringilla orci, sed condimentum mi. " +
    "Nulla in lorem laoreet, elementum lacus eget, rhoncus diam. " +
    "Donec bibendum est quis metus aliquet, et elementum nisi accumsan.\n\n" +
    "Curabitur vitae enim imperdiet, rhoncus ante id, rutrum nisi. " +
    "Etiam rhoncus felis sit amet sapien tempor vulputate. " +
    "Nunc rutrum molestie purus in pellentesque. " +
    "Phasellus finibus est at erat elementum dapibus.";

Console.WriteLine($"Texto original: {textReaderText}");

string linha, paragrafo = null;

StringReader sr = new StringReader(textReaderText);

while (true)
{
    linha = sr.ReadLine();
    if (linha != null)
    {
        paragrafo += linha + " ";
    }
    else
    {
        paragrafo += "\n";
        break;
    }
}

Console.WriteLine($"Texto modificado: {paragrafo}");
int caractereLido;
char caractereConvertido;

StringWriter sw = new StringWriter();
sr = new StringReader(paragrafo);

while(true)
{
    caractereLido = sr.Read();
    if (caractereLido == -1) break;

    caractereConvertido = Convert.ToChar(caractereLido);

    if (caractereLido == '.')
    {
        sw.Write("\n\n");

        sr.Read();
        sr.Read();
    }
    else
    {
        sw.Write(caractereConvertido);
    }

    Console.WriteLine($"Texto convertido armazenado na StringWriter: {sw.ToString()}");
}