using System;

namespace ControleCurriculos.Models
{
    public class CurriculosViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereço { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public double? PretensaoSalarial { get; set; }
        public string CargoPretendido { get; set; }
        public string Curso1 { get; set; }
        public string Curso2 { get; set; }
        public string Curso3 { get; set; }
        public string Curso4 { get; set; }
        public string Curso5 { get; set; }
        public string Experiencia1 { get; set; }
        public string Experiencia2 { get; set; }
        public string Experiencia3 { get; set; }
        public string Idioma1 { get; set; }
        public string Idioma2 { get; set; }
        public string Idioma3 { get; set; }
    }
}
