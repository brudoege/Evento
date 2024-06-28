using Evento.Entities;

Conferencia conferencia = new Conferencia("TDC Floripa", new DateOnly(2024, 10, 28), "Florianópolis", 1000);
Palestrante palestrante = new Palestrante("Thamirys");
Espectador espectador1 = new Espectador("Brunella");
Espectador espectador2 = new Espectador("Maria");
Atividade atividadeConferencia = new Atividade("Abertura", new DateTime(2024, 10, 28, 14, 0, 0), new DateTime(2024, 6, 28, 16, 00, 0));

conferencia.AdicionarAtividade(atividadeConferencia);
conferencia.AdicionarParticipante(palestrante);
conferencia.AdicionarParticipante(espectador1);
conferencia.AdicionarParticipante(espectador2);
conferencia.Cancelar();
conferencia.Listar();


Workshop workshop = new Workshop("EleveElas", new DateOnly(2024, 3, 1), "Blumenau", 20);
Atividade atividadeWorkshop = new Atividade("Aula 10 EleveElas", new DateTime(2024, 6, 28, 13, 30, 0), new DateTime(2024, 6, 28, 16, 00, 0));

workshop.AdicionarAtividade(atividadeWorkshop);
workshop.AdicionarParticipante(espectador1);
workshop.Iniciar();
workshop.Listar();

palestrante.Inscrever(atividadeConferencia);
palestrante.Listar();
palestrante.ListarAgenda();

espectador1.Inscrever(atividadeConferencia);
espectador1.Inscrever(atividadeWorkshop);
espectador1.Listar();
espectador1.ListarAgenda();

espectador2.Inscrever(atividadeConferencia);
espectador2.Listar();
espectador2.ListarAgenda();

Console.ReadLine();
