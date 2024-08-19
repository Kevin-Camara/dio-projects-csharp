using System;

namespace ProjetoHospedagem.models
{
    public class Pessoa
    {
        private string _nome;
        private string _sobrenome;
        public string Nome 
        { 
            get => _nome;  
            set
            {
                if (string.IsNullOrEmpty(value)){
                    throw new ArgumentException("O nome não pode ser vazio !");
                }
                _nome = value;
            }
        }
        public string Sobrenome { 
            get => _sobrenome;  
            set
            {
                if (string.IsNullOrEmpty(value)){
                    throw new ArgumentException("O sobrenome não pode ser vazio !");
                }
                _sobrenome = value;
            }
        }
        public Pessoa(string nome, string sobrenome){
            Nome = nome.ToUpper();
            Sobrenome = sobrenome.ToUpper();
        }
    }
}