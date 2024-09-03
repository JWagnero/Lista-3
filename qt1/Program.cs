/*-------------------------------------------------------------------
Questão 1: Coleção de Itens Raros com Variações de Baús
Contextualização:
Em um jogo de exploração, o jogador pode abrir diferentes tipos de baús em uma masmorra. 
Cada tipo de baú possui uma variação na quantidade de itens raros que pode conter.
Comando:
Crie um programa em C# que simule a coleta de itens raros a partir de diferentes tipos de baús. 
O programa deve:
1. Perguntar ao jogador quantos baús ele deseja abrir.
2. Perguntar ao jogador quantos tipos diferentes de baús existem no jogo.
3. Para cada tipo de baú, perguntar quantos baús desse tipo o jogador deseja abrir.
Para cada baú aberto, dependendo do tipo, gerar aleatoriamente a quantidade de itens raros 
obtidos:
• Tipo A: 0 a 3 itens
• Tipo B: 1 a 5 itens
• Tipo C: 2 a 6 itens
• (Adapte conforme o número de tipos definidos pelo jogador)
O programa deve calcular e exibir a quantidade total de itens raros obtidos após abrir todos os 
baús.

@Lista: 03 - Laços de Repetição
@Autor: João Wagner
@Data: 03/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int qntdTotal, qntdTipos, qntdAbrir;

        System.Console.WriteLine("Fale a qauntidade total de baús: ");
        int.TryParse(Console.ReadLine(), out qntdTotal);

        System.Console.WriteLine("Fale a qauntidade baús existentes: ");
        int.TryParse(Console.ReadLine(), out qntdTipos);

        for (int i = 1; i <= qntdTipos; i++)
        {
            System.Console.WriteLine($"No {i}° tipo quantos serão abertos: ");
            int.TryParse(Console.ReadLine(), out qntdAbrir);

            while (qntdTotal - qntdAbrir < 0)
            {
                System.Console.WriteLine("Quantitade insuficiente");
                int.TryParse(Console.ReadLine(), out qntdAbrir);

            }
            qntdTotal -= qntdAbrir;
            
            for (int j = 1; j <= qntdAbrir; j++)
            {
                System.Console.WriteLine($"O {j}° baú do {i}° tipo é: {random.Next(0,11)}");
            }

        }

        Console.WriteLine("Pressione ENTER para encerrar o código");
        Console.ReadKey();
    }
}