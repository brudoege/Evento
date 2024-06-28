namespace Evento.Entities
{
    internal class Evento
    {
        public string Nome { get; set; }
        public DateOnly Data { get; set; }
        public string Local { get; set; }
        public int MaxParticipantes { get; set; }

        public static void Iniciar()
        {
            throw new NotSupportedException();
        }
        public static void Pausar()
        {
            throw new NotSupportedException();
        }
        public static void Concluir()
        {
            throw new NotSupportedException();
        }
        public static void Cancelar()
        {
            throw new NotSupportedException();
        }

    }
}
