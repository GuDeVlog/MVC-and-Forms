using CadLivrosMVC.DAO;
using CadLivrosMVC.Models;
using DAO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CadLivrosMVC.Controllers
{
    public class LivrosController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                LivrosDAO dao = new LivrosDAO();
                List<LivrosViewModel> lista = dao.ConsultarTodosLivros();
                return View("index", lista);
            }
            catch (Exception ex)
            {
                return View("error", new ErrorViewModel(ex.ToString()));
            }
        }
        public IActionResult Create()
        {
            LivrosViewModel livro = new LivrosViewModel();
            //livro.Ano = DateTime.Now;
            livro.Id = 1;
            return View("Form", livro);
        }

        public IActionResult Edit(int id)
        {
                LivrosDAO dao = new LivrosDAO();
                LivrosViewModel livro = dao.Consulta(id);
                return View("Form1", livro);
        }

        public IActionResult Editar(LivrosViewModel livro)
        {
            try
            {
                LivrosDAO dao = new LivrosDAO();
                dao.AlterarLivros(livro);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                return View("error", new ErrorViewModel(ex.ToString()));
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                LivrosDAO dao = new LivrosDAO();
                dao.ExcluirLivros(id);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                return View("error", new ErrorViewModel(ex.ToString()));
            }
        }

        public IActionResult Salvar(LivrosViewModel livro)
        {
            try
            {
                LivrosDAO dao = new LivrosDAO();
                if (dao.Consulta(livro.Id) == null)
                    dao.InserirLivros(livro);
                else
                    dao.AlterarLivros(livro);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                return View("error", new ErrorViewModel(ex.ToString()));
            }
            
        }

    }
}
