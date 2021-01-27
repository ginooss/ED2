using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportePilha.Models
{
    class Viagens
    {
        private Queue<Viagem> viagens;

        public void incluir(Viagem viagem)
        {
            viagem.Id = viagens.Count + 1;
            viagens.Enqueue(viagem);
        }
    }
}
