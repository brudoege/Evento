using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evento.Entities
{
    internal class Palestrante : Participante
    {
        public string Curriculo { get; set; }

        public void AgendarPalestra()
        {
            throw new NotSupportedException();
        }
    }
}
