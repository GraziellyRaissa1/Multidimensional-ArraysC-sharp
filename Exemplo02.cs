using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Você também pode alterar o valor de um elemento.

O exemplo a seguir alterará o valor do elemento na primeira linha (0) e na primeira coluna (0) :*/

namespace MultidimensionalArraysCsharp
{
    internal class Exemplo02
    {   
        public static void Main(string[] args)

        {
            int[,] numero = { { 1, 4, 2 }, { 3, 6, 8,} };

            numero[0, 0] = 1;

            Console.WriteLine(numero[0, 0]);
        }
    }
}
