using ControleCurriculos.DAO;
using ControleCurriculos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ControleCurriculos.Controllers
{
    public class CurriculosController : Controller
    {
        public IActionResult Index()
        {
                CurriculosDAO dao = new CurriculosDAO();
                List<CurriculosViewModel> lista = dao.Listagem();
                return View("index", lista);
        }
        public IActionResult Create()
        {
            CurriculosViewModel curriculo = new CurriculosViewModel();
            curriculo.Id = 1;
            return View("Form", curriculo);
        }

        public IActionResult Edit(int id)
        {
            CurriculosDAO dao = new CurriculosDAO();
            CurriculosViewModel curriculo = dao.Consulta(id);
            return View("Form1", curriculo);
        }

        public IActionResult Editar(CurriculosViewModel curriculo)
        {
                CurriculosDAO dao = new CurriculosDAO();
                dao.Alterar(curriculo);
                return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
                CurriculosDAO dao = new CurriculosDAO();
                dao.Excluir(id);
            return RedirectToAction("index");
        }

        public IActionResult Salvar(CurriculosViewModel curriculo)
        {
                CurriculosDAO dao = new CurriculosDAO();
                if (dao.Consulta(curriculo.Id) == null)
                    dao.Inserir(curriculo);
                else
                    dao.Alterar(curriculo);
                return RedirectToAction("index");
        }

    }
}
