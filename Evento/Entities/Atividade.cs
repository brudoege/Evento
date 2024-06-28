using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento.Entities
{
    public class Atividade
    {
        public Atividade(string nome, DateTime horaInicio, DateTime horaFim)
        {
            Nome = nome;
            HoraInicio = horaInicio;
            HoraFim = horaFim;
            Status = "Não iniciada";
            Participantes = new List<Participante>();
        }

        public string Nome { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }
        public string Status { get; private set; }
        public List<Participante> Participantes { get; private set; }

        public void Iniciar()
        {
            Status = "Iniciada";
        }
        public void Pausar()
        {
            Status = "Pausada";
        }
        public void Concluir()
        {
            Status = "Concluída";
        }
        public void Cancelar()
        {
            Status = "Cancelada";
        }
        public void AdicionarParticipante(Participante participante)
        {
            Participantes.Add(participante);
        }
        public void Listar()
        {
            Console.WriteLine($"Atividade: {Nome} Hora Início: {HoraInicio} Hora Fim: {HoraFim} Staus: {Status}");
        }
    }
}
