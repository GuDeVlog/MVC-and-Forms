using CadJogosMVC.DAO;
using CadJogosMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CadJogosMVC.Controllers
{
    public class JogosController : Controller
    {
        public IActionResult Index()
        {
            try
            {
                JogosDAO dao = new JogosDAO();
                List<JogosViewModel> lista = dao.Listagem();
                return View("index", lista);
            }
            catch (Exception ex)
            {
                return View("error", new ErrorViewModel(ex.ToString()));
            }
        }
        public IActionResult Create()
        {
            JogosViewModel jogo = new JogosViewModel();
            jogo.Data_Aquisicao = DateTime.Now;
            jogo.Id = 1;
            return View("Form", jogo);
        }

        public IActionResult Edit(int id)
        {
                JogosDAO dao = new JogosDAO();
                JogosViewModel jogo = dao.Consulta(id);
                return View("Form1", jogo);
        }

        public IActionResult Editar(JogosViewModel jogo)
        {
            try
            {
                JogosDAO dao = new JogosDAO();
                dao.Alterar(jogo);
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
                JogosDAO dao = new JogosDAO();
                dao.Excluir(id);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                return View("error", new ErrorViewModel(ex.ToString()));
            }
        }

        public IActionResult Salvar(JogosViewModel jogo)
        {
            try
            {
                JogosDAO dao = new JogosDAO();
                if (dao.Consulta(jogo.Id) == null)
                    dao.Inserir(jogo);
                else
                    dao.Alterar(jogo);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                return View("error", new ErrorViewModel(ex.ToString()));
            }
            
        }

    }
}
