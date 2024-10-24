﻿// As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. 
// Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.

Console.WriteLine(@"
   +--------------------------------------+
   |           Mercado de maçãs           |
   + -------------------------------------+
   ");


Console.Write("Digite o número de maçãs compradas: ");
int quantidade = int.Parse(Console.ReadLine());

decimal precoUnitario;

if (quantidade < 12)
{
    precoUnitario = 0.30m;
}
else
{
    precoUnitario = 0.25m;
}

decimal total = quantidade * precoUnitario;

Console.WriteLine($"O valor total da compra é: R$ {total}");