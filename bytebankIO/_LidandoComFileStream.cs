using System.Text;


namespace bytebankIO
{

  partial class Program
  {
    static void LidandoComFilestream()
    {
      string enderecoDoArquivo = "contas.txt";

      //Using cria internamente um try catch e checa se a condição é nula.
      using (FileStream fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))//fluxo do arquivo
      {
        int numeroDeBytesLidos = -1; //Um número negativo nunca será retornado pelo Read

        byte[] buffer = new byte[1024];//1KB

        while (numeroDeBytesLidos != 0)
        {
          numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
          //System.Console.WriteLine($"Bytes lidos: {numeroDeBytesLidos}");
          EscreverBuffer(buffer, numeroDeBytesLidos);
        }
        //fluxoDoArquivo.Read(buffer, 0, 1024);
        //public override int Read(byte[] array, int offset, int count);
        //esse array é chamado de buffer
        fluxoDoArquivo.Close();

        Console.ReadLine();
      }
      static void EscreverBuffer(byte[] buffer, int bytesLidos)
      {
        UTF8Encoding uft8 = new UTF8Encoding();
        string texto = uft8.GetString(buffer, 0, bytesLidos);
        System.Console.Write(texto);

        /*
          foreach (var meuByte in buffer)
          {
            System.Console.Write(meuByte);
            System.Console.Write(" ");
          }
        */
      }
    }
  }
}