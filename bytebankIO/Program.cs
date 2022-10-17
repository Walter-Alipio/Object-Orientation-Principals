using System.Globalization;
using System.Collections;
using System.Text;
using System;
using ByteBankIO;

namespace bytebankIO
{
  partial class Program
  {
    static void Main(string[] args)
    {
      // string caminhoNovoArquivo = "contasExportadas.csv";

      // using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
      // using (var escritor = new StreamWriter(fluxoDeArquivo))
      // {
      //   escritor.WriteLine(true);
      //   escritor.WriteLine(false);
      //   escritor.WriteLine(4545454545);
      // }

      // EscritaBinaria();
      // LeituraBinaria();
      //UsarStreamDeEntrada();

      var linhas = File.ReadAllLines("contas.txt");
      System.Console.WriteLine(linhas.Length);

      // foreach (var linha in linhas)
      // {
      //   System.Console.WriteLine(linha);
      // }

      var byteArquivo = File.ReadAllBytes("contas.txt");
      System.Console.WriteLine($"Arquivo contas.txt possui {byteArquivo.Length} bytes.");

      File.WriteAllText("escrevendoComClasseFile.txt", "Testando File.WriteAllText");

      System.Console.WriteLine("Aplicação finalizada...");
      Console.ReadLine();
    }
  }
}