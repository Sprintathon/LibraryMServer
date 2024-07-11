using System.ComponentModel.DataAnnotations.Schema;

public class Visit : BaseModel {
    public int MemberId { get; set; }
    public Member? Member { get; set;}
    public DateTime? CheckoutTime { get; set; }
    public List<Resource> VisitResources { get; set; }  = new();
    [NotMapped]
    public string? Name { get; set; } = null;
}