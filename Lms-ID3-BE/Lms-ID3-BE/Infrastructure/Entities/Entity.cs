namespace Lms_ID3_BE.Infrastructure.Entities
{
  public abstract class Entity: IDeleteEntity, IHasCreationTime, ILastUpdatedTime
  {

    public bool IsDeleted { get; set; } = false;
    public DateTime CreateAt { get; set; }
    public DateTime LastUpdate { get; set; }
  }
}
