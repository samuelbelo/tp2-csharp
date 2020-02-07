using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste_performance_2.Services
{
    public class CalculadoraService
    {
        public int EfetuaSoma(Models.SomaModel somaModel)
        {
            var result = somaModel.operando1 + somaModel.operando2;
            return result;
        }
    }
}
