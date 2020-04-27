using ProjectCore.Domain.Eventos;
using System;

namespace ConsoleTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var evento = new Evento(
                "",
                DateTime.Now,
                DateTime.Now,
                true,
                50,
                false,
                "");


            //var evento2 = new Evento(
            //    "Nome do Evento",
            //    DateTime.Now,
            //    DateTime.Now,
            //    false,
            //    50,
            //    false,
            //    "Wesley Nunes");

            Console.WriteLine(evento.ToString());
            //Console.WriteLine(evento.Equals(evento2));
            Console.WriteLine(evento.EhValido());

            
            if (!evento.ValidationResult.IsValid)
            {
                foreach (var erro in evento.ValidationResult.Errors)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }

            Console.ReadLine();
        }
    }
}
