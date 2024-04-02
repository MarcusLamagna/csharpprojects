//CRiar e inicializar uma matriz de int
int[] inventory = { 200, 450, 700, 175, 250 };

//Declarando uma nova variável
int sum = 0;
int bin = 0;

//Adicionar uma instrução foreach para iterar através da matriz
foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

//Exibir o valor final da soma
Console.WriteLine($"We have {sum} items in inventory.");