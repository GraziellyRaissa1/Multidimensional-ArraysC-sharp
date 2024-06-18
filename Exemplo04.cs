using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Você também pode usar um loop for . Para arrays multidimensionais, você precisa de um loop para cada uma das dimensões do array.

Observe também que temos que usar GetLength()em vez de Length para especificar quantas vezes o loop deve ser executado:*/

namespace MultidimensionalArraysCsharp
{
    internal class Exemplo04
    {
        public static void Main(string[] args)

        {
            int[,] numero = { { 1, 4, 2 }, { 3, 6, 8 } };


            for (int i = 0; i < numero.GetLength(0); i++)

            {
                for (int j = 0; j < numero.GetLength(1); j++)

                {
                    Console.WriteLine(numero[i, j]);
                }
            }
        }
    }
}
