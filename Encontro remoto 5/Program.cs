using Encontro_remoto_2.Classes;

// PessoaFisica novaPF = new PessoaFisica();
// Endereco novoEndPF = new Endereco();

// novaPF.nome = "Diego";
// novaPF.cpf = "12345678910";
// novaPF.rendimento = 6600.5f;
// novaPF.dataNasc = new DateTime(2000, 01, 01);

// novoEndPF.logradouro = "Rua Niteroi";
// novoEndPF.numero = 180;
// novoEndPF.complemento = "Senai Informatica";
// novoEndPF.endComercial = true;

// novaPF.endereco = novoEndPF;

// Console.WriteLine(@$"
// Nome: {novaPF.nome}
// Endereco: {novaPF.endereco.logradouro}, {novaPF.endereco.numero}
// Maior de idade: {novaPF.ValidarDataNasc(novaPF.dataNasc)}
// ");


// Console.WriteLine(novaPF.nome);

// Console.WriteLine("Nome: " + novaPF.nome + " - CPF: " + novaPF.cpf);
// Console.WriteLine($"Nome: {novaPF.nome} - CPF: {novaPF.cpf}");

// float impostoPagar = novaPF.CalcularImposto(novaPF.rendimento);

// Console.WriteLine(impostoPagar);
// Console.WriteLine($"R$ {impostoPagar:0.00}");
// Console.WriteLine(impostoPagar.ToString("C"));

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

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razao Social: {novaPj.razaoSocial}
CNPJ: {novaPj.cnpj} - valido: {novaPj.Validarcnpj(novaPj.cnpj)}
");




Console.WriteLine(novaPj.Validarcnpj("12.345.678/0001-34"));




