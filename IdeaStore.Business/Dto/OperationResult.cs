using System;
using System.Collections.Generic;
using System.Text;

namespace IdeaStore.Business.Dto
{
   public class OperationResult<T>
   {
      public T Data { get; set; }
      public IList<OperationMessage> Messages { get; set; }

      public OperationResult()
      {
         Messages = new List<OperationMessage>();
      }
   }

   public class OperationMessage
   {
      public ActionStatus Status { get; set; }
      public string Message { get; set; }
   }

   public enum ActionStatus
   {
      Success = 0,
      Warning = 1, 
      Error = 2
   }
}
