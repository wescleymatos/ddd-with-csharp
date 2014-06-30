using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workflow.Domain.Contracts;
using Workflow.Domain.Entities;

namespace Workflow.Domain.Services
{
    class CursoServicoDominio : ICursoServicoDominio
    {
        private IRepositorioCurso _repositorioCurso;

        public void DocumentoServicoDominio(IRepositorioCurso repositorioCurso)
        {
            this._repositorioCurso = repositorioCurso;
        }

        public void CadastrarCurso(Curso curso)
        {
            if (curso.Nome == null)
            {
                throw new Exception("Documento não pode ser nulo");
            }

            this._repositorioCurso.Salvar(curso);
        }
    }
}
