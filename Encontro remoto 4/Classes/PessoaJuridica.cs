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
            if (rendimento <= 3000)
            {
                return rendimento * .03f;

            }else if (rendimento <= 6000)
            {
                return rendimento * .05f;

            }else if (rendimento <= 10000)
            {
                return rendimento * .07f;

            }else
            {
                return rendimento * .09f;
            }
        }

        public bool Validarcnpj(string CNPJ)
        {
            throw new NotImplementedException();
        }
    }
}