namespace bytebankIO
{
  partial class Program
  {
    static void EscritaBinaria()
    {
      using (var fs = new FileStream("contaCorrente.txt", FileMode.Create))
      using (var escritor = new BinaryWriter(fs))//BinaryWtrite para escrever de forma binária
      {
        escritor.Write(546);            //número da agência
        escritor.Write(546544);         //número da conta
        escritor.Write(4000.50);        //saldo
        escritor.Write("Gustavo Braga");
      }
    }

    static void LeituraBinaria()
    {
      using (var fs = new FileStream("contaCorrente.txt", FileMode.Open))
      using (var leitor = new BinaryReader(fs))
      {
        int agencia = leitor.ReadInt32();
        int contaCorrente = leitor.ReadInt32();
        double saldo = leitor.ReadDouble();
        string nome = leitor.ReadString();

        System.Console.WriteLine($"{nome}: Cc: {contaCorrente}, Ag: {agencia}, Saldo: {saldo.ToString().Replace('.', ',')}");
      }
    }
  }
}