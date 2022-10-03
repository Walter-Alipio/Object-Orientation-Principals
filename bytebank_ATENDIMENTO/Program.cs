using System.Collections;
using bytebank.Modelos.Conta;
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
  new ContaCorrente(95){Saldo = 100},
  new ContaCorrente(95){Saldo = 200},
  new ContaCorrente(94){Saldo = 600}
};
AtendimentoCliente();
void AtendimentoCliente()
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
    opcao = Console.ReadLine()[0];
    Console.Clear();
    switch (opcao)
    {
      case '1':
        CadastrarConta();
        break;
      case '2':
        System.Console.WriteLine("Opção selecionada");
        ListarContas();
        break;
      case '6': break;
      default:
        Console.WriteLine("Opção não implementada.");
        break;
    }

  }
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