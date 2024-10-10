using System;

namespace CadLivrosMVC.Models
{
    public class LivrosViewModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor1 { get; set; }
        public string Autor2 { get; set; }
        public string Editora { get; set; }
        public double PrecoSugerido { get; set; }
        public int Edicao { get; set; }
        public int Ano { get; set; }
    }
}
