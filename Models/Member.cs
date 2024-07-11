using System.ComponentModel.DataAnnotations.Schema;

public class Member : BaseModel {
    public string IdentificationNumber { get; set; }
    public string FirstName {get; set;}
    public string LastName {get; set;}
    public string PhoneNumber {get; set;}
    public DateOnly DateOfBirth {get; set;}
    public string Address {get; set;}

    [NotMapped]
    public string Name => $"{FirstName} {LastName}";
}