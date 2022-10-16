using System.Text;
using System;
using ByteBankIO;

namespace bytebankIO
{
  partial class Program
  {
    static void Main(string[] args)
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
          System.Console.WriteLine(linha);
        }
      }
      //LidandoComFilestream();

      Console.ReadLine();
    }
  }
}