using excecoesEcolecoes.Models;


//string[] linhas = File.ReadAllLines("C:\\Users\\kelly\\source\\repos\\excecoesEcolecoes\\excecoesEcolecoes\\Arquivos\\arquivoLeitura.txt");

//foreach (string linha in linhas)
//{
//    Console.WriteLine(linha);
//}


//LeituraArquivo arquivo = new LeituraArquivo();

//var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("C:\\Users\\kelly\\source\\repos\\excecoesEcolecoes\\excecoesEcolecoes\\Arquivos\\arquivoLeitura.txt");

//if (sucesso)
//{

//    foreach (string linha in linhasArquivo)
//    {
//        Console.WriteLine(linha);
//    }
//}
//else
//{
//    Console.WriteLine("Não foi possível ler o arquivo");
//}

Queue<int> fila = new Queue<int>();

fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
fila.Enqueue(8);

foreach (int item in fila)
{
    Console.WriteLine(item);
}

// removendo elemento da fila. Ele sempre remove o 1º elemento, é uma regra da QUEUE.
Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"  );
