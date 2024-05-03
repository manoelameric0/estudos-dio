using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace D001.Models
{
    public class contarLetras
    {
       public string frase { get;  }
       public char letra { get;  }

       public contarLetras(string frase, char letra)
       {
            frase = frase;
            letra = letra;
       }

       public int ContadorDeLetras()
       {
            int contagem = 0;
            foreach (char c in frase)
            {
                if (char.ToLower(c) == char.ToLower(letra))
                {
                    contagem++;
                }  
            }
            return contagem; 
       }
     }
}
