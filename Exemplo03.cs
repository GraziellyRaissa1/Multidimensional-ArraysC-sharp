using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Você pode facilmente percorrer os elementos de uma matriz bidimensional com um foreachloop:


namespace MultidimensionalArraysCsharp
{
    internal class Exemplo03
    {
        public static void Main(string[] args)

        {
            int[,] numero = { { 1, 4, 2, 3}, { 3, 6, 8, 9 } };

            foreach (int contadora in numero)
            {
                Console.WriteLine(contadora);
   }    }   }
}
