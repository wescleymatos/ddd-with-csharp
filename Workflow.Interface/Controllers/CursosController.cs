using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Workflow.Domain.Entities;
using Workflow.Application.Contracts;

namespace Workflow.Interface.Controllers
{
    public class CursosController : Controller
    {
        private ICursoServicoAplicacao _cursoServicoAplicacao;

        public CursosController(ICursoServicoAplicacao cursoServicoAplicacao) 
        {
            this._cursoServicoAplicacao = cursoServicoAplicacao;
        }


        //
        // GET: /Cursos/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Curso curso)
        {
            this._cursoServicoAplicacao.CadastrarDocumento(curso);
            return View();
        }

    }
}
