using System.Text;
namespace bytebankIO
{
  partial class Program
  {
    static void CriandoArquivo()
    {
      string caminhoNovoArquivo = "contasExportadas.csv";

      using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
      {
        string contaComoString = "456, 7895, 4785.40, Gustavo Santos";
        var endocing = Encoding.UTF8;

        byte[] bytes = endocing.GetBytes(contaComoString);

        fluxoDeArquivo.Write(bytes, 0, bytes.Length);
      }
    }
    static void CriandoArquivosComWriter()
    {
      string caminhoNovoArquivo = "contasExportadas.csv";

      using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
      using (var escritor = new StreamWriter(fluxoDeArquivo))
      {
        escritor.Write("446, 65465, 456.0, Pedro");
      }
    }

    static void TestaEscrita()
    {
      string caminhoNovoArquivo = "teste.txt";

      using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
      using (var escritor = new StreamWriter(fluxoDeArquivo))
      {
        for (int i = 0; i < 1000000; i++)
        {
          escritor.WriteLine($"Linha: {i}");
          escritor.Flush();//Despeja o buffer no Stream
          System.Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
          Console.ReadLine();
        }
      }
    }
  }
}