public class Resource : BaseModel 
{
    public int Quantity { get; set; }
    public ResourceStatus Status { get; set; } = ResourceStatus.Available;
    public List<Visit>? Visits {get; set;}
}

public enum ResourceStatus {
    Available,
    Borrowed,
    Damaged,
    Lost,
    Disposed
}