/*-------------------------------------------------------------------
Questão 2: Cálculo de Pontuação por Missão com Níveis de 
Dificuldade
Contextualização:
Em um jogo de aventuras, um jogador completa missões com diferentes níveis de dificuldade. 
Cada nível de dificuldade afeta a pontuação ganha por inimigo derrotado.
Comando:
Desenvolva um programa em C# que:
1. Pergunte ao jogador quantas missões ele completou.
2. Para cada missão, pergunte qual o nível de dificuldade (Fácil, Médio, Difícil).
3. Para cada missão, pergunte quantos inimigos ele derrotou.
A pontuação por inimigo depende do nível de dificuldade:
• Fácil: 50 pontos por inimigo
• Médio: 100 pontos por inimigo
• Difícil: 150 pontos por inimigo
O programa deve calcular e exibir a pontuação total acumulada pelo jogador.

@Lista: 03 - Laços de Repetição
@Autor: João Wagner
@Data: 03/09/2024
---------------------------------------------------------------------*/

using System;

    class Program
    {
        static void Main(string[] args)
        {
            int totalMissões, totalInimigos, pontuacaoTotal = 0;
            string? dificuldade;

            Console.Write("Quantas missões você completou? ");
            int.TryParse(Console.ReadLine(),out  totalMissões);

            for (int i = 1; i <= totalMissões; i++)
            {
                Console.Write($"Missão {i}: Qual o nível de dificuldade (Fácil, Médio, Difícil)? ");
                dificuldade = Console.ReadLine();

                Console.Write($"Missão {i}: Quantos inimigos você derrotou? ");
                int.TryParse(Console.ReadLine(), out totalInimigos);

                switch (dificuldade)
                {
                    case "fácil":
                        pontuacaoTotal += totalInimigos * 50;
                        break;
                    case "médio":
                        pontuacaoTotal += totalInimigos * 100;
                        break;
                    case "difícil":
                        pontuacaoTotal += totalInimigos * 150;
                        break;
                    default:
                        Console.WriteLine("Nível de dificuldade inválido.");
                        break;
                }
            }

            Console.WriteLine($"Sua pontuação total é: {pontuacaoTotal}");
        }
    }