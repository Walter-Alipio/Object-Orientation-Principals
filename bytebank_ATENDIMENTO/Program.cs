using System.Collections;
using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");


#region Exemplo de arrays em C#
void TestaArrayDeContasCorrentes()
{
  ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();

  listaDeContas.Adicionar(new ContaCorrente(874));
  listaDeContas.Adicionar(new ContaCorrente(884));
  listaDeContas.Adicionar(new ContaCorrente(894));
  listaDeContas.Adicionar(new ContaCorrente(900));
  listaDeContas.Adicionar(new ContaCorrente(910));
  listaDeContas.Adicionar(new ContaCorrente(920));
  listaDeContas.Adicionar(new ContaCorrente(930));

  ContaCorrente contaAndre = new ContaCorrente(940);
  listaDeContas.Adicionar(contaAndre);

  // listaDeContas.ExibirLista();

  // System.Console.WriteLine("====================");

  // listaDeContas.Remover(contaAndre);
  // listaDeContas.ExibirLista();

  for (int i = 0; i < listaDeContas.Tamanho; i++)
  {
    ContaCorrente conta = listaDeContas[i];

    Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
  }


}
//TestaArrayDeContasCorrentes();
#endregion
List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
{
  new ContaCorrente(95){
    Saldo = 100,
    Titular = new Cliente{Nome = "Henrique", Cpf = "1111111", Profissao = "Estagiário"}
    },
  new ContaCorrente(95){
    Saldo = 200,
    Titular = new Cliente{Nome = "Pedro", Cpf = "2222222", Profissao = "Desenvolvedor pleno" }
    },
  new ContaCorrente(94){
    Saldo = 600,
    Titular = new Cliente{Nome = "Marisa", Cpf = "3333333", Profissao="Tech Leader"}
    }
};
AtendimentoCliente();
void AtendimentoCliente()
{
  try
  {
    char opcao = '0';
    while (opcao != '6')
    {
      Console.Clear();
      System.Console.WriteLine("===================================");
      System.Console.WriteLine("===         Atendimento         ===");
      System.Console.WriteLine("===1 - Cadastrar Conta          ===");
      System.Console.WriteLine("===2 - Listar Contas            ===");
      System.Console.WriteLine("===3 - Remover Conta            ===");
      System.Console.WriteLine("===4 - Ordenar Contas           ===");
      System.Console.WriteLine("===5 - Pesquisar Contas         ===");
      System.Console.WriteLine("===6 - Sair do Sistema          ===");
      System.Console.WriteLine("===================================");
      System.Console.WriteLine("\n\n - ");
      System.Console.Write("Digite a opção desejada: ");

      try
      {
        opcao = Console.ReadLine()[0];
      }
      catch (System.Exception exception)
      {
        //criando uma mensagem de exceção que sera capiturada pelo catch externo.
        throw new BytebankException(exception.Message);
      }
      Console.Clear();
      switch (opcao)
      {
        case '1':
          CadastrarConta();
          break;
        case '2':
          ListarContas();
          break;
        case '3':
          RemoverContas();
          break;
        case '4':
          OrdenarContas();
          break;
        case '5':
          PesquisarContas();
          break;
        case '6': break;
        default:
          Console.WriteLine("Opção não implementada.");
          break;
      }
    }
  }
  catch (BytebankException exception)
  {
    System.Console.WriteLine($"{exception.Message}");
  }
}

void PesquisarContas()
{
  Console.Clear();
  System.Console.WriteLine("=====================================");
  System.Console.WriteLine("===        Pesquisar Contas       ===");
  System.Console.WriteLine("=====================================");
  System.Console.WriteLine("\n");
  System.Console.WriteLine("Deseja pesquisar por (1)NÚMERO DA CONTA (2)CPF TITULAR?");
  switch (int.Parse(Console.ReadLine()))
  {
    case 1:
      {
        System.Console.WriteLine("Informe o número da Conta: ");
        string _numeroConta = Console.ReadLine();
        ContaCorrente consultaConta = ConsultaPorNumeroConta(_numeroConta);
        System.Console.WriteLine(consultaConta.ToString());
        Console.ReadKey();
        break;
      }
    case 2:
      {
        System.Console.WriteLine("Informe o CPF do Titular: ");
        string _cpf = Console.ReadLine();
        ContaCorrente consultaCpf = ConsultaPorCpfTitular(_cpf);
        System.Console.WriteLine(consultaCpf.ToString());
        Console.ReadKey();
        break;
      }

    default:
      {
        System.Console.WriteLine("Opção não implementada.");
        break;
      }
  }
}

