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

new BytebankAtendimento().AtendimentoCliente();