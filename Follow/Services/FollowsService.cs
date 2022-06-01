using Follow.Repositories;

namespace Follow.Services
{
  public class FollowsService
  {
    private readonly FollowsRepository _repo;
    public FollowsService(FollowsRepository repo)
    {
      _repo = repo;
    }
  }
}