ContaCorrente ConsultaPorCpfTitular(string? cpf)
{
  ContaCorrente conta = null;
  for (int i = 0; i < _listaDeContas.Count; i++)
  {
    if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
    {
      conta = _listaDeContas[i];
    }
  }
  return conta;
}

ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
{
  ContaCorrente conta = null;
  for (int i = 0; i < _listaDeContas.Count; i++)
  {
    if (_listaDeContas[i].Conta.Equals(numeroConta))
    {
      conta = _listaDeContas[i];
    }
  }
  return conta;
}

void OrdenarContas()
{
  _listaDeContas.Sort();
  System.Console.WriteLine("... Lista de Contas ordenada ...");
  Console.ReadKey();
}

void RemoverContas()
{
  Console.Clear();
  System.Console.WriteLine("===================================");
  System.Console.WriteLine("===        Remover Contas       ===");
  System.Console.WriteLine("===================================");
  System.Console.WriteLine("\n");
  System.Console.WriteLine("Informe o número da Conta: ");
  string numeroDaConta = Console.ReadLine();
  ContaCorrente conta = null;
  foreach (var item in _listaDeContas)
  {
    if (item.Conta.Equals(numeroDaConta))
    {
      conta = item;
    }
  }
  if (conta != null)
  {
    _listaDeContas.Remove(conta);
    System.Console.WriteLine("... Conta removida da lista! ...");
    Console.ReadKey();
    return;
  }
  System.Console.WriteLine("... Conta para remoção não encontrada ...");
  Console.ReadKey();
  return;
}

void ListarContas()
{
  Console.Clear();
  System.Console.WriteLine("===================================");
  System.Console.WriteLine("===         Listar Contas       ===");
  System.Console.WriteLine("===================================");
  System.Console.WriteLine("\n");
  if (_listaDeContas.Count <= 0)
  {
    System.Console.WriteLine("... Não há contas cadastradas! ...");
    Console.ReadKey();
    return;
  }

  foreach (ContaCorrente item in _listaDeContas)
  {
    System.Console.WriteLine("===       Dados da Conta       ===");
    System.Console.WriteLine($"Número da conta: {item.Conta}");
    System.Console.WriteLine($"Titular da conta: {item.Titular.Nome}");
    System.Console.WriteLine($"CPF do Titular: {item.Titular.Cpf}");
    System.Console.WriteLine($"Profissão do Titular: {item.Titular.Profissao}");
    System.Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
    Console.ReadKey();
  }
}

void CadastrarConta()
{
  Console.Clear();
  System.Console.WriteLine("===================================");
  System.Console.WriteLine("===       Cadastrar Conta       ===");
  System.Console.WriteLine("===================================");
  System.Console.WriteLine("\n");
  System.Console.WriteLine("===   Informe dados da conta    ===");

  System.Console.Write("Número da conta: ");
  string numeroDaConta = Console.ReadLine();

  System.Console.Write("Número da agência: ");
  int numeroDaAgencia = int.Parse(Console.ReadLine());

  ContaCorrente conta = new ContaCorrente(numeroDaAgencia);

  System.Console.Write("Informe o saldo inicial: ");
  conta.Saldo = double.Parse(Console.ReadLine());

  System.Console.Write("Informe o nome do Titular: ");
  conta.Titular.Nome = Console.ReadLine();

  System.Console.Write("Informe o CPF do Titular: ");
  conta.Titular.Cpf = Console.ReadLine();

  System.Console.Write("Informe Profissão do Titular: ");
  conta.Titular.Profissao = Console.ReadLine();

  _listaDeContas.Add(conta);

  System.Console.WriteLine("... Conta cadastrada com sucesso! ...");
  Console.ReadKey();
}