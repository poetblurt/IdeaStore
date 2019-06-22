using System.Collections.Generic;
using System.Linq;
using IdeaStore.Business.Infrastructure;
using IdeaStore.Database.Data;

namespace IdeaStore.Business.Features.Ideas
{
   public class GetIdeasAction : BusinessAction<List<IdeaData>>
   {
      private readonly AppDbContext _db;

      public GetIdeasAction(AppDbContext db)
      {
         _db = db;
      }

      public override OperationResult<List<IdeaData>> Execute()
      {
         return OperationResult.GetSuccessWithData(_db.Ideas.Select(x => new IdeaData
         {
            Id = x.Id,
            Description = x.Description,
            Name = x.Name
         }).ToList());
      }
   }
}