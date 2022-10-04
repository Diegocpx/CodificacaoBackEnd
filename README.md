- Título e descrição

ClientLab Cadastramento de clientes 0.1 - Sistema para cadastramento de carteira de clientes

- Features (funcionalidades)

O sistema de clientes deverá armazenar os cadastros das pessoas físicas e jurídicas;
O cadastro das pessoas físicas é feito com os seguintes dados: nome, CPF e data de nascimento;
O cadastro das pessoas jurídicas é feito com os seguintes dados: nome, CNPJ e razão social;
Ambos devem possuir um endereço e indicar se o endereço é comercial ou residencial;
O sistema deve armazenar os registros em arquivos;

- Tecnologias utilizadas

Linguagem de programação C# 

- Organização do projeto

Este projeto foi dividido nas seguintes etapas:

Criar o projeto e as classes base de pessoa física e jurídica
Criar a classe filha de pessoa física com as propriedades de CPF e a data de nascimento
Criar a classe filha de pessoa jurídica com CNPJ e razão social
Adicionar à classe base de pessoa física, o método de pagar imposto
Adicionar à classe base de pessoa jurídica, o método de pagar imposto
Adicionar o endereço à classe base de pessoa física
Adicionar o endereço à classe base de pessoa jurídica
Documentar o sistema, por meio do arquivo readme

- Pré-requisitos mínimos de instalação

Processador     - 4 core 2 GHz
RAM             - 8Gb
Espaço em disco - 1GB

- Execução da aplicação

Antes de começar, você vai precisar ter instalado em sua máquina o VSCode (https://code.visualstudio.com/) e o git (https://git-scm.com)
Clone este repositório (https://github.com/Diegocpx/CodificacaoBackEnd/tree/master/Encontro%20remoto%208)
Abra o VSCode
Acesse a pasta do projeto no terminal
Digite dotnet run
Inicie o cadastramento dos clientes

- Erros comuns

Clientes podem ser cadastrados com dados errados, pois o software não consulta bancos de dados externos.
Se não concluir o processo até o final, o cliente não será cadastrado

- Contribuidores

Diego da Cruz Paixão - Desenvolvedor Back-end