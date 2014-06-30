using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workflow.Application.Contracts;
using Workflow.Domain.Contracts;

namespace Workflow.Application.Services
{
    class CursoServicoAplicacao : ICursoServicoAplicacao
    {
        private ICursoServicoDominio _cursoServicoDominio;

        public CursoServicoAplicacao(ICursoServicoDominio cursoServicoDominio)
        {
            this._cursoServicoDominio = cursoServicoDominio;
        }

        public void CadastrarCurso(IEntity curso)
        {
            //AbrirTransacao();
            this._cursoServicoDominio.CadastrarDocumento(curso);
            //Salvar();
            //EnviarEmail();
        }
    }
}
