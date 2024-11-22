using System.ComponentModel.DataAnnotations;

namespace ProgrammersInside.Web.Core.UserContext.Models;

public class User
{
    [Key]
    public long Id { get; set;}
    public required string Email {get; set;}
    public required string Password {get; set;}
    public required string Name {get; set;}
    public DateTime Dob {get; set;}
}
