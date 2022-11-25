using System;

namespace Programacao00
{
    class Program
    {

        static void Main(string[] args)
        {
            var professor = new Professor(5000m, "Joao", "12345", new DateTime(1980, 1, 1));
            var estudante = new Estudante("A", "Felix", "54321", new DateTime(1986, 4, 5));

            var pessoas = new List<Pessoa> { estudante, professor };

            foreach (var pessoa in pessoas)
            {
                pessoa.SeApresentar();
            }

            Console.Read();
        }
    }
}