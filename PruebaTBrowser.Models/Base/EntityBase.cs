namespace PruebaTBrowser.Models.Base
{
    public class EntityBase<TId> : EntityWithTypedId<TId>
    {
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public int? CreatedUserId { get; set; }
        public int? UpdatedUserId { get; set; }
        public EntityBase()
        {
            CreatedOn = DateTime.UtcNow;
            UpdatedOn = DateTime.UtcNow;
        }
    }
}
