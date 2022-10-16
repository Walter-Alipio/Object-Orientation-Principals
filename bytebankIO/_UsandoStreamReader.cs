using ByteBankIO;

namespace bytebankIO
{
  partial class Program
  {
    static void UsandoStreamReader()
    {
      var enderecoDoArquivo = "contas.txt";
      using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
      {
        var leitor = new StreamReader(fluxoDeArquivo);
        //var linha = leitor.ReadLine();
        //var texto = leitor.ReadToEnd();
        //var numero = leitor.Read();

        while (!leitor.EndOfStream)
        {
          var linha = leitor.ReadLine();
          var contaCorrente = ConverterStringParaContaCorrente(linha);

          string msg = $"{contaCorrente.Titular.Nome}: Cc: {contaCorrente.Numero}, Ag: {contaCorrente.Agencia}, Saldo: {contaCorrente.Saldo.ToString().Replace('.', ',')}";
          System.Console.WriteLine(msg);
        }
      }
      //LidandoComFilestream();

      Console.ReadLine();
    }
    static ContaCorrente ConverterStringParaContaCorrente(string linha)
    {
      string[] campos = linha.Split(',');
      string agencia = campos[0];
      string numero = campos[1];
      string saldo = campos[2];
      string nomeTitular = campos[3];

      Cliente titular = new();
      titular.Nome = nomeTitular;

      ContaCorrente resulado = new ContaCorrente(int.Parse(agencia), int.Parse(numero));
      resulado.Depositar(double.Parse(saldo));
      resulado.Titular = titular;

      return resulado;
    }
  }

}