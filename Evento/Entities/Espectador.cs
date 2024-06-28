using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento.Entities
{
    public class Espectador : Participante
    {
        public Espectador(string nome) : base(nome)
        {
        }

        public override void Listar()
        {
            Console.WriteLine($"Espectador: {Nome}");
        }
    }
}
