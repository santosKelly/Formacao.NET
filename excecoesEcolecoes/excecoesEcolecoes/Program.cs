using excecoesEcolecoes.Models;


string[] linhas = File.ReadAllLines("C:\\Arquivos\\arquivoLeitura.txt");

foreach (string linha in linhas)
{
    Console.WriteLine(linha);
}


LeituraArquivo arquivo = new LeituraArquivo();

var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("\\Arquivos\\arquivoLeitura.txt");

if (sucesso)
{

    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possível ler o arquivo");
}


