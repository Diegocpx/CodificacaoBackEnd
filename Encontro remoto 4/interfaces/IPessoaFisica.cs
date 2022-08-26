using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontro_remoto_2.Interfaces
{
    public interface IPessoaFisica
    {
        bool ValidarDataNasc(DateTime DataNasc);
    }
}