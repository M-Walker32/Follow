using System.Data;

namespace Follow.Repositories
{
  public class FollowsRepository
  {
    private readonly IDbConnection _db;
    public FollowsRepository(IDbConnection db)
    {
      _db = db;
    }
    // 
  }
}