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
            JogosDAO dao = new JogosDAO();
            List<JogosViewModel> lista = dao.Listagem();
            return View("index", lista);
        }
        public IActionResult Create()
        {
            JogosViewModel jogo = new JogosViewModel();
            jogo.Data_Aquisicao = DateTime.Now;
            jogo.Id = 1;
            return View("Form", jogo);
        }
        public IActionResult Salvar(JogosViewModel jogo)
        {

            try
            {
                JogosDAO dao = new JogosDAO();
                dao.Inserir(jogo);
                return RedirectToAction("index");
            }
            catch (Exception ex)
            {
                return View("error", new ErrorViewModel(ex.ToString()));
            }
            
        }

    }
}
