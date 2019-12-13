using System;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        char[] brackets = new char[] { '(', ')', '[', ']', '{', '}' };
        char[] sequencia = new char[] { '{', '[', '(', '{',  '{', '[', '[', '(', '(', ')', ')', ']', ']', '}', '}', ')', ']', '}' };
        Console.WriteLine(String.Format("A seguinte sequência de brackets será testada: {0}", String.Join(", ", sequencia)));
        bool balanceada = true;
        for (int x = 0; x < sequencia.Length / 2; x++)
        {
            int bracketSequenciaEsquerda = x;
            int bracketSequenciaDireita = sequencia.Length - x - 1;
            bool bracketEsquerdaEsperado = brackets.ToList().FindIndex(br => br == sequencia[bracketSequenciaEsquerda]) % 2 == 0;
            int bracketDireitaEsperado = brackets.ToList().FindIndex(br => br == sequencia[x]) + 1;
            if (!bracketEsquerdaEsperado || sequencia[bracketSequenciaDireita] != brackets[bracketDireitaEsperado])
            {
                Console.WriteLine(String.Format("O bracket '{0}' na posição {1} não balanceia com o bracket '{2}' na posição {3}", sequencia[bracketSequenciaEsquerda], bracketSequenciaEsquerda, sequencia[bracketSequenciaDireita], bracketSequenciaDireita));
                balanceada = false;
                break;
            }
        }
        Console.WriteLine(String.Format("A sequência de brackets{0}está balanceada", balanceada? " ": " não "));
        Console.ReadKey();
    }
}