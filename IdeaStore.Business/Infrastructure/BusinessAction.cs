namespace IdeaStore.Business.Infrastructure
{
   public abstract class BusinessAction{}

   public abstract class BusinessActionWithInput<T, TD> : BusinessAction
   {
      public abstract OperationResult<T> Execute(TD data);
   }

   public abstract class BusinessAction<T> : BusinessAction
   {
      public abstract OperationResult<T> Execute();
   }
}