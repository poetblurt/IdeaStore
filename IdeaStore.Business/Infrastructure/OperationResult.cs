using System.Collections.Generic;

namespace IdeaStore.Business.Infrastructure
{
   public class OperationResult
   {
      public IList<OperationMessage> Messages { get; set; }

      protected OperationResult()
      {
         Messages = new List<OperationMessage>();
      }
      
      public static OperationResult GetSuccess() => new OperationResult();
      public static OperationResult<T> GetSuccessWithData<T>(T data) => new OperationResult<T>(data);
   }

   public class OperationResult<T> : OperationResult
   {
      public T Data { get; set; }

      public OperationResult(T data)
      {
         Data = data;
      }
   }

   public class OperationMessage
   {
      public ActionStatus Status { get; set; } = ActionStatus.Success;
      public string Message { get; set; }
   }

   public enum ActionStatus
   {
      Success = 0,
      Warning = 1, 
      Error = 2
   }
}
