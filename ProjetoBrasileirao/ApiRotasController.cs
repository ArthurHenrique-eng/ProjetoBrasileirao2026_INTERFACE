using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBrasileirao
{
    public static class ApiRotasController
    {
        private static readonly string baseUrl = "http://127.0.0.1:5000";

        public static string ConsultarSerie_A => $"{baseUrl}/Serie_A";

        public static string ConsultarSerie_B => $"{baseUrl}/Serie_B";

        public static string ConsultarSerie_C => $"{baseUrl}/Serie_C";

        public static string ConsultarSerie_D => $"{baseUrl}/Serie_D";

        //Botão INSERIR:
        public static string InserirSerie_A => $"{baseUrl}/Serie_A";
        public static string InserirSerie_B => $"{baseUrl}/Serie_B";
        public static string InserirSerie_C => $"{baseUrl}/Serie_C";
        public static string InserirSerie_D => $"{baseUrl}/Serie_D";

        //Botão APAGAR:
        public static string ExcluirSerie_A(int id) => $"{baseUrl}/Serie_A/{id}";
        public static string ExcluirSerie_B(int id) => $"{baseUrl}/Serie_B/{id}";
        public static string ExcluirSerie_C(int id) => $"{baseUrl}/Serie_C/{id}";
        public static string ExcluirSerie_D(int id) => $"{baseUrl}/Serie_D/{id}";

        //Botão ATUALIZAR:
        public static string AtualizarSerie_A(int id) => $"{baseUrl}/Serie_A/{id}";
        public static string AtualizarSerie_B(int id) => $"{baseUrl}/Serie_B/{id}";
        public static string AtualizarSerie_C(int id) => $"{baseUrl}/Serie_C/{id}";
        public static string AtualizarSerie_D(int id) => $"{baseUrl}/Serie_D/{id}";
    }
}
