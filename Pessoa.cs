using System;


namespace Programacao00
{
    public abstract class Pessoa
    {
        public Pessoa(string nome, string documento, DateTime dataNascimento)
        {
            Nome = nome;
            Documento = documento;
            DataNascimento= dataNascimento;
        }

        public string Nome { get; protected set; }
        public string Documento { get; protected set; }
        public DateTime DataNascimento { get; protected set; }

        public virtual void SeApresentar()
        {
            Console.WriteLine($"Ola, meu nome e {Nome}, Documento {Documento}, DataNascimento: {DataNascimento}");
        }
    }
}
