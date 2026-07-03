using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBrasileirao
{
    public class ConsultarSerieBAModel
    {
        public int idSerieB { get; set; }
        public string? NomeClube { get; set; }
        public int PontosClube { get; set; }
        public int PosicaoClube { get; set; }
        public int JogosClube { get; set; }
        public int VitoriasClube { get; set; }
        public int EmpatesClube { get; set; }
        public int DerrotasClube { get; set; }
        public int GolsproClube { get; set; }
        public int GolscontraClube { get; set; }
        public int SaldoGolsClube { get; set; }

    }
}