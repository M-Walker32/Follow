namespace Follow.Models
{
  public class FollowProfileViewModel : Profile
  {
    public new string Id { get; set; }
    public int followId { get; set; }
  }
}