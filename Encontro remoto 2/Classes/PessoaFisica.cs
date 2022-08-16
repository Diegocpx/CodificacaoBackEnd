using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encontro_remoto_2.Interfaces;

namespace Encontro_remoto_2.Classes
{
    public class PessoaFisica : Pessoa , IPessoaFisica
    {
        public string? cpf { get; set; }
        
        public DateTime DataNasc { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime DataNasc)
        {
            throw new NotImplementedException();
        }
    }
}