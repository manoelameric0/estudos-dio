using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;
        public string Nome 
        {
            get => _nome.ToUpper();
    
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O Nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public int Idade
        { 
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Formato de Idade Inválido!");
                }
                _idade = value;
            } 
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}