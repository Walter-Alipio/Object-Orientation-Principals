
public class FinantialOperationExcepetion : Exception
{
  public FinantialOperationExcepetion() { }
  public FinantialOperationExcepetion(string message) : base(message) { }
  public FinantialOperationExcepetion(string message, Exception inner) : base(message, inner) { }
  public FinantialOperationExcepetion(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context
        ) : base(info, context)
  { }

}