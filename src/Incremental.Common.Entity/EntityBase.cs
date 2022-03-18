namespace Incremental.Common.Entity;

public abstract class EntityBase
{
    /// <summary>
    /// Id of the entity.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Date of creation of the entity.
    /// </summary>
    public DateTime CreatedAt { get; set; }
    
    /// <summary>
    /// Optional creator of the entity.
    /// </summary>
    public Guid? CreatedBy { get; set; }
    
    /// <summary>
    /// Date of last update of the entity
    /// </summary>
    public DateTime LastUpdatedAt { get; set; }
    
    /// <summary>
    /// Optional last updater of the entity.
    /// </summary>
    public Guid? LastUpdatedBy { get; set; }
    
    /// <summary>
    /// Optional date of deletion.
    /// </summary>
    public DateTime? DeletedAt { get; set; }
    
    /// <summary>
    /// Optional deleter of the entity.
    /// </summary>
    public Guid? DeletedBy { get; set; }
}