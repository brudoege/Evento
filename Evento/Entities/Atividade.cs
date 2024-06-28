using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento.Entities
{
    internal class Atividade
    {
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFim { get; set; }
        public int Status { get; set; }

        public void IniciarAtividade()
        {
            throw new NotSupportedException();
        }

    }
}
