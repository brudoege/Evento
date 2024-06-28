using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento.Entities
{
    internal class Espectador : Participante
    {
        public string Empresa { get; set; }

        public void AvaliarAtividade()
        {
            throw new NotSupportedException();
        }

    }
}
