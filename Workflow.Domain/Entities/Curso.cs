using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workflow.Domain.Contracts;

namespace Workflow.Domain.Entities
{
    class Curso : IEntity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public int CargaHoraria { get; set; }
        public string Ementa { get; set; }
        public string Objetivo { get; set; }
        public string Requisito { get; set; }
    }
}
