namespace Evento.Entities
{
    public abstract class Evento
    {
        public Evento(string nome, DateOnly data, string local, int maxParticipantes)
        {
            Nome = nome;
            Data = data;
            Local = local;
            MaxParticipantes = maxParticipantes;
            Participantes = new List<Participante>();
            Atividades = new List<Atividade>();
            Status = "Não iniciado";
        }

        public string Nome { get; set; }
        public DateOnly Data { get; set; }
        public string Local { get; set; }
        public int MaxParticipantes { get; set; }
        public List<Participante> Participantes { get; private set; }
        public List<Atividade> Atividades { get; private set; }
        public string Status { get; private set; }


        public void Iniciar()
        {
            Status = "Iniciado";
        }
        public void Pausar()
        {
            Status = "Pausado";
        }
        public void Concluir()
        {
            Status = "Concluído";
        }
        public void Cancelar()
        {
            Status = "Cancelado";
        }

        public void AdicionarParticipante(Participante participante)
        {
            if (Participantes.Count < MaxParticipantes)
            {
                Participantes.Add(participante);
            }
            else
            {
                throw new Exception("Capacidade máxima atingida.");
            }
        }

        public void AdicionarAtividade(Atividade atividade)
        {
            Atividades.Add(atividade);
        }

        public abstract void Listar();
    }
}
