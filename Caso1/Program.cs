using Caso1;

var lista = new List<int> { 1, 2, 2, 3, 4, 0, -5, 6 };

var algoritmo = new OrderRange();
var (listaPar, listaImpar) = OrderRange.Build(lista);

Console.WriteLine("Pares: " + string.Join(", ", listaPar));
Console.WriteLine("Impares: " + string.Join(", ", listaImpar));