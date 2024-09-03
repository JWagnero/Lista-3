/*-------------------------------------------------------------------
Questão 4: Jornada do Herói com Pontos de Vida e Itens de Cura
Contextualização
O herói de um jogo atravessa várias fases, ganhando ou perdendo pontos de vida. Além disso, 
em algumas fases, o herói pode usar itens de cura para recuperar pontos de vida.
Comando
Desenvolva um programa em C# que:
1. Pergunte ao jogador quantas fases ele deseja jogar.
2. Para cada fase, pergunte quantos pontos de vida o herói ganhou ou perdeu (valores 
positivos indicam ganho e negativos indicam perda).
3. Para cada fase, pergunte se o herói usou um item de cura (Sim/Não). Se sim, pergunte 
quantos pontos de cura foram usados.
O programa deve calcular e mostrar a vida total do herói ao final da jornada, considerando que 
ele começa com 100 pontos de vida.

@Lista: 03 - Laços de Repetição
@Autor: João Wagner
@Data: 03/09/2024
---------------------------------------------------------------------*/

using System;
class Program {
    static void Main(string[] args) 
    {
            int vidaTotal = 100;
            int numFases, pontosVida, pontosCura;
            string? respostaCura;

            Console.WriteLine("Bem-vindo ao jogo de aventura!");
            Console.Write("Quantas fases você deseja jogar? ");
             int.TryParse(Console.ReadLine(), out numFases);

            for (int i = 1; i <= numFases; i++)
            {
                Console.WriteLine($"Fase {i}:");
                Console.Write("Quantos pontos de vida você ganhou/perdeu? ");
                int.TryParse(Console.ReadLine(), out pontosVida);
                vidaTotal += pontosVida;

                Console.Write("Você usou um item de cura? (Sim/Não) ");
                respostaCura = Console.ReadLine();
                if (respostaCura == "SIM")
                {
                    Console.Write("Quantos pontos de cura foram usados? ");
                    int.TryParse(Console.ReadLine(), out pontosCura);
                    vidaTotal += pontosCura;
                }
            }

            Console.WriteLine($"A vida total do herói ao final da jornada é: {vidaTotal}");


        Console.WriteLine("Pressione ENTER para encerrar o código");
        Console.ReadKey();
    }
}