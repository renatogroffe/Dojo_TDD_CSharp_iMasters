using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financas
{
    public static class  CalculoFinanceiro
    {        
        public static double CalcularEmprestimo(double ValorEmprestimo, Int32 Periodo, double Taxa)
        {            
            // evitar retornar 0, pois pode conflitar com teste que já espera zero
            return (Math.Round(ValorEmprestimo * Math.Pow(1 + Taxa, Periodo), 02));  
        }
    }
}
