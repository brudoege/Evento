using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento.Entities
{
    public class Palestrante : Participante
    {
        public Palestrante(string nome) : base(nome)
        {
        }

        public override void Listar()
        {
            Console.WriteLine($"Palestrante: {Nome}");
        }
    }
}
