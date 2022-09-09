using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        public bool Validarcnpj(string cnpj)
        {
           bool retonoCnpjValido = Regex.IsMatch (cnpj, @"(^(\d{14})|(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})$)");

   
           if (retonoCnpjValido)
           {

                if (cnpj.Length == 14)
                {
                    string subStringCnpj = cnpj.Substring(8, 4);

                    if (subStringCnpj == "0001")
                    {
                          return true;
                    }
                    return false;

                }


                string subStringCnpj18 = cnpj.Substring(11, 4);

                if (subStringCnpj18 == "0001")
                {
                    return true;
                }              
           }

           return false;
        }
    }
}