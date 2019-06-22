using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdeaStore.Business.Infrastructure;

namespace IdeaStore.Services
{
   public interface IBusinessActionLocator
   {
      T GetAction<T>() where T : BusinessAction;
   }

   public class BusinessActionLocator : IBusinessActionLocator
   {
      private readonly IServiceProvider _serviceProvider;

      public BusinessActionLocator(IServiceProvider serviceProvider)
      {
         _serviceProvider = serviceProvider;
      }

      public T GetAction<T>() where T : BusinessAction
      {
         var test = _serviceProvider.GetService(typeof(T));
         return (T) test;
      }
   }
}
