//***** Filas - QUEUE *****

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
Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");


//***** Pilhas - STACK *****

Stack<int> pilha = new Stack<int>();

//Push insere um objeto no topo da pilha.
pilha.Push(4);
pilha.Push(6);
pilha.Push(8);
pilha.Push(10);

foreach (int item in pilha)
{
    Console.WriteLine(item);
}

//POP remove e retorna um objeto no topo da pilha.
Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

foreach (int item in pilha)
{
    Console.WriteLine(item);
}


//***** DICTIONARY *****

// o primeiro elemento é a chave única e o segundo elemento, é o valor.
Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("AL", "Alagoas");
estados.Add("RS", "Rio Grande do Sul");
estados.Add("MG", "Minas Gerais");

//Acessando um valor do Dictionary
Console.WriteLine(estados["MG"]);
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

//adicionando uma chave já existente, tenho uma exceção retornada.
//estados.Add("AL", "Alagoas");

Console.WriteLine("***************");
//Removo passando a chave.
estados.Remove("MG");
estados["SC"] = "Santa Catarina - valor alterado";

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

//verificando sejá existe uma chave

string chave = "SC";
Console.WriteLine($"Verificando o elemento : {chave}");

if (estados.ContainsKey(chave))
{
    Console.WriteLine($"Valor existente: {chave}");
}
else
{
    Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
}

