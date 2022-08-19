using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Encontro_remoto_2.Interfaces;

namespace Encontro_remoto_2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {
        public string? cnpj { get; set; }
        
        public string? razaoSocial { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool Validarcnpj(string CNPJ)
        {
            throw new NotImplementedException();
        }
    }
}