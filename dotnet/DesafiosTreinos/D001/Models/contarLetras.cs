using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D001.Models
{
    public class contarLetras
    {
        public string frase { get; set; }
        public char letra { get; set; }
        public int contadorLetras(string frase, char letra)
        {
            int contagem = 0;

            foreach (char caracters in frase)
            {
                if (char.ToLower(caracters) == char.ToLower(letra))
                {
                    contagem++;
                }
            }
            return contagem;
        }
    }
}