using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUL
{
    class Oferta
    {
        public int Id { get; set; }
        public Curso curso;
        public DateTime DataInicio { get; set; }
        public DateTime DataEncerramento { get; set; }
        public int NumeroVagas { get; set; }
        public bool Privacidade { get; set; }
    }
}
