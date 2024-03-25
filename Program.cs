//Declarando nova matriz - Atribuir valores a elementos de uma matriz

//string[] fraudulentOrderIDs = new string[3];

//fraudulentOrderIDs[0] = "A123";
//fraudulentOrderIDs[1] = "B456";
//fraudulentOrderIDs[2] = "C789";

//Inicializar uma matriz

string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"First: {fraudulentOrderIDs[1]}");
Console.WriteLine($"First: {fraudulentOrderIDs[2]}");

//REatribuir o vaor de uma matriz
fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassing First: {fraudulentOrderIDs[0]}");

//No final do arquivo de código, para relatar o número de pedidos fraudulentos, digite o seguinte código:
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");