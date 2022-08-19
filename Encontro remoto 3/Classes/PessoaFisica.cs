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
            if (rendimento <= 1500)
            {
                return 0;
            }else if (rendimento > 1500 && rendimento <= 3500)
            {
                float resultado = (rendimento / 100) * 2;

                return resultado;

            }else if (rendimento > 3500 && rendimento <=6000)
            {
                float resultado = (rendimento / 100) * 3.5f;

                return resultado;
            }else
            {
                float resultado = (rendimento / 100) * 5;

                return resultado;
            }
        }


        public bool ValidarDataNasc(DateTime DataNasc)
        {
            throw new NotImplementedException();
        }
    }
}