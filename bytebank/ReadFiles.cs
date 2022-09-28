public class ReadFiles
{
  public string Files { get; }
  public ReadFiles(string file)
  {
    Files = file;
    //throw new FileNotFoundException();
    System.Console.WriteLine($"Abrindo arquivo: {file}");
  }
  public string ReadNextLine()
  {
    System.Console.WriteLine("Lendo linha...");
    //throw new IOException();
    return "Linha do arquivo";
  }
  public void Close()
  {
    System.Console.WriteLine("Fechando arquivo.");
  }
}