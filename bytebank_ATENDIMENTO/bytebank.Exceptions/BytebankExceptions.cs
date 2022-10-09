using System.Runtime.ExceptionServices;
using System;
namespace bytebank_ATENDIMENTO.bytebank.Exceptions
{
  public class BytebankException : Exception
  {
    public BytebankException() { }
    public BytebankException(string message) : base("Aconteceu uma exceção ->" + message) { }
    public BytebankException(string message, Exception inner) : base(message, inner) { }
    protected BytebankException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context
    ) : base(info, context) { }

  }
}