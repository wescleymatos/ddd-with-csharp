using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUL
{
    class Inscricao
    {
        public int Id { get; set; }
        public Pessoa Pessoa;
        public Oferta Oferta;
        public Situacao Situacao;
        public string Justificativa { get; set; }
        public bool CursoCorrelacaoAtividades { get; set; }
    }
}
