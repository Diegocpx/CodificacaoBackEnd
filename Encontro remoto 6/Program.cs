using Encontro_remoto_2.Classes;

Console.Clear();
Console.WriteLine(@$"

=============================================
|   Bem vindo ao sistema de cadastro de     |
|       Pessoas físicas e jurídicas         |
=============================================

");

Console.BackgroundColor = ConsoleColor.DarkGreen;
Console.ForegroundColor = ConsoleColor.Yellow;

Utils.BarraCarregamento("Carregando", 10, ".", 200);

String? opcao;
do
{
    Console.Clear();
    Console.WriteLine(@$"

=============================================
|       Escolha uma das opçoes abaixo       |
---------------------------------------------
|           1 - Pessoa Física               |
|           2 - Pessoa Jurídica             |
|                                           |
|           0 - Sair                        |
=============================================

");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":

            PessoaFisica novaPF = new PessoaFisica();
            Endereco novoEndPF = new Endereco();

            novaPF.nome = "Diego";
            novaPF.cpf = "12345678910";
            novaPF.rendimento = 6600.5f;
            novaPF.dataNasc = new DateTime(2000, 01, 01);

            novoEndPF.logradouro = "Rua Niteroi";
            novoEndPF.numero = 180;
            novoEndPF.complemento = "Senai Informatica";
            novoEndPF.endComercial = true;

            novaPF.endereco = novoEndPF;

            Console.Clear();
            Console.WriteLine(@$"

Nome: {novaPF.nome}
Endereco: {novaPF.endereco.logradouro}, {novaPF.endereco.numero}
Maior de idade: {novaPF.ValidarDataNasc(novaPF.dataNasc)}
");

            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();
            
            break;

        case "2":

            PessoaJuridica novaPj = new PessoaJuridica();

            Endereco novoEndPj = new Endereco();

            novaPj.nome = "Nome Pj";
            novaPj.razaoSocial = "Razao Social Pj";
            novaPj.cnpj = "12.345.678/0001-34";
            novaPj.rendimento = 6000.5f;

            novoEndPj.logradouro = "Rua Niteroi";
            novoEndPj.numero = 180;
            novoEndPj.complemento = "Senai Informatica";
            novoEndPj.endComercial = true;

            novaPj.endereco = novoEndPj;

            Console.Clear();
            Console.WriteLine(@$"

Nome: {novaPj.nome}
Razao Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj} - valido: {novaPj.Validarcnpj(novaPj.cnpj)}
");
            Console.WriteLine(novaPj.Validarcnpj("12.345.678/0001-34"));

            Console.WriteLine($"Aperte 'ENTER' para continuar");
            Console.ReadLine();
           
            break;

        case "0":

            Console.WriteLine($"Obrigado por utilizar nosso sistema!");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            Utils.BarraCarregamento("Finalizando", 5, "+", 500);

            break;

        default:

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"Opção Inválida! Por favor digite uma opção válida.");
            Console.ResetColor();

            for (int contador = 0; contador < 6; contador++)
            {
                Thread.Sleep(500);
                Console.Write($"-");
            }
            break;
    }

} while (opcao != "0");

































// Console.WriteLine(novaPF.nome);

// Console.WriteLine("Nome: " + novaPF.nome + " - CPF: " + novaPF.cpf);
// Console.WriteLine($"Nome: {novaPF.nome} - CPF: {novaPF.cpf}");

// float impostoPagar = novaPF.CalcularImposto(novaPF.rendimento);

// Console.WriteLine(impostoPagar);
// Console.WriteLine($"R$ {impostoPagar:0.00}");
// Console.WriteLine(impostoPagar.ToString("C"));










