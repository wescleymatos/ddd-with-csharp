using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workflow.Domain.Entities;

namespace Workflow.Domain.Contracts
{
    interface IRepositorioCurso
    {
        Curso BuscarPorId(int id);
        List<Curso> BuscarTodos();
        void Salvar(Curso curso);
        void Deletar(Curso curso);
    }
}
