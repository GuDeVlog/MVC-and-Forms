using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadjogosWF.Models
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
