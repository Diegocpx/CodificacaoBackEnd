using Encontro_remoto_2.Classes;

PessoaFisica metodosPF = new PessoaFisica();
List<PessoaFisica> listaPF = new List<PessoaFisica>();


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

            string? opcaoPF;
            do
            {

                Console.Clear();
                Console.WriteLine(@$"

=============================================
|       Escolha uma das opçoes abaixo       |
---------------------------------------------
|       1 - Cadastrar Pessoa Física         |
|       2 - Listar Pessoas Físicas          |
|                                           |
|       0 - Voltar ao menu anterior         |
=============================================

");
                opcaoPF = Console.ReadLine();

                switch (opcaoPF)
                {
                    case "1":

                        PessoaFisica novaPF = new PessoaFisica();
                        Endereco novoEndPF = new Endereco();

                        Console.WriteLine($"Digite o nome da Pessoa Física que deseja cadastrar");
                        novaPF.nome = Console.ReadLine();

                        bool dataValida;
                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento Ex: DD/MM/AAAA");
                            string? dataNascimento = Console.ReadLine();

                            dataValida = novaPF.ValidarDataNasc(dataNascimento);

                            if (dataValida)
                            {
                                DateTime.TryParse(dataNascimento, out DateTime dataConvertida);
                                novaPF.dataNasc = dataConvertida;
                            }else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine($"Data Invalida. Digite uma data válida");
                                Console.ResetColor();
                                Thread.Sleep(3000);
                                
                            }
                            
                        } while (!dataValida); 

                        Console.WriteLine($"Digite o numero do CPF");
                        novaPF.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento mensal (somente números)");
                        novaPF.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o logradouro");
                        novoEndPF.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o número");
                        novoEndPF.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o Complemento (Aperte 'ENTER' para vazio)");                        
                        novoEndPF.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é comercial? S/N?");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPF.endComercial = true;
                        
                        }else
                        {
                            novoEndPF.endComercial = false;
                        }
                                             
                        novaPF.endereco = novoEndPF;

                        listaPF.Add(novaPF);

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine($"Cadastro realizado com sucesso!");
                        Console.ResetColor();
                        Thread.Sleep(3000);                     
                        break;

                    case "2":

                        Console.Clear();

                        if (listaPF.Count > 0)
                        {
                            
                            foreach (PessoaFisica cadaPF in listaPF)
                            {
                                Console.Clear();
                                Console.WriteLine(@$"

Nome: {cadaPF.nome}
Endereco: {cadaPF.endereco.logradouro}, {cadaPF.endereco.numero}
Data de Nascimento: {cadaPF.dataNasc.ToString("d")}
Imposto a ser pago: {metodosPF.CalcularImposto(cadaPF.rendimento).ToString("C")}
");

                                Console.WriteLine($"Aperte 'ENTER' para continuar");
                                Console.ReadLine();
                            }

                        }else
                        {
                            Console.WriteLine($"Lista vazia");
                            Thread.Sleep(3000); 
                        }

                        break;

                    case "0":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine($"Voltar ao menu anterior");
                        Console.ResetColor();
                        break;

                    default:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine($"Opção Inválida! Por favor digite uma opção válida.");
                        Console.ResetColor();
                        Thread.Sleep(3000);
                        break;
                }


            } while (opcaoPF != "0");

















           

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
CNPJ: {novaPj.cnpj} - valido: {(novaPj.Validarcnpj(novaPj.cnpj) ? "Sim" : "Não")}
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
            Thread.Sleep(3000);

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










