using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Evento.Entities
{
    public class Conferencia : Evento
    {
        public Conferencia(string nome, DateOnly data, string local, int maxParticipantes) : base(nome, data, local, maxParticipantes)
        {
        }

        public override void Listar()
        {
            Console.WriteLine($"Conferência: {Nome} Data: {Data} Local: {Local} Max.Participantes: {MaxParticipantes} Staus: {Status}");
            Console.WriteLine("\nAtividades:");
            foreach (var atividade in Atividades)
            {
                atividade.Listar();
            }
            Console.WriteLine("\nParticipantes:");
            foreach (var participante in Participantes)
            {
                participante.Listar();
            }
            Console.WriteLine("\n");
        }
    }
}
