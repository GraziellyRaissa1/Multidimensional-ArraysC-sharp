using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Para acessar um elemento de um array bidimensional, você deve especificar dois índices: um para o array e outro para o elemento dentro desse array. Ou melhor ainda, pensando na visualização da tabela; um para a linha e outro para a coluna (veja exemplo abaixo).

Esta instrução acessa o valor do elemento na primeira linha (0) e na terceira coluna (2) do numbersarray:*/


namespace MultidimensionalArraysCsharp
{
    internal class Exemplo01
    {
        public static void Main(string[] args)

        {
            int[,] numero = {{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, } };

            Console.WriteLine(numero[0,2]);
         }
    }
}
