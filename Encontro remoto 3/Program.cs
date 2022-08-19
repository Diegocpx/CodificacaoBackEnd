using Encontro_remoto_2.Classes;

PessoaFisica novaPF = new PessoaFisica();


novaPF.nome = "Diego";
novaPF.cpf = "12345678910";
novaPF.rendimento = 6600.5f;

// Console.WriteLine(novaPF.nome);

// Console.WriteLine("Nome: " + novaPF.nome + " - CPF: " + novaPF.cpf);
// Console.WriteLine($"Nome: {novaPF.nome} - CPF: {novaPF.cpf}");

float impostoPagar = novaPF.CalcularImposto(novaPF.rendimento);
Console.WriteLine(impostoPagar);
Console.WriteLine($"R$ {impostoPagar:0.00}");
Console.WriteLine(impostoPagar.ToString("C"));

PessoaJuridica novaPJ = new PessoaJuridica();
Console.WriteLine(novaPJ.CalcularImposto(6600.5f));
