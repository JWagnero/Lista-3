/*-------------------------------------------------------------------
Questão 5: Sistema de Recompensas Diárias com Limites e Bônus
Contextualização
Em um jogo online, os jogadores ganham recompensas diárias por logarem consecutivamente. 
A cada dia consecutivo, o valor da recompensa aumenta, mas há um limite diário. Além disso, 
se o jogador atingir certos marcos de dias, recebe bônus adicionais.
Comando
Crie um programa em C# que:
1. Pergunte ao jogador por quantos dias consecutivos ele logou no jogo.
2. Pergunte qual é a recompensa inicial em moedas no primeiro dia.
3. Pergunte qual é o incremento da recompensa a cada dia consecutivo.
4. (Opcional) Pergunte se o jogador deseja considerar bônus por marcos de dias 
(Sim/Não). Se sim, pergunte a cada quantos dias consecutivos há um bônus e qual o 
valor do bônus.
O programa deve calcular e exibir o total de moedas acumuladas pelo jogador, incluindo os 
bônus se aplicável.
Observações:
• Sem considerar bônus (Input 4 = Não): Apenas soma das recompensas diárias.
• Considerando bônus (Input 4 = Sim): Além da soma das recompensas diárias, 
adiciona o bônus a cada marco alcançado.

@Lista: 03 - Laços de Repetição
@Autor: João Wagner
@Data: 03/09/2024
---------------------------------------------------------------------*/

using System;
class Program
{
    static void Main(string[] args)
    {
        {
            int diasJogados, recompensaInicial, incremento, totalMoedas = 0;
            bool temBonus;

            Console.Write("Por quantos dias consecutivos você jogou? ");
            int.TryParse(Console.ReadLine(), out diasJogados);

            Console.Write("Qual é a recompensa inicial em moedas no primeiro dia? ");
            int.TryParse(Console.ReadLine(), out recompensaInicial);

            Console.Write("Qual é o incremento da recompensa a cada dia consecutivo? ");
            int.TryParse(Console.ReadLine(), out incremento);

            Console.Write("Deseja considerar bônus por marcos de dias? (Sim/Não) ");
            temBonus = Console.ReadLine() == "sim";

            if (temBonus)
            {
                int diasPorBonus, valorBonus;
                Console.Write("A cada quantos dias consecutivos há um bônus? ");
                int.TryParse(Console.ReadLine(), out diasPorBonus);
                Console.Write("Qual o valor do bônus? ");
                int.TryParse(Console.ReadLine(), out valorBonus);

                for (int dia = 1; dia <= diasJogados; dia++)
                {
                    totalMoedas += recompensaInicial + (dia - 1) * incremento;
                    if (dia % diasPorBonus == 0)
                        totalMoedas += valorBonus;
                }
            }
            else
            {
                for (int dia = 1; dia <= diasJogados; dia++)
                {
                    totalMoedas += recompensaInicial + (dia - 1) * incremento;
                }
            }

            Console.WriteLine($"O total de moedas acumuladas é: {totalMoedas}");
        }


        Console.WriteLine("Pressione ENTER para encerrar o código");
        Console.ReadKey();
    }
}