using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUL
{
    class Curso
    {
        public int Id { get; set; }
        public Escolaridade NivelEscolaridade;
        public Categoria categoria;
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int CargaHoraria { get; set; }
        public string Ementa { get; set; }
        public string Objetivo { get; set; }
        public string Requisito { get; set; }
    }
}
