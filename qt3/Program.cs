/*-------------------------------------------------------------------
Questão 3: Gerenciamento de Inventário com Limite e Tipos de 
Itens
Contextualização
Em um RPG, o jogador gerencia um inventário com diferentes tipos de itens, cada um com sua 
quantidade específica. O inventário tem um limite máximo de itens que pode conter.
Comando:
Crie um programa em C# que:
1. Pergunte ao jogador quantos tipos diferentes de itens ele deseja armazenar no 
inventário.
2. Para cada tipo de item, pergunte o nome do item e quantos itens desse tipo ele possui.
3. Pergunte ao jogador qual é a capacidade máxima do inventário.
O programa deve calcular e mostrar a quantidade total de itens no inventário e verificar se está 
dentro da capacidade máxima, informando se está excedido ou não.

@Lista: 03 - Laços de Repetição
@Autor: João Wagner
@Data: 03/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Main(string[] args)
    {
        int numTipos, capacidadeMaxima;

        Console.Write("Quantos tipos diferentes de itens você deseja armazenar? ");
        int.TryParse(Console.ReadLine(), out numTipos);

        string?[] nomesItens = new string?[numTipos];
        int[] quantidadesItens = new int[numTipos];
        /*
        variavel[] nome = new variavel[variavel inteira ou numero inteiro]
        */
        for (int i = 0; i < numTipos; i++)
        {
            Console.Write($"Digite o nome do item {i + 1}: ");
            nomesItens[i] = Console.ReadLine();

            Console.Write($"Digite a quantidade de {nomesItens[i]}: ");
            int.TryParse(Console.ReadLine(), out quantidadesItens[i]);
        }


        Console.Write("Qual é a capacidade máxima do seu inventário? ");
        int.TryParse(Console.ReadLine(), out capacidadeMaxima);


        int quantidadeTotal = 0;
        for (int i = 0; i < numTipos; i++)
        {
            quantidadeTotal += quantidadesItens[i];
        }

        if (quantidadeTotal <= capacidadeMaxima)
        {
            Console.WriteLine($"A quantidade total de itens ({quantidadeTotal}) está dentro da capacidade máxima.");
        }
        else
        {
            Console.WriteLine($"A quantidade total de itens ({quantidadeTotal}) excede a capacidade máxima do inventário.");
        }

        Console.WriteLine("Pressione ENTER para encerrar o código");
        Console.ReadKey();
    }
}