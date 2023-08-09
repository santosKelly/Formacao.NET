using excecoesEcolecoes.Models;

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
