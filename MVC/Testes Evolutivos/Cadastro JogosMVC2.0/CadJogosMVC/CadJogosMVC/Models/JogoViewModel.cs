using System;

namespace CadJogosMVC.Models
{
    public class JogosViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Valor_Locacao { get; set; }
        public int CPU_ID { get; set; }
        public DateTime Data_Aquisicao { get; set; }
    }

}
