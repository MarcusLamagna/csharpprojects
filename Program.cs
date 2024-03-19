//Criei uma classe e armezenei uma referência ao objeto em uma variável chamada dice.
/*Regra 1: Seu código deve exibir apenas uma mensagem.
*Regra 2: Se a assinatura do usuário expirar em 10 dias ou menos, exiba a mensagem:
*Regra 4: Se a assinatura do usuário expirar em um dia, exiba as mensagens:
*Regra 5: Se a assinatura do usuário expirou, exiba a mensagem:
*Regra 6: Se a assinatura do usuário não expirar em 10 dias ou menos, não exiba nada.
*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
//Crie uma instrução que exiba uma if-else mensagem sobre quando a assinatura expirará.
//Crie uma declaração separada if que exiba uma oferta de desconto.

if (daysUntilExpiration == 1){
    Console.WriteLine("Your subscription expires within a day!");
}
else if (daysUntilExpiration == 1){
    Console.WriteLine("Your subscription expires within a day");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5){
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <=10){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
if (discountPercentage > 0){
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}