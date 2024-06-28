using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento.Entities
{
    public abstract class Participante
    {
        public Participante(string nome)
        {
            Nome = nome;
            Agenda = new List<Atividade>();
        }

        public string Nome { get; set; }
        public List<Atividade> Agenda { get; private set; }


        public void Inscrever(Atividade atividade)
        {
            Agenda.Add(atividade);
        }

        public abstract void Listar();

        public void ListarAgenda()
        {
            Console.WriteLine("Agenda:");
            foreach (var atividade in Agenda)
            {
                atividade.Listar();
            }
            Console.WriteLine("\n");
        }
    }
}